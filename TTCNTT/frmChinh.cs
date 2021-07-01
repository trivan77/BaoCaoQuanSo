using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCNTT
{
     public partial class frmChinh : Form
     {
          public frmChinh()
          {
               InitializeComponent();
          }

          private Form activeForm = null;
          private void openChildForm(Form childForm)
          {
               if (activeForm != null) activeForm.Close();
               activeForm = childForm;
               childForm.TopLevel = false;
               childForm.FormBorderStyle = FormBorderStyle.None;
               childForm.Dock = DockStyle.Fill;
               pnlMain.Controls.Add(childForm);
               pnlMain.Tag = childForm;
               childForm.BringToFront();
               childForm.Show();
          }

          private void hideSubMenu()
          {
               pnlCapNhatSub.Visible = false;
               
          }

          private void showSubMenu(Panel subMenu)
          {
               if (subMenu.Visible == false)
               {
                    hideSubMenu();
                    subMenu.Visible = true;
               }
               else
                    subMenu.Visible = false;
          }

          private void btnCapNhat_Click(object sender, EventArgs e)
          {
               showSubMenu(pnlCapNhatSub);
          }

          private void lbClose_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void btnBaoCaoQS_Click(object sender, EventArgs e)
          {
               frmBaoCaoQuanSo frmBaoCaoQS = new frmBaoCaoQuanSo();
               openChildForm(frmBaoCaoQS);
          }
     }
}
