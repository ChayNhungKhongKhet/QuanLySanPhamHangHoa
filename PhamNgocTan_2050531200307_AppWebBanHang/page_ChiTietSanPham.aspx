<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page_User.Master" AutoEventWireup="true" CodeBehind="page_ChiTietSanPham.aspx.cs" Inherits="PhamNgocTan_2050531200307_AppWebBanHang.page_ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <img alt="" src="IMAGES/<%#Eval("HinhAnh") %>" width="150" height ="150" />
            <h1>Tên sản phẩm : <%# Eval("TenSanPham")%></%></h1>
            <%#Eval("MoTa") %>
        </ItemTemplate>
</asp:Repeater>
    <asp:DropDownList ID="dropListSoLuong" runat="server"></asp:DropDownList>
    <asp:Button ID="btnGioHang" runat="server" Text="Thêm vào giỏ hàng" OnClick="btnGioHang_Click" />
</asp:Content>

