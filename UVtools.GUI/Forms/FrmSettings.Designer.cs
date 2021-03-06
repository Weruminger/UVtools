﻿namespace UVtools.GUI.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreviousNextLayerColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnPreviousLayerColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextLayerColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTouchingBoundsColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResinTrapColor = new System.Windows.Forms.Button();
            this.btnResinTrapHLColor = new System.Windows.Forms.Button();
            this.btnIslandColor = new System.Windows.Forms.Button();
            this.btnIslandHLColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCheckForUpdatesOnStartup = new System.Windows.Forms.CheckBox();
            this.cbStartMaximized = new System.Windows.Forms.CheckBox();
            this.cbZoomToFitPrintVolumeBounds = new System.Windows.Forms.CheckBox();
            this.cbOutlineHollowAreas = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nmOutlineHollowAreasLineThickness = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.btnOutlineHollowAreasColor = new System.Windows.Forms.Button();
            this.cbOutlineLayerBounds = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nmOutlineLayerBoundsLineThickness = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOutlineLayerBoundsColor = new System.Windows.Forms.Button();
            this.cbOutlinePrintVolumeBounds = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nmOutlinePrintVolumeBoundsLineThickness = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOutlinePrintVolumeBoundsColor = new System.Windows.Forms.Button();
            this.cbLayerZoomToFit = new System.Windows.Forms.CheckBox();
            this.cbLayerDifferenceDefault = new System.Windows.Forms.CheckBox();
            this.cbLayerAutoRotateBestView = new System.Windows.Forms.CheckBox();
            this.cbComputeIssuesOnLoad = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbComputeIslands = new System.Windows.Forms.CheckBox();
            this.cbComputeResinTraps = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmResinTrapBinaryThreshold = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.nmResinTrapMaximumPixelBrightnessToDrain = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nmResinTrapRequiredBlackPixelsToDrain = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nmResinTrapRequiredAreaToProcessCheck = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIslandAllowDiagonalBonds = new System.Windows.Forms.CheckBox();
            this.nmIslandBinaryThreshold = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nmIslandRequiredPixelBrightnessToSupport = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmIslandRequiredPixelsToSupport = new System.Windows.Forms.NumericUpDown();
            this.nmIslandRequiredAreaToProcessCheck = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmIslandRequiredPixelBrightnessToProcessCheck = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cbComputeTouchingBounds = new System.Windows.Forms.CheckBox();
            this.cbAutoComputeIssuesClickOnTab = new System.Windows.Forms.CheckBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFileExtractDefaultDirectoryClear = new System.Windows.Forms.Button();
            this.btnFileExtractDefaultDirectorySearch = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.tbFileExtractDefaultDirectory = new System.Windows.Forms.TextBox();
            this.btnFileConvertDefaultDirectoryClear = new System.Windows.Forms.Button();
            this.btnFileConvertDefaultDirectorySearch = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.tbFileConvertDefaultDirectory = new System.Windows.Forms.TextBox();
            this.btnFileSaveDefaultDirectoryClear = new System.Windows.Forms.Button();
            this.btnFileSaveDefaultDirectorySearch = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.tbFileSaveDefaultDirectory = new System.Windows.Forms.TextBox();
            this.btnFileOpenDefaultDirectoryClear = new System.Windows.Forms.Button();
            this.btnFileOpenDefaultDirectorySearch = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.tbFileOpenDefaultDirectory = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbDefaultOpenFileExtension = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbFileSavePromptOverwrite = new System.Windows.Forms.CheckBox();
            this.tbFileSaveNameSuffix = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbFileSaveNamePreffix = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbZoomIssuesAuto = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.nmCrosshairLineMargin = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cbCrosshairShowOnlyOnSelectedIssues = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.nmCrosshairLineLength = new System.Windows.Forms.NumericUpDown();
            this.cbCrosshairFadeLevel = new System.Windows.Forms.ComboBox();
            this.cbZoomIssues = new System.Windows.Forms.CheckBox();
            this.cbZoomLockLevel = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbPartialUpdateIslandsOnEditing = new System.Windows.Forms.CheckBox();
            this.btnPixelEditorDrainHoleColor = new System.Windows.Forms.Button();
            this.btnPixelEditorDrainHoleHLColor = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btnPixelEditorSupportColor = new System.Windows.Forms.Button();
            this.btnPixelEditorSupportHLColor = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnPixelEditorRemovePixelColor = new System.Windows.Forms.Button();
            this.btnPixelEditorRemovePixelHLColor = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnPixelEditorAddPixelColor = new System.Windows.Forms.Button();
            this.btnPixelEditorAddPixelHLColor = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.nmLayerRepairDefaultOpeningIterations = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.nmLayerRepairDefaultClosingIterations = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.cbLayerRepairResinTraps = new System.Windows.Forms.CheckBox();
            this.cbLayerRepairRemoveEmptyLayers = new System.Windows.Forms.CheckBox();
            this.cbLayerRepairLayersIslands = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbComputeEmptyLayers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlineHollowAreasLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlineLayerBoundsLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlinePrintVolumeBoundsLineThickness)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapBinaryThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapMaximumPixelBrightnessToDrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapRequiredBlackPixelsToDrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapRequiredAreaToProcessCheck)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandBinaryThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelBrightnessToSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelsToSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredAreaToProcessCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelBrightnessToProcessCheck)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrosshairLineMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrosshairLineLength)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairDefaultOpeningIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairDefaultClosingIterations)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous and next layer color:";
            // 
            // btnPreviousNextLayerColor
            // 
            this.btnPreviousNextLayerColor.BackColor = System.Drawing.Color.White;
            this.btnPreviousNextLayerColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPreviousNextLayerColor.FlatAppearance.BorderSize = 2;
            this.btnPreviousNextLayerColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousNextLayerColor.Location = new System.Drawing.Point(219, 8);
            this.btnPreviousNextLayerColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousNextLayerColor.Name = "btnPreviousNextLayerColor";
            this.btnPreviousNextLayerColor.Size = new System.Drawing.Size(32, 32);
            this.btnPreviousNextLayerColor.TabIndex = 1;
            this.btnPreviousNextLayerColor.UseVisualStyleBackColor = false;
            this.btnPreviousNextLayerColor.Click += new System.EventHandler(this.EventClick);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // btnPreviousLayerColor
            // 
            this.btnPreviousLayerColor.BackColor = System.Drawing.Color.White;
            this.btnPreviousLayerColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPreviousLayerColor.FlatAppearance.BorderSize = 2;
            this.btnPreviousLayerColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousLayerColor.Location = new System.Drawing.Point(219, 48);
            this.btnPreviousLayerColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousLayerColor.Name = "btnPreviousLayerColor";
            this.btnPreviousLayerColor.Size = new System.Drawing.Size(32, 32);
            this.btnPreviousLayerColor.TabIndex = 3;
            this.btnPreviousLayerColor.UseVisualStyleBackColor = false;
            this.btnPreviousLayerColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Previous layer color:";
            // 
            // btnNextLayerColor
            // 
            this.btnNextLayerColor.BackColor = System.Drawing.Color.White;
            this.btnNextLayerColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNextLayerColor.FlatAppearance.BorderSize = 2;
            this.btnNextLayerColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLayerColor.Location = new System.Drawing.Point(219, 88);
            this.btnNextLayerColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextLayerColor.Name = "btnNextLayerColor";
            this.btnNextLayerColor.Size = new System.Drawing.Size(32, 32);
            this.btnNextLayerColor.TabIndex = 5;
            this.btnNextLayerColor.UseVisualStyleBackColor = false;
            this.btnNextLayerColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Next layer color:";
            // 
            // btnTouchingBoundsColor
            // 
            this.btnTouchingBoundsColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTouchingBoundsColor.BackColor = System.Drawing.Color.White;
            this.btnTouchingBoundsColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTouchingBoundsColor.FlatAppearance.BorderSize = 2;
            this.btnTouchingBoundsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTouchingBoundsColor.Location = new System.Drawing.Point(536, 88);
            this.btnTouchingBoundsColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnTouchingBoundsColor.Name = "btnTouchingBoundsColor";
            this.btnTouchingBoundsColor.Size = new System.Drawing.Size(32, 32);
            this.btnTouchingBoundsColor.TabIndex = 7;
            this.btnTouchingBoundsColor.UseVisualStyleBackColor = false;
            this.btnTouchingBoundsColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Island color / Highlight color:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resin trap color / Highlight color:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Touching bound color:";
            // 
            // btnResinTrapColor
            // 
            this.btnResinTrapColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResinTrapColor.BackColor = System.Drawing.Color.White;
            this.btnResinTrapColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResinTrapColor.FlatAppearance.BorderSize = 2;
            this.btnResinTrapColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResinTrapColor.Location = new System.Drawing.Point(536, 48);
            this.btnResinTrapColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnResinTrapColor.Name = "btnResinTrapColor";
            this.btnResinTrapColor.Size = new System.Drawing.Size(32, 32);
            this.btnResinTrapColor.TabIndex = 10;
            this.btnResinTrapColor.UseVisualStyleBackColor = false;
            this.btnResinTrapColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnResinTrapHLColor
            // 
            this.btnResinTrapHLColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResinTrapHLColor.BackColor = System.Drawing.Color.White;
            this.btnResinTrapHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResinTrapHLColor.FlatAppearance.BorderSize = 2;
            this.btnResinTrapHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResinTrapHLColor.Location = new System.Drawing.Point(576, 48);
            this.btnResinTrapHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnResinTrapHLColor.Name = "btnResinTrapHLColor";
            this.btnResinTrapHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnResinTrapHLColor.TabIndex = 10;
            this.btnResinTrapHLColor.UseVisualStyleBackColor = false;
            this.btnResinTrapHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnIslandColor
            // 
            this.btnIslandColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslandColor.BackColor = System.Drawing.Color.White;
            this.btnIslandColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIslandColor.FlatAppearance.BorderSize = 2;
            this.btnIslandColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslandColor.Location = new System.Drawing.Point(536, 8);
            this.btnIslandColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnIslandColor.Name = "btnIslandColor";
            this.btnIslandColor.Size = new System.Drawing.Size(32, 32);
            this.btnIslandColor.TabIndex = 11;
            this.btnIslandColor.UseVisualStyleBackColor = false;
            this.btnIslandColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnIslandHLColor
            // 
            this.btnIslandHLColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslandHLColor.BackColor = System.Drawing.Color.White;
            this.btnIslandHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIslandHLColor.FlatAppearance.BorderSize = 2;
            this.btnIslandHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslandHLColor.Location = new System.Drawing.Point(576, 8);
            this.btnIslandHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnIslandHLColor.Name = "btnIslandHLColor";
            this.btnIslandHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnIslandHLColor.TabIndex = 11;
            this.btnIslandHLColor.UseVisualStyleBackColor = false;
            this.btnIslandHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::UVtools.GUI.Properties.Resources.Ok_24x24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(303, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.EventClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::UVtools.GUI.Properties.Resources.Cancel_24x24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 48);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbCheckForUpdatesOnStartup
            // 
            this.cbCheckForUpdatesOnStartup.AutoSize = true;
            this.cbCheckForUpdatesOnStartup.Location = new System.Drawing.Point(6, 51);
            this.cbCheckForUpdatesOnStartup.Name = "cbCheckForUpdatesOnStartup";
            this.cbCheckForUpdatesOnStartup.Size = new System.Drawing.Size(218, 22);
            this.cbCheckForUpdatesOnStartup.TabIndex = 7;
            this.cbCheckForUpdatesOnStartup.Text = "Check for updates on startup";
            this.cbCheckForUpdatesOnStartup.UseVisualStyleBackColor = true;
            // 
            // cbStartMaximized
            // 
            this.cbStartMaximized.AutoSize = true;
            this.cbStartMaximized.Location = new System.Drawing.Point(6, 23);
            this.cbStartMaximized.Name = "cbStartMaximized";
            this.cbStartMaximized.Size = new System.Drawing.Size(133, 22);
            this.cbStartMaximized.TabIndex = 6;
            this.cbStartMaximized.Text = "Start maximized";
            this.cbStartMaximized.UseVisualStyleBackColor = true;
            // 
            // cbZoomToFitPrintVolumeBounds
            // 
            this.cbZoomToFitPrintVolumeBounds.AutoSize = true;
            this.cbZoomToFitPrintVolumeBounds.Location = new System.Drawing.Point(336, 277);
            this.cbZoomToFitPrintVolumeBounds.Name = "cbZoomToFitPrintVolumeBounds";
            this.cbZoomToFitPrintVolumeBounds.Size = new System.Drawing.Size(272, 22);
            this.cbZoomToFitPrintVolumeBounds.TabIndex = 34;
            this.cbZoomToFitPrintVolumeBounds.Text = "Zoom to print volume bounds instead";
            this.cbZoomToFitPrintVolumeBounds.UseVisualStyleBackColor = true;
            // 
            // cbOutlineHollowAreas
            // 
            this.cbOutlineHollowAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutlineHollowAreas.AutoSize = true;
            this.cbOutlineHollowAreas.Location = new System.Drawing.Point(477, 213);
            this.cbOutlineHollowAreas.Name = "cbOutlineHollowAreas";
            this.cbOutlineHollowAreas.Size = new System.Drawing.Size(131, 22);
            this.cbOutlineHollowAreas.TabIndex = 33;
            this.cbOutlineHollowAreas.Text = "Show by default";
            this.cbOutlineHollowAreas.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(321, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 18);
            this.label18.TabIndex = 32;
            this.label18.Text = "Line thickness (-1-50)";
            // 
            // nmOutlineHollowAreasLineThickness
            // 
            this.nmOutlineHollowAreasLineThickness.Location = new System.Drawing.Point(258, 212);
            this.nmOutlineHollowAreasLineThickness.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmOutlineHollowAreasLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmOutlineHollowAreasLineThickness.Name = "nmOutlineHollowAreasLineThickness";
            this.nmOutlineHollowAreasLineThickness.Size = new System.Drawing.Size(57, 24);
            this.nmOutlineHollowAreasLineThickness.TabIndex = 31;
            this.nmOutlineHollowAreasLineThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 215);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 18);
            this.label19.TabIndex = 29;
            this.label19.Text = "Outline Hollow areas color:";
            // 
            // btnOutlineHollowAreasColor
            // 
            this.btnOutlineHollowAreasColor.BackColor = System.Drawing.Color.White;
            this.btnOutlineHollowAreasColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOutlineHollowAreasColor.FlatAppearance.BorderSize = 2;
            this.btnOutlineHollowAreasColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlineHollowAreasColor.Location = new System.Drawing.Point(219, 208);
            this.btnOutlineHollowAreasColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutlineHollowAreasColor.Name = "btnOutlineHollowAreasColor";
            this.btnOutlineHollowAreasColor.Size = new System.Drawing.Size(32, 32);
            this.btnOutlineHollowAreasColor.TabIndex = 30;
            this.btnOutlineHollowAreasColor.UseVisualStyleBackColor = false;
            this.btnOutlineHollowAreasColor.Click += new System.EventHandler(this.EventClick);
            // 
            // cbOutlineLayerBounds
            // 
            this.cbOutlineLayerBounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutlineLayerBounds.AutoSize = true;
            this.cbOutlineLayerBounds.Location = new System.Drawing.Point(477, 173);
            this.cbOutlineLayerBounds.Name = "cbOutlineLayerBounds";
            this.cbOutlineLayerBounds.Size = new System.Drawing.Size(131, 22);
            this.cbOutlineLayerBounds.TabIndex = 28;
            this.cbOutlineLayerBounds.Text = "Show by default";
            this.cbOutlineLayerBounds.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(321, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "Line thickness (1-50)";
            // 
            // nmOutlineLayerBoundsLineThickness
            // 
            this.nmOutlineLayerBoundsLineThickness.Location = new System.Drawing.Point(258, 172);
            this.nmOutlineLayerBoundsLineThickness.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmOutlineLayerBoundsLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmOutlineLayerBoundsLineThickness.Name = "nmOutlineLayerBoundsLineThickness";
            this.nmOutlineLayerBoundsLineThickness.Size = new System.Drawing.Size(57, 24);
            this.nmOutlineLayerBoundsLineThickness.TabIndex = 26;
            this.nmOutlineLayerBoundsLineThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 175);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 18);
            this.label17.TabIndex = 24;
            this.label17.Text = "Outline Layer bounds color:";
            // 
            // btnOutlineLayerBoundsColor
            // 
            this.btnOutlineLayerBoundsColor.BackColor = System.Drawing.Color.White;
            this.btnOutlineLayerBoundsColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOutlineLayerBoundsColor.FlatAppearance.BorderSize = 2;
            this.btnOutlineLayerBoundsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlineLayerBoundsColor.Location = new System.Drawing.Point(219, 168);
            this.btnOutlineLayerBoundsColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutlineLayerBoundsColor.Name = "btnOutlineLayerBoundsColor";
            this.btnOutlineLayerBoundsColor.Size = new System.Drawing.Size(32, 32);
            this.btnOutlineLayerBoundsColor.TabIndex = 25;
            this.btnOutlineLayerBoundsColor.UseVisualStyleBackColor = false;
            this.btnOutlineLayerBoundsColor.Click += new System.EventHandler(this.EventClick);
            // 
            // cbOutlinePrintVolumeBounds
            // 
            this.cbOutlinePrintVolumeBounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutlinePrintVolumeBounds.AutoSize = true;
            this.cbOutlinePrintVolumeBounds.Location = new System.Drawing.Point(477, 133);
            this.cbOutlinePrintVolumeBounds.Name = "cbOutlinePrintVolumeBounds";
            this.cbOutlinePrintVolumeBounds.Size = new System.Drawing.Size(131, 22);
            this.cbOutlinePrintVolumeBounds.TabIndex = 23;
            this.cbOutlinePrintVolumeBounds.Text = "Show by default";
            this.cbOutlinePrintVolumeBounds.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Line thickness (1-50)";
            // 
            // nmOutlinePrintVolumeBoundsLineThickness
            // 
            this.nmOutlinePrintVolumeBoundsLineThickness.Location = new System.Drawing.Point(258, 132);
            this.nmOutlinePrintVolumeBoundsLineThickness.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmOutlinePrintVolumeBoundsLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmOutlinePrintVolumeBoundsLineThickness.Name = "nmOutlinePrintVolumeBoundsLineThickness";
            this.nmOutlinePrintVolumeBoundsLineThickness.Size = new System.Drawing.Size(57, 24);
            this.nmOutlinePrintVolumeBoundsLineThickness.TabIndex = 19;
            this.nmOutlinePrintVolumeBoundsLineThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 18);
            this.label14.TabIndex = 16;
            this.label14.Text = "Print volume bounds color:";
            // 
            // btnOutlinePrintVolumeBoundsColor
            // 
            this.btnOutlinePrintVolumeBoundsColor.BackColor = System.Drawing.Color.White;
            this.btnOutlinePrintVolumeBoundsColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOutlinePrintVolumeBoundsColor.FlatAppearance.BorderSize = 2;
            this.btnOutlinePrintVolumeBoundsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlinePrintVolumeBoundsColor.Location = new System.Drawing.Point(219, 128);
            this.btnOutlinePrintVolumeBoundsColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutlinePrintVolumeBoundsColor.Name = "btnOutlinePrintVolumeBoundsColor";
            this.btnOutlinePrintVolumeBoundsColor.Size = new System.Drawing.Size(32, 32);
            this.btnOutlinePrintVolumeBoundsColor.TabIndex = 17;
            this.btnOutlinePrintVolumeBoundsColor.UseVisualStyleBackColor = false;
            this.btnOutlinePrintVolumeBoundsColor.Click += new System.EventHandler(this.EventClick);
            // 
            // cbLayerZoomToFit
            // 
            this.cbLayerZoomToFit.AutoSize = true;
            this.cbLayerZoomToFit.Location = new System.Drawing.Point(11, 277);
            this.cbLayerZoomToFit.Name = "cbLayerZoomToFit";
            this.cbLayerZoomToFit.Size = new System.Drawing.Size(313, 22);
            this.cbLayerZoomToFit.TabIndex = 15;
            this.cbLayerZoomToFit.Text = "Zoom to fit layer on load and window resize";
            this.cbLayerZoomToFit.UseVisualStyleBackColor = true;
            // 
            // cbLayerDifferenceDefault
            // 
            this.cbLayerDifferenceDefault.AutoSize = true;
            this.cbLayerDifferenceDefault.Location = new System.Drawing.Point(11, 333);
            this.cbLayerDifferenceDefault.Name = "cbLayerDifferenceDefault";
            this.cbLayerDifferenceDefault.Size = new System.Drawing.Size(234, 22);
            this.cbLayerDifferenceDefault.TabIndex = 13;
            this.cbLayerDifferenceDefault.Text = "Show layer difference by default";
            this.cbLayerDifferenceDefault.UseVisualStyleBackColor = true;
            // 
            // cbLayerAutoRotateBestView
            // 
            this.cbLayerAutoRotateBestView.AutoSize = true;
            this.cbLayerAutoRotateBestView.Location = new System.Drawing.Point(11, 249);
            this.cbLayerAutoRotateBestView.Name = "cbLayerAutoRotateBestView";
            this.cbLayerAutoRotateBestView.Size = new System.Drawing.Size(327, 22);
            this.cbLayerAutoRotateBestView.TabIndex = 12;
            this.cbLayerAutoRotateBestView.Text = "Auto rotate layer to best fit window on file load";
            this.cbLayerAutoRotateBestView.UseVisualStyleBackColor = true;
            // 
            // cbComputeIssuesOnLoad
            // 
            this.cbComputeIssuesOnLoad.AutoSize = true;
            this.cbComputeIssuesOnLoad.Location = new System.Drawing.Point(6, 23);
            this.cbComputeIssuesOnLoad.Name = "cbComputeIssuesOnLoad";
            this.cbComputeIssuesOnLoad.Size = new System.Drawing.Size(210, 22);
            this.cbComputeIssuesOnLoad.TabIndex = 14;
            this.cbComputeIssuesOnLoad.Text = "Compute issues on file load";
            this.cbComputeIssuesOnLoad.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Image = global::UVtools.GUI.Properties.Resources.Rotate_16x16;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(13, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 48);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "&Reset all settings";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.EventClick);
            // 
            // cbComputeIslands
            // 
            this.cbComputeIslands.AutoSize = true;
            this.cbComputeIslands.Location = new System.Drawing.Point(85, 79);
            this.cbComputeIslands.Name = "cbComputeIslands";
            this.cbComputeIslands.Size = new System.Drawing.Size(73, 22);
            this.cbComputeIslands.TabIndex = 16;
            this.cbComputeIslands.Text = "Islands";
            this.cbComputeIslands.UseVisualStyleBackColor = true;
            // 
            // cbComputeResinTraps
            // 
            this.cbComputeResinTraps.AutoSize = true;
            this.cbComputeResinTraps.Location = new System.Drawing.Point(164, 79);
            this.cbComputeResinTraps.Name = "cbComputeResinTraps";
            this.cbComputeResinTraps.Size = new System.Drawing.Size(102, 22);
            this.cbComputeResinTraps.TabIndex = 17;
            this.cbComputeResinTraps.Text = "Resin traps";
            this.cbComputeResinTraps.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmResinTrapBinaryThreshold);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.nmResinTrapMaximumPixelBrightnessToDrain);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.nmResinTrapRequiredBlackPixelsToDrain);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.nmResinTrapRequiredAreaToProcessCheck);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 152);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resin Traps";
            // 
            // nmResinTrapBinaryThreshold
            // 
            this.nmResinTrapBinaryThreshold.Location = new System.Drawing.Point(10, 23);
            this.nmResinTrapBinaryThreshold.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nmResinTrapBinaryThreshold.Name = "nmResinTrapBinaryThreshold";
            this.nmResinTrapBinaryThreshold.Size = new System.Drawing.Size(57, 24);
            this.nmResinTrapBinaryThreshold.TabIndex = 26;
            this.nmResinTrapBinaryThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(512, 18);
            this.label20.TabIndex = 27;
            this.label20.Text = "Pixels below this value will turn black, otherwise white. Value=0 to disable this" +
    "";
            // 
            // nmResinTrapMaximumPixelBrightnessToDrain
            // 
            this.nmResinTrapMaximumPixelBrightnessToDrain.Location = new System.Drawing.Point(10, 113);
            this.nmResinTrapMaximumPixelBrightnessToDrain.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nmResinTrapMaximumPixelBrightnessToDrain.Name = "nmResinTrapMaximumPixelBrightnessToDrain";
            this.nmResinTrapMaximumPixelBrightnessToDrain.Size = new System.Drawing.Size(57, 24);
            this.nmResinTrapMaximumPixelBrightnessToDrain.TabIndex = 24;
            this.nmResinTrapMaximumPixelBrightnessToDrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(347, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Maximum pixel brightness to be a drain pixel (0-150)";
            // 
            // nmResinTrapRequiredBlackPixelsToDrain
            // 
            this.nmResinTrapRequiredBlackPixelsToDrain.Location = new System.Drawing.Point(10, 83);
            this.nmResinTrapRequiredBlackPixelsToDrain.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmResinTrapRequiredBlackPixelsToDrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmResinTrapRequiredBlackPixelsToDrain.Name = "nmResinTrapRequiredBlackPixelsToDrain";
            this.nmResinTrapRequiredBlackPixelsToDrain.Size = new System.Drawing.Size(57, 24);
            this.nmResinTrapRequiredBlackPixelsToDrain.TabIndex = 22;
            this.nmResinTrapRequiredBlackPixelsToDrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(441, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Number of drain pixels required to promote area as a drain (1-255)";
            // 
            // nmResinTrapRequiredAreaToProcessCheck
            // 
            this.nmResinTrapRequiredAreaToProcessCheck.Location = new System.Drawing.Point(10, 53);
            this.nmResinTrapRequiredAreaToProcessCheck.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmResinTrapRequiredAreaToProcessCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmResinTrapRequiredAreaToProcessCheck.Name = "nmResinTrapRequiredAreaToProcessCheck";
            this.nmResinTrapRequiredAreaToProcessCheck.Size = new System.Drawing.Size(57, 24);
            this.nmResinTrapRequiredAreaToProcessCheck.TabIndex = 20;
            this.nmResinTrapRequiredAreaToProcessCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(504, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Required pixel bound area (x*y) to process and consider a resin trap (1-255)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIslandAllowDiagonalBonds);
            this.groupBox2.Controls.Add(this.nmIslandBinaryThreshold);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nmIslandRequiredPixelBrightnessToSupport);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nmIslandRequiredPixelsToSupport);
            this.groupBox2.Controls.Add(this.nmIslandRequiredAreaToProcessCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nmIslandRequiredPixelBrightnessToProcessCheck);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 214);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Islands";
            // 
            // cbIslandAllowDiagonalBonds
            // 
            this.cbIslandAllowDiagonalBonds.AutoSize = true;
            this.cbIslandAllowDiagonalBonds.Location = new System.Drawing.Point(10, 23);
            this.cbIslandAllowDiagonalBonds.Name = "cbIslandAllowDiagonalBonds";
            this.cbIslandAllowDiagonalBonds.Size = new System.Drawing.Size(166, 22);
            this.cbIslandAllowDiagonalBonds.TabIndex = 30;
            this.cbIslandAllowDiagonalBonds.Text = "Allow diagonal bonds";
            this.toolTip.SetToolTip(this.cbIslandAllowDiagonalBonds, resources.GetString("cbIslandAllowDiagonalBonds.ToolTip"));
            this.cbIslandAllowDiagonalBonds.UseVisualStyleBackColor = true;
            // 
            // nmIslandBinaryThreshold
            // 
            this.nmIslandBinaryThreshold.Location = new System.Drawing.Point(10, 51);
            this.nmIslandBinaryThreshold.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nmIslandBinaryThreshold.Name = "nmIslandBinaryThreshold";
            this.nmIslandBinaryThreshold.Size = new System.Drawing.Size(57, 24);
            this.nmIslandBinaryThreshold.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(512, 18);
            this.label21.TabIndex = 29;
            this.label21.Text = "Pixels below this value will turn black, otherwise white. Value=0 to disable this" +
    "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(507, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Minimum pixel brightness bellow island to consider it as a safe pixel (50-255)";
            // 
            // nmIslandRequiredPixelBrightnessToSupport
            // 
            this.nmIslandRequiredPixelBrightnessToSupport.Location = new System.Drawing.Point(10, 171);
            this.nmIslandRequiredPixelBrightnessToSupport.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmIslandRequiredPixelBrightnessToSupport.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmIslandRequiredPixelBrightnessToSupport.Name = "nmIslandRequiredPixelBrightnessToSupport";
            this.nmIslandRequiredPixelBrightnessToSupport.Size = new System.Drawing.Size(57, 24);
            this.nmIslandRequiredPixelBrightnessToSupport.TabIndex = 24;
            this.nmIslandRequiredPixelBrightnessToSupport.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Required safe pixels bellow the island to demote it (1-255)";
            // 
            // nmIslandRequiredPixelsToSupport
            // 
            this.nmIslandRequiredPixelsToSupport.Location = new System.Drawing.Point(10, 141);
            this.nmIslandRequiredPixelsToSupport.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmIslandRequiredPixelsToSupport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmIslandRequiredPixelsToSupport.Name = "nmIslandRequiredPixelsToSupport";
            this.nmIslandRequiredPixelsToSupport.Size = new System.Drawing.Size(57, 24);
            this.nmIslandRequiredPixelsToSupport.TabIndex = 22;
            this.nmIslandRequiredPixelsToSupport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmIslandRequiredAreaToProcessCheck
            // 
            this.nmIslandRequiredAreaToProcessCheck.Location = new System.Drawing.Point(10, 81);
            this.nmIslandRequiredAreaToProcessCheck.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmIslandRequiredAreaToProcessCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmIslandRequiredAreaToProcessCheck.Name = "nmIslandRequiredAreaToProcessCheck";
            this.nmIslandRequiredAreaToProcessCheck.Size = new System.Drawing.Size(57, 24);
            this.nmIslandRequiredAreaToProcessCheck.TabIndex = 18;
            this.nmIslandRequiredAreaToProcessCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Required pixel bound area (x*y) to process and consider a island (1-255)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Minimum pixel brightness to consider that pixel on a island (1-255)";
            // 
            // nmIslandRequiredPixelBrightnessToProcessCheck
            // 
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Location = new System.Drawing.Point(10, 111);
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Name = "nmIslandRequiredPixelBrightnessToProcessCheck";
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Size = new System.Drawing.Size(57, 24);
            this.nmIslandRequiredPixelBrightnessToProcessCheck.TabIndex = 20;
            this.nmIslandRequiredPixelBrightnessToProcessCheck.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbComputeEmptyLayers);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.cbComputeTouchingBounds);
            this.groupBox1.Controls.Add(this.cbAutoComputeIssuesClickOnTab);
            this.groupBox1.Controls.Add(this.cbComputeIssuesOnLoad);
            this.groupBox1.Controls.Add(this.cbComputeIslands);
            this.groupBox1.Controls.Add(this.cbComputeResinTraps);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 111);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commun";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 81);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 18);
            this.label42.TabIndex = 20;
            this.label42.Text = "Compute:";
            // 
            // cbComputeTouchingBounds
            // 
            this.cbComputeTouchingBounds.AutoSize = true;
            this.cbComputeTouchingBounds.Location = new System.Drawing.Point(272, 79);
            this.cbComputeTouchingBounds.Name = "cbComputeTouchingBounds";
            this.cbComputeTouchingBounds.Size = new System.Drawing.Size(141, 22);
            this.cbComputeTouchingBounds.TabIndex = 19;
            this.cbComputeTouchingBounds.Text = "Touching bounds";
            this.cbComputeTouchingBounds.UseVisualStyleBackColor = true;
            // 
            // cbAutoComputeIssuesClickOnTab
            // 
            this.cbAutoComputeIssuesClickOnTab.AutoSize = true;
            this.cbAutoComputeIssuesClickOnTab.Location = new System.Drawing.Point(6, 51);
            this.cbAutoComputeIssuesClickOnTab.Name = "cbAutoComputeIssuesClickOnTab";
            this.cbAutoComputeIssuesClickOnTab.Size = new System.Drawing.Size(416, 22);
            this.cbAutoComputeIssuesClickOnTab.TabIndex = 18;
            this.cbAutoComputeIssuesClickOnTab.Text = "Auto compute issues when click Issues tab for the first time";
            this.cbAutoComputeIssuesClickOnTab.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Controls.Add(this.tabPage2);
            this.tabSettings.Controls.Add(this.tabPage3);
            this.tabSettings.Controls.Add(this.tabPage4);
            this.tabSettings.Controls.Add(this.tabPage5);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(624, 625);
            this.tabSettings.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFileExtractDefaultDirectoryClear);
            this.groupBox5.Controls.Add(this.btnFileExtractDefaultDirectorySearch);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.tbFileExtractDefaultDirectory);
            this.groupBox5.Controls.Add(this.btnFileConvertDefaultDirectoryClear);
            this.groupBox5.Controls.Add(this.btnFileConvertDefaultDirectorySearch);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.tbFileConvertDefaultDirectory);
            this.groupBox5.Controls.Add(this.btnFileSaveDefaultDirectoryClear);
            this.groupBox5.Controls.Add(this.btnFileSaveDefaultDirectorySearch);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.tbFileSaveDefaultDirectory);
            this.groupBox5.Controls.Add(this.btnFileOpenDefaultDirectoryClear);
            this.groupBox5.Controls.Add(this.btnFileOpenDefaultDirectorySearch);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.tbFileOpenDefaultDirectory);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.cbDefaultOpenFileExtension);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.cbFileSavePromptOverwrite);
            this.groupBox5.Controls.Add(this.tbFileSaveNameSuffix);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.tbFileSaveNamePreffix);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(610, 250);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File operations";
            // 
            // btnFileExtractDefaultDirectoryClear
            // 
            this.btnFileExtractDefaultDirectoryClear.Image = global::UVtools.GUI.Properties.Resources.delete_16x16;
            this.btnFileExtractDefaultDirectoryClear.Location = new System.Drawing.Point(574, 115);
            this.btnFileExtractDefaultDirectoryClear.Name = "btnFileExtractDefaultDirectoryClear";
            this.btnFileExtractDefaultDirectoryClear.Size = new System.Drawing.Size(30, 24);
            this.btnFileExtractDefaultDirectoryClear.TabIndex = 30;
            this.btnFileExtractDefaultDirectoryClear.UseVisualStyleBackColor = true;
            this.btnFileExtractDefaultDirectoryClear.Click += new System.EventHandler(this.EventClick);
            // 
            // btnFileExtractDefaultDirectorySearch
            // 
            this.btnFileExtractDefaultDirectorySearch.Image = global::UVtools.GUI.Properties.Resources.Open_16x16;
            this.btnFileExtractDefaultDirectorySearch.Location = new System.Drawing.Point(538, 115);
            this.btnFileExtractDefaultDirectorySearch.Name = "btnFileExtractDefaultDirectorySearch";
            this.btnFileExtractDefaultDirectorySearch.Size = new System.Drawing.Size(30, 24);
            this.btnFileExtractDefaultDirectorySearch.TabIndex = 29;
            this.btnFileExtractDefaultDirectorySearch.UseVisualStyleBackColor = true;
            this.btnFileExtractDefaultDirectorySearch.Click += new System.EventHandler(this.EventClick);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 118);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(191, 18);
            this.label32.TabIndex = 28;
            this.label32.Text = "File extract default directory:";
            // 
            // tbFileExtractDefaultDirectory
            // 
            this.tbFileExtractDefaultDirectory.Location = new System.Drawing.Point(225, 115);
            this.tbFileExtractDefaultDirectory.Name = "tbFileExtractDefaultDirectory";
            this.tbFileExtractDefaultDirectory.ReadOnly = true;
            this.tbFileExtractDefaultDirectory.Size = new System.Drawing.Size(307, 24);
            this.tbFileExtractDefaultDirectory.TabIndex = 27;
            // 
            // btnFileConvertDefaultDirectoryClear
            // 
            this.btnFileConvertDefaultDirectoryClear.Image = global::UVtools.GUI.Properties.Resources.delete_16x16;
            this.btnFileConvertDefaultDirectoryClear.Location = new System.Drawing.Point(574, 145);
            this.btnFileConvertDefaultDirectoryClear.Name = "btnFileConvertDefaultDirectoryClear";
            this.btnFileConvertDefaultDirectoryClear.Size = new System.Drawing.Size(30, 24);
            this.btnFileConvertDefaultDirectoryClear.TabIndex = 26;
            this.btnFileConvertDefaultDirectoryClear.UseVisualStyleBackColor = true;
            this.btnFileConvertDefaultDirectoryClear.Click += new System.EventHandler(this.EventClick);
            // 
            // btnFileConvertDefaultDirectorySearch
            // 
            this.btnFileConvertDefaultDirectorySearch.Image = global::UVtools.GUI.Properties.Resources.Open_16x16;
            this.btnFileConvertDefaultDirectorySearch.Location = new System.Drawing.Point(538, 145);
            this.btnFileConvertDefaultDirectorySearch.Name = "btnFileConvertDefaultDirectorySearch";
            this.btnFileConvertDefaultDirectorySearch.Size = new System.Drawing.Size(30, 24);
            this.btnFileConvertDefaultDirectorySearch.TabIndex = 25;
            this.btnFileConvertDefaultDirectorySearch.UseVisualStyleBackColor = true;
            this.btnFileConvertDefaultDirectorySearch.Click += new System.EventHandler(this.EventClick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 148);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(196, 18);
            this.label31.TabIndex = 24;
            this.label31.Text = "File convert default directory:";
            // 
            // tbFileConvertDefaultDirectory
            // 
            this.tbFileConvertDefaultDirectory.Location = new System.Drawing.Point(225, 145);
            this.tbFileConvertDefaultDirectory.Name = "tbFileConvertDefaultDirectory";
            this.tbFileConvertDefaultDirectory.ReadOnly = true;
            this.tbFileConvertDefaultDirectory.Size = new System.Drawing.Size(307, 24);
            this.tbFileConvertDefaultDirectory.TabIndex = 23;
            // 
            // btnFileSaveDefaultDirectoryClear
            // 
            this.btnFileSaveDefaultDirectoryClear.Image = global::UVtools.GUI.Properties.Resources.delete_16x16;
            this.btnFileSaveDefaultDirectoryClear.Location = new System.Drawing.Point(574, 85);
            this.btnFileSaveDefaultDirectoryClear.Name = "btnFileSaveDefaultDirectoryClear";
            this.btnFileSaveDefaultDirectoryClear.Size = new System.Drawing.Size(30, 24);
            this.btnFileSaveDefaultDirectoryClear.TabIndex = 22;
            this.btnFileSaveDefaultDirectoryClear.UseVisualStyleBackColor = true;
            this.btnFileSaveDefaultDirectoryClear.Click += new System.EventHandler(this.EventClick);
            // 
            // btnFileSaveDefaultDirectorySearch
            // 
            this.btnFileSaveDefaultDirectorySearch.Image = global::UVtools.GUI.Properties.Resources.Open_16x16;
            this.btnFileSaveDefaultDirectorySearch.Location = new System.Drawing.Point(538, 85);
            this.btnFileSaveDefaultDirectorySearch.Name = "btnFileSaveDefaultDirectorySearch";
            this.btnFileSaveDefaultDirectorySearch.Size = new System.Drawing.Size(30, 24);
            this.btnFileSaveDefaultDirectorySearch.TabIndex = 21;
            this.btnFileSaveDefaultDirectorySearch.UseVisualStyleBackColor = true;
            this.btnFileSaveDefaultDirectorySearch.Click += new System.EventHandler(this.EventClick);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(198, 18);
            this.label30.TabIndex = 20;
            this.label30.Text = "File save as default directory:";
            // 
            // tbFileSaveDefaultDirectory
            // 
            this.tbFileSaveDefaultDirectory.Location = new System.Drawing.Point(225, 85);
            this.tbFileSaveDefaultDirectory.Name = "tbFileSaveDefaultDirectory";
            this.tbFileSaveDefaultDirectory.ReadOnly = true;
            this.tbFileSaveDefaultDirectory.Size = new System.Drawing.Size(307, 24);
            this.tbFileSaveDefaultDirectory.TabIndex = 19;
            // 
            // btnFileOpenDefaultDirectoryClear
            // 
            this.btnFileOpenDefaultDirectoryClear.Image = global::UVtools.GUI.Properties.Resources.delete_16x16;
            this.btnFileOpenDefaultDirectoryClear.Location = new System.Drawing.Point(574, 55);
            this.btnFileOpenDefaultDirectoryClear.Name = "btnFileOpenDefaultDirectoryClear";
            this.btnFileOpenDefaultDirectoryClear.Size = new System.Drawing.Size(30, 24);
            this.btnFileOpenDefaultDirectoryClear.TabIndex = 18;
            this.btnFileOpenDefaultDirectoryClear.UseVisualStyleBackColor = true;
            this.btnFileOpenDefaultDirectoryClear.Click += new System.EventHandler(this.EventClick);
            // 
            // btnFileOpenDefaultDirectorySearch
            // 
            this.btnFileOpenDefaultDirectorySearch.Image = global::UVtools.GUI.Properties.Resources.Open_16x16;
            this.btnFileOpenDefaultDirectorySearch.Location = new System.Drawing.Point(538, 55);
            this.btnFileOpenDefaultDirectorySearch.Name = "btnFileOpenDefaultDirectorySearch";
            this.btnFileOpenDefaultDirectorySearch.Size = new System.Drawing.Size(30, 24);
            this.btnFileOpenDefaultDirectorySearch.TabIndex = 17;
            this.btnFileOpenDefaultDirectorySearch.UseVisualStyleBackColor = true;
            this.btnFileOpenDefaultDirectorySearch.Click += new System.EventHandler(this.EventClick);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(180, 18);
            this.label29.TabIndex = 16;
            this.label29.Text = "File open default directory:";
            // 
            // tbFileOpenDefaultDirectory
            // 
            this.tbFileOpenDefaultDirectory.Location = new System.Drawing.Point(225, 55);
            this.tbFileOpenDefaultDirectory.Name = "tbFileOpenDefaultDirectory";
            this.tbFileOpenDefaultDirectory.ReadOnly = true;
            this.tbFileOpenDefaultDirectory.Size = new System.Drawing.Size(307, 24);
            this.tbFileOpenDefaultDirectory.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(214, 18);
            this.label22.TabIndex = 9;
            this.label22.Text = "File load default view extension:";
            // 
            // cbDefaultOpenFileExtension
            // 
            this.cbDefaultOpenFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefaultOpenFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefaultOpenFileExtension.FormattingEnabled = true;
            this.cbDefaultOpenFileExtension.Location = new System.Drawing.Point(225, 23);
            this.cbDefaultOpenFileExtension.Name = "cbDefaultOpenFileExtension";
            this.cbDefaultOpenFileExtension.Size = new System.Drawing.Size(379, 26);
            this.cbDefaultOpenFileExtension.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(361, 206);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 18);
            this.label28.TabIndex = 14;
            this.label28.Text = "Suffix:";
            // 
            // cbFileSavePromptOverwrite
            // 
            this.cbFileSavePromptOverwrite.AutoSize = true;
            this.cbFileSavePromptOverwrite.Location = new System.Drawing.Point(9, 175);
            this.cbFileSavePromptOverwrite.Name = "cbFileSavePromptOverwrite";
            this.cbFileSavePromptOverwrite.Size = new System.Drawing.Size(381, 22);
            this.cbFileSavePromptOverwrite.TabIndex = 10;
            this.cbFileSavePromptOverwrite.Text = "On file \"Save\" prompt for file overwrite for the first time";
            this.cbFileSavePromptOverwrite.UseVisualStyleBackColor = true;
            // 
            // tbFileSaveNameSuffix
            // 
            this.tbFileSaveNameSuffix.Location = new System.Drawing.Point(420, 203);
            this.tbFileSaveNameSuffix.Name = "tbFileSaveNameSuffix";
            this.tbFileSaveNameSuffix.Size = new System.Drawing.Size(184, 24);
            this.tbFileSaveNameSuffix.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 206);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(147, 18);
            this.label27.TabIndex = 11;
            this.label27.Text = "File \"Save as\" Preffix:";
            // 
            // tbFileSaveNamePreffix
            // 
            this.tbFileSaveNamePreffix.Location = new System.Drawing.Point(162, 203);
            this.tbFileSaveNamePreffix.Name = "tbFileSaveNamePreffix";
            this.tbFileSaveNamePreffix.Size = new System.Drawing.Size(184, 24);
            this.tbFileSaveNamePreffix.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbStartMaximized);
            this.groupBox4.Controls.Add(this.cbCheckForUpdatesOnStartup);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 83);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Startup";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbZoomIssuesAuto);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.nmCrosshairLineMargin);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.cbCrosshairShowOnlyOnSelectedIssues);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.nmCrosshairLineLength);
            this.tabPage2.Controls.Add(this.cbCrosshairFadeLevel);
            this.tabPage2.Controls.Add(this.cbZoomIssues);
            this.tabPage2.Controls.Add(this.cbZoomLockLevel);
            this.tabPage2.Controls.Add(this.cbZoomToFitPrintVolumeBounds);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbOutlineHollowAreas);
            this.tabPage2.Controls.Add(this.btnPreviousNextLayerColor);
            this.tabPage2.Controls.Add(this.btnPreviousLayerColor);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.btnIslandColor);
            this.tabPage2.Controls.Add(this.btnIslandHLColor);
            this.tabPage2.Controls.Add(this.cbLayerAutoRotateBestView);
            this.tabPage2.Controls.Add(this.nmOutlineHollowAreasLineThickness);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbLayerDifferenceDefault);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btnResinTrapColor);
            this.tabPage2.Controls.Add(this.btnResinTrapHLColor);
            this.tabPage2.Controls.Add(this.cbLayerZoomToFit);
            this.tabPage2.Controls.Add(this.btnOutlineHollowAreasColor);
            this.tabPage2.Controls.Add(this.btnNextLayerColor);
            this.tabPage2.Controls.Add(this.btnOutlinePrintVolumeBoundsColor);
            this.tabPage2.Controls.Add(this.cbOutlineLayerBounds);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nmOutlinePrintVolumeBoundsLineThickness);
            this.tabPage2.Controls.Add(this.nmOutlineLayerBoundsLineThickness);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btnTouchingBoundsColor);
            this.tabPage2.Controls.Add(this.cbOutlinePrintVolumeBounds);
            this.tabPage2.Controls.Add(this.btnOutlineLayerBoundsColor);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Layer Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbZoomIssuesAuto
            // 
            this.cbZoomIssuesAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZoomIssuesAuto.AutoSize = true;
            this.cbZoomIssuesAuto.Location = new System.Drawing.Point(457, 305);
            this.cbZoomIssuesAuto.Name = "cbZoomIssuesAuto";
            this.cbZoomIssuesAuto.Size = new System.Drawing.Size(151, 22);
            this.cbZoomIssuesAuto.TabIndex = 49;
            this.cbZoomIssuesAuto.Text = "Auto zoom instead";
            this.cbZoomIssuesAuto.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(226, 422);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(23, 18);
            this.label40.TabIndex = 48;
            this.label40.Text = "px";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 422);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(126, 18);
            this.label41.TabIndex = 47;
            this.label41.Text = "Crosshair margin:";
            // 
            // nmCrosshairLineMargin
            // 
            this.nmCrosshairLineMargin.Location = new System.Drawing.Point(162, 419);
            this.nmCrosshairLineMargin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmCrosshairLineMargin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCrosshairLineMargin.Name = "nmCrosshairLineMargin";
            this.nmCrosshairLineMargin.Size = new System.Drawing.Size(57, 24);
            this.nmCrosshairLineMargin.TabIndex = 46;
            this.nmCrosshairLineMargin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(226, 392);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(213, 18);
            this.label39.TabIndex = 45;
            this.label39.Text = "px (0 to fill up to image bounds)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(526, 363);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 18);
            this.label37.TabIndex = 44;
            this.label37.Text = "zoom";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 392);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(146, 18);
            this.label36.TabIndex = 43;
            this.label36.Text = "Crosshair line length:";
            // 
            // cbCrosshairShowOnlyOnSelectedIssues
            // 
            this.cbCrosshairShowOnlyOnSelectedIssues.AutoSize = true;
            this.cbCrosshairShowOnlyOnSelectedIssues.Location = new System.Drawing.Point(11, 361);
            this.cbCrosshairShowOnlyOnSelectedIssues.Name = "cbCrosshairShowOnlyOnSelectedIssues";
            this.cbCrosshairShowOnlyOnSelectedIssues.Size = new System.Drawing.Size(434, 22);
            this.cbCrosshairShowOnlyOnSelectedIssues.TabIndex = 42;
            this.cbCrosshairShowOnlyOnSelectedIssues.Text = "Show crossharis only for the selected issues. Hide them after:";
            this.cbCrosshairShowOnlyOnSelectedIssues.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(393, 307);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 18);
            this.label38.TabIndex = 41;
            this.label38.Text = "zoom";
            // 
            // nmCrosshairLineLength
            // 
            this.nmCrosshairLineLength.Location = new System.Drawing.Point(162, 389);
            this.nmCrosshairLineLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmCrosshairLineLength.Name = "nmCrosshairLineLength";
            this.nmCrosshairLineLength.Size = new System.Drawing.Size(57, 24);
            this.nmCrosshairLineLength.TabIndex = 40;
            // 
            // cbCrosshairFadeLevel
            // 
            this.cbCrosshairFadeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCrosshairFadeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrosshairFadeLevel.FormattingEnabled = true;
            this.cbCrosshairFadeLevel.Location = new System.Drawing.Point(451, 359);
            this.cbCrosshairFadeLevel.Name = "cbCrosshairFadeLevel";
            this.cbCrosshairFadeLevel.Size = new System.Drawing.Size(68, 26);
            this.cbCrosshairFadeLevel.TabIndex = 37;
            // 
            // cbZoomIssues
            // 
            this.cbZoomIssues.AutoSize = true;
            this.cbZoomIssues.Location = new System.Drawing.Point(11, 305);
            this.cbZoomIssues.Name = "cbZoomIssues";
            this.cbZoomIssues.Size = new System.Drawing.Size(301, 22);
            this.cbZoomIssues.TabIndex = 35;
            this.cbZoomIssues.Text = "Zoom to issues and drawings region with:";
            this.cbZoomIssues.UseVisualStyleBackColor = true;
            // 
            // cbZoomLockLevel
            // 
            this.cbZoomLockLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZoomLockLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZoomLockLevel.FormattingEnabled = true;
            this.cbZoomLockLevel.Location = new System.Drawing.Point(318, 303);
            this.cbZoomLockLevel.Name = "cbZoomLockLevel";
            this.cbZoomLockLevel.Size = new System.Drawing.Size(68, 26);
            this.cbZoomLockLevel.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(616, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Issues";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbPartialUpdateIslandsOnEditing);
            this.tabPage4.Controls.Add(this.btnPixelEditorDrainHoleColor);
            this.tabPage4.Controls.Add(this.btnPixelEditorDrainHoleHLColor);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.btnPixelEditorSupportColor);
            this.tabPage4.Controls.Add(this.btnPixelEditorSupportHLColor);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.btnPixelEditorRemovePixelColor);
            this.tabPage4.Controls.Add(this.btnPixelEditorRemovePixelHLColor);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.btnPixelEditorAddPixelColor);
            this.tabPage4.Controls.Add(this.btnPixelEditorAddPixelHLColor);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(616, 594);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pixel Editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbPartialUpdateIslandsOnEditing
            // 
            this.cbPartialUpdateIslandsOnEditing.AutoSize = true;
            this.cbPartialUpdateIslandsOnEditing.Location = new System.Drawing.Point(9, 170);
            this.cbPartialUpdateIslandsOnEditing.Name = "cbPartialUpdateIslandsOnEditing";
            this.cbPartialUpdateIslandsOnEditing.Size = new System.Drawing.Size(565, 40);
            this.cbPartialUpdateIslandsOnEditing.TabIndex = 19;
            this.cbPartialUpdateIslandsOnEditing.Text = "Partial update islands for the affected layers after apply the modifications and " +
    "when\r\nremove a island";
            this.cbPartialUpdateIslandsOnEditing.UseVisualStyleBackColor = true;
            // 
            // btnPixelEditorDrainHoleColor
            // 
            this.btnPixelEditorDrainHoleColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorDrainHoleColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorDrainHoleColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorDrainHoleColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorDrainHoleColor.Location = new System.Drawing.Point(256, 131);
            this.btnPixelEditorDrainHoleColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorDrainHoleColor.Name = "btnPixelEditorDrainHoleColor";
            this.btnPixelEditorDrainHoleColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorDrainHoleColor.TabIndex = 9;
            this.btnPixelEditorDrainHoleColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorDrainHoleColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnPixelEditorDrainHoleHLColor
            // 
            this.btnPixelEditorDrainHoleHLColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorDrainHoleHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorDrainHoleHLColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorDrainHoleHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorDrainHoleHLColor.Location = new System.Drawing.Point(299, 131);
            this.btnPixelEditorDrainHoleHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorDrainHoleHLColor.Name = "btnPixelEditorDrainHoleHLColor";
            this.btnPixelEditorDrainHoleHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorDrainHoleHLColor.TabIndex = 23;
            this.btnPixelEditorDrainHoleHLColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorDrainHoleHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 138);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(223, 18);
            this.label26.TabIndex = 8;
            this.label26.Text = "Drain hole color / Highlight color:";
            // 
            // btnPixelEditorSupportColor
            // 
            this.btnPixelEditorSupportColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorSupportColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorSupportColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorSupportColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorSupportColor.Location = new System.Drawing.Point(256, 91);
            this.btnPixelEditorSupportColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorSupportColor.Name = "btnPixelEditorSupportColor";
            this.btnPixelEditorSupportColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorSupportColor.TabIndex = 7;
            this.btnPixelEditorSupportColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorSupportColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnPixelEditorSupportHLColor
            // 
            this.btnPixelEditorSupportHLColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorSupportHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorSupportHLColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorSupportHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorSupportHLColor.Location = new System.Drawing.Point(299, 91);
            this.btnPixelEditorSupportHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorSupportHLColor.Name = "btnPixelEditorSupportHLColor";
            this.btnPixelEditorSupportHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorSupportHLColor.TabIndex = 22;
            this.btnPixelEditorSupportHLColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorSupportHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 98);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 18);
            this.label25.TabIndex = 6;
            this.label25.Text = "Support color / Highlight color:";
            // 
            // btnPixelEditorRemovePixelColor
            // 
            this.btnPixelEditorRemovePixelColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorRemovePixelColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorRemovePixelColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorRemovePixelColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorRemovePixelColor.Location = new System.Drawing.Point(256, 51);
            this.btnPixelEditorRemovePixelColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorRemovePixelColor.Name = "btnPixelEditorRemovePixelColor";
            this.btnPixelEditorRemovePixelColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorRemovePixelColor.TabIndex = 5;
            this.btnPixelEditorRemovePixelColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorRemovePixelColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnPixelEditorRemovePixelHLColor
            // 
            this.btnPixelEditorRemovePixelHLColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorRemovePixelHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorRemovePixelHLColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorRemovePixelHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorRemovePixelHLColor.Location = new System.Drawing.Point(298, 51);
            this.btnPixelEditorRemovePixelHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorRemovePixelHLColor.Name = "btnPixelEditorRemovePixelHLColor";
            this.btnPixelEditorRemovePixelHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorRemovePixelHLColor.TabIndex = 21;
            this.btnPixelEditorRemovePixelHLColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorRemovePixelHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 58);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(241, 18);
            this.label24.TabIndex = 4;
            this.label24.Text = "Pixel remove color / Highlight color:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(215, 18);
            this.label23.TabIndex = 2;
            this.label23.Text = "Pixel add color / Highlight color:";
            // 
            // btnPixelEditorAddPixelColor
            // 
            this.btnPixelEditorAddPixelColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorAddPixelColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorAddPixelColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorAddPixelColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorAddPixelColor.Location = new System.Drawing.Point(256, 10);
            this.btnPixelEditorAddPixelColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorAddPixelColor.Name = "btnPixelEditorAddPixelColor";
            this.btnPixelEditorAddPixelColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorAddPixelColor.TabIndex = 3;
            this.btnPixelEditorAddPixelColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorAddPixelColor.Click += new System.EventHandler(this.EventClick);
            // 
            // btnPixelEditorAddPixelHLColor
            // 
            this.btnPixelEditorAddPixelHLColor.BackColor = System.Drawing.Color.White;
            this.btnPixelEditorAddPixelHLColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPixelEditorAddPixelHLColor.FlatAppearance.BorderSize = 2;
            this.btnPixelEditorAddPixelHLColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelEditorAddPixelHLColor.Location = new System.Drawing.Point(298, 10);
            this.btnPixelEditorAddPixelHLColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixelEditorAddPixelHLColor.Name = "btnPixelEditorAddPixelHLColor";
            this.btnPixelEditorAddPixelHLColor.Size = new System.Drawing.Size(32, 32);
            this.btnPixelEditorAddPixelHLColor.TabIndex = 20;
            this.btnPixelEditorAddPixelHLColor.UseVisualStyleBackColor = false;
            this.btnPixelEditorAddPixelHLColor.Click += new System.EventHandler(this.EventClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Controls.Add(this.nmLayerRepairDefaultOpeningIterations);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.nmLayerRepairDefaultClosingIterations);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.cbLayerRepairResinTraps);
            this.tabPage5.Controls.Add(this.cbLayerRepairRemoveEmptyLayers);
            this.tabPage5.Controls.Add(this.cbLayerRepairLayersIslands);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(616, 594);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Layer Repair";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // nmLayerRepairRemoveIslandsBelowEqualPixelsDefault
            // 
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.Location = new System.Drawing.Point(6, 66);
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.Name = "nmLayerRepairRemoveIslandsBelowEqualPixelsDefault";
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.Size = new System.Drawing.Size(57, 24);
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.TabIndex = 34;
            this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(69, 69);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(357, 18);
            this.label35.TabIndex = 35;
            this.label35.Text = "Remove islands below or equal to pixels default value";
            // 
            // nmLayerRepairDefaultOpeningIterations
            // 
            this.nmLayerRepairDefaultOpeningIterations.Location = new System.Drawing.Point(6, 36);
            this.nmLayerRepairDefaultOpeningIterations.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmLayerRepairDefaultOpeningIterations.Name = "nmLayerRepairDefaultOpeningIterations";
            this.nmLayerRepairDefaultOpeningIterations.Size = new System.Drawing.Size(57, 24);
            this.nmLayerRepairDefaultOpeningIterations.TabIndex = 32;
            this.nmLayerRepairDefaultOpeningIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(69, 39);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(215, 18);
            this.label34.TabIndex = 33;
            this.label34.Text = "Noise removal default iterations";
            // 
            // nmLayerRepairDefaultClosingIterations
            // 
            this.nmLayerRepairDefaultClosingIterations.Location = new System.Drawing.Point(6, 6);
            this.nmLayerRepairDefaultClosingIterations.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmLayerRepairDefaultClosingIterations.Name = "nmLayerRepairDefaultClosingIterations";
            this.nmLayerRepairDefaultClosingIterations.Size = new System.Drawing.Size(57, 24);
            this.nmLayerRepairDefaultClosingIterations.TabIndex = 30;
            this.nmLayerRepairDefaultClosingIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(69, 9);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(198, 18);
            this.label33.TabIndex = 31;
            this.label33.Text = "Gap closing default iterations";
            // 
            // cbLayerRepairResinTraps
            // 
            this.cbLayerRepairResinTraps.AutoSize = true;
            this.cbLayerRepairResinTraps.Location = new System.Drawing.Point(6, 152);
            this.cbLayerRepairResinTraps.Name = "cbLayerRepairResinTraps";
            this.cbLayerRepairResinTraps.Size = new System.Drawing.Size(209, 22);
            this.cbLayerRepairResinTraps.TabIndex = 17;
            this.cbLayerRepairResinTraps.Text = "Repair resin traps by default";
            this.cbLayerRepairResinTraps.UseVisualStyleBackColor = true;
            // 
            // cbLayerRepairRemoveEmptyLayers
            // 
            this.cbLayerRepairRemoveEmptyLayers.AutoSize = true;
            this.cbLayerRepairRemoveEmptyLayers.Location = new System.Drawing.Point(6, 124);
            this.cbLayerRepairRemoveEmptyLayers.Name = "cbLayerRepairRemoveEmptyLayers";
            this.cbLayerRepairRemoveEmptyLayers.Size = new System.Drawing.Size(236, 22);
            this.cbLayerRepairRemoveEmptyLayers.TabIndex = 16;
            this.cbLayerRepairRemoveEmptyLayers.Text = "Remove empty layers by default";
            this.cbLayerRepairRemoveEmptyLayers.UseVisualStyleBackColor = true;
            // 
            // cbLayerRepairLayersIslands
            // 
            this.cbLayerRepairLayersIslands.AutoSize = true;
            this.cbLayerRepairLayersIslands.Location = new System.Drawing.Point(6, 96);
            this.cbLayerRepairLayersIslands.Name = "cbLayerRepairLayersIslands";
            this.cbLayerRepairLayersIslands.Size = new System.Drawing.Size(257, 22);
            this.cbLayerRepairLayersIslands.TabIndex = 15;
            this.cbLayerRepairLayersIslands.Text = "Repair layers and islands by default";
            this.cbLayerRepairLayersIslands.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 77);
            this.panel1.TabIndex = 19;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 32767;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Information";
            // 
            // cbComputeEmptyLayers
            // 
            this.cbComputeEmptyLayers.AutoSize = true;
            this.cbComputeEmptyLayers.Location = new System.Drawing.Point(419, 79);
            this.cbComputeEmptyLayers.Name = "cbComputeEmptyLayers";
            this.cbComputeEmptyLayers.Size = new System.Drawing.Size(117, 22);
            this.cbComputeEmptyLayers.TabIndex = 21;
            this.cbComputeEmptyLayers.Text = "Empty Layers";
            this.cbComputeEmptyLayers.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlineHollowAreasLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlineLayerBoundsLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutlinePrintVolumeBoundsLineThickness)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapBinaryThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapMaximumPixelBrightnessToDrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapRequiredBlackPixelsToDrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResinTrapRequiredAreaToProcessCheck)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandBinaryThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelBrightnessToSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelsToSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredAreaToProcessCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIslandRequiredPixelBrightnessToProcessCheck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrosshairLineMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrosshairLineLength)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairRemoveIslandsBelowEqualPixelsDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairDefaultOpeningIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLayerRepairDefaultClosingIterations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousNextLayerColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnPreviousLayerColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextLayerColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTouchingBoundsColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResinTrapColor;
        private System.Windows.Forms.Button btnResinTrapHLColor;
        private System.Windows.Forms.Button btnIslandColor;
        private System.Windows.Forms.Button btnIslandHLColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbStartMaximized;
        private System.Windows.Forms.CheckBox cbCheckForUpdatesOnStartup;
        private System.Windows.Forms.CheckBox cbLayerAutoRotateBestView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbLayerDifferenceDefault;
        private System.Windows.Forms.CheckBox cbComputeIssuesOnLoad;
        private System.Windows.Forms.CheckBox cbLayerZoomToFit;
        private System.Windows.Forms.CheckBox cbComputeResinTraps;
        private System.Windows.Forms.CheckBox cbComputeIslands;
        private System.Windows.Forms.NumericUpDown nmIslandRequiredAreaToProcessCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmIslandRequiredPixelBrightnessToProcessCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmIslandRequiredPixelsToSupport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmIslandRequiredPixelBrightnessToSupport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nmResinTrapRequiredAreaToProcessCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmResinTrapRequiredBlackPixelsToDrain;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmResinTrapMaximumPixelBrightnessToDrain;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbAutoComputeIssuesClickOnTab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOutlinePrintVolumeBoundsColor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nmOutlinePrintVolumeBoundsLineThickness;
        private System.Windows.Forms.CheckBox cbOutlinePrintVolumeBounds;
        private System.Windows.Forms.CheckBox cbOutlineLayerBounds;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nmOutlineLayerBoundsLineThickness;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOutlineLayerBoundsColor;
        private System.Windows.Forms.CheckBox cbOutlineHollowAreas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nmOutlineHollowAreasLineThickness;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnOutlineHollowAreasColor;
        private System.Windows.Forms.CheckBox cbZoomToFitPrintVolumeBounds;
        private System.Windows.Forms.NumericUpDown nmResinTrapBinaryThreshold;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nmIslandBinaryThreshold;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbDefaultOpenFileExtension;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnPixelEditorRemovePixelColor;
        private System.Windows.Forms.Button btnPixelEditorRemovePixelHLColor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnPixelEditorAddPixelColor;
        private System.Windows.Forms.Button btnPixelEditorAddPixelHLColor;
        private System.Windows.Forms.Button btnPixelEditorSupportColor;
        private System.Windows.Forms.Button btnPixelEditorSupportHLColor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnPixelEditorDrainHoleColor;
        private System.Windows.Forms.Button btnPixelEditorDrainHoleHLColor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbFileSavePromptOverwrite;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbFileSaveNameSuffix;
        private System.Windows.Forms.TextBox tbFileSaveNamePreffix;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFileOpenDefaultDirectoryClear;
        private System.Windows.Forms.Button btnFileOpenDefaultDirectorySearch;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbFileOpenDefaultDirectory;
        private System.Windows.Forms.Button btnFileSaveDefaultDirectoryClear;
        private System.Windows.Forms.Button btnFileSaveDefaultDirectorySearch;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbFileSaveDefaultDirectory;
        private System.Windows.Forms.Button btnFileConvertDefaultDirectoryClear;
        private System.Windows.Forms.Button btnFileConvertDefaultDirectorySearch;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbFileConvertDefaultDirectory;
        private System.Windows.Forms.Button btnFileExtractDefaultDirectoryClear;
        private System.Windows.Forms.Button btnFileExtractDefaultDirectorySearch;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbFileExtractDefaultDirectory;
        private System.Windows.Forms.CheckBox cbZoomIssues;
        private System.Windows.Forms.ComboBox cbZoomLockLevel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbLayerRepairLayersIslands;
        private System.Windows.Forms.CheckBox cbLayerRepairRemoveEmptyLayers;
        private System.Windows.Forms.CheckBox cbLayerRepairResinTraps;
        private System.Windows.Forms.NumericUpDown nmLayerRepairDefaultClosingIterations;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nmLayerRepairDefaultOpeningIterations;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown nmLayerRepairRemoveIslandsBelowEqualPixelsDefault;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbPartialUpdateIslandsOnEditing;
        private System.Windows.Forms.CheckBox cbIslandAllowDiagonalBonds;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbCrosshairFadeLevel;
        private System.Windows.Forms.NumericUpDown nmCrosshairLineLength;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox cbCrosshairShowOnlyOnSelectedIssues;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown nmCrosshairLineMargin;
        private System.Windows.Forms.CheckBox cbZoomIssuesAuto;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox cbComputeTouchingBounds;
        private System.Windows.Forms.CheckBox cbComputeEmptyLayers;
    }
}
