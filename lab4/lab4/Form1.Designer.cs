namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            txtSearch = new Label();
            searchText = new TextBox();
            dataGridView1 = new DataGridView();
            btnShow = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            btnOrder = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(510, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 50);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Location = new Point(12, 174);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(111, 20);
            txtSearch.TabIndex = 6;
            txtSearch.Text = "Ключові слова";
            // 
            // searchText
            // 
            searchText.Location = new Point(181, 171);
            searchText.Name = "searchText";
            searchText.Size = new Size(187, 27);
            searchText.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(749, 195);
            dataGridView1.TabIndex = 8;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(322, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(141, 44);
            btnShow.TabIndex = 9;
            btnShow.Text = "Увесь товар";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 10;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Кількість";
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 27);
            txtName.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(181, 98);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 27);
            txtQuantity.TabIndex = 13;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(510, 71);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(162, 50);
            btnOrder.TabIndex = 14;
            btnOrder.Text = "Замовити";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(311, 433);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(162, 50);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 495);
            Controls.Add(btnEdit);
            Controls.Add(btnOrder);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(dataGridView1);
            Controls.Add(searchText);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Label txtSearch;
        private TextBox searchText;
        private DataGridView dataGridView1;
        private Button btnShow;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtQuantity;
        private Button btnOrder;
        private Button btnEdit;
    }
}
