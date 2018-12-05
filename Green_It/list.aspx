<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Green_It.list"
    MasterPageFile="~/MasterPage.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        let beginDate;
        window.onload = () => {
            let beginDate = +document.querySelector("[id$=startDate]").textContent;
            const endDate = + new Date()
            console.log(beginDate, endDate, (endDate - beginDate) / 1000 + "s");
        }
    </script>
    <asp:Panel runat="server" Style="top: 5%;">
        <h3>Chargement d’un fichier haché par le serveur</h3>
        <asp:Label runat="server" ID="lblChrono" Font-Bold="true"></asp:Label><br />
        <center>
        <asp:Table Id="tblFile" runat="server">
        <asp:TableRow>
            <asp:TableHeaderCell Text="Joindre un fichier : "></asp:TableHeaderCell>
            <asp:TableCell>
                <asp:FileUpload ID="fileUpload" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Button ID="btnSend" Text ="Envoyer"  runat ="server" OnClick="btnSend_Click"/>
            </asp:TableCell>
        
        </asp:TableRow>
    </asp:Table>
           <asp:GridView ID="gvList" AutoGenerateColumns="true" runat="server"  ></asp:GridView>
 </center>
    </asp:Panel>

</asp:Content>
