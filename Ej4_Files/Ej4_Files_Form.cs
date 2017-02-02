using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ChangeLanguage(object sender, EventArgs e)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("Files.Resources.traductor_galego",typeof(Ej4_Files_Form).Assembly);
            foreach(Control c in this.Controls)
            {
                


            }
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
    }
}
