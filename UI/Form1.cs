using System;
using System.Windows.Forms;

namespace Prakt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Метод для добавления пользователя
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Add(textBoxUsername.Text, numericUpDownBudget.Value);
            textBoxUsername.Clear();
            numericUpDownBudget.Value = 0;
        }

        // Метод для добавления транзакции
        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            dataGridViewTransactions.Rows.Add(
                textBoxTransactionUsername.Text,
                numericUpDownTransactionAmount.Value,
                dateTimePickerTransaction.Value,
                comboBoxCategory.Text,
                textBoxTransactionDescription.Text
            );
            textBoxTransactionUsername.Clear();
            numericUpDownTransactionAmount.Value = 0;
            comboBoxCategory.SelectedIndex = -1;
            textBoxTransactionDescription.Clear();
        }

        // Метод для добавления категории расходов
        private void buttonAddExpenseCategory_Click(object sender, EventArgs e)
        {
            dataGridViewExpenseCategories.Rows.Add(
                textBoxCategoryName.Text,
                textBoxCategoryUsername.Text,
                numericUpDownCategoryBudget.Value
            );
            textBoxCategoryName.Clear();
            textBoxCategoryUsername.Clear();
            numericUpDownCategoryBudget.Value = 0;
        }

    }
}