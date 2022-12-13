using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class RoomForm : Form
    {
        int id_room;
        int id_user;

        bool admin = false;
        string nickname;
        string phone;

        JudgeRoomsForm jrf;
        PlayerRoomsForm prf;

        public RoomForm()
        {
            InitializeComponent();
        }

        public RoomForm(JudgeRoomsForm jrf, string nickname, int id_user, string phone, bool admin, int id_room)
        {
            this.id_room = id_room;
            this.id_user = id_user;

            this.admin = admin;
            this.nickname = nickname;
            this.phone = phone;
            this.jrf = jrf;
            InitializeComponent();

            usernameLabel.Text = nickname + "#" +id_user+ "\n" + phone; ;

            string d, n;
            int p;
            DateTime e;

            GetRoomInfo(id_room, out d, out n, out p, out e);
            DescriptionInput.Text = d;
            RoomNameInput.Text = n;
            PrizeInput.Value = p;
            EndDateLabel.Text = e.ToString();

            DataTable ds = PivkoDBHandler.GetData("Select Users.ID_User, Users.Login, Users.Phone, Admin.Prefix From Admin,Users where Admin.ID_User = Users.ID_User AND Users.ID_User = " + id_user);
            if (ds.Rows.Count != 0)
            {
                PrefixInput.Text = ds.Rows[0].Field<string>("Prefix");
                AdminNickname.Text = ds.Rows[0].Field<string>("Prefix") + " " + ds.Rows[0].Field<string>("Login") + "\n"
                    + PivkoDBHandler.decPhone(ds.Rows[0].Field<string>("Phone"), ds.Rows[0].Field<string>("Login"));
            }

            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "TaskButtons";
            buttonColumn.Text = "+";
            buttonColumn.UseColumnTextForButtonValue = true;

            RoomPlayersGrid.Columns.Add(buttonColumn);
            RoomPlayersGrid.CellClick +=
                new DataGridViewCellEventHandler(RoomPlayersGrid_CellClick);

            UpdateTables();

            if (e <= DateTime.Now)
            {
                string message;
                ds = PivkoDBHandler.GetData("SELECT Users.ID_User, Users.Login FROM Player, Users where Player.ID_User = Users.ID_User AND Player.ID_Room = " + id_room 
                    + "\nAND Player.Points = (Select MAX(POINTS) FROM Player where Player.ID_Room = " + id_room + ")");
                if (ds.Rows.Count == 1) message = "ь: "+ ds.Rows[0].Field<string>("Login");
                else 
                {
                    message = "и: " + ds.Rows[0].Field<string>("Login");
                    for (int i = 1; i < ds.Rows.Count; i++)
                    { 
                        message += ", " + ds.Rows[i].Field<string>("Login");
                    }
                }
                message += "\nУдалить комнату?";
                var result = MessageBox.Show("Спор завершен!\n Победител" + message, "Спор завершен",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PivkoDBHandler.DeleteRoomDB(id_room);
                    Close();
                }

                PlayerToolsPanel.Visible = false;
                TaskToolsPanel.Visible = false;
                SaveChangesButton.Visible = false;
                RoomNameInput.Enabled = false;
                DescriptionInput.Enabled = false;
                PrefixInput.Enabled = false;
                PrizeInput.Enabled = false;
            }
        }

        public RoomForm(PlayerRoomsForm prf, string nickname, int id_user, string phone, bool admin, int id_room)
        {
            this.id_room = id_room;
            this.id_user = id_user;

            this.admin = admin;
            this.nickname = nickname;
            this.phone = phone;
            this.prf = prf;
            InitializeComponent();

            usernameLabel.Text = nickname + "\n" + phone;

            string d, n;
            int p;
            DateTime e;

            GetRoomInfo(id_room, out d, out n, out p, out e);
            DescriptionInput.Text = d;
            RoomNameInput.Text = n;
            PrizeInput.Value = p;
            EndDateLabel.Text = e.ToString();

            UpdateTables();

            DataTable ds = PivkoDBHandler.GetData("Select Users.ID_User, Users.Login, Users.Phone, Admin.Prefix From Admin,Users where Admin.ID_User = Users.ID_User AND Admin.ID_Room = " + id_room);
            if (ds.Rows.Count != 0)
            {
                PrefixInput.Text = ds.Rows[0].Field<string>("Prefix");
                AdminNickname.Text = ds.Rows[0].Field<string>("Prefix") + " " + ds.Rows[0].Field<string>("Login") + "\n"
                    + PivkoDBHandler.decPhone(ds.Rows[0].Field<string>("Phone"), ds.Rows[0].Field<string>("Login"));
            }

            PlayerToolsPanel.Visible = false;
            TaskToolsPanel.Visible = false;
            SaveChangesButton.Visible = false;
            RoomNameInput.Enabled = false;
            DescriptionInput.Enabled = false;
            PrefixInput.Enabled = false;
            PrizeInput.Enabled = false;
        }

        public void UpdateTables()
        {
            DataTable dsp = new DataTable();
            DataTable dst = new DataTable();

            string askp = PlayerSearchInput.Text;
            string askt = TaskSearchInput.Text;

            if (askp == string.Empty)
                dsp = PivkoDBHandler.GetData("Select distinct Users.ID_User, Users.Login, Player.Points From Users, Player " +
                    "where Player.ID_Room = " + id_room + " AND Users.ID_User = Player.ID_User");
            else
                dsp = PivkoDBHandler.GetData("Select distinct Users.ID_User, Users.Login, Player.Points From Users, Player " +
                    "where Player.ID_Room = " + id_room + " AND Users.ID_User = Player.ID_User AND Users.Login Like \'%" + askp + "%\'");
            
            RoomPlayersGrid.DataSource = dsp;

            if (askt == string.Empty)
                dst = PivkoDBHandler.GetData("Select ID_Task, Description,Points From Tasks where ID_Room = " + id_room);
            else
                dst = PivkoDBHandler.GetData("Select ID_Task, Description,Points From Tasks where ID_Room = " + id_room + " AND Description Like \'%" + askt + "%\'");

            RoomTasksGrid.DataSource = dst;

            RoomTasksGrid.Columns[0].Visible = false;
            RoomTasksGrid.Columns[1].HeaderText = "Задание"; RoomTasksGrid.Columns[1].Width = 405;
            RoomTasksGrid.Columns[2].HeaderText = "Очки"; RoomTasksGrid.Columns[2].Width = 100;

            if (jrf != null)
            {
                RoomPlayersGrid.Columns[0].HeaderText = "Задание"; RoomPlayersGrid.Columns[0].Width = 90;
                RoomPlayersGrid.Columns[1].Visible = false;
                RoomPlayersGrid.Columns[2].HeaderText = "Имя пользователя"; RoomPlayersGrid.Columns[2].Width = 354;
                RoomPlayersGrid.Columns[3].HeaderText = "Очки"; RoomPlayersGrid.Columns[3].Width = 70;
            }
            else
            {
                RoomPlayersGrid.Columns[0].Visible = false;
                RoomPlayersGrid.Columns[1].HeaderText = "Имя пользователя"; RoomPlayersGrid.Columns[1].Width = 405;
                RoomPlayersGrid.Columns[2].HeaderText = "Очки"; RoomPlayersGrid.Columns[2].Width = 100;
            }
        }

        private void GetRoomInfo(int id_room, out string descr, out string name, out int prize, out DateTime endTime)
        {
            descr = string.Empty;
            name = string.Empty;
            prize = 0;
            endTime = DateTime.Now;

            DataTable ds = PivkoDBHandler.GetData("Select * From Room where ID_Room = " + id_room);
            if (ds.Rows.Count != 0)
            {
                descr = ds.Rows[0].Field<string>("Description");
                name = ds.Rows[0].Field<string>("RoomName");
                prize = ds.Rows[0].Field<int>("Prize");
                endTime = ds.Rows[0].Field<DateTime>("End_Data").Date + ds.Rows[0].Field<DateTime>("End_Data").TimeOfDay;
            }
            else MessageBox.Show("Ошибка поиска комнаты!");
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (jrf != null) jrf.Show();
            if (prf != null) prf.Show();
        }

        private void PlayerSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }

        private void TaskSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayerForm apf = new AddPlayerForm(this, id_room, id_user);
            apf.Show();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (!(RoomNameInput.Text == string.Empty))
            {
                if (!(DescriptionInput.Text == string.Empty))
                {
                    Room r = PivkoDBHandler.db.Room.Find(id_room);
                    if (r != null)
                    {
                        r.RoomName = RoomNameInput.Text;
                        r.Description = DescriptionInput.Text;
                        r.Prize = Convert.ToInt32(PrizeInput.Value);

                    }

                    Admin a = PivkoDBHandler.db.Admin.Find(id_room, id_user);
                    a.Prefix = PrefixInput.Text;
                    PivkoDBHandler.db.SaveChanges();

                    MessageBox.Show("Изменения внесены!");

                    jrf.UpdateTable();
                }
                else MessageBox.Show("Ошибка! Описание не может быть пустым!");
            }
            else MessageBox.Show("Ошибка! Название комнаты не может быть пустым!");
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm atf = new AddTaskForm(this, id_room);
            atf.Show();
        }

        private void DelPlayerButton_Click(object sender, EventArgs e)
        {
            if (RoomPlayersGrid.CurrentCell != null)
            { 
                int id = Convert.ToInt32(RoomPlayersGrid.CurrentRow.Cells["ID_User"].Value);
                Player p = PivkoDBHandler.db.Player.Find(id, id_room);
                if (p != null)
                {
                    PivkoDBHandler.db.Player.Remove(p);
                    PivkoDBHandler.db.SaveChanges();

                    UpdateTables();
                    MessageBox.Show("Игрок успешно удален!");
                }
                else  MessageBox.Show("ОШИБКА! Пользователь не найден!");
            }
            else MessageBox.Show("Сначала выберите игрока, которого хотите удалить из спора!");
        }

        private void DelTaskButton_Click(object sender, EventArgs e)
        {
            if (RoomTasksGrid.CurrentCell != null)
            {
                int id = Convert.ToInt32(RoomTasksGrid.CurrentRow.Cells["ID_Task"].Value);
                Tasks t = PivkoDBHandler.db.Tasks.Find(id, id_room);
                if (t != null)
                {
                    PivkoDBHandler.db.Tasks.Remove(t);
                    PivkoDBHandler.db.SaveChanges();

                    UpdateTables();
                    MessageBox.Show("Задание успешно удалено!");
                }
                else MessageBox.Show("ОШИБКА! Задание не найдено!");
            }
            else MessageBox.Show("Сначала выберите задание, которое хотите удалить из спора!");
        }

        private void RoomPlayersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RoomPlayersGrid.Columns["TaskButtons"].Index && e.RowIndex>=0)
            {
                int id = Convert.ToInt32(RoomPlayersGrid.Rows[e.RowIndex].Cells["ID_User"].Value);
                ChooseTaskToCountForm countTask = new ChooseTaskToCountForm(this, id_room, id);
                countTask.Show();
            }
        }

    }
}
