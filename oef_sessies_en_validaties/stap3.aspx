<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stap3.aspx.cs" Inherits="oef_sessies_en_validaties.stap3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href ="./css/styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Stap 3</h3>
            <p>
                <asp:CheckBox ID="nieuwsbriefCheckBox" runat="server" Text="Ik wens de nieuwsbrief te ontvangen" />
            </p>
            <asp:Button ID="continueButton" runat="server" OnClick="continueButton_Click" Text="&gt;&gt;" />
        </div>
    </form>
</body>
</html>
