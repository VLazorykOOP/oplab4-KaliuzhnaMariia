namespace lab4
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtType = new TextBox();
            txtCategory = new TextBox();
            txtSupplier = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            dtpExpirationDate = new DateTimePicker();
            numPrice = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Expiration date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 172);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 205);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 238);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 6;
            label7.Text = "Price";
            // 
            // txtType
            // 
            txtType.Location = new Point(145, 66);
            txtType.Name = "txtType";
            txtType.Size = new Size(250, 27);
            txtType.TabIndex = 8;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(145, 99);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(250, 27);
            txtCategory.TabIndex = 9;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(145, 165);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(250, 27);
            txtSupplier.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 198);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 69);
            btnSave.TabIndex = 14;
            btnSave.Text = "Зберегти зміни";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(145, 132);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(250, 27);
            dtpExpirationDate.TabIndex = 15;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(145, 231);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(250, 27);
            numPrice.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 24);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 17;
            label1.Text = "Редагування асортименту";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 356);
            Controls.Add(label1);
            Controls.Add(numPrice);
            Controls.Add(dtpExpirationDate);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(txtSupplier);
            Controls.Add(txtCategory);
            Controls.Add(txtType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtType;
        private TextBox txtCategory;
        private TextBox txtSupplier;
        private TextBox txtName;
        private Button btnSave;
        private DateTimePicker dtpExpirationDate;
        private NumericUpDown numPrice;
        private Label label1;
    }
}