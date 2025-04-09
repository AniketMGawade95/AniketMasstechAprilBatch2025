<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="verify.aspx.cs" Inherits="_3_session_using_mail.verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter OTP&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verify" />
        </div>
    </form>
</body>
</html>
