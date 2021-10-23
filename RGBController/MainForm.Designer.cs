using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RGBController
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeveloperButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.MaterialDivider = new MaterialSkin.Controls.MaterialDivider();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.HexLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CurrentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CheckBoxAutoSave = new MaterialSkin.Controls.MaterialCheckBox();
            this.SaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ColorTabControl = new System.Windows.Forms.TabControl();
            this.TabHexagon = new System.Windows.Forms.TabPage();
            this.ColorHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.TabWheel = new System.Windows.Forms.TabPage();
            this.ColorWheel = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.TabColorBox = new System.Windows.Forms.TabPage();
            this.NumLuminance = new System.Windows.Forms.NumericUpDown();
            this.RadioLuminance = new System.Windows.Forms.RadioButton();
            this.NumSaturation = new System.Windows.Forms.NumericUpDown();
            this.RadioSaturation = new System.Windows.Forms.RadioButton();
            this.numHue = new System.Windows.Forms.NumericUpDown();
            this.RadioHue = new System.Windows.Forms.RadioButton();
            this.NumBlue = new System.Windows.Forms.NumericUpDown();
            this.RadioBlue = new System.Windows.Forms.RadioButton();
            this.NumGreen = new System.Windows.Forms.NumericUpDown();
            this.RadioGreen = new System.Windows.Forms.RadioButton();
            this.NumRed = new System.Windows.Forms.NumericUpDown();
            this.RadioRed = new System.Windows.Forms.RadioButton();
            this.ColorSlider = new MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical();
            this.ColorBox2D = new MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D();
            this.HexColorTextbox = new System.Windows.Forms.TextBox();
            this.CurrentColor = new System.Windows.Forms.Label();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.SpeedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.RainbowCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.SendColor = new System.Windows.Forms.Timer(this.components);
            this.RGBKeyboardCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            this.ColorTabControl.SuspendLayout();
            this.TabHexagon.SuspendLayout();
            this.TabWheel.SuspendLayout();
            this.TabColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLuminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRed)).BeginInit();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DeveloperButton
            // 
            this.DeveloperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeveloperButton.AutoSize = true;
            this.DeveloperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeveloperButton.Depth = 0;
            this.DeveloperButton.Icon = null;
            this.DeveloperButton.Location = new System.Drawing.Point(809, 657);
            this.DeveloperButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeveloperButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeveloperButton.Name = "DeveloperButton";
            this.DeveloperButton.Primary = true;
            this.DeveloperButton.Size = new System.Drawing.Size(175, 36);
            this.DeveloperButton.TabIndex = 1;
            this.DeveloperButton.Text = "Developed by Majdev";
            this.DeveloperButton.UseVisualStyleBackColor = true;
            this.DeveloperButton.Click += new System.EventHandler(this.DeveloperButton_Click);
            // 
            // MaterialDivider
            // 
            this.MaterialDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialDivider.Depth = 0;
            this.MaterialDivider.Location = new System.Drawing.Point(0, 650);
            this.MaterialDivider.Margin = new System.Windows.Forms.Padding(0);
            this.MaterialDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialDivider.Name = "MaterialDivider";
            this.MaterialDivider.Size = new System.Drawing.Size(1008, 1);
            this.MaterialDivider.TabIndex = 16;
            this.MaterialDivider.Text = "materialDivider1";
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(0, 64);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1008, 48);
            this.TabSelector.TabIndex = 17;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Page1);
            this.TabControl.Controls.Add(this.Page2);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(14, 111);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(974, 527);
            this.TabControl.TabIndex = 18;
            // 
            // Page1
            // 
            this.Page1.BackColor = System.Drawing.Color.White;
            this.Page1.Controls.Add(this.HexLabel);
            this.Page1.Controls.Add(this.CurrentLabel);
            this.Page1.Controls.Add(this.CheckBoxAutoSave);
            this.Page1.Controls.Add(this.SaveButton);
            this.Page1.Controls.Add(this.ColorTabControl);
            this.Page1.Controls.Add(this.HexColorTextbox);
            this.Page1.Controls.Add(this.CurrentColor);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(966, 501);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "STATIC COLOR";
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Depth = 0;
            this.HexLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.HexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HexLabel.Location = new System.Drawing.Point(447, 89);
            this.HexLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(39, 19);
            this.HexLabel.TabIndex = 14;
            this.HexLabel.Text = "Hex:";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Depth = 0;
            this.CurrentLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CurrentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentLabel.Location = new System.Drawing.Point(447, 25);
            this.CurrentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(62, 19);
            this.CurrentLabel.TabIndex = 13;
            this.CurrentLabel.Text = "Current:";
            // 
            // CheckBoxAutoSave
            // 
            this.CheckBoxAutoSave.AutoSize = true;
            this.CheckBoxAutoSave.Checked = true;
            this.CheckBoxAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxAutoSave.Depth = 0;
            this.CheckBoxAutoSave.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxAutoSave.Location = new System.Drawing.Point(448, 140);
            this.CheckBoxAutoSave.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxAutoSave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxAutoSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxAutoSave.Name = "CheckBoxAutoSave";
            this.CheckBoxAutoSave.Ripple = true;
            this.CheckBoxAutoSave.Size = new System.Drawing.Size(92, 30);
            this.CheckBoxAutoSave.TabIndex = 12;
            this.CheckBoxAutoSave.Text = "Auto Save";
            this.CheckBoxAutoSave.UseVisualStyleBackColor = true;
            this.CheckBoxAutoSave.CheckedChanged += new System.EventHandler(this.CheckBoxAutoSave_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(451, 174);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = true;
            this.SaveButton.Size = new System.Drawing.Size(55, 36);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ColorTabControl
            // 
            this.ColorTabControl.Controls.Add(this.TabHexagon);
            this.ColorTabControl.Controls.Add(this.TabWheel);
            this.ColorTabControl.Controls.Add(this.TabColorBox);
            this.ColorTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColorTabControl.Location = new System.Drawing.Point(3, 3);
            this.ColorTabControl.Name = "ColorTabControl";
            this.ColorTabControl.SelectedIndex = 0;
            this.ColorTabControl.Size = new System.Drawing.Size(427, 495);
            this.ColorTabControl.TabIndex = 10;
            // 
            // TabHexagon
            // 
            this.TabHexagon.Controls.Add(this.ColorHexagon);
            this.TabHexagon.Location = new System.Drawing.Point(4, 22);
            this.TabHexagon.Name = "TabHexagon";
            this.TabHexagon.Padding = new System.Windows.Forms.Padding(3);
            this.TabHexagon.Size = new System.Drawing.Size(419, 469);
            this.TabHexagon.TabIndex = 0;
            this.TabHexagon.Text = "Color Hexagon";
            this.TabHexagon.UseVisualStyleBackColor = true;
            // 
            // ColorHexagon
            // 
            this.ColorHexagon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorHexagon.Location = new System.Drawing.Point(3, 3);
            this.ColorHexagon.Name = "ColorHexagon";
            this.ColorHexagon.Size = new System.Drawing.Size(413, 463);
            this.ColorHexagon.TabIndex = 1;
            this.ColorHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.ColorHexagon_ColorChanged);
            // 
            // TabWheel
            // 
            this.TabWheel.Controls.Add(this.ColorWheel);
            this.TabWheel.Location = new System.Drawing.Point(4, 22);
            this.TabWheel.Name = "TabWheel";
            this.TabWheel.Padding = new System.Windows.Forms.Padding(3);
            this.TabWheel.Size = new System.Drawing.Size(419, 469);
            this.TabWheel.TabIndex = 1;
            this.TabWheel.Text = "Color Wheel";
            this.TabWheel.UseVisualStyleBackColor = true;
            // 
            // ColorWheel
            // 
            this.ColorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorWheel.Location = new System.Drawing.Point(3, 3);
            this.ColorWheel.Name = "ColorWheel";
            this.ColorWheel.Size = new System.Drawing.Size(413, 463);
            this.ColorWheel.TabIndex = 0;
            this.ColorWheel.ColorChanged += new System.EventHandler(this.ColorWheel_ColorChanged);
            // 
            // TabColorBox
            // 
            this.TabColorBox.Controls.Add(this.NumLuminance);
            this.TabColorBox.Controls.Add(this.RadioLuminance);
            this.TabColorBox.Controls.Add(this.NumSaturation);
            this.TabColorBox.Controls.Add(this.RadioSaturation);
            this.TabColorBox.Controls.Add(this.numHue);
            this.TabColorBox.Controls.Add(this.RadioHue);
            this.TabColorBox.Controls.Add(this.NumBlue);
            this.TabColorBox.Controls.Add(this.RadioBlue);
            this.TabColorBox.Controls.Add(this.NumGreen);
            this.TabColorBox.Controls.Add(this.RadioGreen);
            this.TabColorBox.Controls.Add(this.NumRed);
            this.TabColorBox.Controls.Add(this.RadioRed);
            this.TabColorBox.Controls.Add(this.ColorSlider);
            this.TabColorBox.Controls.Add(this.ColorBox2D);
            this.TabColorBox.Location = new System.Drawing.Point(4, 22);
            this.TabColorBox.Name = "TabColorBox";
            this.TabColorBox.Padding = new System.Windows.Forms.Padding(3);
            this.TabColorBox.Size = new System.Drawing.Size(419, 469);
            this.TabColorBox.TabIndex = 2;
            this.TabColorBox.Text = "Color Box & Slider";
            this.TabColorBox.UseVisualStyleBackColor = true;
            // 
            // NumLuminance
            // 
            this.NumLuminance.Location = new System.Drawing.Point(349, 165);
            this.NumLuminance.Name = "NumLuminance";
            this.NumLuminance.Size = new System.Drawing.Size(54, 20);
            this.NumLuminance.TabIndex = 13;
            this.NumLuminance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumLuminance.ValueChanged += new System.EventHandler(this.NumLuminance_ValueChanged);
            // 
            // RadioLuminance
            // 
            this.RadioLuminance.AutoSize = true;
            this.RadioLuminance.Location = new System.Drawing.Point(306, 165);
            this.RadioLuminance.Name = "RadioLuminance";
            this.RadioLuminance.Size = new System.Drawing.Size(34, 17);
            this.RadioLuminance.TabIndex = 12;
            this.RadioLuminance.Text = "L:";
            this.RadioLuminance.UseVisualStyleBackColor = true;
            this.RadioLuminance.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // NumSaturation
            // 
            this.NumSaturation.Location = new System.Drawing.Point(349, 139);
            this.NumSaturation.Name = "NumSaturation";
            this.NumSaturation.Size = new System.Drawing.Size(54, 20);
            this.NumSaturation.TabIndex = 11;
            this.NumSaturation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumSaturation.ValueChanged += new System.EventHandler(this.NumSaturation_ValueChanged);
            // 
            // RadioSaturation
            // 
            this.RadioSaturation.AutoSize = true;
            this.RadioSaturation.Location = new System.Drawing.Point(306, 139);
            this.RadioSaturation.Name = "RadioSaturation";
            this.RadioSaturation.Size = new System.Drawing.Size(35, 17);
            this.RadioSaturation.TabIndex = 10;
            this.RadioSaturation.Text = "S:";
            this.RadioSaturation.UseVisualStyleBackColor = true;
            this.RadioSaturation.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // numHue
            // 
            this.numHue.Location = new System.Drawing.Point(349, 113);
            this.numHue.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numHue.Name = "numHue";
            this.numHue.Size = new System.Drawing.Size(54, 20);
            this.numHue.TabIndex = 9;
            this.numHue.ValueChanged += new System.EventHandler(this.NumHue_ValueChanged);
            // 
            // RadioHue
            // 
            this.RadioHue.AutoSize = true;
            this.RadioHue.Checked = true;
            this.RadioHue.Location = new System.Drawing.Point(306, 113);
            this.RadioHue.Name = "RadioHue";
            this.RadioHue.Size = new System.Drawing.Size(36, 17);
            this.RadioHue.TabIndex = 8;
            this.RadioHue.TabStop = true;
            this.RadioHue.Text = "H:";
            this.RadioHue.UseVisualStyleBackColor = true;
            this.RadioHue.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // NumBlue
            // 
            this.NumBlue.Location = new System.Drawing.Point(349, 69);
            this.NumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumBlue.Name = "NumBlue";
            this.NumBlue.Size = new System.Drawing.Size(54, 20);
            this.NumBlue.TabIndex = 7;
            this.NumBlue.ValueChanged += new System.EventHandler(this.NumBlue_ValueChanged);
            // 
            // RadioBlue
            // 
            this.RadioBlue.AutoSize = true;
            this.RadioBlue.Location = new System.Drawing.Point(306, 69);
            this.RadioBlue.Name = "RadioBlue";
            this.RadioBlue.Size = new System.Drawing.Size(35, 17);
            this.RadioBlue.TabIndex = 6;
            this.RadioBlue.Text = "B:";
            this.RadioBlue.UseVisualStyleBackColor = true;
            this.RadioBlue.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // NumGreen
            // 
            this.NumGreen.Location = new System.Drawing.Point(349, 43);
            this.NumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumGreen.Name = "NumGreen";
            this.NumGreen.Size = new System.Drawing.Size(54, 20);
            this.NumGreen.TabIndex = 5;
            this.NumGreen.ValueChanged += new System.EventHandler(this.NumGreen_ValueChanged);
            // 
            // RadioGreen
            // 
            this.RadioGreen.AutoSize = true;
            this.RadioGreen.Location = new System.Drawing.Point(306, 43);
            this.RadioGreen.Name = "RadioGreen";
            this.RadioGreen.Size = new System.Drawing.Size(36, 17);
            this.RadioGreen.TabIndex = 4;
            this.RadioGreen.Text = "G:";
            this.RadioGreen.UseVisualStyleBackColor = true;
            this.RadioGreen.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // NumRed
            // 
            this.NumRed.Location = new System.Drawing.Point(349, 17);
            this.NumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumRed.Name = "NumRed";
            this.NumRed.Size = new System.Drawing.Size(54, 20);
            this.NumRed.TabIndex = 3;
            this.NumRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumRed.ValueChanged += new System.EventHandler(this.NumRed_ValueChanged);
            // 
            // RadioRed
            // 
            this.RadioRed.AutoSize = true;
            this.RadioRed.Location = new System.Drawing.Point(306, 17);
            this.RadioRed.Name = "RadioRed";
            this.RadioRed.Size = new System.Drawing.Size(36, 17);
            this.RadioRed.TabIndex = 2;
            this.RadioRed.Text = "R:";
            this.RadioRed.UseVisualStyleBackColor = true;
            this.RadioRed.CheckedChanged += new System.EventHandler(this.ColorModeChangedHandler);
            // 
            // ColorSlider
            // 
            this.ColorSlider.ColorMode = MechanikaDesign.WinForms.UI.ColorPicker.ColorModes.Hue;
            this.ColorSlider.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorSlider.Location = new System.Drawing.Point(259, 8);
            this.ColorSlider.Name = "ColorSlider";
            this.ColorSlider.NubColor = System.Drawing.Color.White;
            this.ColorSlider.Position = 142;
            this.ColorSlider.Size = new System.Drawing.Size(40, 252);
            this.ColorSlider.TabIndex = 1;
            this.ColorSlider.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical.ColorChangedEventHandler(this.ColorSlider_ColorChanged);
            // 
            // ColorBox2D
            // 
            this.ColorBox2D.ColorMode = MechanikaDesign.WinForms.UI.ColorPicker.ColorModes.Hue;
            this.ColorBox2D.ColorRGB = System.Drawing.Color.Red;
            this.ColorBox2D.Location = new System.Drawing.Point(8, 8);
            this.ColorBox2D.Name = "ColorBox2D";
            this.ColorBox2D.Size = new System.Drawing.Size(245, 252);
            this.ColorBox2D.TabIndex = 0;
            this.ColorBox2D.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D.ColorChangedEventHandler(this.ColorBox2D_ColorChanged);
            // 
            // HexColorTextbox
            // 
            this.HexColorTextbox.Location = new System.Drawing.Point(451, 111);
            this.HexColorTextbox.Name = "HexColorTextbox";
            this.HexColorTextbox.ReadOnly = true;
            this.HexColorTextbox.Size = new System.Drawing.Size(68, 20);
            this.HexColorTextbox.TabIndex = 9;
            this.HexColorTextbox.Text = "FFFFFF";
            // 
            // CurrentColor
            // 
            this.CurrentColor.BackColor = System.Drawing.Color.White;
            this.CurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentColor.Location = new System.Drawing.Point(451, 47);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(68, 32);
            this.CurrentColor.TabIndex = 7;
            // 
            // Page2
            // 
            this.Page2.BackColor = System.Drawing.Color.White;
            this.Page2.Controls.Add(this.SpeedLabel);
            this.Page2.Controls.Add(this.SpeedBar);
            this.Page2.Controls.Add(this.RainbowCheckBox);
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(966, 501);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "RAINBOW";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Depth = 0;
            this.SpeedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.SpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpeedLabel.Location = new System.Drawing.Point(14, 56);
            this.SpeedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(54, 19);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "Speed:";
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(18, 78);
            this.SpeedBar.Maximum = 20;
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(916, 45);
            this.SpeedBar.TabIndex = 1;
            this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SpeedBar.Value = 1;
            this.SpeedBar.ValueChanged += new System.EventHandler(this.SpeedBar_ValueChanged);
            // 
            // RainbowCheckBox
            // 
            this.RainbowCheckBox.AutoSize = true;
            this.RainbowCheckBox.Depth = 0;
            this.RainbowCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.RainbowCheckBox.Location = new System.Drawing.Point(12, 14);
            this.RainbowCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.RainbowCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RainbowCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RainbowCheckBox.Name = "RainbowCheckBox";
            this.RainbowCheckBox.Ripple = true;
            this.RainbowCheckBox.Size = new System.Drawing.Size(79, 30);
            this.RainbowCheckBox.TabIndex = 0;
            this.RainbowCheckBox.Text = "Enabled";
            this.RainbowCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendColor
            // 
            this.SendColor.Enabled = true;
            this.SendColor.Interval = 1;
            this.SendColor.Tick += new System.EventHandler(this.SendColor_Tick);
            // 
            // RGBKeyboardCheckBox
            // 
            this.RGBKeyboardCheckBox.AutoSize = true;
            this.RGBKeyboardCheckBox.Checked = true;
            this.RGBKeyboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RGBKeyboardCheckBox.Depth = 0;
            this.RGBKeyboardCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.RGBKeyboardCheckBox.Location = new System.Drawing.Point(9, 660);
            this.RGBKeyboardCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.RGBKeyboardCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RGBKeyboardCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RGBKeyboardCheckBox.Name = "RGBKeyboardCheckBox";
            this.RGBKeyboardCheckBox.Ripple = true;
            this.RGBKeyboardCheckBox.Size = new System.Drawing.Size(118, 30);
            this.RGBKeyboardCheckBox.TabIndex = 24;
            this.RGBKeyboardCheckBox.Text = "RGB Keyboard";
            this.RGBKeyboardCheckBox.UseVisualStyleBackColor = true;
            this.RGBKeyboardCheckBox.CheckedChanged += new System.EventHandler(this.RGBKeyboardCheckBox_CheckedChanged);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "RGBController";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.RGBKeyboardCheckBox);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MaterialDivider);
            this.Controls.Add(this.DeveloperButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBController";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ColorTabControl.ResumeLayout(false);
            this.TabHexagon.ResumeLayout(false);
            this.TabWheel.ResumeLayout(false);
            this.TabColorBox.ResumeLayout(false);
            this.TabColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLuminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRed)).EndInit();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton DeveloperButton;
        private MaterialDivider MaterialDivider;
        private MaterialTabSelector TabSelector;
        private MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private TabControl ColorTabControl;
        private TabPage TabHexagon;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon ColorHexagon;
        private TabPage TabWheel;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel ColorWheel;
        private TabPage TabColorBox;
        private NumericUpDown NumLuminance;
        private RadioButton RadioLuminance;
        private NumericUpDown NumSaturation;
        private RadioButton RadioSaturation;
        private NumericUpDown numHue;
        private RadioButton RadioHue;
        private NumericUpDown NumBlue;
        private RadioButton RadioBlue;
        private NumericUpDown NumGreen;
        private RadioButton RadioGreen;
        private NumericUpDown NumRed;
        private RadioButton RadioRed;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical ColorSlider;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D ColorBox2D;
        private TextBox HexColorTextbox;
        private Label CurrentColor;
        private MaterialRaisedButton SaveButton;
        private MaterialCheckBox CheckBoxAutoSave;
        private MaterialLabel HexLabel;
        private MaterialLabel CurrentLabel;
        private MaterialLabel SpeedLabel;
        private TrackBar SpeedBar;
        private MaterialCheckBox RainbowCheckBox;
        private Timer SendColor;
        private MaterialCheckBox RGBKeyboardCheckBox;
        private NotifyIcon NotifyIcon;
    }
}