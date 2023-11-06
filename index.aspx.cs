using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Marketplace_CRUD
{
    public partial class index : System.Web.UI.Page
    {
        private List<Product> products = new List<Product>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayProducts();
            }
        }

        private void displayProducts()
        {
            // Limpe a tabela antes de exibir os produtos
            productTable.Rows.Clear();

            foreach (var product in products)
            {
                TableRow row = new TableRow();
                TableCell cellId = new TableCell();
                TableCell cellName = new TableCell();
                TableCell cellPrice = new TableCell();
                TableCell cellDescription = new TableCell();
                TableCell cellActions = new TableCell();

                cellId.Text = product.Id.ToString();
                cellName.Text = product.Nome;
                cellPrice.Text = product.Preco.ToString("C");
                cellDescription.Text = product.Descricao;

                Button btnEdit = new Button();
                btnEdit.Text = "Editar";
                btnEdit.CommandArgument = product.Id.ToString();
                btnEdit.Click += new EventHandler(editProduct_Click);

                Button btnDelete = new Button();
                btnDelete.Text = "Excluir";
                btnDelete.CommandArgument = product.Id.ToString();
                btnDelete.Click += new EventHandler(deleteProduct_Click);

                cellActions.Controls.Add(btnEdit);
                cellActions.Controls.Add(btnDelete);

                row.Cells.Add(cellId);
                row.Cells.Add(cellName);
                row.Cells.Add(cellPrice);
                row.Cells.Add(cellDescription);
                row.Cells.Add(cellActions);

                productTable.Rows.Add(row);
            }
        }

        protected void editProduct_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            int productId = Convert.ToInt32(btnEdit.CommandArgument);

            var productToEdit = products.FirstOrDefault(p => p.Id == productId);
            if (productToEdit != null)
            {
                editProductId.Text = productToEdit.Id.ToString();
                editProductName.Text = productToEdit.Nome;
                editProductPrice.Text = productToEdit.Preco.ToString();
                editProductDescription.Text = productToEdit.Descricao;
            }
        }

        protected void deleteProduct_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            int productId = Convert.ToInt32(btnDelete.CommandArgument);

            var productToDelete = products.FirstOrDefault(p => p.Id == productId);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                displayProducts();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string nome = productName.Text;
            double preco = Convert.ToDouble(productPrice.Text);
            string descricao = productDescription.Text;

            Product newProduct = new Product
            {
                Id = products.Count + 1,
                Nome = nome,
                Preco = preco,
                Descricao = descricao
            };

            products.Add(newProduct);
            displayProducts();
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(editProductId.Text);
            string updatedProductName = editProductName.Text;
            decimal updatedPrice = Convert.ToDecimal(editProductPrice.Text);

            bool updateSuccess = UpdateProductInDatabase(productId, updatedProductName, updatedPrice);

            if (updateSuccess)
            {
                lblStatus.Text = "Produto atualizado com sucesso!";
            }
            else
            {
                lblStatus.Text = "Erro ao atualizar o produto. Por favor, tente novamente.";
            }
        }

        // Implemente o método UpdateProductInDatabase de acordo com a lógica do seu aplicativo.
        private bool UpdateProductInDatabase(int productId, string updatedProductName, decimal updatedPrice)
        {
            // Lógica para atualizar o produto no banco de dados.
            // Retorne true se a atualização for bem-sucedida e false em caso de erro.
            return true; // Substitua por sua lógica real.
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
    }
}
