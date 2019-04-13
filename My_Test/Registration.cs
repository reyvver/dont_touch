using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Test
{
    public partial class Registration : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Registration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textboxLogin.Text != "" & textboxPassword.Text != "" & textboxName_user.Text != "")
            {

                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                       // SqlCommand Command_1 = new SqlCommand("SELECT id_user FROM Users ORDER BY id_user DESC",connecting);
                        SqlCommand Command = new SqlCommand(@"INSERT INTO Users VALUES(@Name,@login,@password,@status);",connecting);
                        Command.Parameters.AddWithValue("@Name", textboxName_user.Text);
                        Command.Parameters.AddWithValue("@login", textboxLogin.Text);
                        Command.Parameters.AddWithValue("@password", textboxPassword.Text);
                        Command.Parameters.AddWithValue("@status", "users");
                        Command.ExecuteNonQuery();
                        connecting.Close();
                        string message = "Регистрация прошла успешно", header="Выполнено";   
                        MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
            }
            else
            {
                string message = "Заполнены не все поля", mistake_type="Ошибка регистрации"; 
                MessageBox.Show(message, mistake_type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Отмена создания пользователя
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Очистка полей от имеющихся значений
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxName_user.Text = "";
            textboxLogin.Text = "";
            textboxPassword.Text = "";
        }
    }
}
