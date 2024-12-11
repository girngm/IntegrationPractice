namespace Prakt2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTimeTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddExpenseCategory = new System.Windows.Forms.Button();
            this.numericUpDownCategoryBudget = new System.Windows.Forms.NumericUpDown();
            this.textBoxCategoryUsername = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.dataGridViewExpenseCategories = new System.Windows.Forms.DataGridView();
            this.Category_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxTransactionDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.numericUpDownTransactionAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxTransactionUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCategoryBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Budget});
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(243, 311);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.HeaderText = "Имя пользователя";
            this.Username.Name = "Username";
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Оставшийся бюджет";
            this.Budget.Name = "Budget";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Name,
            this.Sum_transaction,
            this.DataTimeTransaction,
            this.Category_Budget,
            this.Transaction_description});
            this.dataGridViewTransactions.Location = new System.Drawing.Point(261, 12);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.Size = new System.Drawing.Size(544, 311);
            this.dataGridViewTransactions.TabIndex = 4;
            // 
            // User_Name
            // 
            this.User_Name.HeaderText = "Имя пользователя";
            this.User_Name.Name = "User_Name";
            // 
            // Sum_transaction
            // 
            this.Sum_transaction.HeaderText = "Сумма транзакции";
            this.Sum_transaction.Name = "Sum_transaction";
            // 
            // DataTimeTransaction
            // 
            this.DataTimeTransaction.HeaderText = "Дата и время транзакции";
            this.DataTimeTransaction.Name = "DataTimeTransaction";
            // 
            // Category_Budget
            // 
            this.Category_Budget.HeaderText = "Категория расхода";
            this.Category_Budget.Name = "Category_Budget";
            // 
            // Transaction_description
            // 
            this.Transaction_description.HeaderText = "Описание транзакции";
            this.Transaction_description.Name = "Transaction_description";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddExpenseCategory);
            this.panel2.Controls.Add(this.numericUpDownCategoryBudget);
            this.panel2.Controls.Add(this.textBoxCategoryUsername);
            this.panel2.Controls.Add(this.textBoxCategoryName);
            this.panel2.Location = new System.Drawing.Point(811, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 184);
            this.panel2.TabIndex = 0;
            // 
            // buttonAddExpenseCategory
            // 
            this.buttonAddExpenseCategory.Location = new System.Drawing.Point(3, 131);
            this.buttonAddExpenseCategory.Name = "buttonAddExpenseCategory";
            this.buttonAddExpenseCategory.Size = new System.Drawing.Size(109, 40);
            this.buttonAddExpenseCategory.TabIndex = 5;
            this.buttonAddExpenseCategory.Text = "Добавить";
            this.buttonAddExpenseCategory.UseVisualStyleBackColor = true;
            this.buttonAddExpenseCategory.Click += new System.EventHandler(this.buttonAddExpenseCategory_Click);
            // 
            // numericUpDownCategoryBudget
            // 
            this.numericUpDownCategoryBudget.Location = new System.Drawing.Point(3, 68);
            this.numericUpDownCategoryBudget.Name = "numericUpDownCategoryBudget";
            this.numericUpDownCategoryBudget.Size = new System.Drawing.Size(227, 20);
            this.numericUpDownCategoryBudget.TabIndex = 5;
            // 
            // textBoxCategoryUsername
            // 
            this.textBoxCategoryUsername.Location = new System.Drawing.Point(3, 42);
            this.textBoxCategoryUsername.Name = "textBoxCategoryUsername";
            this.textBoxCategoryUsername.Size = new System.Drawing.Size(227, 20);
            this.textBoxCategoryUsername.TabIndex = 6;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(3, 16);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(227, 20);
            this.textBoxCategoryName.TabIndex = 5;
            // 
            // dataGridViewExpenseCategories
            // 
            this.dataGridViewExpenseCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenseCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_Name,
            this.User_Name2,
            this.Budget_Category});
            this.dataGridViewExpenseCategories.Location = new System.Drawing.Point(811, 12);
            this.dataGridViewExpenseCategories.Name = "dataGridViewExpenseCategories";
            this.dataGridViewExpenseCategories.Size = new System.Drawing.Size(344, 311);
            this.dataGridViewExpenseCategories.TabIndex = 8;
            // 
            // Category_Name
            // 
            this.Category_Name.HeaderText = "Название категории";
            this.Category_Name.Name = "Category_Name";
            // 
            // User_Name2
            // 
            this.User_Name2.HeaderText = "Имя пользователя";
            this.User_Name2.Name = "User_Name2";
            // 
            // Budget_Category
            // 
            this.Budget_Category.HeaderText = "Бюджет по категории";
            this.Budget_Category.Name = "Budget_Category";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(3, 14);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(227, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(227, 20);
            this.numericUpDownBudget.TabIndex = 1;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(3, 70);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(109, 40);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(3, 66);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerTransaction.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 92);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(227, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // textBoxTransactionDescription
            // 
            this.textBoxTransactionDescription.Location = new System.Drawing.Point(3, 119);
            this.textBoxTransactionDescription.Name = "textBoxTransactionDescription";
            this.textBoxTransactionDescription.Size = new System.Drawing.Size(227, 20);
            this.textBoxTransactionDescription.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.numericUpDownBudget);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 125);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonAddTransaction);
            this.panel3.Controls.Add(this.textBoxTransactionDescription);
            this.panel3.Controls.Add(this.numericUpDownTransactionAmount);
            this.panel3.Controls.Add(this.comboBoxCategory);
            this.panel3.Controls.Add(this.textBoxTransactionUsername);
            this.panel3.Controls.Add(this.dateTimePickerTransaction);
            this.panel3.Location = new System.Drawing.Point(261, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 198);
            this.panel3.TabIndex = 8;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(3, 145);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(109, 40);
            this.buttonAddTransaction.TabIndex = 3;
            this.buttonAddTransaction.Text = "Добавить";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // numericUpDownTransactionAmount
            // 
            this.numericUpDownTransactionAmount.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownTransactionAmount.Name = "numericUpDownTransactionAmount";
            this.numericUpDownTransactionAmount.Size = new System.Drawing.Size(227, 20);
            this.numericUpDownTransactionAmount.TabIndex = 5;
            // 
            // textBoxTransactionUsername
            // 
            this.textBoxTransactionUsername.Location = new System.Drawing.Point(3, 14);
            this.textBoxTransactionUsername.Name = "textBoxTransactionUsername";
            this.textBoxTransactionUsername.Size = new System.Drawing.Size(227, 20);
            this.textBoxTransactionUsername.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewExpenseCategories);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCategoryBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddExpenseCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownCategoryBudget;
        private System.Windows.Forms.TextBox textBoxCategoryUsername;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridView dataGridViewExpenseCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTimeTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget_Category;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxTransactionDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownTransactionAmount;
        private System.Windows.Forms.TextBox textBoxTransactionUsername;
        private System.Windows.Forms.Button buttonAddTransaction;
    }
}

