﻿
namespace EAM_Statistics
{
    partial class UIAccountViewer
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIAccountViewer));
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState7 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState8 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState9 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState10 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState11 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState12 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.pAccount = new System.Windows.Forms.Panel();
            this.lAccountEmail = new System.Windows.Forms.Label();
            this.lAccounts = new System.Windows.Forms.Label();
            this.lAmountName = new System.Windows.Forms.Label();
            this.mtpAccounts = new EAM_Statistics.MaterialPanel();
            this.pTotalFame = new System.Windows.Forms.Panel();
            this.lTotalFame = new System.Windows.Forms.Label();
            this.lTotalFameValue = new System.Windows.Forms.Label();
            this.mtpTotalFame = new EAM_Statistics.MaterialPanel();
            this.pDataActuality = new System.Windows.Forms.Panel();
            this.lTimeOfLastDataset = new System.Windows.Forms.Label();
            this.lDataActuality = new System.Windows.Forms.Label();
            this.lDataActualityValue = new System.Windows.Forms.Label();
            this.mtpDataActuality = new EAM_Statistics.MaterialPanel();
            this.pAliveFame = new System.Windows.Forms.Panel();
            this.lAliveFame = new System.Windows.Forms.Label();
            this.lAliveFameValue = new System.Windows.Forms.Label();
            this.mtpAliveFame = new EAM_Statistics.MaterialPanel();
            this.pBestClass = new System.Windows.Forms.Panel();
            this.toggleBestClassByTotalFame = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.lBestToggleT = new System.Windows.Forms.Label();
            this.lBestToggleB = new System.Windows.Forms.Label();
            this.lBestLevel = new System.Windows.Forms.Label();
            this.lBestLevelValue = new System.Windows.Forms.Label();
            this.lBestFameValue = new System.Windows.Forms.Label();
            this.lBestFame = new System.Windows.Forms.Label();
            this.pbBestClassImage = new System.Windows.Forms.PictureBox();
            this.lBestClass = new System.Windows.Forms.Label();
            this.lBestClassName = new System.Windows.Forms.Label();
            this.mtpBestClass = new EAM_Statistics.MaterialPanel();
            this.pbReturn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.mtpRadarChars = new EAM_Statistics.MaterialRadarChars();
            this.mtpCharacters = new EAM_Statistics.MaterialTopAccount();
            this.toggleRadarCharsByTotalFame = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.lRadarToggleT = new System.Windows.Forms.Label();
            this.lRadarToggleB = new System.Windows.Forms.Label();
            this.lNoChars = new System.Windows.Forms.Label();
            this.pAccount.SuspendLayout();
            this.pTotalFame.SuspendLayout();
            this.pDataActuality.SuspendLayout();
            this.pAliveFame.SuspendLayout();
            this.pBestClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBestClassImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pAccount
            // 
            this.pAccount.Controls.Add(this.lAccountEmail);
            this.pAccount.Controls.Add(this.lAccounts);
            this.pAccount.Controls.Add(this.lAmountName);
            this.pAccount.Controls.Add(this.mtpAccounts);
            this.pAccount.Location = new System.Drawing.Point(5, 5);
            this.pAccount.Name = "pAccount";
            this.pAccount.Size = new System.Drawing.Size(200, 85);
            this.pAccount.TabIndex = 15;
            // 
            // lAccountEmail
            // 
            this.lAccountEmail.AutoSize = true;
            this.lAccountEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAccountEmail.Location = new System.Drawing.Point(9, 58);
            this.lAccountEmail.Name = "lAccountEmail";
            this.lAccountEmail.Size = new System.Drawing.Size(45, 17);
            this.lAccountEmail.TabIndex = 4;
            this.lAccountEmail.Text = "E-Mail";
            // 
            // lAccounts
            // 
            this.lAccounts.AutoSize = true;
            this.lAccounts.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAccounts.Location = new System.Drawing.Point(10, 11);
            this.lAccounts.Name = "lAccounts";
            this.lAccounts.Size = new System.Drawing.Size(45, 13);
            this.lAccounts.TabIndex = 2;
            this.lAccounts.Text = "Account";
            // 
            // lAmountName
            // 
            this.lAmountName.AutoSize = true;
            this.lAmountName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmountName.Location = new System.Drawing.Point(9, 32);
            this.lAmountName.Name = "lAmountName";
            this.lAmountName.Size = new System.Drawing.Size(119, 21);
            this.lAmountName.TabIndex = 3;
            this.lAmountName.Text = "AccountName";
            // 
            // mtpAccounts
            // 
            this.mtpAccounts.BackColor = System.Drawing.Color.Transparent;
            this.mtpAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpAccounts.Location = new System.Drawing.Point(0, 0);
            this.mtpAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.mtpAccounts.Name = "mtpAccounts";
            this.mtpAccounts.Size = new System.Drawing.Size(200, 85);
            this.mtpAccounts.TabIndex = 1;
            // 
            // pTotalFame
            // 
            this.pTotalFame.Controls.Add(this.lTotalFame);
            this.pTotalFame.Controls.Add(this.lTotalFameValue);
            this.pTotalFame.Controls.Add(this.mtpTotalFame);
            this.pTotalFame.Location = new System.Drawing.Point(210, 5);
            this.pTotalFame.Name = "pTotalFame";
            this.pTotalFame.Size = new System.Drawing.Size(200, 70);
            this.pTotalFame.TabIndex = 16;
            // 
            // lTotalFame
            // 
            this.lTotalFame.AutoSize = true;
            this.lTotalFame.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalFame.Location = new System.Drawing.Point(10, 11);
            this.lTotalFame.Name = "lTotalFame";
            this.lTotalFame.Size = new System.Drawing.Size(56, 13);
            this.lTotalFame.TabIndex = 2;
            this.lTotalFame.Text = "Total fame";
            // 
            // lTotalFameValue
            // 
            this.lTotalFameValue.AutoSize = true;
            this.lTotalFameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalFameValue.Location = new System.Drawing.Point(9, 32);
            this.lTotalFameValue.Name = "lTotalFameValue";
            this.lTotalFameValue.Size = new System.Drawing.Size(114, 21);
            this.lTotalFameValue.TabIndex = 3;
            this.lTotalFameValue.Text = "{0} total fame";
            // 
            // mtpTotalFame
            // 
            this.mtpTotalFame.BackColor = System.Drawing.Color.Transparent;
            this.mtpTotalFame.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpTotalFame.Location = new System.Drawing.Point(0, 0);
            this.mtpTotalFame.Margin = new System.Windows.Forms.Padding(2);
            this.mtpTotalFame.Name = "mtpTotalFame";
            this.mtpTotalFame.Size = new System.Drawing.Size(200, 70);
            this.mtpTotalFame.TabIndex = 1;
            // 
            // pDataActuality
            // 
            this.pDataActuality.Controls.Add(this.lTimeOfLastDataset);
            this.pDataActuality.Controls.Add(this.lDataActuality);
            this.pDataActuality.Controls.Add(this.lDataActualityValue);
            this.pDataActuality.Controls.Add(this.mtpDataActuality);
            this.pDataActuality.Location = new System.Drawing.Point(5, 95);
            this.pDataActuality.Name = "pDataActuality";
            this.pDataActuality.Size = new System.Drawing.Size(200, 85);
            this.pDataActuality.TabIndex = 17;
            // 
            // lTimeOfLastDataset
            // 
            this.lTimeOfLastDataset.AutoSize = true;
            this.lTimeOfLastDataset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeOfLastDataset.Location = new System.Drawing.Point(9, 32);
            this.lTimeOfLastDataset.Name = "lTimeOfLastDataset";
            this.lTimeOfLastDataset.Size = new System.Drawing.Size(127, 17);
            this.lTimeOfLastDataset.TabIndex = 4;
            this.lTimeOfLastDataset.Text = "Time of last dataset";
            // 
            // lDataActuality
            // 
            this.lDataActuality.AutoSize = true;
            this.lDataActuality.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataActuality.Location = new System.Drawing.Point(10, 11);
            this.lDataActuality.Name = "lDataActuality";
            this.lDataActuality.Size = new System.Drawing.Size(71, 13);
            this.lDataActuality.TabIndex = 2;
            this.lDataActuality.Text = "Data actuality";
            // 
            // lDataActualityValue
            // 
            this.lDataActualityValue.AutoSize = true;
            this.lDataActualityValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataActualityValue.Location = new System.Drawing.Point(9, 52);
            this.lDataActualityValue.Name = "lDataActualityValue";
            this.lDataActualityValue.Size = new System.Drawing.Size(134, 21);
            this.lDataActualityValue.TabIndex = 3;
            this.lDataActualityValue.Text = "28.03.2021 21:16";
            // 
            // mtpDataActuality
            // 
            this.mtpDataActuality.BackColor = System.Drawing.Color.Transparent;
            this.mtpDataActuality.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpDataActuality.Location = new System.Drawing.Point(0, 0);
            this.mtpDataActuality.Margin = new System.Windows.Forms.Padding(2);
            this.mtpDataActuality.Name = "mtpDataActuality";
            this.mtpDataActuality.Size = new System.Drawing.Size(200, 85);
            this.mtpDataActuality.TabIndex = 1;
            // 
            // pAliveFame
            // 
            this.pAliveFame.Controls.Add(this.lAliveFame);
            this.pAliveFame.Controls.Add(this.lAliveFameValue);
            this.pAliveFame.Controls.Add(this.mtpAliveFame);
            this.pAliveFame.Location = new System.Drawing.Point(210, 80);
            this.pAliveFame.Name = "pAliveFame";
            this.pAliveFame.Size = new System.Drawing.Size(200, 70);
            this.pAliveFame.TabIndex = 20;
            // 
            // lAliveFame
            // 
            this.lAliveFame.AutoSize = true;
            this.lAliveFame.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAliveFame.Location = new System.Drawing.Point(10, 11);
            this.lAliveFame.Name = "lAliveFame";
            this.lAliveFame.Size = new System.Drawing.Size(56, 13);
            this.lAliveFame.TabIndex = 2;
            this.lAliveFame.Text = "Alive fame";
            // 
            // lAliveFameValue
            // 
            this.lAliveFameValue.AutoSize = true;
            this.lAliveFameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAliveFameValue.Location = new System.Drawing.Point(9, 32);
            this.lAliveFameValue.Name = "lAliveFameValue";
            this.lAliveFameValue.Size = new System.Drawing.Size(115, 21);
            this.lAliveFameValue.TabIndex = 3;
            this.lAliveFameValue.Text = "{0} alive fame";
            // 
            // mtpAliveFame
            // 
            this.mtpAliveFame.BackColor = System.Drawing.Color.Transparent;
            this.mtpAliveFame.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpAliveFame.Location = new System.Drawing.Point(0, 0);
            this.mtpAliveFame.Margin = new System.Windows.Forms.Padding(2);
            this.mtpAliveFame.Name = "mtpAliveFame";
            this.mtpAliveFame.Size = new System.Drawing.Size(200, 70);
            this.mtpAliveFame.TabIndex = 1;
            // 
            // pBestClass
            // 
            this.pBestClass.Controls.Add(this.toggleBestClassByTotalFame);
            this.pBestClass.Controls.Add(this.lBestToggleT);
            this.pBestClass.Controls.Add(this.lBestToggleB);
            this.pBestClass.Controls.Add(this.lBestLevel);
            this.pBestClass.Controls.Add(this.lBestLevelValue);
            this.pBestClass.Controls.Add(this.lBestFameValue);
            this.pBestClass.Controls.Add(this.lBestFame);
            this.pBestClass.Controls.Add(this.pbBestClassImage);
            this.pBestClass.Controls.Add(this.lBestClass);
            this.pBestClass.Controls.Add(this.lBestClassName);
            this.pBestClass.Controls.Add(this.mtpBestClass);
            this.pBestClass.Location = new System.Drawing.Point(415, 5);
            this.pBestClass.Name = "pBestClass";
            this.pBestClass.Size = new System.Drawing.Size(200, 145);
            this.pBestClass.TabIndex = 21;
            // 
            // toggleBestClassByTotalFame
            // 
            this.toggleBestClassByTotalFame.Animation = 5;
            this.toggleBestClassByTotalFame.AnimationSpeed = 5;
            this.toggleBestClassByTotalFame.BackColor = System.Drawing.Color.Transparent;
            this.toggleBestClassByTotalFame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleBestClassByTotalFame.BackgroundImage")));
            this.toggleBestClassByTotalFame.Checked = true;
            this.toggleBestClassByTotalFame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleBestClassByTotalFame.InnerCirclePadding = 3;
            this.toggleBestClassByTotalFame.Location = new System.Drawing.Point(114, 11);
            this.toggleBestClassByTotalFame.Margin = new System.Windows.Forms.Padding(5);
            this.toggleBestClassByTotalFame.Name = "toggleBestClassByTotalFame";
            this.toggleBestClassByTotalFame.Size = new System.Drawing.Size(42, 18);
            this.toggleBestClassByTotalFame.TabIndex = 27;
            this.toggleBestClassByTotalFame.ThumbMargin = 3;
            toggleState7.BackColor = System.Drawing.Color.DarkGray;
            toggleState7.BackColorInner = System.Drawing.Color.White;
            toggleState7.BorderColor = System.Drawing.Color.DarkGray;
            toggleState7.BorderColorInner = System.Drawing.Color.White;
            toggleState7.BorderRadius = 17;
            toggleState7.BorderRadiusInner = 11;
            toggleState7.BorderThickness = 1;
            toggleState7.BorderThicknessInner = 1;
            this.toggleBestClassByTotalFame.ToggleStateDisabled = toggleState7;
            toggleState8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState8.BackColorInner = System.Drawing.Color.White;
            toggleState8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState8.BorderColorInner = System.Drawing.Color.White;
            toggleState8.BorderRadius = 17;
            toggleState8.BorderRadiusInner = 11;
            toggleState8.BorderThickness = 1;
            toggleState8.BorderThicknessInner = 1;
            this.toggleBestClassByTotalFame.ToggleStateOff = toggleState8;
            toggleState9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState9.BackColorInner = System.Drawing.Color.White;
            toggleState9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState9.BorderColorInner = System.Drawing.Color.White;
            toggleState9.BorderRadius = 17;
            toggleState9.BorderRadiusInner = 11;
            toggleState9.BorderThickness = 1;
            toggleState9.BorderThicknessInner = 1;
            this.toggleBestClassByTotalFame.ToggleStateOn = toggleState9;
            this.toggleBestClassByTotalFame.Value = true;
            this.toggleBestClassByTotalFame.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.toggleBestClassByTotalFame_CheckedChanged);
            // 
            // lBestToggleT
            // 
            this.lBestToggleT.AutoSize = true;
            this.lBestToggleT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestToggleT.Location = new System.Drawing.Point(155, 11);
            this.lBestToggleT.Name = "lBestToggleT";
            this.lBestToggleT.Size = new System.Drawing.Size(37, 17);
            this.lBestToggleT.TabIndex = 28;
            this.lBestToggleT.Text = "Total";
            // 
            // lBestToggleB
            // 
            this.lBestToggleB.AutoSize = true;
            this.lBestToggleB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestToggleB.Location = new System.Drawing.Point(80, 11);
            this.lBestToggleB.Name = "lBestToggleB";
            this.lBestToggleB.Size = new System.Drawing.Size(36, 17);
            this.lBestToggleB.TabIndex = 24;
            this.lBestToggleB.Text = "Base";
            // 
            // lBestLevel
            // 
            this.lBestLevel.AutoSize = true;
            this.lBestLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestLevel.Location = new System.Drawing.Point(86, 97);
            this.lBestLevel.Name = "lBestLevel";
            this.lBestLevel.Size = new System.Drawing.Size(65, 17);
            this.lBestLevel.TabIndex = 25;
            this.lBestLevel.Text = "Best level";
            // 
            // lBestLevelValue
            // 
            this.lBestLevelValue.AutoSize = true;
            this.lBestLevelValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestLevelValue.Location = new System.Drawing.Point(85, 115);
            this.lBestLevelValue.Name = "lBestLevelValue";
            this.lBestLevelValue.Size = new System.Drawing.Size(28, 21);
            this.lBestLevelValue.TabIndex = 26;
            this.lBestLevelValue.Text = "20";
            // 
            // lBestFameValue
            // 
            this.lBestFameValue.AutoSize = true;
            this.lBestFameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestFameValue.Location = new System.Drawing.Point(85, 74);
            this.lBestFameValue.Name = "lBestFameValue";
            this.lBestFameValue.Size = new System.Drawing.Size(73, 21);
            this.lBestFameValue.TabIndex = 24;
            this.lBestFameValue.Text = "9999999";
            // 
            // lBestFame
            // 
            this.lBestFame.AutoSize = true;
            this.lBestFame.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestFame.Location = new System.Drawing.Point(86, 56);
            this.lBestFame.Name = "lBestFame";
            this.lBestFame.Size = new System.Drawing.Size(68, 17);
            this.lBestFame.TabIndex = 23;
            this.lBestFame.Text = "Best fame";
            // 
            // pbBestClassImage
            // 
            this.pbBestClassImage.Location = new System.Drawing.Point(12, 66);
            this.pbBestClassImage.Name = "pbBestClassImage";
            this.pbBestClassImage.Size = new System.Drawing.Size(64, 64);
            this.pbBestClassImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBestClassImage.TabIndex = 22;
            this.pbBestClassImage.TabStop = false;
            // 
            // lBestClass
            // 
            this.lBestClass.AutoSize = true;
            this.lBestClass.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestClass.Location = new System.Drawing.Point(10, 11);
            this.lBestClass.Name = "lBestClass";
            this.lBestClass.Size = new System.Drawing.Size(64, 13);
            this.lBestClass.TabIndex = 2;
            this.lBestClass.Text = "Best class by";
            // 
            // lBestClassName
            // 
            this.lBestClassName.AutoSize = true;
            this.lBestClassName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBestClassName.Location = new System.Drawing.Point(9, 32);
            this.lBestClassName.Name = "lBestClassName";
            this.lBestClassName.Size = new System.Drawing.Size(64, 21);
            this.lBestClassName.TabIndex = 3;
            this.lBestClassName.Text = "Wizard";
            // 
            // mtpBestClass
            // 
            this.mtpBestClass.BackColor = System.Drawing.Color.Transparent;
            this.mtpBestClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpBestClass.Location = new System.Drawing.Point(0, -1);
            this.mtpBestClass.Margin = new System.Windows.Forms.Padding(2);
            this.mtpBestClass.Name = "mtpBestClass";
            this.mtpBestClass.Size = new System.Drawing.Size(200, 145);
            this.mtpBestClass.TabIndex = 1;
            // 
            // pbReturn
            // 
            this.pbReturn.AllowFocused = false;
            this.pbReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReturn.AutoSizeHeight = true;
            this.pbReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.pbReturn.BorderRadius = 25;
            this.pbReturn.Image = global::EAM_Statistics.Properties.Resources.return_36_white;
            this.pbReturn.IsCircle = true;
            this.pbReturn.Location = new System.Drawing.Point(553, 533);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(50, 50);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbReturn.TabIndex = 22;
            this.pbReturn.TabStop = false;
            this.pbReturn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            this.pbReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbReturn_MouseDown);
            this.pbReturn.MouseEnter += new System.EventHandler(this.pbReturn_MouseEnter);
            this.pbReturn.MouseLeave += new System.EventHandler(this.pbReturn_MouseLeave);
            this.pbReturn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbReturn_MouseUp);
            // 
            // mtpRadarChars
            // 
            this.mtpRadarChars.BackColor = System.Drawing.Color.Transparent;
            this.mtpRadarChars.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpRadarChars.Location = new System.Drawing.Point(210, 155);
            this.mtpRadarChars.Margin = new System.Windows.Forms.Padding(2);
            this.mtpRadarChars.Name = "mtpRadarChars";
            this.mtpRadarChars.Size = new System.Drawing.Size(405, 440);
            this.mtpRadarChars.TabIndex = 19;
            // 
            // mtpCharacters
            // 
            this.mtpCharacters.BackColor = System.Drawing.Color.Transparent;
            this.mtpCharacters.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtpCharacters.Location = new System.Drawing.Point(5, 185);
            this.mtpCharacters.Margin = new System.Windows.Forms.Padding(2);
            this.mtpCharacters.Name = "mtpCharacters";
            this.mtpCharacters.Size = new System.Drawing.Size(200, 410);
            this.mtpCharacters.TabIndex = 18;
            // 
            // toggleRadarCharsByTotalFame
            // 
            this.toggleRadarCharsByTotalFame.Animation = 5;
            this.toggleRadarCharsByTotalFame.AnimationSpeed = 5;
            this.toggleRadarCharsByTotalFame.BackColor = System.Drawing.Color.Transparent;
            this.toggleRadarCharsByTotalFame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleRadarCharsByTotalFame.BackgroundImage")));
            this.toggleRadarCharsByTotalFame.Checked = true;
            this.toggleRadarCharsByTotalFame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleRadarCharsByTotalFame.InnerCirclePadding = 3;
            this.toggleRadarCharsByTotalFame.Location = new System.Drawing.Point(529, 167);
            this.toggleRadarCharsByTotalFame.Margin = new System.Windows.Forms.Padding(7);
            this.toggleRadarCharsByTotalFame.Name = "toggleRadarCharsByTotalFame";
            this.toggleRadarCharsByTotalFame.Size = new System.Drawing.Size(42, 18);
            this.toggleRadarCharsByTotalFame.TabIndex = 30;
            this.toggleRadarCharsByTotalFame.ThumbMargin = 3;
            toggleState10.BackColor = System.Drawing.Color.DarkGray;
            toggleState10.BackColorInner = System.Drawing.Color.White;
            toggleState10.BorderColor = System.Drawing.Color.DarkGray;
            toggleState10.BorderColorInner = System.Drawing.Color.White;
            toggleState10.BorderRadius = 17;
            toggleState10.BorderRadiusInner = 11;
            toggleState10.BorderThickness = 1;
            toggleState10.BorderThicknessInner = 1;
            this.toggleRadarCharsByTotalFame.ToggleStateDisabled = toggleState10;
            toggleState11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState11.BackColorInner = System.Drawing.Color.White;
            toggleState11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState11.BorderColorInner = System.Drawing.Color.White;
            toggleState11.BorderRadius = 17;
            toggleState11.BorderRadiusInner = 11;
            toggleState11.BorderThickness = 1;
            toggleState11.BorderThicknessInner = 1;
            this.toggleRadarCharsByTotalFame.ToggleStateOff = toggleState11;
            toggleState12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState12.BackColorInner = System.Drawing.Color.White;
            toggleState12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            toggleState12.BorderColorInner = System.Drawing.Color.White;
            toggleState12.BorderRadius = 17;
            toggleState12.BorderRadiusInner = 11;
            toggleState12.BorderThickness = 1;
            toggleState12.BorderThicknessInner = 1;
            this.toggleRadarCharsByTotalFame.ToggleStateOn = toggleState12;
            this.toggleRadarCharsByTotalFame.Value = true;
            this.toggleRadarCharsByTotalFame.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.toggleRadarCharsByTotalFame_CheckedChanged);
            // 
            // lRadarToggleT
            // 
            this.lRadarToggleT.AutoSize = true;
            this.lRadarToggleT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadarToggleT.Location = new System.Drawing.Point(570, 167);
            this.lRadarToggleT.Name = "lRadarToggleT";
            this.lRadarToggleT.Size = new System.Drawing.Size(37, 17);
            this.lRadarToggleT.TabIndex = 31;
            this.lRadarToggleT.Text = "Total";
            // 
            // lRadarToggleB
            // 
            this.lRadarToggleB.AutoSize = true;
            this.lRadarToggleB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRadarToggleB.Location = new System.Drawing.Point(495, 167);
            this.lRadarToggleB.Name = "lRadarToggleB";
            this.lRadarToggleB.Size = new System.Drawing.Size(36, 17);
            this.lRadarToggleB.TabIndex = 29;
            this.lRadarToggleB.Text = "Base";
            // 
            // lNoChars
            // 
            this.lNoChars.AutoSize = true;
            this.lNoChars.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoChars.Location = new System.Drawing.Point(218, 384);
            this.lNoChars.Name = "lNoChars";
            this.lNoChars.Size = new System.Drawing.Size(390, 20);
            this.lNoChars.TabIndex = 32;
            this.lNoChars.Text = "You need at least data from three different characters!";
            this.lNoChars.Visible = false;
            // 
            // UIAccountViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lNoChars);
            this.Controls.Add(this.toggleRadarCharsByTotalFame);
            this.Controls.Add(this.lRadarToggleT);
            this.Controls.Add(this.lRadarToggleB);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.pBestClass);
            this.Controls.Add(this.pAliveFame);
            this.Controls.Add(this.mtpRadarChars);
            this.Controls.Add(this.mtpCharacters);
            this.Controls.Add(this.pDataActuality);
            this.Controls.Add(this.pTotalFame);
            this.Controls.Add(this.pAccount);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UIAccountViewer";
            this.Size = new System.Drawing.Size(620, 600);
            this.pAccount.ResumeLayout(false);
            this.pAccount.PerformLayout();
            this.pTotalFame.ResumeLayout(false);
            this.pTotalFame.PerformLayout();
            this.pDataActuality.ResumeLayout(false);
            this.pDataActuality.PerformLayout();
            this.pAliveFame.ResumeLayout(false);
            this.pAliveFame.PerformLayout();
            this.pBestClass.ResumeLayout(false);
            this.pBestClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBestClassImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pAccount;
        private System.Windows.Forms.Label lAccountEmail;
        private System.Windows.Forms.Label lAccounts;
        private System.Windows.Forms.Label lAmountName;
        private MaterialPanel mtpAccounts;
        private System.Windows.Forms.Panel pTotalFame;
        private System.Windows.Forms.Label lTotalFame;
        private System.Windows.Forms.Label lTotalFameValue;
        private MaterialPanel mtpTotalFame;
        private System.Windows.Forms.Panel pDataActuality;
        private System.Windows.Forms.Label lTimeOfLastDataset;
        private System.Windows.Forms.Label lDataActuality;
        private System.Windows.Forms.Label lDataActualityValue;
        private MaterialPanel mtpDataActuality;
        private MaterialTopAccount mtpCharacters;
        private MaterialRadarChars mtpRadarChars;
        private System.Windows.Forms.Panel pAliveFame;
        private System.Windows.Forms.Label lAliveFame;
        private System.Windows.Forms.Label lAliveFameValue;
        private MaterialPanel mtpAliveFame;
        private System.Windows.Forms.Panel pBestClass;
        private System.Windows.Forms.Label lBestFameValue;
        private System.Windows.Forms.Label lBestFame;
        private System.Windows.Forms.PictureBox pbBestClassImage;
        private System.Windows.Forms.Label lBestClass;
        private System.Windows.Forms.Label lBestClassName;
        private MaterialPanel mtpBestClass;
        private System.Windows.Forms.Label lBestLevel;
        private System.Windows.Forms.Label lBestLevelValue;
        private Bunifu.UI.WinForms.BunifuPictureBox pbReturn;
        private Bunifu.UI.WinForms.BunifuToggleSwitch toggleBestClassByTotalFame;
        private System.Windows.Forms.Label lBestToggleT;
        private System.Windows.Forms.Label lBestToggleB;
        private Bunifu.UI.WinForms.BunifuToggleSwitch toggleRadarCharsByTotalFame;
        private System.Windows.Forms.Label lRadarToggleT;
        private System.Windows.Forms.Label lRadarToggleB;
        private System.Windows.Forms.Label lNoChars;
    }
}
