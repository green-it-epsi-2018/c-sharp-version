<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Green_It.Default"
    MasterPageFile="~/MasterPage.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <Center>
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
 </Center>
    <asp:Label runat="server" ID="lblChrono" Font-Bold="true"></asp:Label><br />
    <asp:Label runat="server" ID="lblResult"></asp:Label>
</asp:Content>


