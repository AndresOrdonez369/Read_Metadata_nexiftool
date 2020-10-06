<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="home.aspx.cs" Inherits="WebAppTaller1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/resumenws.html"></asp:HyperLink>
        <br />
        <br />
        
        <h1><strong>Herramienta para analizar metadatos en imagenes<br /></h1>
                     
        <h4>Selecciona una imagen de formato .gif, .png, .jpeg, .jpg, para con la herramienta Nexiftool leer sus metadatos. </h4>
        <br /> 
        
        </strong>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnLeerMetadatos" runat="server" OnClick="btnLeerMetadatos_Click" Text="Leer metadatos" />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="#000099"></asp:Label>
        <br />
        <br />  
        <h4>Oswaldo Andrés Ordóñez Bolaños</h4>
        
    
        <asp:Image ID="imgPreview" runat="server" Height="238px" style="margin-top: 47px" Width="291px" Visible="False" />
        <asp:TextBox ID="txtSalida" runat="server" Height="238px" style="margin-top: 0px" TextMode="MultiLine" Width="541px" Visible="False"></asp:TextBox>
        <br />
       </div>
    </form>
</body>
</html>
