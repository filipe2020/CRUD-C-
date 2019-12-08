<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaInicial.aspx.cs" Inherits="CRUD.paginaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CadastroDeProduto</title>
    <style type="text/css">
        body {background:center;
              background-color:darkcyan;

              
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="idproduto" runat ="server" />
            <table>
                <tr>
                    <td class="auto-style2">
                        <asp:Label Text="Produto" runat ="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox id="textnome" runat ="server" OnTextChanged="textnome_TextChanged"  CssClass="auto-style3" Width="137px" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label Text="Descrição" runat ="server" />
                    </td>
                    <td colspan ="2" class="auto-style1">
                        <asp:TextBox id="txtdescrição" runat ="server" OnTextChanged="txtdescrição_TextChanged"  CssClass="auto-style3" Width="137px" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label Text="Preço" runat ="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox id="TextPreço" runat ="server" OnTextChanged="TextPreço_TextChanged" CssClass="auto-style3" Width="137px" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label Text="QuantidadeDoProduto" runat ="server" />
                    </td>
                    
                         <td colspan ="2">
                              <asp:TextBox id="TextQuantidadeDoProduto" runat ="server" OnTextChanged="TextQuantidadeDoProduto_TextChanged"  CssClass="auto-style3" Width="137px" />
                         </td>
                     <tr>
                         <td colspan ="3">
                        <asp:Button Text="Salvar" id="Salvar" runat ="server" OnClick="Salvar_Click" />
                        <asp:Button Text="Editar" id="bntEditar" runat ="server" OnClick="bntEditar_Click" />
                        <asp:Button Text="Excluir" id="bntEcluir" runat ="server" OnClick="bntEcluir_Click" Width="59px" />
                    </td>
                     </tr>

                      <tr>
                     <td colspan ="3">
                          <asp:Label Text="MensagemOK" id="lblmensagemOK" runat ="server" ForeColor="Green" />
                     </td>
                     <tr>
                         <td colspan ="3">
                         <asp:Label Text="MensagemErro" id="lblmensagemErro" runat ="server" ForeColor="Red" />
                     </td>
                     </tr>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
