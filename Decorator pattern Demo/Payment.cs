using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator_pattern_Demo
{
    
    public partial class Payment : Form
    {
        BubbleTea b = new BubbleTea();
        private string _totalprice;

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(string TotalPrice) : this()
        {
            _totalprice = TotalPrice;
            lbtotalCost.Text = _totalprice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
