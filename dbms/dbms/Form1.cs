using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class Form1 : Form
    {
        private Form2.Record recRef;
        public Form1()
        {
            InitializeComponent();
            dbGrid.DefaultCellStyle.BackColor = DefaultBackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 createBox = new Form2();
            createBox.FormClosing += HandleForm2Closing;
            createBox.createRecordButton.Click += HandleForm2CreateRecordClick;
            this.Enabled = false;
            createBox.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbGrid.SelectedRows.Count == 0)
            {
                toolStripStatusLabel1.Text = "Не выбрана запись для изменения";
                return;
            }
            Form2 changeBox = new Form2(dbGrid);
            changeBox.FormClosing += HandleForm2Closing;
            changeBox.createRecordButton.Click += HandleForm2ChangeRecordClick;
            this.Enabled = false;
            changeBox.Show();
        }

        public void HandleForm2Closing(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        public void HandleForm2CreateRecordClick(object sender, EventArgs e) {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            Form2 obj = (Form2)button.FindForm();
            recRef = obj.rec;
            if (recRef.Equals(default(Form2.Record))) return;
            dbGrid.Rows.Add(dbGrid.Rows.Count+1,recRef.BeltShape,recRef.MachineType,recRef.LoadPattern,recRef.DriveEngine,recRef.Dp1,recRef.Phi,
                            recRef.U,recRef.N,recRef.Xi,recRef.V,recRef.Chi,recRef.Dp2,recRef.S10,recRef.Q10,recRef.L0,recRef.A,recRef.L,
                            recRef.Afinal,recRef.Lst,recRef.Alpha1,recRef.Gamma1,recRef.C1,recRef.C3,recRef.CL,recRef.F,recRef.SigmaF0,
                            recRef.DeltaSigmaFI,recRef.DeltaSigmaF0,recRef.SigmaF,recRef.Z,recRef.Sigma0,recRef.Q0,recRef.R,recRef.Theta);
            toolStripStatusLabel1.Text = "Добавлена запись №" + dbGrid.Rows.Count;
        }

        public void HandleForm2ChangeRecordClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            Form2 obj = (Form2)button.FindForm();
            recRef = obj.rec;
            if (recRef.Equals(default(Form2.Record))) return;
            int index = dbGrid.CurrentCell.RowIndex;
            dbGrid["BeltShape", index].Value = recRef.BeltShape;
            dbGrid["MachineType", index].Value = recRef.MachineType;
            dbGrid["LoadPattern", index].Value = recRef.LoadPattern;
            dbGrid["DriveEngine", index].Value = recRef.DriveEngine;
            dbGrid["d_p1", index].Value = recRef.Dp1;
            dbGrid["phi", index].Value = recRef.Phi;
            dbGrid["u", index].Value = recRef.U;
            dbGrid["n", index].Value = recRef.N;
            dbGrid["xi", index].Value = recRef.Xi;
            dbGrid["v", index].Value = recRef.V;
            dbGrid["chi", index].Value = recRef.Chi;
            dbGrid["d_p2", index].Value = recRef.Dp2;
            dbGrid["s_10", index].Value = recRef.S10;
            dbGrid["q_10", index].Value = recRef.Q10;
            dbGrid["l_0", index].Value = recRef.L0;
            dbGrid["a", index].Value = recRef.A;
            dbGrid["l", index].Value = recRef.L;
            dbGrid["a_final", index].Value = recRef.Afinal;
            dbGrid["l_st", index].Value = recRef.Lst;
            dbGrid["alpha_1", index].Value = recRef.Alpha1;
            dbGrid["gamma_1", index].Value = recRef.Gamma1;
            dbGrid["c_1", index].Value = recRef.C1;
            dbGrid["c_3", index].Value = recRef.C3;
            dbGrid["c_l", index].Value = recRef.CL;
            dbGrid["f", index].Value = recRef.F;
            dbGrid["sigmaF_0", index].Value = recRef.SigmaF0;
            dbGrid["delta_sigmaF_i", index].Value = recRef.DeltaSigmaFI;
            dbGrid["delta_sigmaF_0", index].Value = recRef.DeltaSigmaF0;
            dbGrid["sigmaF", index].Value = recRef.SigmaF;
            dbGrid["z", index].Value = recRef.Z;
            dbGrid["sigma_0", index].Value = recRef.Sigma0;
            dbGrid["q_0", index].Value = recRef.Q0;
            dbGrid["r", index].Value = recRef.R;
            dbGrid["theta", index].Value = recRef.Theta;
            toolStripStatusLabel1.Text = "Изменена запись №" + (index+1);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.dbGrid.SelectedRows.Count;
            foreach (DataGridViewRow item in this.dbGrid.SelectedRows)
            {
                dbGrid.Rows.RemoveAt(item.Index);
            }
            if (count != 0) {
                if (count % 10 == 1) toolStripStatusLabel1.Text = "Удалена " + count + " запись";
                else if (count % 10 >= 2 && count % 10 <= 4) toolStripStatusLabel1.Text = "Удалены " + count + " записи";
                else toolStripStatusLabel1.Text = "Удалено " + count + " записей";
                foreach (DataGridViewRow row in dbGrid.Rows)
                    row.Cells["no"].Value = row.Index + 1;
            }
            else toolStripStatusLabel1.Text = "Нет записей для удаления";
        }

        private void выборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 selectBox = new Form3(dbGrid);
            selectBox.FormClosing += HandleForm2Closing;
            //SelectButtonCLicked event handler here
            this.Enabled = false;
            selectBox.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           System.IO.StreamWriter sw = new System.IO.StreamWriter("save_1.txt");
           sw.WriteLine(dbGrid.RowCount);
           foreach (DataGridViewRow row in dbGrid.Rows)
           {
             foreach (DataGridViewColumn col in dbGrid.Columns)
             {
               if (col.Name == "DriveEngine"){
                 sw.Write(row.Cells[col.Name].Value);
                 sw.Write("\0");
                 sw.WriteLine();
               }
               else sw.WriteLine(row.Cells[col.Name].Value);
             }
           }
           sw.Close();
           toolStripStatusLabel1.Text = "Сохранены записи.";
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Загрузка...";
            this.Enabled = false;
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("save_1.txt");

                int count = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    dbGrid.Rows.Insert(i);
                    foreach (DataGridViewColumn col in dbGrid.Columns)
                    {
                        if (col.Name == "DriveEngine")
                        {
                            string str = "";
                            while (true)
                            {
                                char c = (char)sr.Read();
                                if (c != '\0') str += c;
                                else break;
                            }
                            dbGrid[col.Name, i].Value = str;
                            sr.ReadLine();
                        }
                        else dbGrid[col.Name, i].Value = sr.ReadLine();
                    }
                }
                sr.Close();
                foreach (DataGridViewRow row in dbGrid.Rows)
                    row.Cells["no"].Value = row.Index + 1;
            }
            catch (System.IO.FileNotFoundException) { MessageBox.Show("Отсутствует файл для загрузки записей.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            toolStripStatusLabel1.Text = "Загружены записи.";
            this.Enabled = true;
        }
    }
}
