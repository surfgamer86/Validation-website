<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stap1.aspx.cs" Inherits="oef_sessies_en_validaties.stap1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href ="./css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Stap 1</h3>
            <p>Kies een mailadres:</p>
            <p>
                <asp:TextBox ID="emailTextbox" runat="server"></asp:TextBox>
                @
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>6IN.be</asp:ListItem>
                    <asp:ListItem>informaticabeheer.be</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="continueButton" runat="server" OnClick="continueButton_Click" Text="&gt;&gt;" />
            </p>
            <p>
                <asp:RequiredFieldValidator ID="emailValidator" runat="server" ErrorMessage="Gelieve het voledige email adres in te vullen" ControlToValidate="emailTextbox" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
        </div>
    </form>
</body>
</html>
