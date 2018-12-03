<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Randam.aspx.cs" Inherits="Green_It.Randam"
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

    <script>
        let beginDate;
        window.onload = () => {
            const endDate = + new Date()
            console.log(beginDate, endDate, (endDate - beginDate) / 1000 + "s")
        }
        beginDate = + new Date()

    </script>
    <asp:Panel runat="server" Style="top: 5%;">
        <h3>Génération d'un nombre aléatoire</h3>

        <asp:Label runat="server" ID="lblChrono" Font-Bold="true"></asp:Label><br />
        <asp:Label runat="server" ID="lblResult"></asp:Label>
    </asp:Panel>
</asp:Content>

