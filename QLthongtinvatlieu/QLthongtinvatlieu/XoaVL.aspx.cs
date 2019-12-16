using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLthongtinvatlieu
{
    public partial class XoaVL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=bcdonlinesv;Integrated security=true;");
            SqlCommand cmd = new SqlCommand("delete from vatlieu  where mavatlieu='" + txtmavl.Text + "'", con);
            con.Open(); // mo ket noi
            cmd.ExecuteNonQuery(); // thuc thi
            con.Close();
        }
    }

    internal class SqlConnection
    {
        private string v;

        public SqlConnection(string v)
        {
            this.v = v;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}