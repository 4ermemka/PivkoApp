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
    public partial class AddTaskForm : Form
    {
        int id_room = -1;
        CreateRoomForm crf;
        RoomForm rf;
        public AddTaskForm()
        {
            InitializeComponent();
        }

        public AddTaskForm(RoomForm rf, int id_room)
        {
            this.id_room = id_room;
            this.rf = rf;
            InitializeComponent();
        }
        public AddTaskForm(CreateRoomForm crf)
        {
            this.crf = crf;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyTaskButton_Click(object sender, EventArgs e)
        {
            int points = Convert.ToInt32(PointsCountInput.Value);
            string taskName = TaskNameInput.Text;

            if (crf == null)
            { 
                PivkoDBHandler.AddNewTaskDB(id_room, points, taskName);
                rf.UpdateTables();
                MessageBox.Show("Задание успешно добавлено!");
            } 
            else crf.AddTaskToList(points, taskName);
        }
    }
}
