<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThêmVL.aspx.cs" Inherits="QLthongtinvatlieu.ThêmVL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Thêm thông tin vật liệu"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Danh mục"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtdanhmuc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mã vật liệu"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtmavl" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Tên vật liệu"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txttenvl" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Số lượng"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtsoluong" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Giá bán"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtgiaban" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label7" runat="server" Text="Đơn vị tính"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtdvt" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="btnthemvl" runat="server" OnClick="btnthemvl_Click" Text="Thêm vật liệu" />
            
            
            
        </div>
    </form>
</body>
</html>
