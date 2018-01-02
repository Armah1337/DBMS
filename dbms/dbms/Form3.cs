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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(DataGridView dbGrid): this()
        {
            dbGridRef = dbGrid;
            columnNameTable = new Dictionary<string, string>();
            selectedRowsIndices = new List<int>();
            string[] colNames = new string[dbGridRef.Columns.Count];
            int i = 0;
            foreach (DataGridViewColumn col in dbGridRef.Columns)
            {
                colNames[i] = col.HeaderText;
                columnNameTable.Add(col.HeaderText, col.Name);
                i++;
            }
            paramBox.Items.AddRange(colNames);
        }
        private DataGridView dbGridRef;
        private Dictionary<string, string> columnNameTable;
        public List<int> selectedRowsIndices;

        private void SelectButton_Click(object sender, EventArgs e)
        {
            string errLog = "";
            if (paramBox.SelectedItem == null)
            {
                errLog += "Выберите параметр.\n";
            }
            if (operatorBox.SelectedItem == null)
            {
                errLog += "Выберите оператор.\n";
            }
            if (valueBox.Text == "")
            {
                errLog += "Выберите значение.\n";
            }
            if (errLog != "") {
                MessageBox.Show(errLog, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dbGridRef.DefaultCellStyle.BackColor = DefaultBackColor;
            selectedRowsIndices.Clear();
            string paramName = columnNameTable[Convert.ToString(paramBox.SelectedItem)];
            foreach (DataGridViewRow row in dbGridRef.Rows)
            {
                try { 
                if (Convert.ToString(operatorBox.SelectedItem) == ">" && Convert.ToDouble(row.Cells[paramName].Value) > Convert.ToDouble(valueBox.Text)) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                }
                else if (Convert.ToString(operatorBox.SelectedItem) == "<" && Convert.ToDouble(row.Cells[paramName].Value) < Convert.ToDouble(valueBox.Text)) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                    }
                else if (Convert.ToString(operatorBox.SelectedItem) == ">=" && Convert.ToDouble(row.Cells[paramName].Value) >= Convert.ToDouble(valueBox.Text)) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                    }
                else if (Convert.ToString(operatorBox.SelectedItem) == "<=" && Convert.ToDouble(row.Cells[paramName].Value) <= Convert.ToDouble(valueBox.Text)) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                    }
                else if (Convert.ToString(operatorBox.SelectedItem) == "=") {
                    if (paramBox.SelectedIndex > 0 && paramBox.SelectedIndex < 5)
                    {
                        if (Convert.ToString(row.Cells[paramName].Value) == Convert.ToString(valueBox.Text)) row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                        }
                    else
                    {
                        if (Convert.ToDouble(row.Cells[paramName].Value) == Convert.ToDouble(valueBox.Text)) row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                        }
                }
                else if (Convert.ToString(operatorBox.SelectedItem) == "!=")
                {
                    if (paramBox.SelectedIndex > 0 && paramBox.SelectedIndex < 5)
                    {
                        if (Convert.ToString(row.Cells[paramName].Value) != Convert.ToString(valueBox.Text)) row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                        }
                    else
                    {
                        if (Convert.ToDouble(row.Cells[paramName].Value) != Convert.ToDouble(valueBox.Text)) row.DefaultCellStyle.BackColor = Color.LightGreen; selectedRowsIndices.Add(row.Index);
                        }
                }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Недопустимое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dbGridRef.ClearSelection();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dbGridRef.DefaultCellStyle.BackColor = DefaultBackColor;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("save_2.txt");
            /*sw.WriteLine(dbGridRef.RowCount);
            foreach (DataGridViewRow row in dbGrid.Rows)
            {
                foreach (DataGridViewColumn col in dbGrid.Columns)
                {
                    if (col.Name == "DriveEngine")
                    {
                        sw.Write(row.Cells[col.Name].Value);
                        sw.Write("\0");
                        sw.WriteLine();
                    }
                    else sw.WriteLine(row.Cells[col.Name].Value);
                }
            }*/
            foreach (int index in selectedRowsIndices)
            {
                DataGridViewRow row = dbGridRef.Rows[index];
                sw.WriteLine("Запись №" + (index + 1));
                foreach (DataGridViewColumn col in dbGridRef.Columns)
                {
                    sw.Write(col.HeaderText + " - ");
                    /*if (col.Name == "DriveEngine")
                    {
                        sw.Write(row.Cells[col.Name].Value);
                        sw.Write("\0");
                        sw.WriteLine();
                    }
                    else */
                    sw.Write(row.Cells[col.Name].Value);
                    sw.WriteLine();
                }
            }
            sw.Close();
        }

        private void operatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paramBox.SelectedIndex > 0 && paramBox.SelectedIndex < 5 && operatorBox.SelectedIndex != 2 && operatorBox.SelectedIndex != 5) {
                //MessageBox.Show("Для данного параметра доступны только оператор \"=\" и \"!=\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                operatorBox.SelectedIndex = 2;
            }
        }

        private void paramBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paramBox.SelectedIndex > 0 && paramBox.SelectedIndex < 5 && operatorBox.SelectedIndex != 2 && operatorBox.SelectedIndex != 5)
            {
                //MessageBox.Show("Для данного параметра доступны только оператор \"=\" и \"!=\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                operatorBox.SelectedIndex = 2;
            }
        }
    }
}
