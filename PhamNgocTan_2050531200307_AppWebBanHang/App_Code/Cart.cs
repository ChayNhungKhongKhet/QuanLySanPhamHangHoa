using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhamNgocTan_2050531200307_AppWebBanHang.App_Code
{
    public class Cart
    {
        Dictionary<string, Item> listCart;

        public Cart(Dictionary<string, Item> listCart)
        {
            this.ListCart = listCart;
        }

        public Cart()
        {
            this.ListCart = new Dictionary<string, Item>();
        }

        public Dictionary<string, Item> ListCart { get => listCart; set => listCart = value; }

        public void AddCart(String maSanPham, string tenSanPham, string hinhAnh, int soLuong, double donGia)
        {
            Item item = new Item(maSanPham, tenSanPham, donGia, soLuong, hinhAnh);
            
            if(listCart == null || !listCart.ContainsKey(item.MaSanPham))
                listCart.Add(item.MaSanPham, item);
            else
                listCart[item.MaSanPham].SoLuong += item.SoLuong;
        }

        public void RemoveCart(String maSanPham)
        {
            listCart.Remove(maSanPham);
        }

        public Double TotalBill()
        {
            var total = 0.0;
            foreach (var item in listCart.Values)
            {
                total += item.ThanhTien;
            }
            return total;
        }
    }
}