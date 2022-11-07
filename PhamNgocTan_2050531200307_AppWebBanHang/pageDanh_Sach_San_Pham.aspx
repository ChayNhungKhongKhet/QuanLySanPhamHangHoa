<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page_User.Master" AutoEventWireup="true" CodeBehind="pageDanh_Sach_San_Pham.aspx.cs" Inherits="PhamNgocTan_2050531200307_AppWebBanHang.pageDanh_Sach_San_Pham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        
        <ItemTemplate>
            <div style="padding:20px">
            <a href="page_ChiTietSanPham.aspx?MaSanPham=<%# Eval("MaSanPham") %>">
            <img alt="" src='IMAGES/<%#Eval("HinhAnh") %>' width="150" height="150" />
            <br />
            Tên Sản Phẩm:<%# Eval("TenSanPham") %><br />Đơn giá:<%# Eval("DonGia") %>
            </a>
            </div>
        </ItemTemplate>
            

</asp:DataList>
</asp:Content>
