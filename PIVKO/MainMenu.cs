using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class MainMenu : Form
    {
        LoginForm LoginForm;
        string username;
        string phone;
        int user_id;

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(LoginForm log, string username, string phone, int id)
        {
            LoginForm = log;
            this.username = username;
            this.user_id = id;
            this.phone = PivkoDBHandler.decPhone(phone, username);
            InitializeComponent();
            usernameLabel.Text = this.username + "#" + this.user_id + "\n" + this.phone;
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            PlayerRoomsForm prf = new PlayerRoomsForm(this, username, phone, user_id);
            prf.Show();
            this.Hide();
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            JudgeRoomsForm jrf = new JudgeRoomsForm(this, phone, username, user_id);
            jrf.Show();
            this.Hide();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить свой аккаунт?", "Удаление аккаунта",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable ds = PivkoDBHandler.GetData("Select Room.ID_Room From Room, Admin where Room.ID_Room = Admin.ID_Room AND Admin.ID_User = " + user_id);
                for (int i = 0; i < ds.Rows.Count; i++) PivkoDBHandler.DeleteRoomDB(ds.Rows[i].Field<int>("ID_Room"));
                ds = PivkoDBHandler.GetData("Select * From Player where ID_User = " + user_id);
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    Player p = PivkoDBHandler.db.Player.Find(user_id, ds.Rows[i].Field<int>("ID_Room"));
                    if(p!=null) PivkoDBHandler.db.Player.Remove(p);
                }

                Users u = PivkoDBHandler.db.Users.Find(user_id);
                if (u != null) PivkoDBHandler.db.Users.Remove(u);

                PivkoDBHandler.db.SaveChanges();

                MessageBox.Show("Ваш аккаунт успешно удален!");
                LoginForm.Show();
                Close();
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
