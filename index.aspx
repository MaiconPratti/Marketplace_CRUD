<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Marketplace_CRUD.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Marketplace</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="center-content">
            <h1>Marketplace</h1>

            <!-- Lista de Produtos -->
            <asp:Table runat="server" ID="productTable">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Nome do Produto</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Preço (R$)</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Descrição</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Ações</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>

            <!-- Formulário para Adicionar Produtos -->
            <h2>Adicionar Produto</h2>
            <div class="add-product-form">
                <asp:Label ID="lblProductName" runat="server" Text="Nome do Produto:" AssociatedControlID="productName"></asp:Label>
                <asp:TextBox ID="productName" runat="server" placeholder="Digite o nome do produto"></asp:TextBox>
                <asp:Label ID="lblProductPrice" runat="server" Text="Preço (R$):" AssociatedControlID="productPrice"></asp:Label>
                <asp:TextBox ID="productPrice" runat="server" placeholder="Digite o preço"></asp:TextBox>
                <asp:Label ID="lblProductDescription" runat="server" Text="Descrição:" AssociatedControlID="productDescription"></asp:Label>
                <asp:TextBox ID="productDescription" runat="server" placeholder="Digite a descrição"></asp:TextBox>
                <asp:Button ID="btnAddProduct" runat="server" Text="Adicionar Produto" CssClass="btn" OnClick="btnAddProduct_Click" />
            </div>

            <!-- Formulário para Editar Produtos -->
            <h2>Editar Produto</h2>
            <div class="edit-product-form">
                <asp:Label ID="lblEditProductName" runat="server" Text="Nome do Produto:" AssociatedControlID="editProductName"></asp:Label>
                <asp:TextBox ID="editProductName" runat="server"></asp:TextBox>
                <asp:Label ID="lblEditProductPrice" runat="server" Text="Preço (R$):" AssociatedControlID="editProductPrice"></asp:Label>
                <asp:TextBox ID="editProductPrice" runat="server"></asp:TextBox>
                <asp:Label ID="lblEditProductDescription" runat="server" Text="Descrição:" AssociatedControlID="editProductDescription"></asp:Label>
                <asp:TextBox ID="editProductDescription" runat="server"></asp:TextBox>
                <asp:Button ID="btnUpdateProduct" runat="server" Text="Atualizar Produto" CssClass="btn" OnClick="btnUpdateProduct_Click" />
                <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="editProductId" runat="server" Style="display: none;"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>
