using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Test
{
    public partial class Editor : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Editor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Очистка полей от введенных или имеющихся значений
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxName_user.Text = "";
            textboxLogin.Text = "";
            textboxPassword.Text = "";
        }
        /// <summary>
        /// Принятие ихменени
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textboxName_user.Text.Length == 4 && textboxLogin.Text == "" && textboxPassword.Text == "")
            {
                string message = "Заполните хотя бы одно поле!", mistake_type="Обновление невозможно";  
                MessageBox.Show(message, mistake_type, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {     
                string message, header="Обновление прошло успешно";
                if (textboxName_user.Text.Length > 4)
                {                    
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand("UPDATE Users SET Name = @New_name WHERE id_user = @id_user", connecting);
                        Command.Parameters.AddWithValue("@New_Name", textboxName_user.Text);
                        Command.Parameters.AddWithValue("@id_user", User.id_user);
                        Command.ExecuteNonQuery();
                        User.name = textboxName_user.Text;
                        connecting.Close();
                        message = "Данные обновлены: изменено имя";
                        MessageBox.Show(message, header);
                    }
                }
                if (textboxLogin.Text != "")
                {
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand("UPDATE Users SET Login = @New_login WHERE id_user = @id_user", connecting);
                        Command.Parameters.AddWithValue("@New_login", textboxLogin.Text);
                        Command.Parameters.AddWithValue("@id_user", User.id_user);
                        Command.ExecuteNonQuery();
                        User.login = textboxLogin.Text;
                        connecting.Close();
                        message = "Данные обновлены: изменено имя";
                        MessageBox.Show(message,header);
                    }
                }
                if (textboxPassword.Text != "")
                {
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand("UPDATE Users SET Password = @New_password WHERE id_user = @id_user", connecting);
                        Command.Parameters.AddWithValue("@New_password", textboxPassword.Text);
                        Command.Parameters.AddWithValue("@id_user", User.id_user);
                        Command.ExecuteNonQuery();
                        connecting.Close();
                        message = "Данные обновлены: изменен пароль";
                        MessageBox.Show(message,header);
                    }
                }
                Close();
            }
        }
        /// <summary>
        /// Отмена изменения
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
