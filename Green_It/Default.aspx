<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Green_It.Default"
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
        <h3>Traitement fichier CSV</h3>
        <center>
        <asp:Table Id="tblFile" runat="server">
        <asp:TableRow>
            <asp:TableHeaderCell Text="Joindre un fichier : "></asp:TableHeaderCell>
            <asp:TableCell>
                <asp:FileUpload ID="fileUpload" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell RowSpan="2" HorizontalAlign="Right">
                <asp:Button ID="btnSend" Text ="Envoyer"  runat ="server" OnClick="btnSend_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
 </center>
        <asp:Label runat="server" ID="lblChrono" Font-Bold="true"></asp:Label><br />
        <asp:Label runat="server" ID="lblResult"></asp:Label>
    </asp:Panel>
</asp:Content>


