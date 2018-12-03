<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallWebService.aspx.cs" Inherits="Green_It.CallWebService"
    MasterPageFile="~/MasterPage.Master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        let beginDate;
        window.onload = () => {
            const endDate = + new Date()
            console.log(beginDate, endDate, (endDate - beginDate) / 1000 + "s")
        }
        beginDate = + new Date()

    </script>
    <asp:Panel runat="server" Style="top: 5%;">
        <h3>Appel web service</h3>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" ID="lblNbrefois" Text="Nombre de fois : "></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" TextMode="Number" ID="txtNbreFois"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button runat="server" ID="btnCallWebService" OnClick="btnCallWebService_Click"
                        Text="Appel web service" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
<br />
<br />
<br />
        <h3>Informations web service</h3>

        <asp:Button ID="btnInfoWebService" Text="Récuperer informations web servie" runat="server" OnClick="btnInfoWebService_Click" />

    </asp:Panel>
</asp:Content>
