namespace lissajous
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.live_preview_check_box = new MetroFramework.Controls.MetroCheckBox();
            this.rotate_check_box = new MetroFramework.Controls.MetroCheckBox();
            this.equation_2 = new MetroFramework.Controls.MetroLabel();
            this.equation_1 = new MetroFramework.Controls.MetroLabel();
            this.drawButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phase_x = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.freq_x = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.amplitude_x = new MetroFramework.Controls.MetroTrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phase_y = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.amplitude_y = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.freq_y = new MetroFramework.Controls.MetroTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.drawingPlace = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroCheckBox2);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.metroCheckBox1);
            this.panel1.Controls.Add(this.live_preview_check_box);
            this.panel1.Controls.Add(this.rotate_check_box);
            this.panel1.Controls.Add(this.equation_2);
            this.panel1.Controls.Add(this.equation_1);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 606);
            this.panel1.TabIndex = 9;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox2.Location = new System.Drawing.Point(15, 516);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(75, 25);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox2.TabIndex = 36;
            this.metroCheckBox2.Text = "pause";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(191, 498);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(24, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "мс";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(140, 499);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 35;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.Location = new System.Drawing.Point(15, 495);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(127, 25);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBox1.TabIndex = 34;
            this.metroCheckBox1.Text = "Step by step";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            // 
            // live_preview_check_box
            // 
            this.live_preview_check_box.AutoSize = true;
            this.live_preview_check_box.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.live_preview_check_box.Location = new System.Drawing.Point(126, 454);
            this.live_preview_check_box.Name = "live_preview_check_box";
            this.live_preview_check_box.Size = new System.Drawing.Size(124, 25);
            this.live_preview_check_box.Style = MetroFramework.MetroColorStyle.Blue;
            this.live_preview_check_box.TabIndex = 33;
            this.live_preview_check_box.Text = "Live preview";
            this.live_preview_check_box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.live_preview_check_box.UseSelectable = true;
            this.live_preview_check_box.UseStyleColors = true;
            // 
            // rotate_check_box
            // 
            this.rotate_check_box.AutoSize = true;
            this.rotate_check_box.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rotate_check_box.Location = new System.Drawing.Point(15, 454);
            this.rotate_check_box.Name = "rotate_check_box";
            this.rotate_check_box.Size = new System.Drawing.Size(79, 25);
            this.rotate_check_box.Style = MetroFramework.MetroColorStyle.Blue;
            this.rotate_check_box.TabIndex = 32;
            this.rotate_check_box.Text = "Rotate";
            this.rotate_check_box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rotate_check_box.UseSelectable = true;
            this.rotate_check_box.UseStyleColors = true;
            // 
            // equation_2
            // 
            this.equation_2.AutoSize = true;
            this.equation_2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.equation_2.Location = new System.Drawing.Point(57, 416);
            this.equation_2.Name = "equation_2";
            this.equation_2.Size = new System.Drawing.Size(120, 25);
            this.equation_2.Style = MetroFramework.MetroColorStyle.Blue;
            this.equation_2.TabIndex = 31;
            this.equation_2.Text = "equation form";
            this.equation_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.equation_2.UseStyleColors = true;
            // 
            // equation_1
            // 
            this.equation_1.AutoSize = true;
            this.equation_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.equation_1.Location = new System.Drawing.Point(57, 183);
            this.equation_1.Name = "equation_1";
            this.equation_1.Size = new System.Drawing.Size(120, 25);
            this.equation_1.Style = MetroFramework.MetroColorStyle.Blue;
            this.equation_1.TabIndex = 30;
            this.equation_1.Text = "equation form";
            this.equation_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.equation_1.UseStyleColors = true;
            // 
            // drawButton
            // 
            this.drawButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.drawButton.Highlight = true;
            this.drawButton.Location = new System.Drawing.Point(0, 556);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(258, 47);
            this.drawButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.drawButton.TabIndex = 10;
            this.drawButton.Text = "Draw";
            this.drawButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.drawButton.UseSelectable = true;
            this.drawButton.UseStyleColors = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phase_x);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.freq_x);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.amplitude_x);
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 168);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equation 1:";
            // 
            // phase_x
            // 
            this.phase_x.BackColor = System.Drawing.Color.Transparent;
            this.phase_x.ImeMode = System.Windows.Forms.ImeMode.On;
            this.phase_x.Location = new System.Drawing.Point(88, 107);
            this.phase_x.Maximum = 360;
            this.phase_x.Name = "phase_x";
            this.phase_x.Size = new System.Drawing.Size(158, 45);
            this.phase_x.TabIndex = 19;
            this.phase_x.Text = "metroTrackBar2";
            this.phase_x.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.phase_x.Value = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Phase";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // freq_x
            // 
            this.freq_x.BackColor = System.Drawing.Color.Transparent;
            this.freq_x.ImeMode = System.Windows.Forms.ImeMode.On;
            this.freq_x.Location = new System.Drawing.Point(88, 70);
            this.freq_x.Maximum = 10;
            this.freq_x.Name = "freq_x";
            this.freq_x.Size = new System.Drawing.Size(158, 45);
            this.freq_x.TabIndex = 30;
            this.freq_x.Text = "metroTrackBar2";
            this.freq_x.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.freq_x.Value = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Frequency";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Amplitude X";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // amplitude_x
            // 
            this.amplitude_x.BackColor = System.Drawing.Color.Transparent;
            this.amplitude_x.ImeMode = System.Windows.Forms.ImeMode.On;
            this.amplitude_x.Location = new System.Drawing.Point(88, 19);
            this.amplitude_x.Maximum = 300;
            this.amplitude_x.Name = "amplitude_x";
            this.amplitude_x.Size = new System.Drawing.Size(158, 45);
            this.amplitude_x.SmallChange = 10;
            this.amplitude_x.Style = MetroFramework.MetroColorStyle.Orange;
            this.amplitude_x.TabIndex = 27;
            this.amplitude_x.Text = "metroTrackBar1";
            this.amplitude_x.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.amplitude_x.Value = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phase_y);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.amplitude_y);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.freq_y);
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(3, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 168);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equation 2:";
            // 
            // phase_y
            // 
            this.phase_y.BackColor = System.Drawing.Color.Transparent;
            this.phase_y.ImeMode = System.Windows.Forms.ImeMode.On;
            this.phase_y.Location = new System.Drawing.Point(88, 115);
            this.phase_y.Maximum = 360;
            this.phase_y.Name = "phase_y";
            this.phase_y.Size = new System.Drawing.Size(158, 45);
            this.phase_y.TabIndex = 31;
            this.phase_y.Text = "metroTrackBar2";
            this.phase_y.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.phase_y.Value = 0;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 27);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Amplitude Y";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 125);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Phase";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            // 
            // amplitude_y
            // 
            this.amplitude_y.BackColor = System.Drawing.Color.Transparent;
            this.amplitude_y.ImeMode = System.Windows.Forms.ImeMode.On;
            this.amplitude_y.Location = new System.Drawing.Point(88, 19);
            this.amplitude_y.Maximum = 300;
            this.amplitude_y.Name = "amplitude_y";
            this.amplitude_y.Size = new System.Drawing.Size(158, 45);
            this.amplitude_y.SmallChange = 10;
            this.amplitude_y.Style = MetroFramework.MetroColorStyle.Orange;
            this.amplitude_y.TabIndex = 28;
            this.amplitude_y.Text = "metroTrackBar1";
            this.amplitude_y.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.amplitude_y.Value = 200;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Frequency";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // freq_y
            // 
            this.freq_y.BackColor = System.Drawing.Color.Transparent;
            this.freq_y.ImeMode = System.Windows.Forms.ImeMode.On;
            this.freq_y.Location = new System.Drawing.Point(88, 68);
            this.freq_y.Maximum = 10;
            this.freq_y.Name = "freq_y";
            this.freq_y.Size = new System.Drawing.Size(158, 45);
            this.freq_y.TabIndex = 31;
            this.freq_y.Text = "metroTrackBar2";
            this.freq_y.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.freq_y.Value = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // drawingPlace
            // 
            this.drawingPlace.AccessibleDescription = "Drawing plane";
            this.drawingPlace.BackColor = System.Drawing.Color.Black;
            this.drawingPlace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawingPlace.BackgroundImage")));
            this.drawingPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPlace.ErrorImage = null;
            this.drawingPlace.InitialImage = null;
            this.drawingPlace.Location = new System.Drawing.Point(258, 58);
            this.drawingPlace.Name = "drawingPlace";
            this.drawingPlace.Size = new System.Drawing.Size(734, 604);
            this.drawingPlace.TabIndex = 0;
            this.drawingPlace.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(3, 27);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(20, 20);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "?";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 665);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawingPlace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lissayous Curve Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox drawingPlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTrackBar amplitude_y;
        private MetroFramework.Controls.MetroTrackBar amplitude_x;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar freq_x;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar phase_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTrackBar freq_y;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton drawButton;
        private MetroFramework.Controls.MetroTrackBar phase_y;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel equation_2;
        private MetroFramework.Controls.MetroLabel equation_1;
        private MetroFramework.Controls.MetroCheckBox live_preview_check_box;
        private MetroFramework.Controls.MetroCheckBox rotate_check_box;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
    }
}

