using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login_Panel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tPass.UseSystemPasswordChar = true;
        }

        private void tPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            String Login = tLogin.Text; // Получаем Логин пользователя
            String Pass = tPass.Text; // Получаем Пароль пользователя

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `logins` WHERE `Login` = @L AND `Password` = @P", db.getConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = Pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Loader loader = new Loader();
                loader.Show();
            }

            else
                    MessageBox.Show("Данные для входа не являются верными.");
        }
    }
}
