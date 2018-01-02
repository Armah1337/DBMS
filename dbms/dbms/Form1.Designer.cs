namespace dbms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeltShape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpha_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamma_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigmaF_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delta_sigmaF_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delta_sigmaF_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigmaF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigma_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.выборкаToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.создатьToolStripMenuItem.Text = "Создать...";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // выборкаToolStripMenuItem
            // 
            this.выборкаToolStripMenuItem.Name = "выборкаToolStripMenuItem";
            this.выборкаToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.выборкаToolStripMenuItem.Text = "Выборка...";
            this.выборкаToolStripMenuItem.Click += new System.EventHandler(this.выборкаToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.обновитьToolStripMenuItem.Text = "Изменить...";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить...";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить...";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dbGrid
            // 
            this.dbGrid.AllowUserToAddRows = false;
            this.dbGrid.AllowUserToDeleteRows = false;
            this.dbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dbGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.BeltShape,
            this.MachineType,
            this.LoadPattern,
            this.DriveEngine,
            this.d_p1,
            this.phi,
            this.u,
            this.n,
            this.xi,
            this.v,
            this.chi,
            this.d_p2,
            this.s_10,
            this.q_10,
            this.l_0,
            this.a,
            this.l,
            this.a_final,
            this.l_st,
            this.alpha_1,
            this.gamma_1,
            this.c_1,
            this.c_3,
            this.c_l,
            this.f,
            this.sigmaF_0,
            this.delta_sigmaF_i,
            this.delta_sigmaF_0,
            this.sigmaF,
            this.z,
            this.sigma_0,
            this.q_0,
            this.r,
            this.theta});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dbGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dbGrid.Location = new System.Drawing.Point(13, 28);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.ReadOnly = true;
            this.dbGrid.RowHeadersVisible = false;
            this.dbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGrid.Size = new System.Drawing.Size(1014, 407);
            this.dbGrid.TabIndex = 1;
            // 
            // no
            // 
            this.no.HeaderText = "№";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 43;
            // 
            // BeltShape
            // 
            this.BeltShape.HeaderText = "BeltShape";
            this.BeltShape.Name = "BeltShape";
            this.BeltShape.ReadOnly = true;
            this.BeltShape.Width = 81;
            // 
            // MachineType
            // 
            this.MachineType.HeaderText = "MachineType";
            this.MachineType.Name = "MachineType";
            this.MachineType.ReadOnly = true;
            this.MachineType.Width = 97;
            // 
            // LoadPattern
            // 
            this.LoadPattern.HeaderText = "LoadPattern";
            this.LoadPattern.Name = "LoadPattern";
            this.LoadPattern.ReadOnly = true;
            this.LoadPattern.Width = 90;
            // 
            // DriveEngine
            // 
            this.DriveEngine.HeaderText = "DriveEngine";
            this.DriveEngine.Name = "DriveEngine";
            this.DriveEngine.ReadOnly = true;
            this.DriveEngine.Width = 90;
            // 
            // d_p1
            // 
            this.d_p1.HeaderText = "Dp1";
            this.d_p1.Name = "d_p1";
            this.d_p1.ReadOnly = true;
            this.d_p1.Width = 52;
            // 
            // phi
            // 
            this.phi.HeaderText = "φ";
            this.phi.Name = "phi";
            this.phi.ReadOnly = true;
            this.phi.Width = 40;
            // 
            // u
            // 
            this.u.HeaderText = "u";
            this.u.Name = "u";
            this.u.ReadOnly = true;
            this.u.Width = 38;
            // 
            // n
            // 
            this.n.HeaderText = "N";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Width = 40;
            // 
            // xi
            // 
            this.xi.HeaderText = "ξ";
            this.xi.Name = "xi";
            this.xi.ReadOnly = true;
            this.xi.Width = 37;
            // 
            // v
            // 
            this.v.HeaderText = "v";
            this.v.Name = "v";
            this.v.ReadOnly = true;
            this.v.Width = 38;
            // 
            // chi
            // 
            this.chi.HeaderText = "χ ";
            this.chi.Name = "chi";
            this.chi.ReadOnly = true;
            this.chi.Width = 39;
            // 
            // d_p2
            // 
            this.d_p2.HeaderText = "Dp2";
            this.d_p2.Name = "d_p2";
            this.d_p2.ReadOnly = true;
            this.d_p2.Width = 52;
            // 
            // s_10
            // 
            this.s_10.HeaderText = "S10";
            this.s_10.Name = "s_10";
            this.s_10.ReadOnly = true;
            this.s_10.Width = 51;
            // 
            // q_10
            // 
            this.q_10.HeaderText = "q10";
            this.q_10.Name = "q_10";
            this.q_10.ReadOnly = true;
            this.q_10.Width = 50;
            // 
            // l_0
            // 
            this.l_0.HeaderText = "L0";
            this.l_0.Name = "l_0";
            this.l_0.ReadOnly = true;
            this.l_0.Width = 44;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 38;
            // 
            // l
            // 
            this.l.HeaderText = "L";
            this.l.Name = "l";
            this.l.ReadOnly = true;
            this.l.Width = 38;
            // 
            // a_final
            // 
            this.a_final.HeaderText = "aok";
            this.a_final.Name = "a_final";
            this.a_final.ReadOnly = true;
            this.a_final.Width = 50;
            // 
            // l_st
            // 
            this.l_st.HeaderText = "Lst";
            this.l_st.Name = "l_st";
            this.l_st.ReadOnly = true;
            this.l_st.Width = 46;
            // 
            // alpha_1
            // 
            this.alpha_1.HeaderText = "α1";
            this.alpha_1.Name = "alpha_1";
            this.alpha_1.ReadOnly = true;
            this.alpha_1.Width = 45;
            // 
            // gamma_1
            // 
            this.gamma_1.HeaderText = "γ1";
            this.gamma_1.Name = "gamma_1";
            this.gamma_1.ReadOnly = true;
            this.gamma_1.Width = 44;
            // 
            // c_1
            // 
            this.c_1.HeaderText = "C1";
            this.c_1.Name = "c_1";
            this.c_1.ReadOnly = true;
            this.c_1.Width = 45;
            // 
            // c_3
            // 
            this.c_3.HeaderText = "C3";
            this.c_3.Name = "c_3";
            this.c_3.ReadOnly = true;
            this.c_3.Width = 45;
            // 
            // c_l
            // 
            this.c_l.HeaderText = "CL";
            this.c_l.Name = "c_l";
            this.c_l.ReadOnly = true;
            this.c_l.Width = 45;
            // 
            // f
            // 
            this.f.HeaderText = "F";
            this.f.Name = "f";
            this.f.ReadOnly = true;
            this.f.Width = 38;
            // 
            // sigmaF_0
            // 
            this.sigmaF_0.HeaderText = "[σF]0";
            this.sigmaF_0.Name = "sigmaF_0";
            this.sigmaF_0.ReadOnly = true;
            this.sigmaF_0.Width = 57;
            // 
            // delta_sigmaF_i
            // 
            this.delta_sigmaF_i.HeaderText = "Δ[σF]и";
            this.delta_sigmaF_i.Name = "delta_sigmaF_i";
            this.delta_sigmaF_i.ReadOnly = true;
            this.delta_sigmaF_i.Width = 64;
            // 
            // delta_sigmaF_0
            // 
            this.delta_sigmaF_0.HeaderText = "Δ[σF]0";
            this.delta_sigmaF_0.Name = "delta_sigmaF_0";
            this.delta_sigmaF_0.ReadOnly = true;
            this.delta_sigmaF_0.Width = 64;
            // 
            // sigmaF
            // 
            this.sigmaF.HeaderText = "[σF]";
            this.sigmaF.Name = "sigmaF";
            this.sigmaF.ReadOnly = true;
            this.sigmaF.Width = 51;
            // 
            // z
            // 
            this.z.HeaderText = "Z";
            this.z.Name = "z";
            this.z.ReadOnly = true;
            this.z.Width = 39;
            // 
            // sigma_0
            // 
            this.sigma_0.HeaderText = "σ0";
            this.sigma_0.Name = "sigma_0";
            this.sigma_0.ReadOnly = true;
            this.sigma_0.Width = 45;
            // 
            // q_0
            // 
            this.q_0.HeaderText = "Q0";
            this.q_0.Name = "q_0";
            this.q_0.ReadOnly = true;
            this.q_0.Width = 46;
            // 
            // r
            // 
            this.r.HeaderText = "R";
            this.r.Name = "r";
            this.r.ReadOnly = true;
            this.r.Width = 40;
            // 
            // theta
            // 
            this.theta.HeaderText = "θ";
            this.theta.Name = "theta";
            this.theta.ReadOnly = true;
            this.theta.Width = 38;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Enabled = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 452);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиноременная передача.  Проверочный расчёт для поликлиновых ремней.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem выборкаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeltShape;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveEngine;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phi;
        private System.Windows.Forms.DataGridViewTextBoxColumn u;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn v;
        private System.Windows.Forms.DataGridViewTextBoxColumn chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn q_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn l;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamma_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigmaF_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn delta_sigmaF_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn delta_sigmaF_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigmaF;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigma_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn q_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn r;
        private System.Windows.Forms.DataGridViewTextBoxColumn theta;
    }
}

