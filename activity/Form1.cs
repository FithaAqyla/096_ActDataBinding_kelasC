using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.adventureWorksDataSet1.Employee);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.adventureWorksDataSet.Employee);

        }
    }
}
