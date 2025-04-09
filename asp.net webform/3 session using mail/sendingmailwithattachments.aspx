<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendingmailwithattachments.aspx.cs" Inherits="_3_session_using_mail.sendingmailwithattachments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

    Mail To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtrecivermail" runat="server"></asp:TextBox>
    <br />
    <br />
    Subject&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtsubject" runat="server"></asp:TextBox>
    <br />
    <br />
    Body&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtbody" runat="server"></asp:TextBox>
            <br />
            <br />
            Attachments&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
    <br />
    <br />
    <br />
    <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" />

</div>
    </form>
</body>
</html>
