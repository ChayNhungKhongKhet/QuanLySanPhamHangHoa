using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhamNgocTan_2050531200307_AppWebBanHang.App_Code
{
    public class Item
    {
        private String maSanPham;
        private String tenSanPham;
        private Double donGia;
        private int soLuong;
        private String hinhAnh;

        public Item(string maSanPham, string tenSanPham, double donGia, int soLuong, string hinhAnh)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.HinhAnh = hinhAnh;
        }

        public Item()
        {
        }

        public double ThanhTien
        {
            get { return this.soLuong * this.donGia; }
        }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }


    }
}