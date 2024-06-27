using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace lab4
{
    public partial class Form1 : Form
    {
        public DairyProd_db db = new DairyProd_db();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                string searchText = this.searchText.Text;
                string query = "SELECT * FROM dairy_production.products WHERE type LIKE @searchText";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час пошуку: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM dairy_production.products";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час завантаження даних: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string productName = this.txtName.Text;
            string quantity = this.txtQuantity.Text;

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Будь ласка, введіть назву товару та кількість замовлення.");
                return;
            }

            MessageBox.Show($"Замовлення на товар '{productName}' в кількості {quantity} виконано успішно!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string type = Convert.ToString(selectedRow.Cells["type"].Value);
                string category = Convert.ToString(selectedRow.Cells["category"].Value);
                DateTime expirationDate = Convert.ToDateTime(selectedRow.Cells["expiration_date"].Value);
                string supplier = Convert.ToString(selectedRow.Cells["supplier"].Value);
                string name = Convert.ToString(selectedRow.Cells["name"].Value);
                decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);

                EditForm editForm = new EditForm(id, type, category, expirationDate, supplier, name, price, this);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }

    }
}
