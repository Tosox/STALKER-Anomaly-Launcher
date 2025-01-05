namespace Launcher
{
    partial class SelectionUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlayAnomaly = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.checkBoxDeleteShaderCache = new System.Windows.Forms.CheckBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFixSound = new System.Windows.Forms.CheckBox();
            this.comboBoxShadowMap = new System.Windows.Forms.ComboBox();
            this.checkBoxDebugMode = new System.Windows.Forms.CheckBox();
            this.groupBoxGfxSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxWindowMode = new System.Windows.Forms.ComboBox();
            this.textBoxResolutionHeight = new System.Windows.Forms.TextBox();
            this.textBoxResolutionWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxForceGfxSettings = new System.Windows.Forms.CheckBox();
            this.checkBoxAVX = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDX11 = new System.Windows.Forms.RadioButton();
            this.radioButtonDX10 = new System.Windows.Forms.RadioButton();
            this.radioButtonDX9 = new System.Windows.Forms.RadioButton();
            this.radioButtonDX8 = new System.Windows.Forms.RadioButton();
            this.checkBoxResetSettings = new System.Windows.Forms.CheckBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.checkBoxPrefetchSounds = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxGfxSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlayAnomaly
            // 
            this.buttonPlayAnomaly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonPlayAnomaly.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayAnomaly.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPlayAnomaly.Location = new System.Drawing.Point(573, 210);
            this.buttonPlayAnomaly.Name = "buttonPlayAnomaly";
            this.buttonPlayAnomaly.Size = new System.Drawing.Size(364, 79);
            this.buttonPlayAnomaly.TabIndex = 1;
            this.buttonPlayAnomaly.Text = "Play S.T.A.L.K.E.R. Anomaly";
            this.buttonPlayAnomaly.UseVisualStyleBackColor = false;
            this.buttonPlayAnomaly.Click += new System.EventHandler(this.buttonPlayAnomaly_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuit.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonQuit.Location = new System.Drawing.Point(573, 417);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(364, 40);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // checkBoxDeleteShaderCache
            // 
            this.checkBoxDeleteShaderCache.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeleteShaderCache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxDeleteShaderCache.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxDeleteShaderCache.Location = new System.Drawing.Point(573, 295);
            this.checkBoxDeleteShaderCache.Name = "checkBoxDeleteShaderCache";
            this.checkBoxDeleteShaderCache.Size = new System.Drawing.Size(180, 24);
            this.checkBoxDeleteShaderCache.TabIndex = 2;
            this.checkBoxDeleteShaderCache.Text = "Delete Shader Cache";
            this.checkBoxDeleteShaderCache.UseVisualStyleBackColor = false;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonSaveSettings.Location = new System.Drawing.Point(573, 371);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(364, 40);
            this.buttonSaveSettings.TabIndex = 5;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Launcher.Properties.Resources.options2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBoxGfxSettings);
            this.panel1.Controls.Add(this.checkBoxForceGfxSettings);
            this.panel1.Controls.Add(this.checkBoxAVX);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(16, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 417);
            this.panel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPrefetchSounds);
            this.groupBox2.Controls.Add(this.checkBoxFixSound);
            this.groupBox2.Controls.Add(this.comboBoxShadowMap);
            this.groupBox2.Controls.Add(this.checkBoxDebugMode);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(9, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Misc Settings ";
            // 
            // checkBoxFixSound
            // 
            this.checkBoxFixSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxFixSound.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxFixSound.Location = new System.Drawing.Point(6, 76);
            this.checkBoxFixSound.Name = "checkBoxFixSound";
            this.checkBoxFixSound.Size = new System.Drawing.Size(180, 24);
            this.checkBoxFixSound.TabIndex = 12;
            this.checkBoxFixSound.Text = "Sound problem workaround";
            this.checkBoxFixSound.UseVisualStyleBackColor = true;
            // 
            // comboBoxShadowMap
            // 
            this.comboBoxShadowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxShadowMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShadowMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxShadowMap.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxShadowMap.FormattingEnabled = true;
            this.comboBoxShadowMap.Items.AddRange(new object[] {
            "Shadow Map 1536",
            "Shadow Map 2048",
            "Shadow Map 2560",
            "Shadow Map 3072",
            "Shadow Map 4096"});
            this.comboBoxShadowMap.Location = new System.Drawing.Point(6, 49);
            this.comboBoxShadowMap.Name = "comboBoxShadowMap";
            this.comboBoxShadowMap.Size = new System.Drawing.Size(180, 21);
            this.comboBoxShadowMap.TabIndex = 11;
            // 
            // checkBoxDebugMode
            // 
            this.checkBoxDebugMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxDebugMode.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxDebugMode.Location = new System.Drawing.Point(6, 19);
            this.checkBoxDebugMode.Name = "checkBoxDebugMode";
            this.checkBoxDebugMode.Size = new System.Drawing.Size(180, 24);
            this.checkBoxDebugMode.TabIndex = 10;
            this.checkBoxDebugMode.Text = "Debug Mode";
            this.checkBoxDebugMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxGfxSettings
            // 
            this.groupBoxGfxSettings.Controls.Add(this.comboBoxWindowMode);
            this.groupBoxGfxSettings.Controls.Add(this.textBoxResolutionHeight);
            this.groupBoxGfxSettings.Controls.Add(this.textBoxResolutionWidth);
            this.groupBoxGfxSettings.Controls.Add(this.label1);
            this.groupBoxGfxSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBoxGfxSettings.Location = new System.Drawing.Point(239, 87);
            this.groupBoxGfxSettings.Name = "groupBoxGfxSettings";
            this.groupBoxGfxSettings.Size = new System.Drawing.Size(267, 302);
            this.groupBoxGfxSettings.TabIndex = 14;
            this.groupBoxGfxSettings.TabStop = false;
            this.groupBoxGfxSettings.Text = " Graphics settings ";
            // 
            // comboBoxWindowMode
            // 
            this.comboBoxWindowMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxWindowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWindowMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxWindowMode.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxWindowMode.FormattingEnabled = true;
            this.comboBoxWindowMode.Items.AddRange(new object[] {
            "Borderless Windowed",
            "Fullscreen",
            "Windowed"});
            this.comboBoxWindowMode.Location = new System.Drawing.Point(13, 74);
            this.comboBoxWindowMode.Name = "comboBoxWindowMode";
            this.comboBoxWindowMode.Size = new System.Drawing.Size(241, 21);
            this.comboBoxWindowMode.TabIndex = 18;
            // 
            // textBoxResolutionHeight
            // 
            this.textBoxResolutionHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxResolutionHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResolutionHeight.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxResolutionHeight.Location = new System.Drawing.Point(139, 41);
            this.textBoxResolutionHeight.Name = "textBoxResolutionHeight";
            this.textBoxResolutionHeight.Size = new System.Drawing.Size(115, 20);
            this.textBoxResolutionHeight.TabIndex = 17;
            // 
            // textBoxResolutionWidth
            // 
            this.textBoxResolutionWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBoxResolutionWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResolutionWidth.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxResolutionWidth.Location = new System.Drawing.Point(13, 41);
            this.textBoxResolutionWidth.Name = "textBoxResolutionWidth";
            this.textBoxResolutionWidth.Size = new System.Drawing.Size(115, 20);
            this.textBoxResolutionWidth.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Screen Resolution";
            // 
            // checkBoxForceGfxSettings
            // 
            this.checkBoxForceGfxSettings.Checked = true;
            this.checkBoxForceGfxSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxForceGfxSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxForceGfxSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxForceGfxSettings.Location = new System.Drawing.Point(239, 57);
            this.checkBoxForceGfxSettings.Name = "checkBoxForceGfxSettings";
            this.checkBoxForceGfxSettings.Size = new System.Drawing.Size(267, 24);
            this.checkBoxForceGfxSettings.TabIndex = 13;
            this.checkBoxForceGfxSettings.Text = "Reset graphics settings";
            this.checkBoxForceGfxSettings.UseVisualStyleBackColor = true;
            this.checkBoxForceGfxSettings.CheckedChanged += new System.EventHandler(this.checkBoxForceGfxSettings_CheckedChanged);
            // 
            // checkBoxAVX
            // 
            this.checkBoxAVX.Checked = true;
            this.checkBoxAVX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAVX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxAVX.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxAVX.Location = new System.Drawing.Point(15, 198);
            this.checkBoxAVX.Name = "checkBoxAVX";
            this.checkBoxAVX.Size = new System.Drawing.Size(186, 24);
            this.checkBoxAVX.TabIndex = 8;
            this.checkBoxAVX.Text = "Support for AVX CPU";
            this.checkBoxAVX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDX11);
            this.groupBox1.Controls.Add(this.radioButtonDX10);
            this.groupBox1.Controls.Add(this.radioButtonDX9);
            this.groupBox1.Controls.Add(this.radioButtonDX8);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Renderer ";
            // 
            // radioButtonDX11
            // 
            this.radioButtonDX11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDX11.Checked = true;
            this.radioButtonDX11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonDX11.Location = new System.Drawing.Point(6, 109);
            this.radioButtonDX11.Name = "radioButtonDX11";
            this.radioButtonDX11.Size = new System.Drawing.Size(180, 24);
            this.radioButtonDX11.TabIndex = 3;
            this.radioButtonDX11.TabStop = true;
            this.radioButtonDX11.Text = "DirectX 11 (R4)";
            this.radioButtonDX11.UseVisualStyleBackColor = true;
            // 
            // radioButtonDX10
            // 
            this.radioButtonDX10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDX10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonDX10.Location = new System.Drawing.Point(6, 79);
            this.radioButtonDX10.Name = "radioButtonDX10";
            this.radioButtonDX10.Size = new System.Drawing.Size(180, 24);
            this.radioButtonDX10.TabIndex = 2;
            this.radioButtonDX10.Text = "DirectX 10 (R3)";
            this.radioButtonDX10.UseVisualStyleBackColor = true;
            // 
            // radioButtonDX9
            // 
            this.radioButtonDX9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDX9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonDX9.Location = new System.Drawing.Point(6, 49);
            this.radioButtonDX9.Name = "radioButtonDX9";
            this.radioButtonDX9.Size = new System.Drawing.Size(180, 24);
            this.radioButtonDX9.TabIndex = 1;
            this.radioButtonDX9.Text = "DirectX 9 (R2)";
            this.radioButtonDX9.UseVisualStyleBackColor = true;
            // 
            // radioButtonDX8
            // 
            this.radioButtonDX8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDX8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonDX8.ForeColor = System.Drawing.Color.DarkGray;
            this.radioButtonDX8.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDX8.Name = "radioButtonDX8";
            this.radioButtonDX8.Size = new System.Drawing.Size(180, 24);
            this.radioButtonDX8.TabIndex = 0;
            this.radioButtonDX8.Text = "DirectX 8 (R1)";
            this.radioButtonDX8.UseVisualStyleBackColor = true;
            // 
            // checkBoxResetSettings
            // 
            this.checkBoxResetSettings.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxResetSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxResetSettings.Location = new System.Drawing.Point(757, 295);
            this.checkBoxResetSettings.Name = "checkBoxResetSettings";
            this.checkBoxResetSettings.Size = new System.Drawing.Size(180, 24);
            this.checkBoxResetSettings.TabIndex = 3;
            this.checkBoxResetSettings.Text = "Restore default user.ltx";
            this.checkBoxResetSettings.UseVisualStyleBackColor = false;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVerify.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonVerify.Location = new System.Drawing.Point(573, 325);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(364, 40);
            this.buttonVerify.TabIndex = 4;
            this.buttonVerify.Text = "Verify Installed Version";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelWarning.Location = new System.Drawing.Point(25, 460);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(912, 23);
            this.labelWarning.TabIndex = 19;
            this.labelWarning.Text = "OK";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPrefetchSounds
            // 
            this.checkBoxPrefetchSounds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxPrefetchSounds.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxPrefetchSounds.Location = new System.Drawing.Point(6, 106);
            this.checkBoxPrefetchSounds.Name = "checkBoxPrefetchSounds";
            this.checkBoxPrefetchSounds.Size = new System.Drawing.Size(180, 24);
            this.checkBoxPrefetchSounds.TabIndex = 13;
            this.checkBoxPrefetchSounds.Text = "Prefetch sounds";
            this.checkBoxPrefetchSounds.UseVisualStyleBackColor = true;
            // 
            // SelectionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(961, 493);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.checkBoxResetSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.checkBoxDeleteShaderCache);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonPlayAnomaly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Launcher.Properties.Resources.Stalker;
            this.MaximizeBox = false;
            this.Name = "SelectionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anomaly Launcher v1.0.5";
            this.Shown += new System.EventHandler(this.SelectionUI_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxGfxSettings.ResumeLayout(false);
            this.groupBoxGfxSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayAnomaly;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.CheckBox checkBoxDeleteShaderCache;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAVX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDX11;
        private System.Windows.Forms.RadioButton radioButtonDX10;
        private System.Windows.Forms.RadioButton radioButtonDX9;
        private System.Windows.Forms.RadioButton radioButtonDX8;
        private System.Windows.Forms.GroupBox groupBoxGfxSettings;
        private System.Windows.Forms.ComboBox comboBoxWindowMode;
        private System.Windows.Forms.TextBox textBoxResolutionHeight;
        private System.Windows.Forms.TextBox textBoxResolutionWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxForceGfxSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxShadowMap;
        private System.Windows.Forms.CheckBox checkBoxDebugMode;
        private System.Windows.Forms.CheckBox checkBoxFixSound;
        private System.Windows.Forms.CheckBox checkBoxResetSettings;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.CheckBox checkBoxPrefetchSounds;
    }
}