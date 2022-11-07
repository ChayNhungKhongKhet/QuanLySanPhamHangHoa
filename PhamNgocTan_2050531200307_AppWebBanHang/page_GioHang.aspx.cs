using PhamNgocTan_2050531200307_AppWebBanHang.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhamNgocTan_2050531200307_AppWebBanHang
{
    public partial class page_GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadCart();
        }

        public void LoadCart()
        {
            Cart cart = (Cart)Session["cart"];
            grvCart.DataSource = cart.ListCart.Values.ToList();
            grvCart.DataBind();
            grvCart.FooterRow.Cells[0].Text = "Tổng tiền";
            grvCart.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Cart cart = (Cart)Session["cart"];
            foreach(GridViewRow row in grvCart.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbRemoveItem");
                if(ckb.Checked)
                {
                    String maSanPham = row.Cells[0].Text;
                    cart.RemoveCart(maSanPham);

                }
            }
            Session["cart"] = cart;
            LoadCart();
        }
    }
}