using System;
using System.Windows.Forms;

namespace My_Test
{
    public partial class Main_screen : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Main_screen()
        {
            InitializeComponent();
            labelUserStatus.Text = User.status;

            if (labelUserStatus.Text == "admin")
            {
                buttonManagment.Enabled = true;
                buttonManagment.Visible = true;
            }
           
            else
            {
                buttonManagment.Enabled = false;
                buttonManagment.Visible = false;
            }
        }
        /// <summary>
        /// Выход из приложения
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void Main_screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Смена пользователя
        /// </summary>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            User.Form.Visible = true;
            Close();
        }
        /// <summary>
        /// Изменение данных 
        /// </summary>
        private void buttonEditInf_Click(object sender, EventArgs e)
        {
            new Editor().ShowDialog();
        }
        /// <summary>
        /// Тестирование 
        /// </summary>
        private void buttonTest_Click(object sender, EventArgs e)
        {
            new User_test().ShowDialog();
        }
        /// <summary>
        /// Управление имеющимися тестами и зарегистрированными пользователями 
        /// </summary>
        private void buttonManagment_Click(object sender, EventArgs e)
        {
            new Managment().ShowDialog();
        }
    }
}
