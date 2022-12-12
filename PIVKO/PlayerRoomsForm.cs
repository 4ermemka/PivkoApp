using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class PlayerRoomsForm : Form
    {
        MainMenu menu;
        string username;
        string phone;
        int user_id;

        public PlayerRoomsForm()
        {
            InitializeComponent();
        }

        public PlayerRoomsForm(MainMenu menu, string username, string phone, int user_id)
        {
            this.menu = menu;
            this.username = username;
            this.phone = phone;
            this.user_id = user_id;

            InitializeComponent();
            usernameLabel.Text = this.username + "#" + this.user_id + "\n" + phone;

            UpdateTable();
        }

        public void UpdateTable()
        {
            string ask = RoomSearchInput.Text;
            if (ask == string.Empty) PlayerRoomsGrid.DataSource = PivkoDBHandler.GetRoomPlayers(this.user_id);
            else PlayerRoomsGrid.DataSource = PivkoDBHandler.GetRoomPlayers(this.user_id, ask);

            PlayerRoomsGrid.Columns[0].Visible = false;
            PlayerRoomsGrid.Columns[1].HeaderText = "Название"; PlayerRoomsGrid.Columns[1].Width = 150; PlayerRoomsGrid.Columns[1].ReadOnly = true;
            PlayerRoomsGrid.Columns[2].HeaderText = "Описание"; PlayerRoomsGrid.Columns[2].Width = 150; PlayerRoomsGrid.Columns[2].ReadOnly = true;
            PlayerRoomsGrid.Columns[3].HeaderText = "Начало"; PlayerRoomsGrid.Columns[3].Width = 100; PlayerRoomsGrid.Columns[3].ReadOnly = true;
            PlayerRoomsGrid.Columns[4].HeaderText = "Окончание"; PlayerRoomsGrid.Columns[4].Width = 100; PlayerRoomsGrid.Columns[4].ReadOnly = true;
            PlayerRoomsGrid.Columns[5].HeaderText = "Приз"; PlayerRoomsGrid.Columns[5].Width = 110; PlayerRoomsGrid.Columns[5].ReadOnly = true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerRoomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void PlayerRoomsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PlayerRoomsGrid.CurrentCell != null)
            {
                int id_room = Convert.ToInt32(PlayerRoomsGrid.CurrentRow.Cells["ID_Room"].Value);

                RoomForm rf = new RoomForm(this, username, user_id, phone, true, id_room);
                Hide();
                rf.Show();
            }
        }

        private void CheckRoomButton_Click(object sender, EventArgs e)
        {
            if (PlayerRoomsGrid.CurrentCell != null)
            {
                RoomForm rf = new RoomForm(this, username, user_id, phone, true, Convert.ToInt32(PlayerRoomsGrid.CurrentRow.Cells["ID_Room"].Value));
                rf.Show();
                Hide();
            }
            else MessageBox.Show("Сначала выберите комнату!");
        }

        private void LeaveRoomButton_Click(object sender, EventArgs e)
        {
            if (PlayerRoomsGrid.CurrentCell != null)
            {
                var result = MessageBox.Show("Желаете выйти из спора?", "Выход из спора",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(PlayerRoomsGrid.CurrentRow.Cells["ID_Room"].Value);

                    Player p = PivkoDBHandler.db.Player.Find(user_id, id);
                    if (p != null)
                    {
                        PivkoDBHandler.db.Player.Remove(p);
                        PivkoDBHandler.db.SaveChanges();
                        MessageBox.Show("Комната успешно покинута!");
                    }
                    else MessageBox.Show("Ошибка! Неверные данные!");
                }
                UpdateTable();
            }
            else MessageBox.Show("Сначала выберите комнату!");
        }

        private void RoomSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }

}
