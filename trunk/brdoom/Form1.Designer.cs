namespace BrDOOM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLauncher = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSkillImpossivel = new System.Windows.Forms.RadioButton();
            this.rbSkillDificil = new System.Windows.Forms.RadioButton();
            this.rbSkillNormal = new System.Windows.Forms.RadioButton();
            this.rbSkillFacil = new System.Windows.Forms.RadioButton();
            this.rbSkillExtraFacil = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCooperative = new System.Windows.Forms.RadioButton();
            this.rbDeathMatch = new System.Windows.Forms.RadioButton();
            this.rbSinglePlayer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIwadDoom = new System.Windows.Forms.RadioButton();
            this.rbIwadHexen = new System.Windows.Forms.RadioButton();
            this.rbIwadHeretic = new System.Windows.Forms.RadioButton();
            this.rbIwadPlutonia = new System.Windows.Forms.RadioButton();
            this.rbIwadTnt = new System.Windows.Forms.RadioButton();
            this.rbIwadDoom2 = new System.Windows.Forms.RadioButton();
            this.txtLevelWarp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpServer = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbOldDeathmatch = new System.Windows.Forms.CheckBox();
            this.cbNoSound = new System.Windows.Forms.CheckBox();
            this.cbNoSfx = new System.Windows.Forms.CheckBox();
            this.cbNoMusic = new System.Windows.Forms.CheckBox();
            this.cbNoMouse = new System.Windows.Forms.CheckBox();
            this.cbNoMonsters = new System.Windows.Forms.CheckBox();
            this.cbAltDeath = new System.Windows.Forms.CheckBox();
            this.cbHost = new System.Windows.Forms.CheckBox();
            this.mtbIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbPlayers = new System.Windows.Forms.MaskedTextBox();
            this.mtbTimeLimit = new System.Windows.Forms.MaskedTextBox();
            this.mtbFragLimit = new System.Windows.Forms.MaskedTextBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLauncher.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpServer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.arquivoToolStripMenuItem.Text = "File";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Open...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sairToolStripMenuItem.Text = "Exit";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ajudaToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.manualToolStripMenuItem.Text = "User Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.sobreToolStripMenuItem.Text = "About...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(498, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLauncher);
            this.tabControl1.Controls.Add(this.tpServer);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 250);
            this.tabControl1.TabIndex = 2;
            // 
            // tpLauncher
            // 
            this.tpLauncher.Controls.Add(this.groupBox3);
            this.tpLauncher.Controls.Add(this.groupBox2);
            this.tpLauncher.Controls.Add(this.groupBox1);
            this.tpLauncher.Controls.Add(this.txtLevelWarp);
            this.tpLauncher.Controls.Add(this.label5);
            this.tpLauncher.Location = new System.Drawing.Point(4, 22);
            this.tpLauncher.Name = "tpLauncher";
            this.tpLauncher.Padding = new System.Windows.Forms.Padding(3);
            this.tpLauncher.Size = new System.Drawing.Size(468, 224);
            this.tpLauncher.TabIndex = 0;
            this.tpLauncher.Text = "Launcher";
            this.tpLauncher.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSkillImpossivel);
            this.groupBox3.Controls.Add(this.rbSkillDificil);
            this.groupBox3.Controls.Add(this.rbSkillNormal);
            this.groupBox3.Controls.Add(this.rbSkillFacil);
            this.groupBox3.Controls.Add(this.rbSkillExtraFacil);
            this.groupBox3.Location = new System.Drawing.Point(175, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 139);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skill";
            // 
            // rbSkillImpossivel
            // 
            this.rbSkillImpossivel.AutoSize = true;
            this.rbSkillImpossivel.Location = new System.Drawing.Point(7, 110);
            this.rbSkillImpossivel.Name = "rbSkillImpossivel";
            this.rbSkillImpossivel.Size = new System.Drawing.Size(93, 17);
            this.rbSkillImpossivel.TabIndex = 4;
            this.rbSkillImpossivel.TabStop = true;
            this.rbSkillImpossivel.Text = "NIGHTMARE!";
            this.rbSkillImpossivel.UseVisualStyleBackColor = true;
            this.rbSkillImpossivel.CheckedChanged += new System.EventHandler(this.rbSkillImpossivel_CheckedChanged);
            // 
            // rbSkillDificil
            // 
            this.rbSkillDificil.AutoSize = true;
            this.rbSkillDificil.Location = new System.Drawing.Point(7, 87);
            this.rbSkillDificil.Name = "rbSkillDificil";
            this.rbSkillDificil.Size = new System.Drawing.Size(91, 17);
            this.rbSkillDificil.TabIndex = 3;
            this.rbSkillDificil.TabStop = true;
            this.rbSkillDificil.Text = "Ultra-Violence";
            this.rbSkillDificil.UseVisualStyleBackColor = true;
            this.rbSkillDificil.CheckedChanged += new System.EventHandler(this.rbSkillDificil_CheckedChanged);
            // 
            // rbSkillNormal
            // 
            this.rbSkillNormal.AutoSize = true;
            this.rbSkillNormal.Location = new System.Drawing.Point(7, 64);
            this.rbSkillNormal.Name = "rbSkillNormal";
            this.rbSkillNormal.Size = new System.Drawing.Size(98, 17);
            this.rbSkillNormal.TabIndex = 2;
            this.rbSkillNormal.TabStop = true;
            this.rbSkillNormal.Text = "Hurt Me Plenty!";
            this.rbSkillNormal.UseVisualStyleBackColor = true;
            this.rbSkillNormal.CheckedChanged += new System.EventHandler(this.rbSkillNormal_CheckedChanged);
            // 
            // rbSkillFacil
            // 
            this.rbSkillFacil.AutoSize = true;
            this.rbSkillFacil.Location = new System.Drawing.Point(7, 41);
            this.rbSkillFacil.Name = "rbSkillFacil";
            this.rbSkillFacil.Size = new System.Drawing.Size(116, 17);
            this.rbSkillFacil.TabIndex = 1;
            this.rbSkillFacil.TabStop = true;
            this.rbSkillFacil.Text = "Hey, not too rough!";
            this.rbSkillFacil.UseVisualStyleBackColor = true;
            this.rbSkillFacil.CheckedChanged += new System.EventHandler(this.rbSkillFacil_CheckedChanged);
            // 
            // rbSkillExtraFacil
            // 
            this.rbSkillExtraFacil.AutoSize = true;
            this.rbSkillExtraFacil.Location = new System.Drawing.Point(9, 18);
            this.rbSkillExtraFacil.Name = "rbSkillExtraFacil";
            this.rbSkillExtraFacil.Size = new System.Drawing.Size(114, 17);
            this.rbSkillExtraFacil.TabIndex = 0;
            this.rbSkillExtraFacil.TabStop = true;
            this.rbSkillExtraFacil.Text = "I\'m too yong to die!";
            this.rbSkillExtraFacil.UseVisualStyleBackColor = true;
            this.rbSkillExtraFacil.CheckedChanged += new System.EventHandler(this.rbSkillExtraFacil_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCooperative);
            this.groupBox2.Controls.Add(this.rbDeathMatch);
            this.groupBox2.Controls.Add(this.rbSinglePlayer);
            this.groupBox2.Location = new System.Drawing.Point(338, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GameType";
            // 
            // rbCooperative
            // 
            this.rbCooperative.AutoSize = true;
            this.rbCooperative.Location = new System.Drawing.Point(9, 66);
            this.rbCooperative.Name = "rbCooperative";
            this.rbCooperative.Size = new System.Drawing.Size(82, 17);
            this.rbCooperative.TabIndex = 2;
            this.rbCooperative.TabStop = true;
            this.rbCooperative.Text = "Cooperative";
            this.rbCooperative.UseVisualStyleBackColor = true;
            this.rbCooperative.CheckedChanged += new System.EventHandler(this.rbCooperative_CheckedChanged);
            // 
            // rbDeathMatch
            // 
            this.rbDeathMatch.AutoSize = true;
            this.rbDeathMatch.Location = new System.Drawing.Point(9, 43);
            this.rbDeathMatch.Name = "rbDeathMatch";
            this.rbDeathMatch.Size = new System.Drawing.Size(84, 17);
            this.rbDeathMatch.TabIndex = 1;
            this.rbDeathMatch.TabStop = true;
            this.rbDeathMatch.Text = "DeathMatch";
            this.rbDeathMatch.UseVisualStyleBackColor = true;
            this.rbDeathMatch.CheckedChanged += new System.EventHandler(this.rbDeathMatch_CheckedChanged);
            // 
            // rbSinglePlayer
            // 
            this.rbSinglePlayer.AutoSize = true;
            this.rbSinglePlayer.Location = new System.Drawing.Point(9, 20);
            this.rbSinglePlayer.Name = "rbSinglePlayer";
            this.rbSinglePlayer.Size = new System.Drawing.Size(83, 17);
            this.rbSinglePlayer.TabIndex = 0;
            this.rbSinglePlayer.TabStop = true;
            this.rbSinglePlayer.Text = "SinglePlayer";
            this.rbSinglePlayer.UseVisualStyleBackColor = true;
            this.rbSinglePlayer.CheckedChanged += new System.EventHandler(this.rbSinglePlayer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIwadDoom);
            this.groupBox1.Controls.Add(this.rbIwadHexen);
            this.groupBox1.Controls.Add(this.rbIwadHeretic);
            this.groupBox1.Controls.Add(this.rbIwadPlutonia);
            this.groupBox1.Controls.Add(this.rbIwadTnt);
            this.groupBox1.Controls.Add(this.rbIwadDoom2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IWAD";
            // 
            // rbIwadDoom
            // 
            this.rbIwadDoom.AutoSize = true;
            this.rbIwadDoom.Location = new System.Drawing.Point(6, 18);
            this.rbIwadDoom.Name = "rbIwadDoom";
            this.rbIwadDoom.Size = new System.Drawing.Size(53, 17);
            this.rbIwadDoom.TabIndex = 11;
            this.rbIwadDoom.TabStop = true;
            this.rbIwadDoom.Text = "Doom";
            this.rbIwadDoom.UseVisualStyleBackColor = true;
            this.rbIwadDoom.CheckedChanged += new System.EventHandler(this.rbIwadDoom_CheckedChanged);
            // 
            // rbIwadHexen
            // 
            this.rbIwadHexen.AutoSize = true;
            this.rbIwadHexen.Location = new System.Drawing.Point(6, 133);
            this.rbIwadHexen.Name = "rbIwadHexen";
            this.rbIwadHexen.Size = new System.Drawing.Size(56, 17);
            this.rbIwadHexen.TabIndex = 4;
            this.rbIwadHexen.TabStop = true;
            this.rbIwadHexen.Text = "Hexen";
            this.rbIwadHexen.UseVisualStyleBackColor = true;
            this.rbIwadHexen.CheckedChanged += new System.EventHandler(this.rbIwadHexen_CheckedChanged);
            // 
            // rbIwadHeretic
            // 
            this.rbIwadHeretic.AutoSize = true;
            this.rbIwadHeretic.Location = new System.Drawing.Point(6, 110);
            this.rbIwadHeretic.Name = "rbIwadHeretic";
            this.rbIwadHeretic.Size = new System.Drawing.Size(59, 17);
            this.rbIwadHeretic.TabIndex = 3;
            this.rbIwadHeretic.TabStop = true;
            this.rbIwadHeretic.Text = "Heretic";
            this.rbIwadHeretic.UseVisualStyleBackColor = true;
            this.rbIwadHeretic.CheckedChanged += new System.EventHandler(this.rbIwadHeretic_CheckedChanged);
            // 
            // rbIwadPlutonia
            // 
            this.rbIwadPlutonia.AutoSize = true;
            this.rbIwadPlutonia.Location = new System.Drawing.Point(6, 87);
            this.rbIwadPlutonia.Name = "rbIwadPlutonia";
            this.rbIwadPlutonia.Size = new System.Drawing.Size(118, 17);
            this.rbIwadPlutonia.TabIndex = 2;
            this.rbIwadPlutonia.TabStop = true;
            this.rbIwadPlutonia.Text = "Plutonia Experiment";
            this.rbIwadPlutonia.UseVisualStyleBackColor = true;
            this.rbIwadPlutonia.CheckedChanged += new System.EventHandler(this.rbIwadPlutonia_CheckedChanged);
            // 
            // rbIwadTnt
            // 
            this.rbIwadTnt.AutoSize = true;
            this.rbIwadTnt.Location = new System.Drawing.Point(6, 64);
            this.rbIwadTnt.Name = "rbIwadTnt";
            this.rbIwadTnt.Size = new System.Drawing.Size(90, 17);
            this.rbIwadTnt.TabIndex = 1;
            this.rbIwadTnt.TabStop = true;
            this.rbIwadTnt.Text = "TNT Evilution";
            this.rbIwadTnt.UseVisualStyleBackColor = true;
            this.rbIwadTnt.CheckedChanged += new System.EventHandler(this.rbIwadTnt_CheckedChanged);
            // 
            // rbIwadDoom2
            // 
            this.rbIwadDoom2.AutoSize = true;
            this.rbIwadDoom2.Location = new System.Drawing.Point(6, 41);
            this.rbIwadDoom2.Name = "rbIwadDoom2";
            this.rbIwadDoom2.Size = new System.Drawing.Size(132, 17);
            this.rbIwadDoom2.TabIndex = 0;
            this.rbIwadDoom2.TabStop = true;
            this.rbIwadDoom2.Text = "Doom 2 - Hell on Earth";
            this.rbIwadDoom2.UseVisualStyleBackColor = true;
            this.rbIwadDoom2.CheckedChanged += new System.EventHandler(this.rbIwadDoom2_CheckedChanged);
            // 
            // txtLevelWarp
            // 
            this.txtLevelWarp.Location = new System.Drawing.Point(9, 187);
            this.txtLevelWarp.Name = "txtLevelWarp";
            this.txtLevelWarp.Size = new System.Drawing.Size(62, 20);
            this.txtLevelWarp.TabIndex = 9;
            this.txtLevelWarp.TextChanged += new System.EventHandler(this.txtLevelWarp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Level Warp";
            // 
            // tpServer
            // 
            this.tpServer.Controls.Add(this.groupBox4);
            this.tpServer.Controls.Add(this.txtCommandLine);
            this.tpServer.Controls.Add(this.label15);
            this.tpServer.Location = new System.Drawing.Point(4, 22);
            this.tpServer.Name = "tpServer";
            this.tpServer.Size = new System.Drawing.Size(468, 224);
            this.tpServer.TabIndex = 4;
            this.tpServer.Text = "Server/Client";
            this.tpServer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbOldDeathmatch);
            this.groupBox4.Controls.Add(this.cbNoSound);
            this.groupBox4.Controls.Add(this.cbNoSfx);
            this.groupBox4.Controls.Add(this.cbNoMusic);
            this.groupBox4.Controls.Add(this.cbNoMouse);
            this.groupBox4.Controls.Add(this.cbNoMonsters);
            this.groupBox4.Controls.Add(this.cbAltDeath);
            this.groupBox4.Controls.Add(this.cbHost);
            this.groupBox4.Controls.Add(this.mtbIpAddress);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.mtbPlayers);
            this.groupBox4.Controls.Add(this.mtbTimeLimit);
            this.groupBox4.Controls.Add(this.mtbFragLimit);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 166);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Options";
            // 
            // cbOldDeathmatch
            // 
            this.cbOldDeathmatch.AutoSize = true;
            this.cbOldDeathmatch.Location = new System.Drawing.Point(7, 42);
            this.cbOldDeathmatch.Name = "cbOldDeathmatch";
            this.cbOldDeathmatch.Size = new System.Drawing.Size(141, 17);
            this.cbOldDeathmatch.TabIndex = 19;
            this.cbOldDeathmatch.Text = "Deathmatch Old Version";
            this.cbOldDeathmatch.UseVisualStyleBackColor = true;
            this.cbOldDeathmatch.CheckedChanged += new System.EventHandler(this.cbOldDeathmatch_CheckedChanged);
            // 
            // cbNoSound
            // 
            this.cbNoSound.AutoSize = true;
            this.cbNoSound.Location = new System.Drawing.Point(207, 88);
            this.cbNoSound.Name = "cbNoSound";
            this.cbNoSound.Size = new System.Drawing.Size(74, 17);
            this.cbNoSound.TabIndex = 18;
            this.cbNoSound.Text = "No Sound";
            this.toolTip1.SetToolTip(this.cbNoSound, "Desativa todos os efeitos de som e músicas");
            this.cbNoSound.UseVisualStyleBackColor = true;
            this.cbNoSound.CheckedChanged += new System.EventHandler(this.cbNoSound_CheckedChanged);
            // 
            // cbNoSfx
            // 
            this.cbNoSfx.AutoSize = true;
            this.cbNoSfx.Location = new System.Drawing.Point(207, 65);
            this.cbNoSfx.Name = "cbNoSfx";
            this.cbNoSfx.Size = new System.Drawing.Size(63, 17);
            this.cbNoSfx.TabIndex = 17;
            this.cbNoSfx.Text = "No SFX";
            this.cbNoSfx.UseVisualStyleBackColor = true;
            this.cbNoSfx.CheckedChanged += new System.EventHandler(this.cbNoSfx_CheckedChanged);
            // 
            // cbNoMusic
            // 
            this.cbNoMusic.AutoSize = true;
            this.cbNoMusic.Location = new System.Drawing.Point(7, 134);
            this.cbNoMusic.Name = "cbNoMusic";
            this.cbNoMusic.Size = new System.Drawing.Size(71, 17);
            this.cbNoMusic.TabIndex = 16;
            this.cbNoMusic.Text = "No Music";
            this.cbNoMusic.UseVisualStyleBackColor = true;
            this.cbNoMusic.CheckedChanged += new System.EventHandler(this.cbNoMusic_CheckedChanged);
            // 
            // cbNoMouse
            // 
            this.cbNoMouse.AutoSize = true;
            this.cbNoMouse.Location = new System.Drawing.Point(7, 111);
            this.cbNoMouse.Name = "cbNoMouse";
            this.cbNoMouse.Size = new System.Drawing.Size(75, 17);
            this.cbNoMouse.TabIndex = 15;
            this.cbNoMouse.Text = "No Mouse";
            this.cbNoMouse.UseVisualStyleBackColor = true;
            this.cbNoMouse.CheckedChanged += new System.EventHandler(this.cbNoMouse_CheckedChanged);
            // 
            // cbNoMonsters
            // 
            this.cbNoMonsters.AutoSize = true;
            this.cbNoMonsters.Location = new System.Drawing.Point(7, 88);
            this.cbNoMonsters.Name = "cbNoMonsters";
            this.cbNoMonsters.Size = new System.Drawing.Size(86, 17);
            this.cbNoMonsters.TabIndex = 14;
            this.cbNoMonsters.Text = "No Monsters";
            this.toolTip1.SetToolTip(this.cbNoMonsters, "Desativa os monstros. Eles não irão aparecer no jogo.");
            this.cbNoMonsters.UseVisualStyleBackColor = true;
            this.cbNoMonsters.CheckedChanged += new System.EventHandler(this.cbNoMonters_CheckedChanged);
            // 
            // cbAltDeath
            // 
            this.cbAltDeath.AutoSize = true;
            this.cbAltDeath.Location = new System.Drawing.Point(7, 65);
            this.cbAltDeath.Name = "cbAltDeath";
            this.cbAltDeath.Size = new System.Drawing.Size(108, 17);
            this.cbAltDeath.TabIndex = 13;
            this.cbAltDeath.Text = "Deathmatch v2.0";
            this.cbAltDeath.UseVisualStyleBackColor = true;
            this.cbAltDeath.CheckedChanged += new System.EventHandler(this.cbAltDeath_CheckedChanged);
            // 
            // cbHost
            // 
            this.cbHost.AutoSize = true;
            this.cbHost.Location = new System.Drawing.Point(7, 19);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(124, 17);
            this.cbHost.TabIndex = 5;
            this.cbHost.Text = "Enable Host (Server)";
            this.cbHost.UseVisualStyleBackColor = true;
            // 
            // mtbIpAddress
            // 
            this.mtbIpAddress.Location = new System.Drawing.Point(357, 25);
            this.mtbIpAddress.Mask = "000.000.000.000";
            this.mtbIpAddress.Name = "mtbIpAddress";
            this.mtbIpAddress.Size = new System.Drawing.Size(97, 20);
            this.mtbIpAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Players";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(354, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "IP Address (IPv4)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Timelimit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fraglimit";
            // 
            // mtbPlayers
            // 
            this.mtbPlayers.Location = new System.Drawing.Point(207, 25);
            this.mtbPlayers.Mask = "00";
            this.mtbPlayers.Name = "mtbPlayers";
            this.mtbPlayers.Size = new System.Drawing.Size(44, 20);
            this.mtbPlayers.TabIndex = 6;
            // 
            // mtbTimeLimit
            // 
            this.mtbTimeLimit.Location = new System.Drawing.Point(307, 25);
            this.mtbTimeLimit.Mask = "00";
            this.mtbTimeLimit.Name = "mtbTimeLimit";
            this.mtbTimeLimit.Size = new System.Drawing.Size(44, 20);
            this.mtbTimeLimit.TabIndex = 8;
            // 
            // mtbFragLimit
            // 
            this.mtbFragLimit.Location = new System.Drawing.Point(257, 25);
            this.mtbFragLimit.Mask = "00";
            this.mtbFragLimit.Name = "mtbFragLimit";
            this.mtbFragLimit.Size = new System.Drawing.Size(44, 20);
            this.mtbFragLimit.TabIndex = 7;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(6, 198);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(459, 20);
            this.txtCommandLine.TabIndex = 10;
            this.txtCommandLine.TextChanged += new System.EventHandler(this.txtCommandLine_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Command line parameters:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 224);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Extra Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(332, 283);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(12, 283);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 331);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrDOOM \'SkullTag\' Launcher 1.0.0 (Alpha)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpLauncher.ResumeLayout(false);
            this.tpLauncher.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpServer.ResumeLayout(false);
            this.tpServer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLauncher;
        private System.Windows.Forms.TabPage tpServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox txtLevelWarp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbTimeLimit;
        private System.Windows.Forms.MaskedTextBox mtbFragLimit;
        private System.Windows.Forms.MaskedTextBox mtbPlayers;
        private System.Windows.Forms.CheckBox cbHost;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mtbIpAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIwadDoom;
        private System.Windows.Forms.RadioButton rbIwadHexen;
        private System.Windows.Forms.RadioButton rbIwadHeretic;
        private System.Windows.Forms.RadioButton rbIwadPlutonia;
        private System.Windows.Forms.RadioButton rbIwadTnt;
        private System.Windows.Forms.RadioButton rbIwadDoom2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCooperative;
        private System.Windows.Forms.RadioButton rbDeathMatch;
        private System.Windows.Forms.RadioButton rbSinglePlayer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSkillImpossivel;
        private System.Windows.Forms.RadioButton rbSkillDificil;
        private System.Windows.Forms.RadioButton rbSkillNormal;
        private System.Windows.Forms.RadioButton rbSkillFacil;
        private System.Windows.Forms.RadioButton rbSkillExtraFacil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbAltDeath;
        private System.Windows.Forms.CheckBox cbNoMonsters;
        private System.Windows.Forms.CheckBox cbNoSfx;
        private System.Windows.Forms.CheckBox cbNoMusic;
        private System.Windows.Forms.CheckBox cbNoMouse;
        private System.Windows.Forms.CheckBox cbNoSound;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbOldDeathmatch;
    }
}

