using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelessDialogBox
{
    public partial class ColorChanger : Form
    {
        public delegate void ChangeWordEvent(Color color);
        public event ChangeWordEvent ChangeColor;

        public ColorChanger()
        {
            InitializeComponent();
        }

        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor?.Invoke(Color.Green);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor?.Invoke(Color.Blue);
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColor?.Invoke(Color.Red);
        }
    }
}
