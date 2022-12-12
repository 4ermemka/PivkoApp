using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class RegForm : Form
    {
        LoginForm loginForm;
        public RegForm()
        {
            InitializeComponent();
        }
        public RegForm(LoginForm log)
        {
            this.loginForm = log;
            InitializeComponent();
        }
       
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginInput.Text;
            String passwordUser = PasswordInput.Text;
            String passwordRepUser = SecondPasswordInput.Text;
            String phoneUser = PhoneInput.Text;

            if(PivkoDBHandler.PhoneIsCorrect(phoneUser))
            { 
                if (passwordUser != "")
                {
                    if (PivkoDBHandler.PasswordIsCorrect(passwordUser)) 
                    { 
                        if (passwordUser == passwordRepUser)
                        {
                            string err = string.Empty;
                            PivkoDBHandler.AddNewUserDB(loginUser,passwordUser,phoneUser, out err);
                            if (err == string.Empty)
                            {
                                MessageBox.Show("Успешная регистрация!");
                                Close();
                            }
                            else MessageBox.Show("Пользователь уже зарегистрирован!");
                        }
                        else MessageBox.Show("Пароли не совпадают!");
                    }
                    else MessageBox.Show("Пароль не соответствует требованиям! \n Он должен состоять из латинских букв обоих регистров и цифр!");
                }
                else MessageBox.Show("Пароль не может быть пустым!");
            }
            else MessageBox.Show("Номер телефона некорректный!");
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void TogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !PasswordInput.UseSystemPasswordChar;
        }

        private void ToggleRepeatPasswordVisibility_Click(object sender, EventArgs e)
        {
            SecondPasswordInput.UseSystemPasswordChar = !SecondPasswordInput.UseSystemPasswordChar;
        }
    }
}
