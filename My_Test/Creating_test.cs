using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Test
{
    public partial class Creating_test : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Creating_test()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавление теста
        /// </summary>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textboxTitle.Text != "" && textboxMinimum.Text != "")
            {
                using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                {
                    connecting.Open();
                    SqlCommand Command = new SqlCommand(@"INSERT INTO Tests VALUES(@Title,@Minimum);", connecting);
                    Command.Parameters.AddWithValue("@Title", textboxTitle.Text);
                    Command.Parameters.AddWithValue("@Minimum", textboxMinimum.Text);
                    Command.ExecuteNonQuery();
                    connecting.Close();
                    string message = "Тест создан!", header="Выполнено";   
                    MessageBox.Show(message,  header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
            }
            else
            {
                string message = "Заполните все поля!", mistake_type="Ошибка";   
                MessageBox.Show(message,  mistake_type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Отмена создания теста
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
