using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace TestForm
{
    public partial class Form1 : Form
    {
        SearchProLineBLL sulb = new SearchProLineBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            dataGridView1.DataSource = sulb.ProLineGet(ProName.Text.Trim(),year.Text.Trim(), Type.Text.Trim(), Batch.Text.Trim());
            //dataGridView1.DataSource = sulb.ProLineGet(ProName.Text.Trim(),year.Text.Trim(),Type.Text.Trim(),Batch.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProLine pl = new ProLine();

            try
            {
                var cel = dataGridView1.Rows[e.RowIndex];
                pl.ProName = cel.Cells[0].Value.ToString();
                pl.Batch = cel.Cells[1].Value.ToString();
                pl.Type = cel.Cells[2].Value.ToString();
                pl.Year = cel.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
