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
    public partial class AddPlayerForm : Form
    {
        int id_room;
        int id_user;
        RoomForm rf;

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        public AddPlayerForm(RoomForm rf, int id_room, int id_user)
        {
            this.id_room = id_room;
            this.id_user = id_user;
            this.rf = rf;
            InitializeComponent();

            usernameLabel.Text = PivkoDBHandler.db.Users.Find(id_user).Login + "#" + this.id_user + "\n" + PivkoDBHandler.decPhone(PivkoDBHandler.db.Users.Find(id_user).Phone, PivkoDBHandler.db.Users.Find(id_user).Login);
            UpdateTables();
        }

        public void UpdateTables()
        {
            string ask = PlayerSearchInput.Text;
            DataTable ds = new DataTable();

            if (ask == string.Empty) ds = PivkoDBHandler.GetAllUsers(this.id_user);
            else ds = PivkoDBHandler.GetData("Select * From Users where ID_User <> " + this.id_user + " AND Login Like \'%" + ask + "%\'");
            
            AllUsersDataGrid.DataSource = ds;

            AllUsersDataGrid.Columns[0].Visible = false;
            AllUsersDataGrid.Columns[1].HeaderText = "Имя пользователя"; AllUsersDataGrid.Columns[1].Width = 569;
            AllUsersDataGrid.Columns[3].Visible = false;
            AllUsersDataGrid.Columns[2].Visible = false;
        }

        private void AllUsersDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(AllUsersDataGrid.CurrentRow.Cells["ID_User"].Value);
            DataTable ds = PivkoDBHandler.GetData("Select * From Users where ID_User in (Select Player.ID_User From Player where Player.ID_Room = " + id_room + ")");
            if (!PivkoDBHandler.idIsInData(ds, id, "ID_User"))
            {
                Player p = new Player();
                p.ID_Room = id_room;
                p.ID_User = id;

                PivkoDBHandler.db.Player.Add(p);
                PivkoDBHandler.db.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен в спор!");
                UpdateTables();

                rf.UpdateTables();
            }
            else MessageBox.Show("Пользователь уже является игроком данной комнаты!");
        }

        private void AddPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rf.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayerSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTables();
        }
    }
}
