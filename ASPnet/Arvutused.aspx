<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Arvutused.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <script runat="server">
        protected void Button1_Click(Object sender, EventArgs e) {
         Label1.Text=Convert.ToString(Convert.ToDouble(TextBox1.Text)*2.54);
    }

        protected void Button2_Click(Object sender, EventArgs e) {
         Label7.Text=Convert.ToString(Convert.ToDouble(TextBox11.Text)/60);
    }
        protected void Button3_Click(Object sender, EventArgs e) {
         Label3.Text=Convert.ToString(Convert.ToDouble(TextBox3.Text)*Convert.ToDouble(TextBox4.Text));
    }
        protected void Button4_Click(Object sender, EventArgs e) {
         Label4.Text=Convert.ToString(Convert.ToDouble(TextBox5.Text)/Convert.ToDouble(TextBox6.Text));
    }
        protected void Button5_Click(Object sender, EventArgs e) {
         Label5.Text=Convert.ToString(Convert.ToDouble(TextBox7.Text)+Convert.ToDouble(TextBox8.Text));
    }

        protected void Button6_Click(Object sender, EventArgs e) {
         Label6.Text=Convert.ToString(Convert.ToDouble(TextBox9.Text)-Convert.ToDouble(TextBox10.Text));
    }

        protected void Button7_Click(Object sender, EventArgs e) {
         Label2.Text=Convert.ToString(Convert.ToDouble(TextBox2.Text)*60);
    }
</script>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Tollide arv: 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      Sentimeetrite arv:
        <asp:Label ID="Label1" runat="server" Text="Teadmata"></asp:Label> <br />
        <asp:Button ID="Button1" runat="server" Text="Arvuta" onclick="Button1_Click" />
    </div>
    
        <div>
      Tundide arv: 
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      Minutite arv:
        <asp:Label ID="Label2" runat="server" Text="Teadmata"></asp:Label> <br />
        <asp:Button ID="Button2" runat="server" Text="Minutid tundideks" onclick="Button7_Click" />
    </div>

        <div>
      Minutite arv: 
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
      Tundide arv: 
        <asp:Label ID="Label7" runat="server" Text="Teadmata"></asp:Label> <br />
        <asp:Button ID="Button7" runat="server" Text="Tunnid minutiteks" onclick="Button2_Click" />
    </div>
    



        <div>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            X
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="=" onclick="Button3_Click" />
            <asp:Label ID="Label3" runat="server" Text="Teadmata"></asp:Label> <br />

        </div>

        <div>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            /
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="=" onclick="Button4_Click" />
            <asp:Label ID="Label4" runat="server" Text="Teadmata"></asp:Label> <br />

        </div>

        <div>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            +
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="=" onclick="Button5_Click" />
            <asp:Label ID="Label5" runat="server" Text="Teadmata"></asp:Label> <br />

        </div>

        <div>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            -
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <asp:Button ID="Button6" runat="server" Text="=" onclick="Button6_Click" />
            <asp:Label ID="Label6" runat="server" Text="Teadmata"></asp:Label> <br />

        </div>





    </form>

</body>
</html>
