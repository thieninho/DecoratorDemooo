using Decorator_pattern_Demo.Decorator;
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
    public partial class BubbleTea : Form
    {
        public BubbleTea()
        {
            InitializeComponent();
            //create a Black sugar, Bubble, Flan cake milk tea
            //var ourMilkTea = new BlackSugar(
            //                    new Bubble(
            //                        new FlanCake(
            //                            new MilkTea())));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeMilkTea(new MilkTea());
                    
        }
        private IMilkTea makeMilkTea(IMilkTea milkTea)
        {
            if (cbBubble.Checked)
            {
                milkTea = new Bubble(milkTea);
                cbBubble.Checked = false;
                return makeMilkTea(milkTea);
            }
            if (cbBlackSugar.Checked)
            {
                milkTea = new BlackSugar(milkTea);
                cbBlackSugar.Checked = false;
                return makeMilkTea(milkTea);
            }
            if (cbFlanCake.Checked)
            {
                milkTea = new FlanCake(milkTea);
                cbFlanCake.Checked = false;
                return makeMilkTea(milkTea);
            }
            if (cbFruitPudding.Checked)
            {
                milkTea = new FruitPudding(milkTea);
                cbFruitPudding.Checked = false;
                return makeMilkTea(milkTea);
            }
            if (cbJelly.Checked)
            {
                milkTea = new Jelly(milkTea);
                cbJelly.Checked = false;
                return makeMilkTea(milkTea);
            }
            else
            {
                lbtotalCost.Text = milkTea.Cost().ToString() +" VND";
                return null;
            }
        }

        private void bubbleee_Click(object sender, EventArgs e)
        {
            makeMilkTea(new MilkTea());
            Payment p = new Payment(lbtotalCost.Text);
            p.Show();
            lbtotalCost.Text = "20000 VND";
        }
    }

}
