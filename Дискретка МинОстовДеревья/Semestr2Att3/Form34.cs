using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Windows.Forms;
using System.IO;
using ClassLibraryGrafh;
namespace Semestr2Att3
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void buttonReadGraf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                try
                {
                    string st = reader.ReadLine();
                    int j = 0;
                    while (st != null && st != "")
                    {
                        string[] str = st.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (j == 0)
                        {
                            dataGridViewGraf.ColumnCount = str.Length;
                            dataGridViewGraf.RowCount = str.Length;
                        }
                        if (str.Length != dataGridViewGraf.ColumnCount)
                        {
                            throw new Exception();
                        }
                        for (int i = 0; i < str.Length; i++)
                        {
                            dataGridViewGraf[i, j].Value = str[i];
                        }
                        st = reader.ReadLine();
                        j++;
                    }
                    for (int i = 0; i < dataGridViewGraf.ColumnCount; i++)
                    {
                        dataGridViewGraf.Columns[i].HeaderCell.Value = i.ToString();
                        dataGridViewGraf.Columns[i].Width = 30;
                    }
                    for (int i = 0; i < dataGridViewGraf.RowCount; i++)
                    {
                        dataGridViewGraf.Rows[i].HeaderCell.Value = i.ToString();
                        dataGridViewGraf.Rows[i].Height = 30;
                    }
                    reader.Close();

                    for (int i=0;i< dataGridViewGraf.RowCount;i++)
                    {
                        for (int k = 0; k < dataGridViewGraf.ColumnCount; k++)
                        {
                            dataGridViewGraf[k, i].Value = dataGridViewGraf[i, k].Value;
                        }
                    }

                        Build();
                }
                catch
                {
                    reader.Close();
                    dataGridViewGraf.Rows.Clear();
                    dataGridViewGraf.ColumnCount = 0;
                    MessageBox.Show("Неверные входные данные");
                }

            }
        }
        Grafh c;
        public void Build()
        {
            try
            {
                int[,] a = new int[dataGridViewGraf.RowCount, dataGridViewGraf.ColumnCount];
                for (int i = 0; i < dataGridViewGraf.RowCount; i++)
                    for (int j = 0; j < dataGridViewGraf.ColumnCount; j++)
                    {
                        if (i == j && Convert.ToInt32(dataGridViewGraf[j, i].Value) != 0)
                            throw new Exception();
                        a[i, j] = Convert.ToInt32(dataGridViewGraf[j, i].Value);
                    }
                if (dataGridViewGraf.ColumnCount != 0)
                {
                    c = new Grafh();
                    c.CreateGrafh(a);
                }
            }
            catch
            {
                c = null;
                MessageBox.Show("Исходная матрица составлена неправильно");
            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                FormGrapfhDraw form = new FormGrapfhDraw();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Постройте граф");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            dataGridViewGraf.ColumnCount++;
            dataGridViewGraf.RowCount++;
            dataGridViewGraf.Columns[dataGridViewGraf.ColumnCount - 1].HeaderCell.Value = (dataGridViewGraf.ColumnCount-1).ToString();
            dataGridViewGraf.Columns[dataGridViewGraf.ColumnCount - 1].Width = 30;
            dataGridViewGraf.Rows[dataGridViewGraf.RowCount-1].HeaderCell.Value =(dataGridViewGraf.RowCount - 1).ToString();
            dataGridViewGraf.Rows[dataGridViewGraf.RowCount - 1].Height = 30;
            Build();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewGraf.ColumnCount != 0 && dataGridViewGraf.RowCount != 0)
            {
                dataGridViewGraf.ColumnCount--;
                dataGridViewGraf.RowCount--;
                Build();
            }
        }

        private void dataGridViewGraf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Build();
        }
        private void buttonBilder_Click(object sender, EventArgs e)
        {
            if(radioButtonPrim.Checked)
            {
                c.Prim();
            }
            else
            {
                if (radioButtonKra.Checked)
                {
                    c.Krascal();
                }
                else
                {
                    MessageBox.Show("Выберите способ");
                }
            }
        }
    }
}
