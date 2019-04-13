using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Test
{
    public partial class User_test : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public User_test()
        {
            InitializeComponent();
            UpdateLabels();
            UpdateGrid();
        }
        /// <summary>
        /// Добавление в список имеющихся тетсов
        /// </summary>
        public void UpdateLabels()
        {
            labelUserLogin.Text = User.login;
            labelUserName.Text = User.name;

            using (SqlConnection connecting = new SqlConnection(User.StringConnection))
            {
                connecting.Open();
                SqlCommand command = new SqlCommand("SELECT Title From Tests",connecting);
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Tests_list.Items.Add(Reader.GetString(0));
                }
                connecting.Close();
            }
        }
        /// <summary>
        /// Измнение информации пользователя
        /// </summary>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            new Editor().ShowDialog();
            UpdateLabels();
        }
        /// <summary>
        /// Запуск тестирования выбранного теста
        /// </summary>
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (Tests_list.SelectedItem != null)
            {
                using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                {
                    connecting.Open();
                    SqlCommand command = new SqlCommand("SELECT id_test,Minimum From Tests WHERE Title='"+ Tests_list.SelectedItem + "'", connecting);
                    SqlDataReader Reader = command.ExecuteReader();
                    Reader.Read();
                    Test.id_test = Reader.GetInt32(0);
                    Test.minimum = Reader.GetInt32(1);
                    Test.result = 0;
                    connecting.Close();

                }
                try
                {
                    new Questions().ShowDialog();
                    UpdateGrid();
                }
                catch
                {
                    string message = "Тест не содержит никаких вопросов. Тестирование невозможно", mistake_type = "Ошибка тестирования";
                    MessageBox.Show(message, mistake_type, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обновление listbox, содержащего информацию о пройденных тестах
        /// </summary>
        public void UpdateGrid()
        {
            results.Items.Clear();
            using (SqlConnection connecting = new SqlConnection(User.StringConnection))
            {
                int k = 0;
                connecting.Open();
                SqlCommand command = new SqlCommand("SELECT id_test,Count,Time,Data,Mark From Results WHERE id_user='"+User.id_user+"'ORDER BY id_result ASC", connecting);
                SqlDataReader Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    k++;
                    SqlCommand command_title = new SqlCommand("SELECT Title FROM Tests WHERE id_test='"+Reader.GetInt32(0)+"'", connecting);
                    string title = command_title.ExecuteScalar().ToString();

                    ListViewItem lvi = new ListViewItem(new [] { Convert.ToString(k), title, Convert.ToString(Reader.GetInt32(1)),Reader.GetString(2), Convert.ToString(Reader.GetDateTime(3)), Reader.GetString(4) });
                    results.Items.Add(lvi);
                }

                connecting.Close();
            }
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
