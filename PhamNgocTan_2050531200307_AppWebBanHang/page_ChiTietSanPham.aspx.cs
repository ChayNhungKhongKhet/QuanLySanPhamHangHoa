using PhamNgocTan_2050531200307_AppWebBanHang.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace PhamNgocTan_2050531200307_AppWebBanHang
{
    public partial class page_ChiTietSanPham : System.Web.UI.Page
    {
        DataTable tbSP;
        protected void Page_Load(object sender, EventArgs e)
        {
            XuLyDuLieu x = new XuLyDuLieu();
            string masp = Request.QueryString.Get("MaSanPham");
            SqlParameter[] pr;
            if (masp != null)
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", masp) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaSanPham", DBNull.Value) };
            this.tbSP =  x.getTable("getChiTietSanPham", pr);
            Repeater2.DataSource = tbSP;
            Repeater2.DataBind();

            int soLuong = Convert.ToInt32(tbSP.Rows[0]["SoLuong"].ToString());
            for (int i = 0; i < soLuong; i++)
                dropListSoLuong.Items.Add(i.ToString());
        }

        protected void btnGioHang_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            Cart cart = new Cart();
            if (tbSP != null)
            {
                String masanpham = tbSP.Rows[0]["MaSanPham"].ToString();
                String tensanpham = tbSP.Rows[0]["TenSanPham"].ToString();
                double dongia = Double.Parse(tbSP.Rows[0]["DonGia"].ToString());
                String hinhanh = tbSP.Rows[0]["HinhAnh"].ToString();

                int soluong = Int16.Parse(dropListSoLuong.SelectedItem.Text);
                if (Session["cart"] != null)
                    cart = (Cart)Session["cart"];

                cart.AddCart(masanpham, tensanpham, hinhanh, soluong, dongia);
                Session["cart"] = cart;
                Response.Redirect("page_GioHang.aspx");
            }
        }
    }
}
   