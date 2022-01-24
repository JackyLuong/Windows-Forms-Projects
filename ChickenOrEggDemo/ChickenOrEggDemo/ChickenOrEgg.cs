using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenOrEggDemo
{
    public partial class ChickenOrEgg : Form
    {
        public ChickenOrEgg()
        {
            InitializeComponent();
        }

        private void radChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.BackgroundImage = Image.FromFile(@"..\..\..\images\chicken.png");
        }

        private void radEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.BackgroundImage = Image.FromFile(@"..\..\..\images\egg.png");
        }
    }
}
