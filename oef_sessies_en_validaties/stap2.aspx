<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stap2.aspx.cs" Inherits="oef_sessies_en_validaties.stap2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href ="./css/styles.css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <h2>Stap 2</h2>
            <p>Kies een wachtwoord:</p>
            <p>
                <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="passwordRequiredField" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Wachtwoord moet ingevuld worden" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </p>
          <asp:Button ID="continueButton" runat="server" OnClick="continueButton_Click" Text="&gt;&gt;" />
        </div>
    </form>
</body>
</html>
