﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hachages.aspx.cs" Inherits="Green_It.hachages" 
    MasterPageFile="~/MasterPage.Master" %>

<asp:content contentplaceholderid="ContentPlaceHolder1" runat="server">
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
</asp:content>

