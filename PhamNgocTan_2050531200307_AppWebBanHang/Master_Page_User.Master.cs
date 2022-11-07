using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhamNgocTan_2050531200307_AppWebBanHang
{
    public partial class Master_Page_User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
            SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            Repeater1.DataSource = xuLyDuLieu.getTable("psGetDanhMuc",pr);
            Repeater1.DataBind();

        }
    }
}