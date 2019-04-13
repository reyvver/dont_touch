using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Test
{
    public partial class Autorization : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Autorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрытие приложения
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Проверка соответствия введенных значений данным, имеющимся в бд
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (StringConnection.Text != "")
            {
                User.StringConnection = StringConnection.Text;
              //  try
               // {
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command =
                            new SqlCommand(
                                "SELECT password FROM Users WHERE login='" + textboxLogin.Text + "' AND password='" +
                                textboxPassword.Text + "'", connecting);
                        string Result = Command.ExecuteScalar().ToString();

                        if (Result == textboxPassword.Text)
                        {
                            SqlCommand Command_new =
                                new SqlCommand(
                                    "SELECT id_user,Name,status,login FROM Users WHERE login='" + textboxLogin.Text +
                                    "' AND password='" + textboxPassword.Text + "'", connecting);
                            SqlDataReader Reader = Command_new.ExecuteReader();
                            Reader.Read();
                            User.id_user = Reader.GetInt32(0);
                            User.name = Reader.GetString(1);
                            User.status = Reader.GetString(2);
                            User.login = Reader.GetString(3);
                        }
                        connecting.Close();
                        User.Form.Visible = false;
                        new Main_screen().ShowDialog();
                    }
               /* }
                catch (NullReferenceException)
                {
                    string message = "Неправильный логин или пароль", mistake_type = "Ошибка авторизации";
                    MessageBox.Show(message, mistake_type, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    string message = ex.Message, mistake_type = "Ошибка авторизации";
                    MessageBox.Show(message, mistake_type, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }
        /// <summary>
        /// Регистрация нового пользователя
        /// </summary>
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            new Registration().ShowDialog();
        }
        /// <summary>
        /// Очищает поля от введенныъ (имеющихся) значений
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxLogin.Text = "";
            textboxPassword.Text = "";
        }
    }
}
