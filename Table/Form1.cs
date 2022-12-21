using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ДабавитьДисциплину_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(textBox1.Text, textBox1.Text);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            bool five = true;

             for (int i = 1; i < dataGridView1.Rows.Count-1; i++)
             {
                 for (int j = 2; j < dataGridView1.Rows[i].Cells.Count-1; j++)
                 {
                     if (Convert.ToInt32(dataGridView1.Rows[i].Cells[j]) < 4)
                     {
                         five = false;
                     }
                 }

                 if (five == true)
                 {
                     listBox1.Items.Add(dataGridView1.Rows[i].Cells[1]);
                 }
                 else
                 {
                     five = true;
                 }
             }*/
            bool five = true;

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                for (int y = 3; y < dataGridView1.ColumnCount; y++)
                {
                    if (dataGridView1[y, i].Value != null)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[y].Value) < 4)
                        {
                            five = false;
                        }
                    }
                }

                if (five == true)
                {
                    listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                }
                else
                {
                    five = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
