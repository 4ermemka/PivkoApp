using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIVKO
{
    public partial class ChooseTaskToCountForm : Form
    {
        RoomForm rf;
        int id_room;
        int id_player;

        public ChooseTaskToCountForm()
        {
            InitializeComponent();
        }
        public ChooseTaskToCountForm(RoomForm rf, int id_room, int id_player)
        {
            this.rf = rf;
            this.id_room   = id_room;
            this.id_player = id_player;

            InitializeComponent();

            UpdateTable();
        }

        public void UpdateTable()
        {
            string ask = PlayerSearchInput.Text;
            if (ask == string.Empty) RoomTasksGrid.DataSource = PivkoDBHandler.GetData("Select ID_Task, Description, Points From Tasks Where ID_Room = "+ id_room);
            else RoomTasksGrid.DataSource = PivkoDBHandler.GetData("Select ID_Task, Description, Points From Tasks Where Description Like \'%" + ask + "%\' AND ID_Room = "+ id_room);

            RoomTasksGrid.Columns["ID_Task"].Visible = false;
            RoomTasksGrid.Columns["Description"].HeaderText = "Задание"; RoomTasksGrid.Columns["Description"].Width = 387;
            RoomTasksGrid.Columns["Points"].HeaderText = "Очки"; RoomTasksGrid.Columns["Points"].Width = 50;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RoomTasksGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("Засчитать задание?", "Присвоение очков",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(RoomTasksGrid.CurrentRow.Cells["ID_Task"].Value);
                PivkoDBHandler.CountPointsForTask(id_player, id, id_room);
                rf.UpdateTables();
            }
            UpdateTable();
        }

        private void PlayerSearchInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
