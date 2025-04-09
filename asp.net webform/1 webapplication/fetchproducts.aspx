<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fetchproducts.aspx.cs" Inherits="_1_webapplication.fetchproducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-SgOJa3DmI69IUzQ2PVdRZhwQ+dy64/BUtbMJw1MZ8t5HZApcHrRKUc4W0kG879m7" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/js/bootstrap.bundle.min.js" integrity="sha384-k6d4wzSIapyDyv1kpU366/PK5hCdSbCRGRCMv+eplOQJWyd1fbcAu9OCUj5zNLiq" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                    <img class="card-img-top" height="200" width="200" src='<%# Eval("pic") %>' alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("pname") %></h5>
                        <h5 class="card-title">category: <%# Eval("pcategory") %></h5>
                        <h5 class="card-title">price: <%# Eval("price") %></h5>

                    </div>
                    <ul class="list-group list-group-flush">
                        <asp:Button ID="Button1" class="btn btn-info" runat="server" Text="Add to cart" />

                    </ul>
                    <div class="card-body">
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/product.aspx">Add Product</asp:HyperLink>
        <div>
        </div>
    </form>
</body>
</html>
