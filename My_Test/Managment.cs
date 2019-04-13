using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Test
{
    public partial class Managment : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Managment()
        {
            InitializeComponent();
            Update_Users();
            Update_Tests();
        }
        /// <summary>
        /// Обновление listbox, содержащего записи о тестах
        /// </summary>
        private void Update_Tests()
        {
            tests.Items.Clear();
            using (SqlConnection connecting = new SqlConnection(User.StringConnection))
            {
                int k = 0;
                connecting.Open();
                SqlCommand command = new SqlCommand("SELECT id_test,Title,Minimum From Tests", connecting);
                SqlDataReader Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    k++;
                    ListViewItem lvi = new ListViewItem(new [] { Convert.ToString(k), Convert.ToString(Reader.GetInt32(0)), Reader.GetString(1), Convert.ToString(Reader.GetInt32(2))});
                    tests.Items.Add(lvi);
                }

                connecting.Close();
            }
        }
        /// <summary>
        /// Обновление listbox, содержащего записи о пользователях
        /// </summary>
        private void Update_Users()
        {
            Users.Items.Clear();
            using (SqlConnection connecting = new SqlConnection(User.StringConnection))
            {
                int k = 0;
                connecting.Open();
                SqlCommand command = new SqlCommand("SELECT id_user,Name,login,password From Users", connecting);
                SqlDataReader Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    k++;
                    ListViewItem lvi = new ListViewItem(new [] { Convert.ToString(k), Convert.ToString(Reader.GetInt32(0)), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3) });
                    Users.Items.Add(lvi);
                }

                connecting.Close();
            }
        }
        /// <summary>
        /// Создание нового теста
        /// </summary>
        private void buttonAddTest_Click(object sender, EventArgs e)
        {
             new Creating_test().ShowDialog();
             new Creating_question().ShowDialog();
             Update_Tests();
            
        }
        /// <summary>
        /// Добавление в имеющийся тест новый ворпрос
        /// </summary>
        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (tests.SelectedItems.Count > 0)
            {
                Test.id_test = Convert.ToInt32(tests.SelectedItems[0].SubItems[1].Text);

                new Creating_question().ShowDialog();
            }
        }
        /// <summary>
        /// Удаление выбранного теста
        /// </summary>
        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            if (tests.SelectedItems.Count > 0)
            {
                int index = Convert.ToInt32(tests.FocusedItem.SubItems[1].Text);

                using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                {
                    connecting.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Tests WHERE id_test=@id_test", connecting);
                    command.Parameters.AddWithValue("@id_test", index);
                    command.ExecuteNonQuery();
                    connecting.Close();
                }
                Update_Tests();

            }
            else
            {
                MessageBox.Show("Выберите тест!");
            }
        }
        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            new Registration().ShowDialog();
            Update_Users();
        }
        /// <summary>
        /// Удаление выбранного пользователя
        /// </summary>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (Users.SelectedItems.Count > 0)
            {
                int index = Convert.ToInt32(Users.FocusedItem.SubItems[1].Text);
                using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                {
                    connecting.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Users WHERE id_user=@id_user", connecting);
                    command.Parameters.AddWithValue("@id_user", index);
                    command.ExecuteNonQuery();
                    connecting.Close();
                }
                Update_Users();
            }
            else
            {
                MessageBox.Show("Выберите пользователя!");
            }
        }
        /// <summary>
        /// Изменение информации о выбранном пользователе
        /// </summary>
        private void buttonEditInf_Click(object sender, EventArgs e)
        {
            if (Users.SelectedItems.Count > 0)
            {

                User.changing_user = User.id_user;
                User.changing_name = User.name;
                User.id_user = Convert.ToInt32(Users.FocusedItem.SubItems[1].Text);

                new Editor().ShowDialog();

                Update_Users();
                User.id_user = User.changing_user;
                User.name = User.changing_name;
            }
            else
            {
                MessageBox.Show("Выберите пользователя!");
            }
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
