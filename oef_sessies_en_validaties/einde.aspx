<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="einde.aspx.cs" Inherits="oef_sessies_en_validaties.einde" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href ="./css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Einde</h3>
            <p>
                Je gegevens:</p>
            <p>
                &nbsp;</p>
            <p>
                mailadres:
                <asp:Label ID="emailLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                Wachtwoord:
                <asp:Label ID="wachtwoordLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                Nieuwsbrief:
                <asp:Label ID="nieuwsbriefLabel" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
