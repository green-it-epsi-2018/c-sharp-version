<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pictures.aspx.cs" Inherits="Green_It.Pictures"
    MasterPageFile="~/MasterPage.Master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script>
        window.onload = () => {
            let beginDate = +document.querySelector("[id$=startDate]").textContent;
            const endDate = + new Date()
            console.log(beginDate, endDate, (endDate - beginDate) / 1000 + "s");
        }
    
    </script>
    <asp:Panel runat="server" Style="top: 5%;">
        <h3>Chargement d’une page avec plusieurs images</h3>
        <asp:Panel runat="server" ID="pnlContent"></asp:Panel>
    </asp:Panel>
</asp:Content>
