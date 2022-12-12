using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class CreateRoomForm : Form
    {
        JudgeRoomsForm jrf;
        DataTable players;
        DataTable tasks;

        int admin_id;
        string admin_username;
        string admin_phone;

        public CreateRoomForm()
        {
            InitializeComponent();
            players = new DataTable();
            players.Columns.Add("ID_user", typeof(Int32));
            players.Columns.Add("Name", typeof(String));

            tasks = new DataTable();
            tasks.Columns.Add("ID_task", typeof(Int32));
            tasks.Columns.Add("Points", typeof(Int32));
            tasks.Columns.Add("Name", typeof(String));
        }

        public CreateRoomForm(JudgeRoomsForm jrf, string username, string phone, int id)
        {
            this.jrf = jrf;
            this.admin_id = id;
            this.admin_username = username;
            this.admin_phone = phone;
            InitializeComponent();

            players = new DataTable();
            players.Columns.Add("ID_user", typeof(Int32));
            players.Columns.Add("Name", typeof(String));

            tasks = new DataTable();

            tasks.Columns.Add("ID_task", typeof(Int32));
            tasks.Columns.Add("Points", typeof(Int32));
            tasks.Columns.Add("Name", typeof(String));

            usernameLabel.Text = admin_username + "\n" + admin_phone;

            UpdateTables();
        }

        public void UpdateTables()
        {
            string ask = PlayerSearchInput.Text;
            DataTable ds = new DataTable();

            if (ask == string.Empty) ds = PivkoDBHandler.GetAllUsers(this.admin_id);
            else ds = PivkoDBHandler.GetData("Select * From Users where ID_User <> " + this.admin_id + " AND Login Like \'%" + ask + "%\'");

            AllUsersDataGrid.DataSource = ds;

            AllUsersDataGrid.Columns[0].Visible = false;
            AllUsersDataGrid.Columns[1].HeaderText = "Имя пользователя"; AllUsersDataGrid.Columns[1].Width = 569;
            AllUsersDataGrid.Columns[2].Visible = false;
            AllUsersDataGrid.Columns[3].Visible = false;

            RoomPlayersGrid.DataSource = players;
            if(RoomPlayersGrid.Columns.Count != 0)
            { 
                RoomPlayersGrid.Columns[0].Visible = false;
                RoomPlayersGrid.Columns[1].HeaderText = "Имя игрока"; RoomPlayersGrid.Columns[1].Width = 569;
            }

            RoomTasksGrid.DataSource = tasks;
            if (RoomTasksGrid.Columns.Count != 0)
            {
                RoomTasksGrid.Columns[0].Visible = false;
                RoomTasksGrid.Columns[1].HeaderText = "Очки"; RoomTasksGrid.Columns[1].Width = 50;
                RoomTasksGrid.Columns[2].HeaderText = "Задание"; RoomTasksGrid.Columns[2].Width = 509;
            }
        }

        public void AddTaskToList(int points, string taskName)
        {
            tasks.Rows.Add(tasks.Rows.Count+1,points, taskName);
            MessageBox.Show("Задание успешно добавлено!");
            UpdateTables();
        }

        public void DeleteTaskFromList()
        {
            var result = MessageBox.Show("Желаете удалить задание?", "Удаление задания",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index;
                if (PivkoDBHandler.idIsInData(tasks, Convert.ToInt32(RoomTasksGrid.CurrentRow.Cells["ID_task"].Value), "ID_task", out index))
                {
                    tasks.Rows.RemoveAt(index);
                    MessageBox.Show("Задание удалено!");
                }
                else MessageBox.Show("Задание не найено!");
            }
            UpdateTables();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateRoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            jrf.Show();
        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            if (!(RoomNameInput.Text == string.Empty))
            {
                if (!(DescriptionInput.Text == string.Empty))
                {
                    if (EndTimeInput.Value > DateTime.Now)
                    {
                        Room r = new Room();

                        r.Description = DescriptionInput.Text;
                        r.Begin_Data = DateTime.Now;
                        r.End_Data = EndTimeInput.Value;
                        r.RoomName = RoomNameInput.Text;
                        r.Prize = Convert.ToInt32(PrizeInput.Value);

                        DataTable ds = PivkoDBHandler.GetData("Select * From Room");
                        int room_id = PivkoDBHandler.findMinId(ds, "ID_Room");
                        r.ID_Room = room_id;

                        PivkoDBHandler.db.Room.Add(r);
                        PivkoDBHandler.db.SaveChanges();
                        Admin a = new Admin();

                        a.Prefix = PrefixInput.Text;
                        a.ID_Room = room_id;
                        a.ID_User = admin_id;

                        PivkoDBHandler.db.Admin.Add(a);
                        PivkoDBHandler.db.SaveChanges();

                        for (int i = 0; i < players.Rows.Count; i++)
                        {
                            Player p = new Player();
                            p.ID_Room = room_id;
                            p.ID_User = players.Rows[i].Field<int>("ID_user");
                            p.Points = 0;

                            PivkoDBHandler.db.Player.Add(p);
                            PivkoDBHandler.db.SaveChanges();
                        }


                        for (int i = 0; i < tasks.Rows.Count; i++)
                        {
                            ds = PivkoDBHandler.GetData("Select * From Tasks");
                            Tasks t = new Tasks();
                            t.ID_Task = PivkoDBHandler.findMinId(ds, "ID_Task");
                            t.ID_Room = room_id;
                            t.Description = tasks.Rows[i].Field<string>("Name");
                            t.Points = tasks.Rows[i].Field<int>("Points");

                            PivkoDBHandler.db.Tasks.Add(t);
                            PivkoDBHandler.db.SaveChanges();
                        }

                        MessageBox.Show("Спор успешно создан!\nСтартовое кол-во участников: " + players.Rows.Count +
                            "\nСтартовое кол-во заданий: " + tasks.Rows.Count + "\nВы можете добавить или удалить участников и задания в меню спора!");
                        jrf.UpdateTable();
                        Close();
                    }
                    else MessageBox.Show("Ошибка! Неверная дата окончания спора!");
                }
                else MessageBox.Show("Ошибка! Описание не может быть пустым!");
            }
            else MessageBox.Show("Ошибка! Название комнаты не может быть пустым!");
        }

        private void AllUsersDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(AllUsersDataGrid.CurrentRow.Cells["ID_User"].Value);
            if (!PivkoDBHandler.idIsInData(players, id, "ID_User"))
            {
                players.Rows.Add(id, AllUsersDataGrid.CurrentRow.Cells["Login"].Value);
                MessageBox.Show("Пользователь успешно добавлен в спор!");
                UpdateTables();
            }
            else MessageBox.Show("Пользователь уже является игроком данной комнаты!");
        }

        private void RoomPlayersGrid_CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = MessageBox.Show("Желаете удалить игрока?", "Удаление игрока",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index;
                if (PivkoDBHandler.idIsInData(players, Convert.ToInt32(RoomPlayersGrid.CurrentRow.Cells["ID_User"].Value), "ID_User", out index))
                {
                    players.Rows.RemoveAt(index);
                    MessageBox.Show("Игрок удален!");
                }
                else MessageBox.Show("Игрок не найен!");
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            DeleteTaskFromList();
        }

        private void RoomTasksGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeleteTaskFromList();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm atf = new AddTaskForm(this);
            atf.Show();
        }

        private void PlayerSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }
    }
}
