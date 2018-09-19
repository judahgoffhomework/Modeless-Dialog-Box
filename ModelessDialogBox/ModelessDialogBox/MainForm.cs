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
    public partial class MainForm : Form
    {
        private ColorChanger colorChanger;

        public MainForm()
        {
            InitializeComponent();
        }

        private void colorChanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            openModalBoxButton.Enabled = true;
        }

        private void colorChanger_ChangeColor(Color color)
        {
            BackColor = color;
        }

        private void openModalBoxButton_Click(object sender, EventArgs e)
        {
            // Don't allow button to be clicked until spelling form closed
            openModalBoxButton.Enabled = false;

            if (colorChanger == null || colorChanger.IsDisposed)
            {
                colorChanger = new ColorChanger();

                colorChanger.FormClosed += colorChanger_FormClosed;

                colorChanger.ChangeColor += colorChanger_ChangeColor;

                // Show modeless dialog box
                colorChanger.Show(this);

                // Make form appear aligned with top-left of main form
                colorChanger.Location = new Point(this.Left, this.Top);

            }
            else
            {
                // Dialog is already visible
                colorChanger.BringToFront();
            }
        }
    }
}
