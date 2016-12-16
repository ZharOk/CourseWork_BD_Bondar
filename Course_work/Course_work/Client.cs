using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        /* */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        DataView ClientDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(sportomplexBDDataSet1.Client);

            ClientDataView = new DataView(sportomplexBDDataSet1.Client);

            dataGridView1.DataSource = ClientDataView;

            ClientDataView.Sort = SortTextBox.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(sportomplexBDDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientDataView.Sort = SortTextBox.Text;
            ClientDataView.RowFilter = FilterTextBox.Text;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
            if (e.ColumnIndex == 1) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
            if (e.ColumnIndex == 2) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
            if (e.ColumnIndex == 3) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
          /*  if (e.ColumnIndex == 4) 
            {
                int temp = 0;
                if (!Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }*/

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
