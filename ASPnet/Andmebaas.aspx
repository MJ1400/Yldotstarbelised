<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Andmebaas.aspx.vb" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="registrinumber" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="registrinumber" HeaderText="registrinumber" ReadOnly="True" SortExpression="registrinumber" />
                    <asp:BoundField DataField="omanik" HeaderText="omanik" SortExpression="omanik" />
                    <asp:BoundField DataField="aasta" HeaderText="aasta" SortExpression="aasta" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString1 %>" DeleteCommand="DELETE FROM [Autod] WHERE [registrinumber] = @registrinumber" InsertCommand="INSERT INTO [Autod] ([registrinumber], [omanik], [aasta]) VALUES (@registrinumber, @omanik, @aasta)" ProviderName="<%$ ConnectionStrings:Database1ConnectionString1.ProviderName %>" SelectCommand="SELECT [registrinumber], [omanik], [aasta] FROM [Autod]" UpdateCommand="UPDATE [Autod] SET [omanik] = @omanik, [aasta] = @aasta WHERE [registrinumber] = @registrinumber">
                <DeleteParameters>
                    <asp:Parameter Name="registrinumber" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="registrinumber" Type="String" />
                    <asp:Parameter Name="omanik" Type="String" />
                    <asp:Parameter Name="aasta" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="omanik" Type="String" />
                    <asp:Parameter Name="aasta" Type="Int32" />
                    <asp:Parameter Name="registrinumber" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
