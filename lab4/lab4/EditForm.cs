using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab4
{
    public partial class EditForm : Form
    {
        private int productId;
        private string initialType;
        private string initialCategory;
        private DateTime initialExpirationDate;
        private string initialSupplier;
        private string initialName;
        private decimal initialPrice;
        private Form1 parentForm;

        public EditForm(int id, string type, string category, DateTime expirationDate, string supplier, string name, decimal price, Form1 parent)
        {
            InitializeComponent();

            productId = id;
            initialType = type;
            initialCategory = category;
            initialExpirationDate = expirationDate;
            initialSupplier = supplier;
            initialName = name;
            initialPrice = price;
            parentForm = parent;

            txtType.Text = initialType;
            txtCategory.Text = initialCategory;
            dtpExpirationDate.Value = initialExpirationDate;
            txtSupplier.Text = initialSupplier;
            txtName.Text = initialName;
            numPrice.Value = initialPrice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string updatedType = txtType.Text;
            string updatedCategory = txtCategory.Text;
            DateTime updatedExpirationDate = dtpExpirationDate.Value;
            string updatedSupplier = txtSupplier.Text;
            string updatedName = txtName.Text;
            decimal updatedPrice = numPrice.Value;
            parentForm.db.OpenConnection();

            try
            {
                string query = "UPDATE dairy_production.products " +
                               "SET type = @type, category = @category, expiration_date = @expiration_date, " +
                               "supplier = @supplier, name = @name, price = @price " +
                               "WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, parentForm.db.Connection);
                cmd.Parameters.AddWithValue("@type", updatedType);
                cmd.Parameters.AddWithValue("@category", updatedCategory);
                cmd.Parameters.AddWithValue("@expiration_date", updatedExpirationDate);
                cmd.Parameters.AddWithValue("@supplier", updatedSupplier);
                cmd.Parameters.AddWithValue("@name", updatedName);
                cmd.Parameters.AddWithValue("@price", updatedPrice);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Запис оновлено успішно!");

                parentForm.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час оновлення запису: " + ex.Message);
            }
            finally
            {
                parentForm.db.CloseConnection();
            }
            this.Close();
        }
    }

}
