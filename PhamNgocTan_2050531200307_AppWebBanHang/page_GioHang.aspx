<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page_User.Master" AutoEventWireup="true" CodeBehind="page_GioHang.aspx.cs" Inherits="PhamNgocTan_2050531200307_AppWebBanHang.page_GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvCart" runat="server" AutoGenerateColumns="False" Height="157px" ViewStateMode="Enabled" Width="297px">
        <Columns>
            <asp:BoundField DataField="MaSanPham" HeaderText="Mã Sản Phẩm" />
            <asp:BoundField DataField="TenSanPham" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
            <asp:BoundField DataField="DonGia" HeaderText="Đơn Giá" />
            <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền" />
            <asp:ImageField DataAlternateTextField="HinhAnh" DataImageUrlField="HinhAnh" DataImageUrlFormatString="IMAGES/{0}" HeaderText="Ảnh">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả Hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbRemoveItem" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Trả hàng" />
</asp:Content>
