using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class JudgeRoomsForm : Form
    {
        MainMenu menu;
        string username;
        string phone;
        int user_id;

        public JudgeRoomsForm()
        {
            InitializeComponent();
        }
        public JudgeRoomsForm(MainMenu menu, string phone, string username, int user_id)
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
            if (ask == string.Empty) JudgedRoomsTable.DataSource = PivkoDBHandler.GetJudgedRooms(this.user_id);
            else JudgedRoomsTable.DataSource = PivkoDBHandler.GetJudgedRooms(this.user_id, ask);

            JudgedRoomsTable.Columns[0].Visible = false;
            JudgedRoomsTable.Columns[1].HeaderText = "Название"; JudgedRoomsTable.Columns[1].Width = 150; JudgedRoomsTable.Columns[1].ReadOnly = true;
            JudgedRoomsTable.Columns[2].HeaderText = "Описание"; JudgedRoomsTable.Columns[2].Width = 150; JudgedRoomsTable.Columns[2].ReadOnly = true;
            JudgedRoomsTable.Columns[3].HeaderText = "Начало"; JudgedRoomsTable.Columns[3].Width = 100; JudgedRoomsTable.Columns[3].ReadOnly = true;
            JudgedRoomsTable.Columns[4].HeaderText = "Окончание"; JudgedRoomsTable.Columns[4].Width = 100; JudgedRoomsTable.Columns[4].ReadOnly = true;
            JudgedRoomsTable.Columns[5].HeaderText = "Приз"; JudgedRoomsTable.Columns[5].Width = 110; JudgedRoomsTable.Columns[5].ReadOnly = true;
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (JudgedRoomsTable.CurrentCell != null)
            {
                int id_room = Convert.ToInt32(JudgedRoomsTable.CurrentRow.Cells["ID_Room"].Value);

                RoomForm rf = new RoomForm(this, username,user_id, phone, true, id_room);
                Hide();
                rf.Show();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JudgeRoomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            CreateRoomForm crf = new CreateRoomForm(this, username, phone, user_id);

            Hide();
            crf.Show();
        }

        private void CheckRoomButton_Click(object sender, EventArgs e)
        {
            if (JudgedRoomsTable.CurrentCell != null)
            {
                RoomForm rf = new RoomForm(this, username, user_id, phone, true, Convert.ToInt32(JudgedRoomsTable.CurrentRow.Cells["ID_Room"].Value));
                rf.Show();
                Hide();
            }
            else MessageBox.Show("Сначала выберите комнату!");
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (JudgedRoomsTable.CurrentCell != null)
            {
                int id_room = Convert.ToInt32(JudgedRoomsTable.CurrentRow.Cells["ID_Room"].Value);

                PivkoDBHandler.DeleteRoomDB(id_room);

                MessageBox.Show("Комната успешно удалена!");
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
