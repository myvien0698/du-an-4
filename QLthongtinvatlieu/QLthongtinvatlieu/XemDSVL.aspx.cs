using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLthongtinvatlieu
{
    public partial class XemDSVL : System.Web.UI.Page
    {
        private object DropDownList_Test2;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                DropDownList_Test2.DataSource = XPathSelect (DropDownList_Test2.SelectedValue);
                DropDownList_Test2.DataTextField = "thép";
                DropDownList_Test2.DataValueField = "đồng";
                DropDownList_Test2.DataBind();
        }

        private object XPathSelect(object selectedValue)
        {
            throw new NotImplementedException();
        }
    }
}