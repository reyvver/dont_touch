using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace My_Test
{
    public partial class Questions : Form
    {
        /// <summary>
        /// Таймер для вычисления длительности выполнения теста
        /// </summary>
        private TimeSpan time1;
        DateTime Date1 = new DateTime(0, 0);
        DateTime initial_time = DateTime.Now;
        /// <summary>
        /// Номер вопроса
        /// </summary>
        private int i = 1;
        private int count;
        /// <summary>
        /// Вопросы и их id
        /// </summary>
        private List<string> Test_questions = new List<string>();
        private List<int> Id_questions = new List<int>();
        /// <summary>
        /// Все правильные варианты ответов
        /// </summary>
        private List<int> Right_answers = new List<int>();
        /// <summary>
        /// Варианты ответов на вопросы
        /// </summary>
        private static RadioButton[] Variants = new RadioButton[4];
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Questions()
        {
                InitializeComponent();
                Name_user.Text = User.name;
                labelTitle.Text = Test.title;
                labelNumber.Text = i.ToString();
            try
            {
                using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                {
                    connecting.Open();
                    SqlCommand command = new SqlCommand("SELECT question,right_id_answer,id_question From Questions WHERE id_test='" + Test.id_test + "'", connecting);
                    SqlDataReader Reader = command.ExecuteReader();

                    while (Reader.Read())
                    {
                        count++;
                        Test_questions.Add(Reader.GetString(0));
                        Right_answers.Add(Reader.GetInt32(1));
                        Id_questions.Add(Reader.GetInt32(2));
                    }

                    connecting.Close();
                }
                labelQuesitonCount.Text = count.ToString();
                QuestionText.Text = Test_questions[i - 1];
                Variants[0] = answer1;
                Variants[1] = answer2;
                Variants[2] = answer3;
                Variants[3] = answer4;

                answers();

                timerQuestion.Enabled = true;
            }
            catch
            {
                Close();
            }

        }
        /// <summary>
        /// Получение вариантов ответа
        /// </summary>
        public void answers()
        {
            using (SqlConnection connecting = new SqlConnection(User.StringConnection))
            {
                int j = 0;
                connecting.Open();
                SqlCommand command = new SqlCommand("SELECT Answer From Answers WHERE id_question='" + Id_questions[i-1] + "'", connecting);
                SqlDataReader Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Variants[j].Text = Reader.GetString(0);
                    j++;
                }

                connecting.Close();
            }
        }
        /// <summary>
        /// Лействие таймера
        /// </summary>
        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            DateTime current_time = DateTime.Now;
            time1 = current_time - initial_time;
            if (time1.Minutes > 9)
                CommonTime.Text = "" + time1.Minutes;
            else
                CommonTime.Text = "0" + time1.Minutes;

            if (time1.Seconds>9)
                CommonTime.Text += ":" + time1.Seconds;
            else
                CommonTime.Text+= ":0" + time1.Seconds;
        }
        /// <summary>
        /// Сохранение результатов или смена вопроса на следующий
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (i < count)
            {
                if (answer1.Checked == false && answer2.Checked == false && answer3.Checked == false && answer4.Checked == false)
                {
                    MessageBox.Show("Выберите вариант ответа!");
                }
                else
                {
                    int check = 0;
                    if (answer1.Checked)
                        check = 1;
                    if (answer2.Checked)
                        check = 2;
                    if (answer3.Checked)
                        check = 3;
                    if (answer4.Checked )
                        check = 4;

                    if (Right_answers[i - 1] == check)
                    {
                        Test.result++;
                    }
                    i++;
                    labelNumber.Text = i.ToString();
                    QuestionText.Text = Test_questions[i - 1];
                    answers();
                    Date1 = new DateTime(0, 0);
                }
            }
            else
            { 
                timerQuestion.Stop();

                int check = 0;
                if (answer1.Checked)
                    check = 1;
                if (answer2.Checked)
                    check = 2;
                if (answer3.Checked)
                    check = 3;
                if (answer4.Checked)
                    check = 4;

                if (Right_answers[i - 1] == check)
                {
                    Test.result++;
                }
                    using (SqlConnection connecting = new SqlConnection(User.StringConnection))
                    {
                        connecting.Open();
                        SqlCommand Command = new SqlCommand(@"INSERT INTO Results VALUES(@id_user,@id_test,@Count,@Time,@data,@mark);", connecting);
                        Command.Parameters.AddWithValue("@id_user", User.id_user);
                        Command.Parameters.AddWithValue("@id_test", Test.id_test);
                        Command.Parameters.AddWithValue("@Count", Test.result);
                        Command.Parameters.AddWithValue("@Time", CommonTime.Text);
                        Command.Parameters.AddWithValue("@data", initial_time);

                        if (Test.result < Test.minimum)
                            Command.Parameters.AddWithValue("@mark", "not passed");
                        else
                        {
                            Command.Parameters.AddWithValue("@mark", "passed");
                        }

                        Command.ExecuteNonQuery();

                        connecting.Close();
                    }
                    MessageBox.Show("Тест пройден");
                    Close();
            }
        }
        /// <summary>
        /// Выход из тестирования
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
