using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Ej4_Files
{
    public partial class Ej4_Files_Form : Form
    {
        public Ej4_Files_Form()
        {
            InitializeComponent();
        }


        private void HoverContextMenu(object sender, EventArgs e)
        {
            ToolStripMenuItem selected = (ToolStripMenuItem) sender;
            toolStripStatusLabel1.Text = "Opcion " + selected.Text;
        }

        private void LeaveContextMenu(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";         
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

        private void spanish(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Controls.Clear();
            InitializeComponent();

        }

        private void english(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();

        }
    }
}
