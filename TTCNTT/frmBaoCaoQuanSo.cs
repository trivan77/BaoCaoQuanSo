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
     public partial class frmBaoCaoQuanSo : Form
     {
          public frmBaoCaoQuanSo()
          {
               InitializeComponent();
          }

          private void txtQuanSoTong_Leave(object sender, EventArgs e)
          {
               if (txtQuanSoTong.Text == "")
               {
                    txtQuanSoTong.Text = "......";
               }
          }

          private void txtQuanSoTong_Enter(object sender, EventArgs e)
          {
               if (txtQuanSoTong.Text == "......")
               {
                    txtQuanSoTong.Text = "";
               }
          }

          private void txtQSCoMat_Leave(object sender, EventArgs e)
          {
               if (txtQSCoMat.Text == "")
               {
                    txtQSCoMat.Text = "......";
               }
          }

          private void txtQSCoMat_Enter(object sender, EventArgs e)
          {
               if (txtQSCoMat.Text == "......")
               {
                    txtQSCoMat.Text = "";
               }
          }

          private void txtQSVang_Leave(object sender, EventArgs e)
          {
               if (txtQSVang.Text == "")
               {
                    txtQSVang.Text = "......";
               }
          }

          private void txtQSVang_Enter(object sender, EventArgs e)
          {
               if (txtQSVang.Text == "......")
               {
                    txtQSVang.Text = "";
               }
          }

          private void txtLiDo_Leave(object sender, EventArgs e)
          {
               if (txtLiDo.Text == "") ;
               {
                    txtLiDo.Text = "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ......";
               }
          }

          private void txtLiDo_Enter(object sender, EventArgs e)
          {
               if (txtLiDo.Text == "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ......") ;
               {
                    txtLiDo.Text = "";
               }
          }
     }
}
