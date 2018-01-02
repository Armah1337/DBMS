namespace dbms
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phiBox = new System.Windows.Forms.TextBox();
            this.dp1Box = new System.Windows.Forms.TextBox();
            this.phiBar = new System.Windows.Forms.TrackBar();
            this.phiLabel = new System.Windows.Forms.Label();
            this.dp1Bar = new System.Windows.Forms.TrackBar();
            this.dp1Label = new System.Windows.Forms.Label();
            this.LBeltShapeRadio = new System.Windows.Forms.RadioButton();
            this.KBeltShapeRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.machineTypeBox = new System.Windows.Forms.TextBox();
            this.MachineTypeLabel = new System.Windows.Forms.Label();
            this.LoadPatternRadio4 = new System.Windows.Forms.RadioButton();
            this.LoadPatternRadio3 = new System.Windows.Forms.RadioButton();
            this.LoadPatternRadio2 = new System.Windows.Forms.RadioButton();
            this.LoadPatternRadio1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.xiBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xiBar = new System.Windows.Forms.TrackBar();
            this.chiBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chiBar = new System.Windows.Forms.TrackBar();
            this.vBox = new System.Windows.Forms.TextBox();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.nBar = new System.Windows.Forms.TrackBar();
            this.uBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uBar = new System.Windows.Forms.TrackBar();
            this.createRecordButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.driveEngineRadio2 = new System.Windows.Forms.RadioButton();
            this.driveEngineRadio1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp1Bar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xiBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phiBox);
            this.groupBox1.Controls.Add(this.dp1Box);
            this.groupBox1.Controls.Add(this.phiBar);
            this.groupBox1.Controls.Add(this.phiLabel);
            this.groupBox1.Controls.Add(this.dp1Bar);
            this.groupBox1.Controls.Add(this.dp1Label);
            this.groupBox1.Controls.Add(this.LBeltShapeRadio);
            this.groupBox1.Controls.Add(this.KBeltShapeRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профиль ремня и зависимые параметры";
            // 
            // phiBox
            // 
            this.phiBox.Enabled = false;
            this.phiBox.Location = new System.Drawing.Point(199, 141);
            this.phiBox.Name = "phiBox";
            this.phiBox.Size = new System.Drawing.Size(52, 20);
            this.phiBox.TabIndex = 7;
            this.phiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phiBox.TextChanged += new System.EventHandler(this.phiBox_TextChanged);
            // 
            // dp1Box
            // 
            this.dp1Box.Enabled = false;
            this.dp1Box.Location = new System.Drawing.Point(199, 92);
            this.dp1Box.Name = "dp1Box";
            this.dp1Box.Size = new System.Drawing.Size(52, 20);
            this.dp1Box.TabIndex = 6;
            this.dp1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dp1Box.TextChanged += new System.EventHandler(this.dp1Box_TextChanged);
            // 
            // phiBar
            // 
            this.phiBar.Enabled = false;
            this.phiBar.Location = new System.Drawing.Point(9, 141);
            this.phiBar.Name = "phiBar";
            this.phiBar.Size = new System.Drawing.Size(184, 45);
            this.phiBar.TabIndex = 5;
            this.phiBar.ValueChanged += new System.EventHandler(this.phiBar_ValueChanged);
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Enabled = false;
            this.phiLabel.Location = new System.Drawing.Point(6, 124);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(120, 13);
            this.phiLabel.TabIndex = 4;
            this.phiLabel.Text = "Rоэффициент тяги φ0";
            // 
            // dp1Bar
            // 
            this.dp1Bar.Enabled = false;
            this.dp1Bar.Location = new System.Drawing.Point(7, 92);
            this.dp1Bar.Name = "dp1Bar";
            this.dp1Bar.Size = new System.Drawing.Size(184, 45);
            this.dp1Bar.TabIndex = 3;
            this.dp1Bar.ValueChanged += new System.EventHandler(this.dp1Bar_ValueChanged);
            // 
            // dp1Label
            // 
            this.dp1Label.AutoSize = true;
            this.dp1Label.Enabled = false;
            this.dp1Label.Location = new System.Drawing.Point(7, 75);
            this.dp1Label.Name = "dp1Label";
            this.dp1Label.Size = new System.Drawing.Size(187, 13);
            this.dp1Label.TabIndex = 2;
            this.dp1Label.Text = "Диаметр меньшего шкива Dp1, мм\r\n";
            // 
            // LBeltShapeRadio
            // 
            this.LBeltShapeRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.LBeltShapeRadio.AutoSize = true;
            this.LBeltShapeRadio.BackColor = System.Drawing.SystemColors.Control;
            this.LBeltShapeRadio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.LBeltShapeRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.LBeltShapeRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBeltShapeRadio.Location = new System.Drawing.Point(63, 28);
            this.LBeltShapeRadio.Name = "LBeltShapeRadio";
            this.LBeltShapeRadio.Size = new System.Drawing.Size(27, 25);
            this.LBeltShapeRadio.TabIndex = 1;
            this.LBeltShapeRadio.Text = "Л";
            this.LBeltShapeRadio.UseVisualStyleBackColor = false;
            this.LBeltShapeRadio.CheckedChanged += new System.EventHandler(this.LBeltShapeRadio_CheckedChanged);
            // 
            // KBeltShapeRadio
            // 
            this.KBeltShapeRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.KBeltShapeRadio.AutoSize = true;
            this.KBeltShapeRadio.BackColor = System.Drawing.SystemColors.Control;
            this.KBeltShapeRadio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.KBeltShapeRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.KBeltShapeRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KBeltShapeRadio.Location = new System.Drawing.Point(10, 28);
            this.KBeltShapeRadio.Name = "KBeltShapeRadio";
            this.KBeltShapeRadio.Size = new System.Drawing.Size(26, 25);
            this.KBeltShapeRadio.TabIndex = 0;
            this.KBeltShapeRadio.Text = "К";
            this.KBeltShapeRadio.UseVisualStyleBackColor = false;
            this.KBeltShapeRadio.CheckedChanged += new System.EventHandler(this.KBeltShapeRadio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.machineTypeBox);
            this.groupBox2.Controls.Add(this.MachineTypeLabel);
            this.groupBox2.Controls.Add(this.LoadPatternRadio4);
            this.groupBox2.Controls.Add(this.LoadPatternRadio3);
            this.groupBox2.Controls.Add(this.LoadPatternRadio2);
            this.groupBox2.Controls.Add(this.LoadPatternRadio1);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характер нагрузки";
            // 
            // machineTypeBox
            // 
            this.machineTypeBox.Enabled = false;
            this.machineTypeBox.Location = new System.Drawing.Point(81, 113);
            this.machineTypeBox.Multiline = true;
            this.machineTypeBox.Name = "machineTypeBox";
            this.machineTypeBox.ReadOnly = true;
            this.machineTypeBox.Size = new System.Drawing.Size(172, 66);
            this.machineTypeBox.TabIndex = 5;
            // 
            // MachineTypeLabel
            // 
            this.MachineTypeLabel.AutoSize = true;
            this.MachineTypeLabel.Enabled = false;
            this.MachineTypeLabel.Location = new System.Drawing.Point(7, 137);
            this.MachineTypeLabel.Name = "MachineTypeLabel";
            this.MachineTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.MachineTypeLabel.TabIndex = 4;
            this.MachineTypeLabel.Text = "Тип машины:";
            // 
            // LoadPatternRadio4
            // 
            this.LoadPatternRadio4.AutoSize = true;
            this.LoadPatternRadio4.Location = new System.Drawing.Point(7, 89);
            this.LoadPatternRadio4.Name = "LoadPatternRadio4";
            this.LoadPatternRadio4.Size = new System.Drawing.Size(249, 17);
            this.LoadPatternRadio4.TabIndex = 3;
            this.LoadPatternRadio4.Text = "Весьма неравномерная и ударная нагрузка";
            this.LoadPatternRadio4.UseVisualStyleBackColor = true;
            this.LoadPatternRadio4.CheckedChanged += new System.EventHandler(this.LoadPatternRadio4_CheckedChanged);
            // 
            // LoadPatternRadio3
            // 
            this.LoadPatternRadio3.AutoSize = true;
            this.LoadPatternRadio3.Location = new System.Drawing.Point(7, 66);
            this.LoadPatternRadio3.Name = "LoadPatternRadio3";
            this.LoadPatternRadio3.Size = new System.Drawing.Size(204, 17);
            this.LoadPatternRadio3.TabIndex = 2;
            this.LoadPatternRadio3.Text = "Значительные колебания нагрузки";
            this.LoadPatternRadio3.UseVisualStyleBackColor = true;
            this.LoadPatternRadio3.CheckedChanged += new System.EventHandler(this.LoadPatternRadio3_CheckedChanged);
            // 
            // LoadPatternRadio2
            // 
            this.LoadPatternRadio2.AutoSize = true;
            this.LoadPatternRadio2.Location = new System.Drawing.Point(7, 43);
            this.LoadPatternRadio2.Name = "LoadPatternRadio2";
            this.LoadPatternRadio2.Size = new System.Drawing.Size(191, 17);
            this.LoadPatternRadio2.TabIndex = 1;
            this.LoadPatternRadio2.Text = "Умеренные колебания нагрузки";
            this.LoadPatternRadio2.UseVisualStyleBackColor = true;
            this.LoadPatternRadio2.CheckedChanged += new System.EventHandler(this.LoadPatternRadio2_CheckedChanged);
            // 
            // LoadPatternRadio1
            // 
            this.LoadPatternRadio1.AutoSize = true;
            this.LoadPatternRadio1.Location = new System.Drawing.Point(7, 20);
            this.LoadPatternRadio1.Name = "LoadPatternRadio1";
            this.LoadPatternRadio1.Size = new System.Drawing.Size(129, 17);
            this.LoadPatternRadio1.TabIndex = 0;
            this.LoadPatternRadio1.Text = "Спокойная нагрузка";
            this.LoadPatternRadio1.UseVisualStyleBackColor = true;
            this.LoadPatternRadio1.CheckedChanged += new System.EventHandler(this.LoadPatternRadio1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.xiBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.xiBar);
            this.groupBox3.Controls.Add(this.chiBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chiBar);
            this.groupBox3.Controls.Add(this.vBox);
            this.groupBox3.Controls.Add(this.nBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.vBar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nBar);
            this.groupBox3.Controls.Add(this.uBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.uBar);
            this.groupBox3.Location = new System.Drawing.Point(277, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 434);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // xiBox
            // 
            this.xiBox.Location = new System.Drawing.Point(198, 388);
            this.xiBox.Name = "xiBox";
            this.xiBox.Size = new System.Drawing.Size(52, 20);
            this.xiBox.TabIndex = 19;
            this.xiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xiBox.TextChanged += new System.EventHandler(this.xiBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Коэффициент скольжения ремня ξ";
            // 
            // xiBar
            // 
            this.xiBar.Location = new System.Drawing.Point(9, 388);
            this.xiBar.Maximum = 200;
            this.xiBar.Minimum = 100;
            this.xiBar.Name = "xiBar";
            this.xiBar.Size = new System.Drawing.Size(184, 45);
            this.xiBar.TabIndex = 18;
            this.xiBar.Value = 100;
            this.xiBar.ValueChanged += new System.EventHandler(this.xiBar_ValueChanged);
            // 
            // chiBox
            // 
            this.chiBox.Location = new System.Drawing.Point(198, 295);
            this.chiBox.Name = "chiBox";
            this.chiBox.Size = new System.Drawing.Size(52, 20);
            this.chiBox.TabIndex = 16;
            this.chiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chiBox.TextChanged += new System.EventHandler(this.chiBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Коэффициент χ";
            // 
            // chiBar
            // 
            this.chiBar.Location = new System.Drawing.Point(9, 295);
            this.chiBar.Maximum = 250;
            this.chiBar.Minimum = 100;
            this.chiBar.Name = "chiBar";
            this.chiBar.Size = new System.Drawing.Size(184, 45);
            this.chiBar.TabIndex = 15;
            this.chiBar.Value = 100;
            this.chiBar.ValueChanged += new System.EventHandler(this.chiBar_ValueChanged);
            // 
            // vBox
            // 
            this.vBox.Location = new System.Drawing.Point(198, 206);
            this.vBox.Name = "vBox";
            this.vBox.Size = new System.Drawing.Size(52, 20);
            this.vBox.TabIndex = 13;
            this.vBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vBox.TextChanged += new System.EventHandler(this.vBox_TextChanged);
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(198, 116);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(52, 20);
            this.nBox.TabIndex = 13;
            this.nBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Скорость v, м/с";
            // 
            // vBar
            // 
            this.vBar.Location = new System.Drawing.Point(9, 206);
            this.vBar.Maximum = 6;
            this.vBar.Minimum = 1;
            this.vBar.Name = "vBar";
            this.vBar.Size = new System.Drawing.Size(184, 45);
            this.vBar.TabIndex = 12;
            this.vBar.Value = 1;
            this.vBar.ValueChanged += new System.EventHandler(this.vBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Мощность N, кВт";
            // 
            // nBar
            // 
            this.nBar.Location = new System.Drawing.Point(9, 116);
            this.nBar.Maximum = 5000;
            this.nBar.Minimum = 1;
            this.nBar.Name = "nBar";
            this.nBar.Size = new System.Drawing.Size(184, 45);
            this.nBar.TabIndex = 12;
            this.nBar.Value = 1;
            this.nBar.ValueChanged += new System.EventHandler(this.nBar_ValueChanged);
            // 
            // uBox
            // 
            this.uBox.Location = new System.Drawing.Point(198, 33);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(52, 20);
            this.uBox.TabIndex = 10;
            this.uBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uBox.TextChanged += new System.EventHandler(this.uBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Передаточное число u";
            // 
            // uBar
            // 
            this.uBar.Location = new System.Drawing.Point(9, 33);
            this.uBar.Maximum = 700;
            this.uBar.Minimum = 100;
            this.uBar.Name = "uBar";
            this.uBar.Size = new System.Drawing.Size(184, 45);
            this.uBar.TabIndex = 9;
            this.uBar.Value = 100;
            this.uBar.ValueChanged += new System.EventHandler(this.uBar_ValueChanged);
            // 
            // createRecordButton
            // 
            this.createRecordButton.Location = new System.Drawing.Point(277, 452);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(259, 96);
            this.createRecordButton.TabIndex = 3;
            this.createRecordButton.Text = "Создать запись";
            this.createRecordButton.UseVisualStyleBackColor = true;
            this.createRecordButton.Click += new System.EventHandler(this.createRecordButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.driveEngineRadio2);
            this.groupBox4.Controls.Add(this.driveEngineRadio1);
            this.groupBox4.Location = new System.Drawing.Point(13, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 148);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Привод двигателя";
            // 
            // driveEngineRadio2
            // 
            this.driveEngineRadio2.AutoSize = true;
            this.driveEngineRadio2.Location = new System.Drawing.Point(11, 104);
            this.driveEngineRadio2.Name = "driveEngineRadio2";
            this.driveEngineRadio2.Size = new System.Drawing.Size(242, 43);
            this.driveEngineRadio2.TabIndex = 11;
            this.driveEngineRadio2.Text = "II - электродвигатели переменного тока \r\nсинхронные, асинхронные с контактными \r\n" +
    "кольцами";
            this.driveEngineRadio2.UseVisualStyleBackColor = true;
            // 
            // driveEngineRadio1
            // 
            this.driveEngineRadio1.AutoSize = true;
            this.driveEngineRadio1.Location = new System.Drawing.Point(11, 29);
            this.driveEngineRadio1.Name = "driveEngineRadio1";
            this.driveEngineRadio1.Size = new System.Drawing.Size(226, 56);
            this.driveEngineRadio1.TabIndex = 10;
            this.driveEngineRadio1.Text = "I - электродвигатели постоянного тока,\r\nпеременного тока однофазные, \r\nпеременног" +
    "о тока асинхронные \r\nс короткозамкнутым ротором";
            this.driveEngineRadio1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 559);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.createRecordButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель создания записи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp1Bar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xiBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LBeltShapeRadio;
        private System.Windows.Forms.RadioButton KBeltShapeRadio;
        private System.Windows.Forms.TrackBar phiBar;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.TrackBar dp1Bar;
        private System.Windows.Forms.Label dp1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MachineTypeLabel;
        private System.Windows.Forms.RadioButton LoadPatternRadio4;
        private System.Windows.Forms.RadioButton LoadPatternRadio3;
        private System.Windows.Forms.RadioButton LoadPatternRadio2;
        private System.Windows.Forms.RadioButton LoadPatternRadio1;
        private System.Windows.Forms.TextBox machineTypeBox;
        private System.Windows.Forms.TextBox phiBox;
        private System.Windows.Forms.TextBox dp1Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox xiBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar xiBar;
        private System.Windows.Forms.TextBox chiBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar chiBar;
        private System.Windows.Forms.TextBox vBox;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar vBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar nBar;
        private System.Windows.Forms.TextBox uBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar uBar;
        public System.Windows.Forms.Button createRecordButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton driveEngineRadio2;
        private System.Windows.Forms.RadioButton driveEngineRadio1;
    }
}