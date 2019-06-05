using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace templateApp
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt;
            BBL.Data _BLL = new BBL.Data();
            dt = _BLL.Test();
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
    }
}