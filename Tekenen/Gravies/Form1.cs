using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TekenProgramma;

namespace Gravies
{
    public partial class Form1 : Form
    {
        private Canvas cv = new Canvas();

        public Form1()
        {
            InitializeComponent();
            Driehoek h1 = new Driehoek { Positie = new Positie { X = 200, Y = 200 }, Basis = 200, Hoek = 60, Hoogte = 300 };
            cv.Add(h1);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            cv.Refresh(e.Graphics);
        }

        private void cirkelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CirkelDlg dlg = new CirkelDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Figuur c = dlg.Generate();
                cv.Add(c);
                Invalidate();
            }
        }

        private void rechtoekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangleDlg dlg = new RectangleDlg();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Figuur c = dlg.Generate();
                cv.Add(c);
                Invalidate();
            }
        }

    }
}
