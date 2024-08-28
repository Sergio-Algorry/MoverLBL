using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoverLBL.FE
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible= false;
            btInicio.Enabled = false;
            btInicio.Visible = false;
            txt_X.Visible= false;
            txt_Y.Visible=false;

            lblCubo.Left = Convert.ToInt32(txt_X.Text);
            lblCubo.Top = Convert.ToInt32(txt_Y.Text);

            //this.lblCubo.Location = new System.Drawing.Point(
            //    Convert.ToInt32(txt_X.Text),
            //    Convert.ToInt32(txt_Y.Text));
            while (true) 
            {
                lblCubo.Left = lblCubo.Left + 1;
                this.Refresh();

                if (lblCubo.Left + lblCubo.Width ==this.Width - 20 )
                {
                    break;
                }
            }
            label2.Visible = true;
            label3.Visible = true;
            btInicio.Enabled = true;
            btInicio.Visible = true;
            txt_X.Visible = true;
            txt_Y.Visible = true;


        }
    }
}




