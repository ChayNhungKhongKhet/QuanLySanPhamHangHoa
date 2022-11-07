using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhamNgocTan_2050531200307_AppWebBanHang
{
    public partial class pageDanh_Sach_San_Pham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XuLyDuLieu x = new XuLyDuLieu();
            string madm = Request.QueryString.Get("MaDanhMuc");
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            DataList1.DataSource = x.getTable("psGetSanPhamByDanhMuc", pr);
            DataList1.DataBind();
            DataList1.RepeatColumns = 3;
        }

        
    }
}