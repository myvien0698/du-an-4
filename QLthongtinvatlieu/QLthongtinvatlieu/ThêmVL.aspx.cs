using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

private SqlConnection con;
private SqlDataAdapter da;
private SqlCommand cmd;
private DataSet ds;

namespace QLthongtinvatlieu
{
    public partial class ThêmVL : System.Web.UI.Page
    {
        private object gvNguoiDung;
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                account.Service1 sv1 = new account.Service1();
                gvNguoiDung.DataSource = sv1.GetAccount();
                gvNguoiDung.DataBind();
            }
        }
        public DataSet GetAccount()
        {
            con = new SqlConnection("server=.; database=AccountDB; integrated security = true;");
            da = new SqlDataAdapter("Select * From NguoiDung", con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
      
        protected void btnthemvl_Click(object sender, EventArgs e)
        {
            account.Service1 sv1 = new account.Service1();

            string danhmuc = txtdanhmuc.Text;
            string mavatlieu = txtmavl.Text;
            string tenvatlieu  = txttenvl.Text;
            string soluong = txtsoluong.Text;
            string giaban = txtgiaban.Text;
            string donvitinh = txtdvt.Text;
            sv1.InsertAccount(danhmuc, mavatlieu,);
        }

    }
}