using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLthongtinvatlieu
{
    public partial class SuaVl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsuavl_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("server=.;database=bcdonlinesv;Integrated security=true;");
             SqlCommand cmd = new SqlCommand("update vatlieu set danhmuc='" + txtdanhmuc.Text + "',mavl=" + txtmavl.Text + ",tenvaltlieu='" + txttenvl.Text + "'," +
                 "soluong='" + txtsoluong.Text + "',giaban='" + txtgiaban.Text + "',donvitinh='" +txtdvt.Text + "'  where mavl='" + txtmavl.Text + "'", con);
             con.Open(); // mo ket noi
             cmd.ExecuteNonQuery(); // thuc thi
             con.Close();
        }
    }
}