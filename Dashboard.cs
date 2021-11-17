using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void v_Movies_Label_Click(object sender, EventArgs e)
        {
            vACTION.Text = "Movies BTN pressed";
        }

        private void v_Tickets_Label_Click(object sender, EventArgs e)
        {
            vACTION.Text = "Tickets BTN pressed";
        }

        private void v_Account_Label_Click(object sender, EventArgs e)
        {
            vACTION.Text = "Account BTN pressed";
        }

        private void v_Panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
