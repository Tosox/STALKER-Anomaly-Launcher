using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class SelectionUI : Form
    {
        private bool _hasAvxSupport;

        public SelectionUI()
        {
            InitializeComponent();
            ShouldStart = false;
            ShouldDeleteShaderCache = false;
            _hasAvxSupport = Program.HasAvxSupport();
            buttonPlayAnomaly.Focus();
            labelWarning.Visible = false;

            ReadConfig();
        }

        private void ReadConfig()
        {
            string[] cfgLines = File.Exists("AnomalyLauncher.cfg") ? File.ReadAllLines("AnomalyLauncher.cfg") : new string[0];

            if (cfgLines.Length > 0)
            {
                radioButtonDX8.Checked = cfgLines[0] == "DX8";
                radioButtonDX9.Checked = cfgLines[0] == "DX9";
                radioButtonDX10.Checked = cfgLines[0] == "DX10";
                radioButtonDX11.Checked = cfgLines[0] == "DX11";
            }

            if (cfgLines.Length > 1)
            {
                checkBoxAVX.Checked = cfgLines[1] == "AVX";
            }

            try
            {
                int index = cfgLines.Length > 2 ? int.Parse(cfgLines[2]) : 0;
                if (index < 0 || index > 2) index = 0;
                comboBoxWindowMode.SelectedIndex = index;
            }
            catch
            {
                comboBoxWindowMode.SelectedIndex = 0;
            }

            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            if (cfgLines.Length > 4)
            {
                int readWidth;
                int readHeight;
                if (int.TryParse(cfgLines[3], out readWidth) && int.TryParse(cfgLines[4], out readHeight))
                {
                    if (readWidth < 0 || readWidth > 4096) readWidth = 1920;
                    if (readHeight < 0 || readHeight > 4096) readHeight = 1080;
                    width = readWidth;
                    height = readHeight;
                }
            }

            textBoxResolutionWidth.Text = width.ToString();
            textBoxResolutionHeight.Text = height.ToString();

            if (cfgLines.Length > 5)
            {
                checkBoxDebugMode.Checked = cfgLines[5] == "DBG";
            }

            try
            {
                int index = cfgLines.Length > 6 ? int.Parse(cfgLines[6]) : 1;
                if (index < 0 || index > 4) index = 1;
                comboBoxShadowMap.SelectedIndex = index;
            }
            catch
            {
                comboBoxShadowMap.SelectedIndex = 1;
            }

            if (cfgLines.Length > 7)
            {
                checkBoxFixSound.Checked = cfgLines[7] == "SNDFIX";
            }

            if (cfgLines.Length > 8)
            {
                checkBoxPrefetchSounds.Checked = cfgLines[8] == "SNDPREFETCH";
            }

            if (!_hasAvxSupport)
            {
                checkBoxAVX.Checked = false;
                checkBoxAVX.Enabled = false;
            }

            checkBoxForceGfxSettings.Checked = !File.Exists(Program.USER_LTX);
        }

        private bool WriteConfig()
        {
            bool result = true;
            string[] cfgLines = new string[9];
            cfgLines[0] = "DX9";
            cfgLines[0] = radioButtonDX8.Checked ? "DX8" : cfgLines[0];
            cfgLines[0] = radioButtonDX9.Checked ? "DX9" : cfgLines[0];
            cfgLines[0] = radioButtonDX10.Checked ? "DX10" : cfgLines[0];
            cfgLines[0] = radioButtonDX11.Checked ? "DX11" : cfgLines[0];
            cfgLines[1] = checkBoxAVX.Checked ? "AVX" : "NOAVX";
            cfgLines[2] = comboBoxWindowMode.SelectedIndex.ToString();
            try
            {
                int width = int.Parse(textBoxResolutionWidth.Text);
                int height = int.Parse(textBoxResolutionHeight.Text);
                if (width < 0 || width > 4096 || height < 0 || height > 4096)
                {
                    cfgLines[3] = "-1";
                    cfgLines[4] = "-1";
                    result = false;
                }

                cfgLines[3] = width.ToString();
                cfgLines[4] = height.ToString();
            }
            catch
            {
                cfgLines[3] = "-1";
                cfgLines[4] = "-1";
                result = false;
            }
            cfgLines[5] = checkBoxDebugMode.Checked ? "DBG" : "NODBG";
            cfgLines[6] = comboBoxShadowMap.SelectedIndex.ToString();
            cfgLines[7] = checkBoxFixSound.Checked ? "SNDFIX" : "NOSNDFIX";
            cfgLines[8] = checkBoxPrefetchSounds.Checked ? "SNDPREFETCH" : "NOSNDPREFETCH";

            File.WriteAllLines("AnomalyLauncher.cfg", cfgLines);
            return result;
        }

        public bool ShouldStart { get; private set; }
        public bool ShouldDeleteShaderCache { get; private set; }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonPlayAnomaly_Click(object sender, System.EventArgs e)
        {
            if (!WriteConfig())
            {
                MessageBox.Show("Invalid screen resolution", "Anomaly Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxResetSettings.Checked || !File.Exists(Program.USER_LTX))
            {
                ResetUserLtx();
            }

            if (checkBoxForceGfxSettings.Checked || checkBoxResetSettings.Checked || !File.Exists(Program.USER_LTX))
            {
                WriteToUserLtx();
            }

            WriteCommandLine();
            ApplySoundFix();

            ShouldDeleteShaderCache = checkBoxDeleteShaderCache.Checked;
            ShouldStart = true;
            Close();
        }

        private void ResetUserLtx()
        {
            if (File.Exists(Program.USER_LTX))
            {
                if (File.Exists(Program.USER_LTX_OLD))
                {
                    File.Delete(Program.USER_LTX_OLD);
                }
                File.Move(Program.USER_LTX, Program.USER_LTX_OLD);
            }
            File.WriteAllLines(Program.USER_LTX, DefaultUserLtx.LINES);
        }

        private void ApplySoundFix()
        {
            if (checkBoxFixSound.Checked)
            {
                if (!File.Exists(Program.ALSOFT_INI))
                {
                    return;
                }
                if (File.Exists(Program.ALSOFT_INI_BAK))
                {
                    File.Delete(Program.ALSOFT_INI_BAK);
                }
                File.Move(Program.ALSOFT_INI, Program.ALSOFT_INI_BAK);
            }
            else
            {
                if (File.Exists(Program.ALSOFT_INI))
                {
                    return;
                }
                if (File.Exists(Program.ALSOFT_INI_BAK))
                {
                    File.Move(Program.ALSOFT_INI_BAK, Program.ALSOFT_INI);
                }
            }
        }

        private void WriteCommandLine()
        {
            StringBuilder sb = new StringBuilder();

            switch (comboBoxShadowMap.SelectedIndex)
            {
                case 0:
                    sb.AppendLine("-smap1536");
                    break;
                case 2:
                    sb.AppendLine("-smap2560");
                    break;
                case 3:
                    sb.AppendLine("-smap3072");
                    break;
                case 4:
                    sb.AppendLine("-smap4096");
                    break;
                default:
                    sb.AppendLine("-smap2048");
                    break;
            }

            if (checkBoxDebugMode.Checked)
            {
                sb.AppendLine("-dbg");
            }

            if (checkBoxPrefetchSounds.Checked)
            {
                sb.AppendLine("-prefetch_sounds");
            }

            File.WriteAllText("commandline.txt", sb.ToString());
        }

        private void WriteToUserLtx()
        {
            string userltx = string.Empty;
            if (File.Exists(Program.USER_LTX))
            {
                userltx = File.ReadAllText(Program.USER_LTX);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(userltx);

            int width = int.Parse(textBoxResolutionWidth.Text);
            int height = int.Parse(textBoxResolutionHeight.Text);
            string res = width + "x" + height;
            sb.AppendLine("vid_mode " + res);

            switch (comboBoxWindowMode.SelectedIndex)
            {
                case 1: // Fullscreen
                    sb.AppendLine("rs_borderless 0");
                    sb.AppendLine("rs_fullscreen on");
                    sb.AppendLine("rs_screenmode fullscreen");
                    break;
                case 2: // Windowed
                    sb.AppendLine("rs_borderless 0");
                    sb.AppendLine("rs_fullscreen off");
                    sb.AppendLine("rs_screenmode windowed");
                    break;
                default: // Borderless Windowed
                    sb.AppendLine("rs_borderless 1");
                    sb.AppendLine("rs_fullscreen off");
                    sb.AppendLine("rs_screenmode borderless");
                    break;
            }

            if (!Directory.Exists(Program.APPDATA))
            {
                Directory.CreateDirectory(Program.APPDATA);
            }

            File.WriteAllText(Program.USER_LTX, sb.ToString());
        }

        private void buttonSaveSettings_Click(object sender, System.EventArgs e)
        {
            WriteConfig();
            MessageBox.Show("Settings saved.", "Anomaly Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxForceGfxSettings_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxGfxSettings.Visible = checkBoxForceGfxSettings.Checked;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            checkBoxDeleteShaderCache.Checked = true;

            try
            {
                labelWarning.ForeColor = Color.OrangeRed;
                Enabled = false;

                labelWarning.Text = "Verifying install";
                labelWarning.Visible = true;
                Application.DoEvents();

                string result = Program.VerifyInstall(text => { labelWarning.Text = text; Application.DoEvents(); });

                if (string.IsNullOrEmpty(result))
                {
                    labelWarning.ForeColor = Color.GreenYellow;
                    labelWarning.Text = "Verification successful";
                    return;
                }

                labelWarning.Text = result;
                labelWarning.Visible = true;
            }
            catch (Exception ex)
            {
                labelWarning.Text = string.Format("Exception: {0}", ex);
                labelWarning.Visible = true;
            }
            finally
            {
                Enabled = true;
            }
        }

        private void SelectionUI_Shown(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                bool hasFilesInGameData = Program.CheckForAddons(text => { labelWarning.Text = text; Application.DoEvents(); });
                if (hasFilesInGameData)
                {
                    labelWarning.Text = "* installed addons can cause problems or crashes *";
                    labelWarning.Visible = true;
                }
            }
            catch (Exception ex)
            {
                labelWarning.Text = string.Format("Exception: {0}", ex);
                labelWarning.Visible = true;
            }
            finally
            {
                Enabled = true;
            }
        }
    }
}
