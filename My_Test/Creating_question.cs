using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Test
{
    public partial class Creating_question : Form
    {
        /// <summary>
        /// массив вариантов ответов
        /// </summary>
        private static TextBox[] Variants = new TextBox[4];
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Creating_question()
        {
            InitializeComponent();
            Variants[0] = textboxAnswer1;
            Variants[1] = textboxAnswer2;
            Variants[2] = textboxAnswer3;
            Variants[3] = textboxAnswer4;
        }
        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textbowQuestion.Text != "" && textboxAnswer1.Text != "" && textboxAnswer2.Text != "" && textboxAnswer3.Text != "" && textboxAnswer4.Text != "")
            {
                if (correctAnswer1.Checked == false && correctAnswer2.Checked == false && correctAnswer3.Checked == false && correctAnswer4.Checked == false)
                {
                    string message = "Укажите верный вариант ответа!";
                    MessageBox.Show(message);
                }
                else
                {
                    int k=0;

                    if (correctAnswer1.Checked)
                        k = 1;
                    if (correctAnswer2.Checked)
                        k = 2;
                    if (correctAnswer3.Checked)
                        k = 3;
                    if (correctAnswer4.Checked)
                        k = 4;


                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand(@"INSERT INTO Questions VALUES(@id_test,@question,@right_id_answer);", connecting);
                        Command.Parameters.AddWithValue("@id_test", Test.id_test);
                        Command.Parameters.AddWithValue("@question", textbowQuestion.Text);
                        Command.Parameters.AddWithValue("@right_id_answer", k);
                        Command.ExecuteNonQuery();
                        connecting.Close();
                    }
                    int id_question;
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand(@"SELECT id_question FROM Questions ORDER BY id_question DESC", connecting);
                        id_question = Convert.ToInt32(Command.ExecuteScalar());
                        connecting.Close();
                    }


                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();

                        for (int i =0; i<=3 ;i++)
                        {
                            SqlCommand Command = new SqlCommand(@"INSERT INTO Answers VALUES(@id_question,@answer);", connecting);
                            Command.Parameters.AddWithValue("@id_question", id_question);
                            Command.Parameters.AddWithValue("@answer", Variants[i].Text);
                            Command.ExecuteNonQuery();
                        }
                        connecting.Close();
                        string message = "Вопрос и ответы успешно добавлены !", header="Выполнено";   
                        MessageBox.Show(message,header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Close();
                    }
                }
            }
            else
            {
                string message = "Заполните все поля!", mistake_type="Ошибка"; 
                MessageBox.Show(message,mistake_type, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Отмена создания вопроса
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
