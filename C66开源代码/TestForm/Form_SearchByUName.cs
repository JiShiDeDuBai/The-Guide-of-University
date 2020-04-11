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
using DAL;

namespace TestForm
{
    public partial class Form_SearchByUName : Form
    {
        SearchUniversityLineBLL sulb = new SearchUniversityLineBLL();

        public Form_SearchByUName()
        {
            InitializeComponent();
        }

        private void Form_SearchByUName_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sulb.UniversityNameGet(textBox1.Text.Trim());
        }
    }
}
