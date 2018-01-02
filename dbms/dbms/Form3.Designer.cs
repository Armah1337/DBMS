namespace dbms
{
    partial class Form3
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
            this.paramBox = new System.Windows.Forms.ComboBox();
            this.operatorBox = new System.Windows.Forms.ComboBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.paramBoxLabel = new System.Windows.Forms.Label();
            this.operatorBoxLabel = new System.Windows.Forms.Label();
            this.valueBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paramBox
            // 
            this.paramBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paramBox.FormattingEnabled = true;
            this.paramBox.Location = new System.Drawing.Point(12, 25);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(99, 21);
            this.paramBox.TabIndex = 1;
            this.paramBox.SelectedIndexChanged += new System.EventHandler(this.paramBox_SelectedIndexChanged);
            // 
            // operatorBox
            // 
            this.operatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorBox.FormattingEnabled = true;
            this.operatorBox.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<=",
            "!="});
            this.operatorBox.Location = new System.Drawing.Point(117, 25);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(62, 21);
            this.operatorBox.TabIndex = 2;
            this.operatorBox.SelectedIndexChanged += new System.EventHandler(this.operatorBox_SelectedIndexChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(185, 26);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 20);
            this.valueBox.TabIndex = 3;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(12, 60);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(87, 53);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Выполнить выборку";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(105, 60);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 53);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(198, 60);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 53);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить выборку";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // paramBoxLabel
            // 
            this.paramBoxLabel.AutoSize = true;
            this.paramBoxLabel.Location = new System.Drawing.Point(26, 9);
            this.paramBoxLabel.Name = "paramBoxLabel";
            this.paramBoxLabel.Size = new System.Drawing.Size(58, 13);
            this.paramBoxLabel.TabIndex = 7;
            this.paramBoxLabel.Text = "Параметр";
            // 
            // operatorBoxLabel
            // 
            this.operatorBoxLabel.AutoSize = true;
            this.operatorBoxLabel.Location = new System.Drawing.Point(120, 9);
            this.operatorBoxLabel.Name = "operatorBoxLabel";
            this.operatorBoxLabel.Size = new System.Drawing.Size(56, 13);
            this.operatorBoxLabel.TabIndex = 8;
            this.operatorBoxLabel.Text = "Оператор";
            // 
            // valueBoxLabel
            // 
            this.valueBoxLabel.AutoSize = true;
            this.valueBoxLabel.Location = new System.Drawing.Point(208, 10);
            this.valueBoxLabel.Name = "valueBoxLabel";
            this.valueBoxLabel.Size = new System.Drawing.Size(55, 13);
            this.valueBoxLabel.TabIndex = 9;
            this.valueBoxLabel.Text = "Значение";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 122);
            this.Controls.Add(this.valueBoxLabel);
            this.Controls.Add(this.operatorBoxLabel);
            this.Controls.Add(this.paramBoxLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.paramBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выборка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paramBox;
        private System.Windows.Forms.ComboBox operatorBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label paramBoxLabel;
        private System.Windows.Forms.Label operatorBoxLabel;
        private System.Windows.Forms.Label valueBoxLabel;
    }
}