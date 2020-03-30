using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Gauss
{
	//
    public partial class Form1 : Form
    {
        public int kolPerem = 2;
        public int kolUravn = 2;
        public Form1()
        {
            InitializeComponent();
        }
       private MethodGaussa CopyToGauss()
        {
            MethodGaussa methodGaussa = new MethodGaussa(kolUravn, kolPerem + 1);

            for (int j = 0; j < kolUravn; j++)
            {
                for (int i = 1; i <= kolPerem; i++)
                {
                    methodGaussa.matrix[j][i - 1] = Convert.ToDouble(dataGridView1["colA" + i, j].Value);
                }
                methodGaussa.matrix[j][kolPerem] = Convert.ToDouble(dataGridView1["colB", j].Value);
            }
            return methodGaussa;
        }
       private  void CopyFromGauss(MethodGaussa methodGaussa)
        {
            numericUpDown1.Value = methodGaussa.curKolPerem;

            for (int j = 0; j < kolUravn; j++)
            {
                for (int i = 1; i <= kolPerem; i++)
                {
                   dataGridView1["colA" + i, j].Value = Convert.ToString(methodGaussa.matrix[j][i - 1]);
                }
                dataGridView1["colB", j].Value = Convert.ToString(methodGaussa.matrix[j][kolPerem]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(numericUpDown1, new EventArgs());
            numericUpDown2_ValueChanged(numericUpDown1, new EventArgs());
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//кол-во переменных
        {
            dataGridView1.Columns.Clear();
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                dataGridView1.Columns.Add("colA" + i, "a" + i);
                dataGridView1.Columns.Add("colX" + i, "x" + i);
                dataGridView1.Columns["colX" + i].ReadOnly = true;
                dataGridView1.Columns["colX" + i].DefaultCellStyle.BackColor = Color.LightGray;
                if (i < numericUpDown1.Value)
                {
                    dataGridView1.Columns.Add("colZ" + i, "");
                    dataGridView1.Columns["colZ" + i].ReadOnly = true;
                    dataGridView1.Columns["colZ" + i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            dataGridView1.Columns.Add("colZ", "");
            dataGridView1.Columns["colZ"].ReadOnly = true;
            dataGridView1.Columns["colZ"].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns.Add("colB", "b");
            numericUpDown2_ValueChanged(numericUpDown1, new EventArgs());

            kolPerem = Convert.ToInt32(numericUpDown1.Value);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)//кол-во уравнений
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    if (i < numericUpDown1.Value)
                        dataGridView1["colZ" + i, j].Value = "+";
                    dataGridView1["colX" + i, j].Value = dataGridView1.Columns["colX" + i].HeaderText;
                }
                dataGridView1["colZ", j].Value = "=";
            }
            kolUravn = Convert.ToInt32(numericUpDown1.Value);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtbox = e.Control as TextBox;
            if (txtbox != null)
            {
                txtbox.KeyPress += new KeyPressEventHandler(txtbox_KeyPress);
                txtbox.Enter += new EventHandler(txtbox_Enter);
            }
        }

        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtbox = sender as TextBox;

            if (e.KeyChar == 46) //точку заменяем на запятую
                e.KeyChar = ',';

            e.Handled = true;

            if ((e.KeyChar > 48 && e.KeyChar <= 57) || e.KeyChar == 8) //числа (кроме нуля)  и клавиша Backspace
                e.Handled = false;

            if (e.KeyChar == 44 && (txtbox.Text.Length != 0 && !txtbox.Text.Contains(","))) //дробные числа
                e.Handled = false;

            if (e.KeyChar == 45  && (txtbox.Text.Length == 0 || txtbox.SelectedText == txtbox.Text)) //отрицательные числа
                e.Handled = false;

            if (e.KeyChar == 48 && (txtbox.Text != "-" && txtbox.Text != "")) //ноль в начела числа
                e.Handled = false;
            
        }
        private void txtbox_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;

            if (txtbox.Text == "0")//заменяем "0" на "" при вводе числа
            {
                txtbox.Text = "";
            }  
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //если число не было введено, возвращаем ячейки значение 0
            if (dataGridView1.CurrentCell.Value != null)
                if (dataGridView1.CurrentCell.Value.ToString() == "" || dataGridView1.CurrentCell.Value.ToString() == "-")
                {
                    dataGridView1.CurrentCell.Value = "0";
                }
        }

        MethodGaussa gauss = new MethodGaussa();
        private void button1_Click(object sender, EventArgs e)
        {
            MethodGaussa gaussAuto = new MethodGaussa();

            gaussAuto = CopyToGauss();
            string str = "";

            str += "Рассширенная матрица системы: \n\n";
            str += gaussAuto.MatrToStr() + "\n";

            str += gaussAuto.AutoRezult();

            str += "С помощью элементарных преобразований получаем матрицу: \n\n";
            str += gaussAuto.MatrToStr() + "\n";
            str += "Ответ: ";

            if (!gaussAuto.IsResultExist())
                str += " система несовместна (не имеет решений)\n";
            else
                if (!gaussAuto.IsFindRez())
                    str += " система имеет бесконечно много решений\n";
                else
                    str += gaussAuto.XtoStr();


            lblAutoRezult.Text = str;
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblMatr.Text.Trim() == "")
            {
                gauss = CopyToGauss();
                lblMatr.Text = "Рассширенная матрица системы: \n\n";
                lblMatr.Text += gauss.MatrToStr() + "\n";

                numRow1.Maximum = numericUpDown1.Value;
                numRow2.Maximum = numericUpDown1.Value;
            }
            else
            if (MessageBox.Show("Очистить решение и скопировать исходную матрицу?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                gauss = CopyToGauss();
                lblMatr.Text = "Рассширенная матрица системы: \n\n";
                lblMatr.Text += gauss.MatrToStr() + "\n";

                numRow1.Maximum = numericUpDown1.Value;
                numRow2.Maximum = numericUpDown1.Value;
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int str1 = Convert.ToInt32(numRow1.Value - 1);
            int str2 = Convert.ToInt32(numRow2.Value - 1);
            double num = 1;
            try
            {
                num = Convert.ToDouble(textBoxX.Text);
            }
            catch { }
            if (rdBtnEchangeRows.Checked == true)
            {
                gauss.ExchangeRow(str1,str2);
                lblMatr.Text += "Поменять местами строки " + numRow1.Value + " и " + numRow2.Value;
            }

            if (rdBtnAddRowToRow.Checked == true)
            {
                gauss.AddRowToRow(str1, str2, num);
                lblMatr.Text += "К строке " + numRow1.Value + " прибавить строку " + numRow2.Value + " умн. на " + num;
            }

            if (rdBtnMultRow.Checked == true)
            {
                gauss.MultiplyRow(str1, num);
                lblMatr.Text += "Умножить строку " + numRow1.Value + " на " + num;
            }
            if (rdBtnDiv.Checked == true)
            {
                gauss.DivideRow(str1, num);
                lblMatr.Text += "Разделить строку " + numRow1.Value + " на " + num;
            }
            if (rdBtnDelRows.Checked == true)
            {
                gauss.DelAllZeroRow();
                lblMatr.Text += "Удалить нулевые строки";
                numRow1.Maximum = gauss.curKolUravn;
                numRow2.Maximum = gauss.curKolUravn;
            }
            if (rdBtnBackWay.Checked == true)
            {
                gauss.BackWay();
                lblMatr.Text += "Ответ: " + gauss.XtoStr() + "\n";
            }
            else
                lblMatr.Text += " ===>\n" + gauss.MatrToStr() + "\n";

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Clipboard.SetText(lblAutoRezult.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblMatr.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Matr";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                Serialize(CopyToGauss(), saveFileDialog1.FileName);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                CopyFromGauss(Deserialize(openFileDialog1.FileName));
        }
        public static void Serialize(MethodGaussa dataGridView, string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MethodGaussa));
            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, dataGridView);
                xml = stringWriter.ToString();
            }
            File.WriteAllText(file, xml, Encoding.Default);
        }

        public static MethodGaussa Deserialize(string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MethodGaussa));
            MethodGaussa list;
            using (StreamReader sr = new StreamReader(file))
            {
                list = (MethodGaussa)xmlSerializer.Deserialize(sr);
            }
            return list;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить решение?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lblAutoRezult.Text = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить решение?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                lblMatr.Text = null;
            }
        }

        private void rdBtnDelRows_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
