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
    public partial class Start : Form
    {
        BubbleTea b = new BubbleTea();
        public Start()
        {
            InitializeComponent();
        }

        private void bubbletea_Click(object sender, EventArgs e)
        {
            b.Show();
        }
    }
}
