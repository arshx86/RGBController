using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MechanikaDesign.WinForms.UI.ColorPicker;

namespace RGBController
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager MaterialSkinManager;
        private HslColor colorHsl = HslColor.FromAhsl(0xff);
        private ColorModes colorMode = ColorModes.Hue;
        private Color colorRgb = Color.Empty;
        private bool LockUpdates = false;
        bool SupportPC = false;
        public MainForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.ColorBox2D.ColorMode = this.colorMode;
            this.ColorSlider.ColorMode = this.colorMode;
            SaveButton.Visible = false;

            MaterialSkinManager = MaterialSkinManager.Instance;
            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if(KeyboardColorHook.CheckSupport() == true)
            {
                SupportPC = true;
            }
            else
            {
                MessageBox.Show("Your System does Not Support it! Please Contact the Developer!", "RGBController", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FadeColor.Setup();
        }
        private void ColorHexagon_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            CurrentColor.BackColor = ColorHexagon.SelectedColor;
            HexColorTextbox.Text = ColorTranslator.ToHtml(ColorHexagon.SelectedColor);
        }

        private void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            CurrentColor.BackColor = ColorWheel.Color;
            HexColorTextbox.Text = ColorTranslator.ToHtml(ColorWheel.Color);
        }

        private void ColorSlider_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            if (!this.LockUpdates)
            {
                HslColor colorHSL = this.ColorSlider.ColorHSL;
                this.colorHsl = colorHSL;
                this.colorRgb = this.colorHsl.RgbValue;
                this.LockUpdates = true;
                this.ColorBox2D.ColorHSL = this.colorHsl;
                this.LockUpdates = false;
                CurrentColor.BackColor = this.colorRgb;
                HexColorTextbox.Text = ColorTranslator.ToHtml(this.colorRgb);
                UpdateColorFields();
            }
        }

        private void ColorBox2D_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            if (!this.LockUpdates)
            {
                HslColor colorHSL = this.ColorBox2D.ColorHSL;
                this.colorHsl = colorHSL;
                this.colorRgb = this.colorHsl.RgbValue;
                this.LockUpdates = true;
                this.ColorSlider.ColorHSL = this.colorHsl;
                this.LockUpdates = false;
                CurrentColor.BackColor = this.colorRgb;
                HexColorTextbox.Text = ColorTranslator.ToHtml(this.colorRgb);
                UpdateColorFields();
            }
        }

        private void ColorModeChangedHandler(object sender, EventArgs e)
        {
            if (sender == this.RadioRed)
            {
                this.colorMode = ColorModes.Red;
            }
            else if (sender == this.RadioGreen)
            {
                this.colorMode = ColorModes.Green;
            }
            else if (sender == this.RadioBlue)
            {
                this.colorMode = ColorModes.Blue;
            }
            else if (sender == this.RadioHue)
            {
                this.colorMode = ColorModes.Hue;
            }
            else if (sender == this.RadioSaturation)
            {
                this.colorMode = ColorModes.Saturation;
            }
            else if (sender == this.RadioLuminance)
            {
                this.colorMode = ColorModes.Luminance;
            }
            this.ColorSlider.ColorMode = this.colorMode;
            this.ColorBox2D.ColorMode = this.colorMode;
        }

        private void UpdateColorFields()
        {
            this.LockUpdates = true;
            this.NumRed.Value = this.colorRgb.R;
            this.NumGreen.Value = this.colorRgb.G;
            this.NumBlue.Value = this.colorRgb.B;
            this.numHue.Value = (int)(((decimal)this.colorHsl.H) * 360M);
            this.NumSaturation.Value = (int)(((decimal)this.colorHsl.S) * 100M);
            this.NumLuminance.Value = (int)(((decimal)this.colorHsl.L) * 100M);
            this.LockUpdates = false;
        }

        private void UpdateRgbFields(Color newColor)
        {
            this.colorHsl = HslColor.FromColor(newColor);
            this.colorRgb = newColor;
            this.LockUpdates = true;
            this.numHue.Value = (int)(((decimal)this.colorHsl.H) * 360M);
            this.NumSaturation.Value = (int)(((decimal)this.colorHsl.S) * 100M);
            this.NumLuminance.Value = (int)(((decimal)this.colorHsl.L) * 100M);
            this.LockUpdates = false;
            this.ColorSlider.ColorHSL = this.colorHsl;
            this.ColorBox2D.ColorHSL = this.colorHsl;
        }

        private void UpdateHslFields(HslColor newColor)
        {
            this.colorHsl = newColor;
            this.colorRgb = newColor.RgbValue;
            this.LockUpdates = true;
            this.NumRed.Value = this.colorRgb.R;
            this.NumGreen.Value = this.colorRgb.G;
            this.NumBlue.Value = this.colorRgb.B;
            this.LockUpdates = false;
            this.ColorSlider.ColorHSL = this.colorHsl;
            this.ColorBox2D.ColorHSL = this.colorHsl;
        }

        private void NumRed_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                UpdateRgbFields(Color.FromArgb((int)this.NumRed.Value, (int)this.NumGreen.Value, (int)this.NumBlue.Value));
            }
        }

        private void NumGreen_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                UpdateRgbFields(Color.FromArgb((int)this.NumRed.Value, (int)this.NumGreen.Value, (int)this.NumBlue.Value));
            }
        }

        private void NumBlue_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                UpdateRgbFields(Color.FromArgb((int)this.NumRed.Value, (int)this.NumGreen.Value, (int)this.NumBlue.Value));
            }
        }

        private void NumHue_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                HslColor newColor = HslColor.FromAhsl((double)(((float)((int)this.numHue.Value)) / 360f), this.colorHsl.S, this.colorHsl.L);
                this.UpdateHslFields(newColor);
            }
        }

        private void NumSaturation_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                HslColor newColor = HslColor.FromAhsl(this.colorHsl.A, this.colorHsl.H, (double)(((float)((int)this.NumSaturation.Value)) / 100f), this.colorHsl.L);
                this.UpdateHslFields(newColor);
            }
        }

        private void NumLuminance_ValueChanged(object sender, EventArgs e)
        {
            if (!this.LockUpdates)
            {
                HslColor newColor = HslColor.FromAhsl(this.colorHsl.A, this.colorHsl.H, this.colorHsl.S, (double)(((float)((int)this.NumLuminance.Value)) / 100f));
                this.UpdateHslFields(newColor);
            }
        }

        private void CheckBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            SaveButton.Visible = !SaveButton.Visible;
        }

        private void SendColor_Tick(object sender, EventArgs e)
        {
            if(SupportPC == true && RGBKeyboardCheckBox.Checked == true)
            {
                if (TabControl.SelectedTab == Page1)
                {
                    if (CheckBoxAutoSave.Checked == true)
                    {
                        KeyboardColorHook.SetColor(CurrentColor.BackColor.R, CurrentColor.BackColor.G, CurrentColor.BackColor.B);
                        KeyboardColorHook.SetBrightness(CurrentColor.BackColor.A);
                    }
                }
                if (TabControl.SelectedTab == Page2)
                {
                    if (RainbowCheckBox.Checked == true)
                    {
                        KeyboardColorHook.SetColor(FadeColor.CurrentColor.R, FadeColor.CurrentColor.G, FadeColor.CurrentColor.B);
                        KeyboardColorHook.SetBrightness(255);
                    }
                }
            } 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SupportPC == true && RGBKeyboardCheckBox.Checked == true)
            {
                KeyboardColorHook.SetBrightness(CurrentColor.BackColor.A);
                KeyboardColorHook.SetColor(CurrentColor.BackColor.R, CurrentColor.BackColor.G, CurrentColor.BackColor.B);
            }
        }

        private void SpeedBar_ValueChanged(object sender, EventArgs e)
        {
            if (SupportPC == true && RGBKeyboardCheckBox.Checked == true)
            {
                FadeColor.SetSpeed(SpeedBar.Value);
            } 
        }

        private void DeveloperButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/furkankadirguzeloglu");
        }

        private void RGBKeyboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SupportPC == true)
            {
                if (RGBKeyboardCheckBox.Checked == true)
                {
                    KeyboardColorHook.TurnOn();
                }
                else
                {
                    KeyboardColorHook.TurnOff();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Result = MessageBox.Show(this, "Keep running in the background?", "RGBController", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes)
            {
                this.Opacity = 0;
                e.Cancel = true;
                return;
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
        }
    }
}
