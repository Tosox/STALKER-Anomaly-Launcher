using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        public static readonly string APPDATA = "appdata";
        private static readonly string BIN = "bin";
        //private static readonly string DB = "db";
        private static readonly string GAMEDATA = "gamedata";
        private static readonly string TOOLS = "tools";
        public static readonly string CHECKSUMS_MD5 = Path.Combine(TOOLS, "checksums.md5");
        public static readonly string USER_LTX = Path.Combine(APPDATA, "user.ltx");
        public static readonly string USER_LTX_OLD = Path.Combine(APPDATA, "user.ltx.old");
        private static readonly string SHADERS_CACHE = Path.Combine(APPDATA, "shaders_cache");
        private static readonly string USER_LTX_UPDATE = string.Format("{0}.update", USER_LTX);
        public static readonly string ALSOFT_INI = Path.Combine(BIN, "alsoft.ini");
        public static readonly string ALSOFT_INI_BAK = Path.Combine(BIN, "alsoft.ini.bak");

        private static readonly string[] ALLOWED_FILES =
        {
            @"configs\atmosfear_default_settings.ltx",
            @"configs\atmosfear_options.ltx",
            @"configs\axr_options.ltx",
            @"configs\cache_dbg.ltx",
            @"configs\localization.ltx",
            @"configs\warfare_options.ltx",
        };

        private static readonly char[] CHECKSUMS_SPLIT = {' '};

        private const int CHUNK_SIZE = 1024 * 1024;

        private static bool _deleteShaderCache;

        [STAThread]
        static void Main(string[] args)
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            string exeDir = Path.GetDirectoryName(exePath);
//exeDir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(exeDir);

            if (!Directory.Exists(APPDATA))
            {
                Directory.CreateDirectory(APPDATA);
            }
            if (!Directory.Exists(GAMEDATA))
            {
                Directory.CreateDirectory(GAMEDATA);
            }

            _deleteShaderCache = false;

            if (!showSelectionUI())
            {
                return;
            }

            if (Directory.Exists(APPDATA) && File.Exists(USER_LTX_UPDATE))
            {
                string userltx = string.Empty;
                if (File.Exists(USER_LTX))
                {
                    userltx = File.ReadAllText(USER_LTX);
                }

                string userltxupdate = File.ReadAllText(USER_LTX_UPDATE);
                string updateduserltx = string.Format("{0}\n{1}", userltx, userltxupdate);

                File.WriteAllText(USER_LTX, updateduserltx);
                File.Delete(USER_LTX_UPDATE);

                _deleteShaderCache = true;
            }

            if (_deleteShaderCache && Directory.Exists(SHADERS_CACHE))
            {
                Directory.Delete(SHADERS_CACHE, true);
            }

            string arguments = string.Empty;
            if (args.Length > 0)
            {
                arguments += string.Join(" ", args);
            }

            string[] cfgLines = File.Exists("AnomalyLauncher.cfg") ? File.ReadAllLines("AnomalyLauncher.cfg") : new string[0];

            string engineName = "AnomalyDX9";

            if (cfgLines.Length > 0)
            {
                if (cfgLines[0] == "DX8")
                {
                    engineName = "AnomalyDX8";
                }
                else if (cfgLines[0] == "DX9")
                {
                    engineName = "AnomalyDX9";
                }
                else if (cfgLines[0] == "DX10")
                {
                    engineName = "AnomalyDX10";
                }
                else if (cfgLines[0] == "DX11")
                {
                    engineName = "AnomalyDX11";
                }
            }

            if (HasAvxSupport())
            {
                if (cfgLines.Length < 2 || cfgLines[1] == "AVX")
                {
                    engineName += "AVX";
                }
            }

            engineName += ".exe";

            string xrEngine = Path.Combine(Path.Combine(exeDir, "bin"), engineName);

            ProcessStartInfo startInfo = new ProcessStartInfo(xrEngine, arguments);
            startInfo.WorkingDirectory = exeDir;
            startInfo.UseShellExecute = false;

            var process = Process.Start(startInfo);
            if (process == null)
            {
                MessageBox.Show("Could not start " + xrEngine, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            process.WaitForExit();
        }

        private static bool showSelectionUI()
        {
            SelectionUI form = new SelectionUI();
            form.Show();
            Application.Run(form);
            _deleteShaderCache = form.ShouldDeleteShaderCache;
            return form.ShouldStart;
        }

        public static bool HasAvxSupport()
        {
            try
            {
                return (GetEnabledXStateFeatures() & 4) != 0;
            }
            catch
            {
                return false;
            }
        }

        public static string VerifyInstall(Action<string> status)
        {
            bool addonsInGamedata = false;
            bool checksumsMissing = false;

            addonsInGamedata = CheckForAddons(status);

            string result = string.Empty;

            if (addonsInGamedata)
            {
                result = result.Length > 0 ? result + " | " : result;
                result += "* installed addons can cause problems or crashes *";
            }

            List<string> missingFiles = new List<string>();
            List<string> corruptFiles = new List<string>();

            if (!File.Exists(CHECKSUMS_MD5))
            {
                checksumsMissing = true;
            }
            else
            {
                byte[] buffer = new byte[CHUNK_SIZE];

                string[] checksums = File.ReadAllLines(CHECKSUMS_MD5);

                foreach (string line in checksums)
                {
                    string[] split = line.Split(CHECKSUMS_SPLIT, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (split.Length < 2 || !split[1].StartsWith("*") || split[0].StartsWith("#") || split[0].StartsWith(";"))
                    {
                        continue;
                    }

                    string checksum = split[0].ToLower(CultureInfo.InvariantCulture);
                    string filename = split[1].Substring(1);

                    if (!File.Exists(filename))
                    {
                        missingFiles.Add(filename);
                    }
                    else
                    {
                        FileStream stream = File.OpenRead(filename);

                        long filesize = stream.Length;
                        int chunks = (int) (filesize / CHUNK_SIZE);
                        int lastsize = (int) (filesize % CHUNK_SIZE);

                        MD5 md5 = MD5.Create();

                        for (int i = 0; i < chunks; i++)
                        {
                            status(string.Format("Checksum for {0} | {1}%", filename, i * 100 / chunks));
                            stream.Read(buffer, 0, CHUNK_SIZE);
                            md5.TransformBlock(buffer, 0, CHUNK_SIZE, null, 0);
                        }

                        status(string.Format("Checksum for {0} | 100%", filename));
                        stream.Read(buffer, 0, lastsize);
                        md5.TransformFinalBlock(buffer, 0, lastsize);

                        stream.Close();

                        string[] hex = Array.ConvertAll(md5.Hash, input => string.Format("{0:x2}", input));
                        string calculated = string.Concat(hex);
                        if (calculated != checksum)
                        {
                            corruptFiles.Add(filename);
                        }
                    }
                }
            }

            if (checksumsMissing)
            {
                result = result.Length > 0 ? result + " | " : result;
                result += "* " + CHECKSUMS_MD5 + " missing *";
            }

            if (corruptFiles.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string corruptFile in corruptFiles)
                {
                    sb.AppendLine(corruptFile);
                }
                MessageBox.Show(sb.ToString(), "Corrupt Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = result.Length > 0 ? result + " | " : result;
                result += "* checksum verification failed, please reinstall *";
            }

            if (missingFiles.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string missingFile in missingFiles)
                {
                    sb.AppendLine(missingFile);
                }
                MessageBox.Show(sb.ToString(), "Missing Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = result.Length > 0 ? result + " | " : result;
                result += "* files missing, please reinstall *";
            }

            return result;
        }

        public static bool CheckForAddons(Action<string> status)
        {
            bool result = false;
            if (!Directory.Exists(GAMEDATA))
            {
                return result;
            }

            string[] gamedataFiles = Directory.GetFiles(GAMEDATA, "*.*", SearchOption.AllDirectories);

            foreach (string filename in gamedataFiles)
            {
                status(string.Format("Detected {0}", filename));

                if (!IsAllowedFile(filename))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private static bool IsAllowedFile(string filename)
        {
            foreach (string name in ALLOWED_FILES)
            {
                string fullname = Path.Combine(GAMEDATA, name);
                if (fullname == filename)
                {
                    return true;
                }
            }
            return false;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern long GetEnabledXStateFeatures();
    }
}
