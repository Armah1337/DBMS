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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dp1Box.Text = "N/A";
            phiBox.Text = "N/A";
            uBox.Text = Convert.ToString(uBar.Value / 100.0);
            nBox.Text = Convert.ToString(nBar.Value);
            vBox.Text = Convert.ToString(vBar.Value * 5);
            chiBox.Text = Convert.ToString(chiBar.Value / 1000.0);
            xiBox.Text = Convert.ToString(xiBar.Value / 10000.0);
            rec = new Record();
        }

        public Form2(DataGridView dbGrid)
        {
            InitializeComponent();
            this.Text = "Панель изменения записи";
            createRecordButton.Text = "Изменить запись";
            uBox.Text = Convert.ToString(uBar.Value / 100.0);
            nBox.Text = Convert.ToString(nBar.Value);
            vBox.Text = Convert.ToString(vBar.Value * 5);
            chiBox.Text = Convert.ToString(chiBar.Value / 1000.0);
            xiBox.Text = Convert.ToString(xiBar.Value / 10000.0);
            int index = dbGrid.CurrentCell.RowIndex;
            if (Convert.ToString(dbGrid["BeltShape", index].Value) == "К") {
              KBeltShapeRadio.Checked = true;
            }
            else {
              LBeltShapeRadio.Checked = true;             
            }
            dp1Bar.Value = Convert.ToInt32(dbGrid["d_p1", index].Value);
            phiBar.Value = Convert.ToInt32(Convert.ToSingle(dbGrid["phi", index].Value) * 100);
            if (Convert.ToString(dbGrid["LoadPattern", index]) == LoadPatternRadio1.Text) LoadPatternRadio1.Checked = true;
            else if (Convert.ToString(dbGrid["LoadPattern", index]) == LoadPatternRadio2.Text) LoadPatternRadio2.Checked = true;
            else if (Convert.ToString(dbGrid["LoadPattern", index]) == LoadPatternRadio3.Text) LoadPatternRadio3.Checked = true;
            else LoadPatternRadio4.Checked = true;
            if (Convert.ToString(dbGrid["DriveEngine", index]) == driveEngineRadio1.Text) driveEngineRadio1.Checked = true;
            else driveEngineRadio2.Checked = true;
            uBar.Value = Convert.ToInt32(Convert.ToSingle(dbGrid["u", index].Value) * 100);
            nBar.Value = Convert.ToInt32(Convert.ToSingle(dbGrid["n", index].Value) * 100);
            vBar.Value = Convert.ToInt32(dbGrid["v", index].Value) / 5;
            chiBar.Value = Convert.ToInt32(Convert.ToSingle(dbGrid["chi", index].Value) * 1000);
            xiBar.Value = Convert.ToInt32(Convert.ToSingle(dbGrid["xi", index].Value) * 10000);
            rec = new Record();
        }

        public struct Record
        {
            public string BeltShape { get; set; }
            public string LoadPattern { get; set; }
            public string MachineType { get; set; }
            public string DriveEngine { get; set; }
            public int Dp1 { get; set; }
            public float Phi { get; set; }
            public float U { get; set; }
            public float N { get; set; }
            public int V { get; set; }
            public float Chi { get; set; }
            public float Xi { get; set; }

            public float Dp2 { get; set; }
            public int S10 { get; set; }
            public float Q10 { get; set; }
            public float A { get; set; }
            public float L { get; set; }
            public int Lst { get; set; }
            public float Afinal { get; set; }
            public int L0 { get; set; }
            public double Alpha1 { get; set; }
            public double Gamma1 { get; set; }
            public float C1 { get; set; }
            public float C3 { get; set; }
            public float CL { get; set; }
            public double F { get; set; }
            public double SigmaF0 { get; set; }
            public float DeltaSigmaFI { get; set; }
            public float DeltaSigmaF0 { get; set; }
            public double SigmaF { get; set; }
            public int Z { get; set; }

            public double Sigma0 { get; set; }
            public double Q0 { get; set; }
            public double R { get; set; }
            public double Theta { get; set; }
        }

        public Record rec;

        private void Form2_FormClosing(Object sender, FormClosingEventArgs e) {

        }

        private void KBeltShapeRadio_CheckedChanged(object sender, EventArgs e)
        {
            dp1Bar.Minimum = 40;
            dp1Bar.Maximum = 250;
            dp1Bar.Value = dp1Bar.Minimum;
            dp1Box.Text = Convert.ToString(dp1Bar.Value);
            dp1Bar.Enabled = true;
            dp1Box.Enabled = true;
            dp1Label.Enabled = true;
            phiBar.Minimum = 75;
            phiBar.Maximum = 85;
            phiBar.Value = phiBar.Minimum;
            phiBox.Text = Convert.ToString(phiBar.Value / 100.0);
            phiBar.Enabled = true;
            phiBox.Enabled = true;
            phiLabel.Enabled = true;
        }

        private void LBeltShapeRadio_CheckedChanged(object sender, EventArgs e)
        {
            dp1Bar.Minimum = 80;
            dp1Bar.Maximum = 250;
            dp1Bar.Value = dp1Bar.Minimum;
            dp1Box.Text = Convert.ToString(dp1Bar.Value);
            dp1Bar.Enabled = true;
            dp1Box.Enabled = true;
            dp1Label.Enabled = true;
            phiBar.Minimum = 65;
            phiBar.Maximum = 75;
            phiBar.Value = phiBar.Minimum;
            phiBox.Text = Convert.ToString(phiBar.Value / 100.0);
            phiBar.Enabled = true;
            phiBox.Enabled = true;
            phiLabel.Enabled = true;
        }

        private void dp1Bar_ValueChanged(object sender, EventArgs e) {
            dp1Box.Text = Convert.ToString(dp1Bar.Value);
        }
        private void phiBar_ValueChanged(object sender, EventArgs e) {
            phiBox.Text = Convert.ToString(phiBar.Value / 100.0);
        }
        private void uBar_ValueChanged(object sender, EventArgs e)
        {
            uBox.Text = Convert.ToString(uBar.Value / 100.0);
        }
        private void nBar_ValueChanged(object sender, EventArgs e)
        {
            nBox.Text = Convert.ToString(nBar.Value/ 100.0);
        }
        private void vBar_ValueChanged(object sender, EventArgs e)
        {
            vBox.Text = Convert.ToString(vBar.Value * 5);
        }
        private void chiBar_ValueChanged(object sender, EventArgs e)
        {
            chiBox.Text = Convert.ToString(chiBar.Value / 1000.0);
        }
        private void xiBar_ValueChanged(object sender, EventArgs e)
        {
            xiBox.Text = Convert.ToString(xiBar.Value / 10000.0);
        }


        private void dp1Box_TextChanged(object sender, EventArgs e)
        {
            try {
                dp1Bar.Value = Convert.ToInt32(dp1Box.Text);
            }
            catch (Exception) {
                dp1Bar.Value = dp1Bar.Minimum;
            }
        }
        private void phiBox_TextChanged(object sender, EventArgs e)
        {
            try {
                phiBar.Value = Convert.ToInt32(Convert.ToSingle(phiBox.Text) * 100);
            }
            catch (Exception) {
                phiBar.Value = phiBar.Minimum;
            }
        }

        private void uBox_TextChanged(object sender, EventArgs e)
        {
            try {
                uBar.Value = Convert.ToInt32(Convert.ToSingle(uBox.Text) * 100);
            }
            catch (Exception) {
                uBar.Value = uBar.Minimum;
            }
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            try {
                nBar.Value = Convert.ToInt32(Convert.ToSingle(nBox.Text) * 100);
            }
            catch (Exception) {
                nBar.Value = nBar.Minimum;
            }
        }

        private void vBox_TextChanged(object sender, EventArgs e)
        {
            try {
                vBar.Value = Convert.ToInt32(vBox.Text) / 5;
            }
            catch (Exception) {
                vBar.Value = vBar.Minimum;
            }
        }

        private void chiBox_TextChanged(object sender, EventArgs e)
        {
            try {
                chiBar.Value = Convert.ToInt32(Convert.ToSingle(chiBox.Text) * 1000);
            }
            catch (Exception) {
                chiBar.Value = chiBar.Minimum;
            }
        }

        private void xiBox_TextChanged(object sender, EventArgs e)
        {
            try {
                xiBar.Value = Convert.ToInt32(Convert.ToSingle(xiBox.Text) * 10000);
            }
            catch (Exception) {
                xiBar.Value = xiBar.Minimum;
            }
        }

        private void LoadPatternRadio1_CheckedChanged(object sender, EventArgs e)
        {
            MachineTypeLabel.Enabled = true;
            machineTypeBox.Enabled = true;
            machineTypeBox.Text = "Ленточные транспортеры; станки с непрерывным процессом резания; токарные, сверлильные, шлифовальные";
        }

        private void LoadPatternRadio2_CheckedChanged(object sender, EventArgs e)
        {
            MachineTypeLabel.Enabled = true;
            machineTypeBox.Enabled = true;
            machineTypeBox.Text = "Пластинчатые транспортеры; станки-автоматы, фрезерные, зубофрезерные и револьверные станки";
        }

        private void LoadPatternRadio3_CheckedChanged(object sender, EventArgs e)
        {
            MachineTypeLabel.Enabled = true;
            machineTypeBox.Enabled = true;
            machineTypeBox.Text = "Реверсивные приводы; станки строгальные, долбежные и зубодолбежные; транспортеры винтовые и скребковые; элеваторы; винтовые и экспентриковые прессы с относительно тяжелыми маховиками";
        }

        private void LoadPatternRadio4_CheckedChanged(object sender, EventArgs e)
        {
            MachineTypeLabel.Enabled = true;
            machineTypeBox.Enabled = true;
            machineTypeBox.Text = "Подъемники; винтовые и эксцентриковые прессы с относительно легкими маховиками; ножницы, молоты, бегуны, мельницы";
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            string errorStr = "";
            if (KBeltShapeRadio.Checked) {
                rec.BeltShape = KBeltShapeRadio.Text;
                rec.S10 = 60;
                rec.Q10 = 0.09f;
                rec.L0 = 750;
            }
            else if (LBeltShapeRadio.Checked) {
                rec.BeltShape = LBeltShapeRadio.Text;
                rec.S10 = 330;
                rec.Q10 = 0.45f;
                rec.L0 = 1500;
            }
            else errorStr = "Не указан профиль ремня\n";

            if (machineTypeBox.Text != "") {
                rec.MachineType = machineTypeBox.Text;
                if (LoadPatternRadio1.Checked) rec.LoadPattern = LoadPatternRadio1.Text;
                else if (LoadPatternRadio2.Checked) rec.LoadPattern = LoadPatternRadio2.Text;
                else if (LoadPatternRadio3.Checked) rec.LoadPattern = LoadPatternRadio3.Text;
                else if (LoadPatternRadio4.Checked) rec.LoadPattern = LoadPatternRadio4.Text;
            }
            else errorStr += "Не указан тип машины\n";

            if (driveEngineRadio1.Checked) {
                rec.DriveEngine = driveEngineRadio1.Text;
                if (LoadPatternRadio1.Checked) rec.C3 = 1;
                else if (LoadPatternRadio2.Checked) rec.C3 = 0.9f;
                else if (LoadPatternRadio3.Checked) rec.C3 = 0.8f;
                else if (LoadPatternRadio4.Checked) rec.C3 = 0.7f;
            }
            else if (driveEngineRadio2.Checked) {
                rec.DriveEngine = driveEngineRadio2.Text;
                if (LoadPatternRadio1.Checked) rec.C3 = 0.9f;
                else if (LoadPatternRadio2.Checked) rec.C3 = 0.8f;
                else if (LoadPatternRadio3.Checked) rec.C3 = 0.7f;
                else if (LoadPatternRadio4.Checked) rec.C3 = 0.6f;
            }
            else errorStr += "Не указан приводной двигатель\n";
            if (errorStr.Length != 0) {
                MessageBox.Show(errorStr, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rec = new Record();
                return;
            }

            rec.Dp1 = dp1Bar.Value;
            rec.Phi = phiBar.Value / 100.0f;
            rec.U = uBar.Value / 100.0f;
            rec.N = nBar.Value / 100.0f;
            rec.V = vBar.Value * 5;
            rec.Chi = chiBar.Value / 1000f;
            rec.Xi = xiBar.Value / 10000f;

            rec.Dp2 = rec.Dp1 * rec.U * (1 - rec.Xi);
            rec.A = 2 * (rec.Dp1 + rec.Dp2);
            rec.L = Convert.ToSingle(2 * rec.A + Math.PI * (rec.Dp1 + rec.Dp2) / 2 + (rec.Dp2 - rec.Dp1) * (rec.Dp2 - rec.Dp1) / (4 * rec.A));
            int[] LstArray = {400,425,450,475,500,530,560,600,630,670,710,750,800,850,900,950,1000,1060,1120,1180,
                              1250,1320,1400,1500,1600,1700,1800,1900,2000,2120,2240,2360,2500,2650,2800,3000,3150,
                              3350,3550,3750,4000,4250,4500};
            foreach (int i in LstArray) 
                if (rec.L <= i) {
                    rec.Lst = i;
                    break;
                }
                if (rec.Lst == 0) rec.Lst = 4500;
                rec.Afinal = Convert.ToSingle((rec.Lst - Math.PI * (rec.Dp1 + rec.Dp2) / 2.0 +
                              Math.Pow(Math.Pow(rec.Lst - Math.PI * (rec.Dp1 + rec.Dp2) / 2.0, 2) -
                              8 * Math.Pow((rec.Dp2 - rec.Dp1) / 2.0, 2), (1 / 2.0))) / 4.0);
                rec.Alpha1 = Math.Acos((rec.Dp2 - rec.Dp1) / (2 * rec.Afinal)) * 2 * 180 / Math.PI;
                rec.Gamma1 = 180 - rec.Alpha1;
                Dictionary<uint, float> C1Table = new Dictionary<uint, float>();
                C1Table.Add(70, 0.56f);
                C1Table.Add(80, 0.62f);
                C1Table.Add(90, 0.68f);
                C1Table.Add(100, 0.74f);
                C1Table.Add(110, 0.79f);
                C1Table.Add(120, 0.83f);
                C1Table.Add(130, 0.87f);
                C1Table.Add(140, 0.9f);
                C1Table.Add(150, 0.93f);
                C1Table.Add(160, 0.96f);
                C1Table.Add(170, 0.98f);
                C1Table.Add(180, 1);
                foreach (uint deg in C1Table.Keys)
                    if (rec.Alpha1 <= deg)
                    {
                        rec.C1 = C1Table[deg];
                        break;
                    }
                if (rec.C1 == 0) rec.C1 = 1;
                Dictionary<float, float> CLTable = new Dictionary<float, float>();
                CLTable.Add(0.4f, float.NaN);
                CLTable.Add(0.5f, float.NaN);
                CLTable.Add(0.75f, float.NaN);
                CLTable.Add(1, 1);
                CLTable.Add(1.25f, float.NaN);
                CLTable.Add(1.5f, 1.05f);
                CLTable.Add(1.75f, float.NaN);
                CLTable.Add(2, 1.1f);
                CLTable.Add(2.5f, 1.15f);
                CLTable.Add(3, 1.2f);
                CLTable.Add(3.5f, 1.25f);
                foreach (float val in CLTable.Keys)
                    if (rec.Lst * 1.0 / rec.L0 <= val)
                    {
                        rec.CL = CLTable[val];
                        break;
                    }
                if (rec.CL == 0) rec.CL = 1.25f;
                else if (float.IsNaN(rec.CL)) rec.CL = 1;
                rec.F = 10 * 10 * 10 * rec.N / rec.V;
                Dictionary<Tuple<int, int, string>, float> SigmaF0Table = new Dictionary<Tuple<int, int, string>, float>();
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 5, "К"), 4.76f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 10, "К"), 4.08f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 15, "К"), 3.62f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 20, "К"), 3.15f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 25, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(40, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 5, "К"), 5.26f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 10, "К"), 4.58f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 15, "К"), 4.07f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 20, "К"), 3.66f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 25, "К"), 3.34f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(45, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 5, "К"), 5.6f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 10, "К"), 4.92f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 15, "К"), 4.53f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 20, "К"), 4.08f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 25, "К"), 3.61f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(50, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 5, "К"), 6.12f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 10, "К"), 5.22f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 15, "К"), 4.86f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 20, "К"), 4.42f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 25, "К"), 3.95f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 30, "К"), 3.51f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(56, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 5, "К"), 6.46f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 10, "К"), 5.77f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 15, "К"), 5.22f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 20, "К"), 4.85f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 25, "К"), 4.36f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 30, "К"), 3.86f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(63, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 5, "К"), 6.8f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 5, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 10, "К"), 6.1f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 10, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 15, "К"), 5.55f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 15, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 20, "К"), 5.1f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 20, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 25, "К"), 4.7f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 30, "К"), 4.18f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(71, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 5, "К"), 6.97f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 5, "Л"), 2.41f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 10, "К"), 6.28f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 10, "Л"), 1.98f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 15, "К"), 5.89f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 15, "Л"), 1.63f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 20, "К"), 5.44f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 20, "Л"), 1.28f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 25, "К"), 4.97f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 30, "К"), 4.48f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(80, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 5, "К"), 7.3f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 5, "Л"), 2.78f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 10, "К"), 6.62f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 10, "Л"), 2.35f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 15, "К"), 6.1f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 15, "Л"), 2);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 20, "К"), 5.7f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 20, "Л"), 1.67f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 25, "К"), 5.25f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 25, "Л"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 30, "К"), 4.76f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(90, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 5, "К"), 7.48f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 5, "Л"), 3.09f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 10, "К"), 6.8f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 10, "Л"), 2.66f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 15, "К"), 6.35f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 15, "Л"), 2.31f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 20, "К"), 5.86f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 20, "Л"), 1.97f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 25, "К"), 5.45f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 25, "Л"), 1.61f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 30, "К"), 4.93f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(100, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 5, "К"), 7.65f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 5, "Л"), 3.40f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 10, "К"), 6.96f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 10, "Л"), 2.96f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 15, "К"), 6.56f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 15, "Л"), 2.62f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 20, "К"), 6.11f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 20, "Л"), 2.27f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 25, "К"), 5.58f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 25, "Л"), 1.89f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 30, "К"), 5.15f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(112, 30, "Л"), float.NaN);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 5, "К"), 7.82f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 5, "Л"), 3.65f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 10, "К"), 7.15f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 10, "Л"), 3.21f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 15, "К"), 7.03f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 15, "Л"), 2.86f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 20, "К"), 6.45f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 20, "Л"), 2.52f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 25, "К"), 5.92f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 25, "Л"), 2.15f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 30, "К"), 5.38f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(125, 30, "Л"), 1.75f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 5, "К"), 8.1f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 5, "Л"), 3.89f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 10, "К"), 7.3f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 10, "Л"), 3.4f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 15, "К"), 7.03f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 15, "Л"), 3.09f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 20, "К"), 6.45f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 20, "Л"), 2.75f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 25, "К"), 5.98f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 25, "Л"), 2.37f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 30, "К"), 5.43f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(140, 30, "Л"), 1.96f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 5, "К"), 8.15f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 5, "Л"), 4.14f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 10, "К"), 7.5f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 10, "Л"), 3.71f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 15, "К"), 7.03f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 15, "Л"), 3.34f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 20, "К"), 6.45f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 20, "Л"), 3);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 25, "К"), 6.13f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 25, "Л"), 2.62f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 30, "К"), 5.78f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(160, 30, "Л"), 2.21f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 5, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 5, "Л"), 4.32f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 10, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 10, "Л"), 3.89f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 15, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 15, "Л"), 3.5f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 20, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 20, "Л"), 3.18f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 25, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 25, "Л"), 2.82f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(180, 30, "Л"), 2.41f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 5, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 5, "Л"), 4.45f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 10, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 10, "Л"), 4.02f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 15, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 15, "Л"), 3.69f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 20, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 20, "Л"), 3.34f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 25, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 25, "Л"), 2.97f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(200, 30, "Л"), 2.55f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 5, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 5, "Л"), 4.64f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 10, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 10, "Л"), 4.17f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 15, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 15, "Л"), 3.83f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 20, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 20, "Л"), 3.49f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 25, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 25, "Л"), 3.11f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(224, 30, "Л"), 2.7f);

                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 5, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 5, "Л"), 4.76f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 10, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 10, "Л"), 4.33f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 15, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 15, "Л"), 3.96f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 20, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 20, "Л"), 3.62f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 25, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 25, "Л"), 3.24f);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 30, "К"), float.NaN);
                SigmaF0Table.Add(Tuple.Create<int, int, string>(250, 30, "Л"), 2.83f);
                foreach (Tuple<int, int, string> key in SigmaF0Table.Keys)
                {
                    if (rec.Dp1 <= key.Item1)
                        if (rec.V == key.Item2)
                            if (rec.BeltShape == key.Item3)
                            {
                                rec.SigmaF0 = SigmaF0Table[key];
                            if (double.IsNaN(rec.SigmaF0))
                            {
                                List<KeyValuePair<Tuple<int, int, string>, float>> found =
                                                  SigmaF0Table.ToList().FindAll(x => x.Key.Item2 == rec.V && x.Key.Item3 == rec.BeltShape && !float.IsNaN(x.Value));
                                int dif = int.MaxValue, item1 = 0;
                                foreach (KeyValuePair<Tuple<int, int, string>, float> pair in found){
                                    if (Math.Abs(rec.Dp1 - pair.Key.Item1) < dif)
                                    {
                                        dif = Math.Abs(rec.Dp1 - pair.Key.Item1);
                                        item1 = pair.Key.Item1;
                                    }
                                    else break;
                                }
                                rec.SigmaF0 = SigmaF0Table[Tuple.Create(item1, rec.V, rec.BeltShape)];
                            }
                            }
                }
                Dictionary<Tuple<string, float>, float> DeltaSigmaFITable = new Dictionary<Tuple<string, float>, float>();
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("К", 1.05f), 0.05f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("К", 1.2f), 0.13f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("К", 1.5f), 0.17f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("К", 3f), 0.24f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("Л", 1.05f), 0.06f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("Л", 1.2f), 0.18f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("Л", 1.5f), 0.28f);
                DeltaSigmaFITable.Add(Tuple.Create<string, float>("Л", 3f), 0.35f);
                foreach (Tuple<string, float> key in DeltaSigmaFITable.Keys)
                {
                    if (rec.BeltShape == key.Item1)
                        if ((key.Item2 == 3f && rec.U >= key.Item2) || (key.Item2 == 1.5f && rec.U > key.Item2 && rec.U < 3f)
                            || (rec.U <= key.Item2))
                        {
                            rec.DeltaSigmaFI = DeltaSigmaFITable[key];
                            break;
                        }
                }
                rec.DeltaSigmaF0 = 100 * rec.DeltaSigmaFI / rec.Dp1;
                rec.SigmaF = (rec.SigmaF0 + rec.DeltaSigmaF0) * rec.C1 * rec.C3 * rec.CL;
                rec.Z = Convert.ToInt32(Math.Floor(10 * rec.F / (rec.S10 * rec.SigmaF)));

                rec.Sigma0 = 5 * rec.F / (rec.Phi * rec.C1 * rec.C3 * rec.CL * rec.S10 * rec.Z);
                rec.Q0 = (rec.Sigma0 * rec.S10 + (1 - rec.Chi) * rec.Q10 * rec.V * rec.V) * rec.Z / 10;
                rec.R = 2 * rec.Sigma0 * (rec.S10 / 10) * rec.Z * Math.Sin((rec.Alpha1 * Math.PI / 180) / 2);
                rec.Theta = Math.Atan((5 * rec.F / (rec.Sigma0 * rec.S10 * rec.Z)) * Math.Tan((rec.Gamma1 * Math.PI / 180) / 2)) * 180/Math.PI;
        }
    }
}
