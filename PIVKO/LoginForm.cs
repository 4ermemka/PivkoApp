using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PivkoDBHandler.db = new PivkoMDL();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginInput.Text;
            String passwordUser = PasswordInput.Text;

            DataTable ds = PivkoDBHandler.GetData("SELECT * FROM Users WHERE Login = \'" + loginUser + "\'");

            if (ds.Rows.Count != 0)
            {
                int id = ds.Rows[0].Field<int>("ID_User");

                if (PivkoDBHandler.hashPassword(passwordUser, loginUser, id) == ds.Rows[0].Field<string>("Password"))
                {
                    MessageBox.Show("Успешная авторизация! ");

                    MainMenu mainMenu = new MainMenu(this, loginUser, ds.Rows[0].Field<string>("Phone"), id);
                    this.Hide();
                    mainMenu.Show();
                }
                else MessageBox.Show("Неверный пароль!");
            }
            else MessageBox.Show("Пользователь не найден!");
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm(this);
            regForm.Show();
            this.Hide();
        }

        private void TogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !PasswordInput.UseSystemPasswordChar;
        }

        private void PasswordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginButton_Click(this, EventArgs.Empty);
            }
        }
    }
}
