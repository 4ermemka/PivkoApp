
namespace PIVKO
{
    partial class CreateRoomForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoomForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.RoomPages = new System.Windows.Forms.TabControl();
            this.AllPlayersPage = new System.Windows.Forms.TabPage();
            this.AllUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerSearchInput = new System.Windows.Forms.TextBox();
            this.RoomPlayersPage = new System.Windows.Forms.TabPage();
            this.RoomPlayersGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.RoomTasksGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.GroupBox();
            this.CreateRoom = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RoomInfo = new System.Windows.Forms.GroupBox();
            this.PrefixInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrizeInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.EndTimeInput = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionInput = new System.Windows.Forms.RichTextBox();
            this.RoomNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.RoomPages.SuspendLayout();
            this.AllPlayersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.RoomPlayersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayersGrid)).BeginInit();
            this.TaskPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.RoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeInput)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.WorkPanel.Controls.Add(this.RoomPages);
            this.WorkPanel.Controls.Add(this.dataTable);
            this.WorkPanel.Controls.Add(this.ButtonsPanel);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(868, 479);
            this.WorkPanel.TabIndex = 1;
            // 
            // RoomPages
            // 
            this.RoomPages.Controls.Add(this.AllPlayersPage);
            this.RoomPages.Controls.Add(this.RoomPlayersPage);
            this.RoomPages.Controls.Add(this.TaskPage);
            this.RoomPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomPages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RoomPages.Location = new System.Drawing.Point(274, 41);
            this.RoomPages.Margin = new System.Windows.Forms.Padding(7);
            this.RoomPages.Multiline = true;
            this.RoomPages.Name = "RoomPages";
            this.RoomPages.Padding = new System.Drawing.Point(20, 10);
            this.RoomPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomPages.SelectedIndex = 0;
            this.RoomPages.Size = new System.Drawing.Size(594, 438);
            this.RoomPages.TabIndex = 6;
            // 
            // AllPlayersPage
            // 
            this.AllPlayersPage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AllPlayersPage.Controls.Add(this.AllUsersDataGrid);
            this.AllPlayersPage.Controls.Add(this.panel1);
            this.AllPlayersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPlayersPage.Location = new System.Drawing.Point(4, 39);
            this.AllPlayersPage.Name = "AllPlayersPage";
            this.AllPlayersPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllPlayersPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllPlayersPage.Size = new System.Drawing.Size(586, 395);
            this.AllPlayersPage.TabIndex = 0;
            this.AllPlayersPage.Text = "Добавить игрока";
            // 
            // AllUsersDataGrid
            // 
            this.AllUsersDataGrid.AllowUserToAddRows = false;
            this.AllUsersDataGrid.AllowUserToDeleteRows = false;
            this.AllUsersDataGrid.AllowUserToResizeColumns = false;
            this.AllUsersDataGrid.AllowUserToResizeRows = false;
            this.AllUsersDataGrid.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.AllUsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllUsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllUsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllUsersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.AllUsersDataGrid.MultiSelect = false;
            this.AllUsersDataGrid.Name = "AllUsersDataGrid";
            this.AllUsersDataGrid.ReadOnly = true;
            this.AllUsersDataGrid.RowHeadersVisible = false;
            this.AllUsersDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AllUsersDataGrid.RowTemplate.ReadOnly = true;
            this.AllUsersDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AllUsersDataGrid.Size = new System.Drawing.Size(580, 346);
            this.AllUsersDataGrid.TabIndex = 1;
            this.AllUsersDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllUsersDataGrid_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PlayerSearchInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 43);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(167, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск по игрокам:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerSearchInput
            // 
            this.PlayerSearchInput.Location = new System.Drawing.Point(173, 4);
            this.PlayerSearchInput.Multiline = true;
            this.PlayerSearchInput.Name = "PlayerSearchInput";
            this.PlayerSearchInput.Size = new System.Drawing.Size(400, 31);
            this.PlayerSearchInput.TabIndex = 3;
            this.PlayerSearchInput.TextChanged += new System.EventHandler(this.PlayerSearchInput_TextChanged);
            // 
            // RoomPlayersPage
            // 
            this.RoomPlayersPage.BackColor = System.Drawing.Color.Wheat;
            this.RoomPlayersPage.Controls.Add(this.RoomPlayersGrid);
            this.RoomPlayersPage.Controls.Add(this.panel2);
            this.RoomPlayersPage.Location = new System.Drawing.Point(4, 39);
            this.RoomPlayersPage.Name = "RoomPlayersPage";
            this.RoomPlayersPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoomPlayersPage.Size = new System.Drawing.Size(586, 395);
            this.RoomPlayersPage.TabIndex = 1;
            this.RoomPlayersPage.Text = "Игроки в комнате";
            // 
            // RoomPlayersGrid
            // 
            this.RoomPlayersGrid.AllowUserToAddRows = false;
            this.RoomPlayersGrid.AllowUserToDeleteRows = false;
            this.RoomPlayersGrid.AllowUserToResizeColumns = false;
            this.RoomPlayersGrid.AllowUserToResizeRows = false;
            this.RoomPlayersGrid.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.RoomPlayersGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomPlayersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomPlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomPlayersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPlayersGrid.Location = new System.Drawing.Point(3, 3);
            this.RoomPlayersGrid.MultiSelect = false;
            this.RoomPlayersGrid.Name = "RoomPlayersGrid";
            this.RoomPlayersGrid.ReadOnly = true;
            this.RoomPlayersGrid.RowHeadersVisible = false;
            this.RoomPlayersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.RoomPlayersGrid.RowTemplate.ReadOnly = true;
            this.RoomPlayersGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomPlayersGrid.Size = new System.Drawing.Size(580, 346);
            this.RoomPlayersGrid.TabIndex = 2;
            this.RoomPlayersGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomPlayersGrid_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 43);
            this.panel2.TabIndex = 1;
            // 
            // TaskPage
            // 
            this.TaskPage.BackColor = System.Drawing.Color.Tan;
            this.TaskPage.Controls.Add(this.RoomTasksGrid);
            this.TaskPage.Controls.Add(this.panel3);
            this.TaskPage.Location = new System.Drawing.Point(4, 39);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(586, 395);
            this.TaskPage.TabIndex = 2;
            this.TaskPage.Text = "Задания";
            // 
            // RoomTasksGrid
            // 
            this.RoomTasksGrid.AllowUserToAddRows = false;
            this.RoomTasksGrid.AllowUserToDeleteRows = false;
            this.RoomTasksGrid.AllowUserToResizeColumns = false;
            this.RoomTasksGrid.AllowUserToResizeRows = false;
            this.RoomTasksGrid.BackgroundColor = System.Drawing.Color.Bisque;
            this.RoomTasksGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomTasksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTasksGrid.Location = new System.Drawing.Point(3, 3);
            this.RoomTasksGrid.MultiSelect = false;
            this.RoomTasksGrid.Name = "RoomTasksGrid";
            this.RoomTasksGrid.ReadOnly = true;
            this.RoomTasksGrid.RowHeadersVisible = false;
            this.RoomTasksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.RoomTasksGrid.RowTemplate.ReadOnly = true;
            this.RoomTasksGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomTasksGrid.Size = new System.Drawing.Size(580, 346);
            this.RoomTasksGrid.TabIndex = 3;
            this.RoomTasksGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RoomTasksGrid_CellMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Peru;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 43);
            this.panel3.TabIndex = 2;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AllowUserToResizeRows = false;
            this.dataTable.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(274, 41);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(594, 438);
            this.dataTable.TabIndex = 5;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsPanel.Controls.Add(this.ToolsPanel);
            this.ButtonsPanel.Controls.Add(this.RoomInfo);
            this.ButtonsPanel.Controls.Add(this.MenuButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 41);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(274, 438);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.ToolsPanel.Controls.Add(this.CreateRoom);
            this.ToolsPanel.Controls.Add(this.DeleteTaskButton);
            this.ToolsPanel.Controls.Add(this.AddTaskButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsPanel.ForeColor = System.Drawing.Color.Maroon;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 280);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(270, 106);
            this.ToolsPanel.TabIndex = 6;
            this.ToolsPanel.TabStop = false;
            this.ToolsPanel.Text = "Редактирование";
            // 
            // CreateRoom
            // 
            this.CreateRoom.BackColor = System.Drawing.Color.Orange;
            this.CreateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateRoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateRoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.CreateRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.CreateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.CreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateRoom.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRoom.ForeColor = System.Drawing.Color.Maroon;
            this.CreateRoom.Location = new System.Drawing.Point(3, 74);
            this.CreateRoom.Margin = new System.Windows.Forms.Padding(2);
            this.CreateRoom.Name = "CreateRoom";
            this.CreateRoom.Size = new System.Drawing.Size(264, 29);
            this.CreateRoom.TabIndex = 8;
            this.CreateRoom.Text = "Создать спор";
            this.CreateRoom.UseVisualStyleBackColor = false;
            this.CreateRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.BackColor = System.Drawing.Color.Chocolate;
            this.DeleteTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteTaskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.DeleteTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.DeleteTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.DeleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteTaskButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTaskButton.ForeColor = System.Drawing.Color.Lavender;
            this.DeleteTaskButton.Location = new System.Drawing.Point(3, 46);
            this.DeleteTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(264, 28);
            this.DeleteTaskButton.TabIndex = 7;
            this.DeleteTaskButton.Text = "Удалить задание";
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddTaskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.AddTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.AddTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTaskButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.Lavender;
            this.AddTaskButton.Location = new System.Drawing.Point(3, 18);
            this.AddTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(264, 28);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "Добавить задание";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RoomInfo
            // 
            this.RoomInfo.BackColor = System.Drawing.Color.Peru;
            this.RoomInfo.Controls.Add(this.PrefixInput);
            this.RoomInfo.Controls.Add(this.label8);
            this.RoomInfo.Controls.Add(this.PrizeInput);
            this.RoomInfo.Controls.Add(this.label7);
            this.RoomInfo.Controls.Add(this.EndTimeInput);
            this.RoomInfo.Controls.Add(this.label6);
            this.RoomInfo.Controls.Add(this.DescriptionInput);
            this.RoomInfo.Controls.Add(this.RoomNameInput);
            this.RoomInfo.Controls.Add(this.label4);
            this.RoomInfo.Controls.Add(this.label5);
            this.RoomInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomInfo.ForeColor = System.Drawing.Color.Maroon;
            this.RoomInfo.Location = new System.Drawing.Point(0, 0);
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.Size = new System.Drawing.Size(270, 280);
            this.RoomInfo.TabIndex = 5;
            this.RoomInfo.TabStop = false;
            this.RoomInfo.Text = "Информация о комнате";
            // 
            // PrefixInput
            // 
            this.PrefixInput.Location = new System.Drawing.Point(10, 155);
            this.PrefixInput.Name = "PrefixInput";
            this.PrefixInput.Size = new System.Drawing.Size(253, 22);
            this.PrefixInput.TabIndex = 8;
            this.PrefixInput.Text = "BOSS OF THIS GYM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(10, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Префикс для администратора:";
            // 
            // PrizeInput
            // 
            this.PrizeInput.Location = new System.Drawing.Point(9, 243);
            this.PrizeInput.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.PrizeInput.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PrizeInput.Name = "PrizeInput";
            this.PrizeInput.Size = new System.Drawing.Size(253, 22);
            this.PrizeInput.TabIndex = 6;
            this.PrizeInput.ThousandsSeparator = true;
            this.PrizeInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Призовой фонд:";
            // 
            // EndTimeInput
            // 
            this.EndTimeInput.CalendarForeColor = System.Drawing.Color.Maroon;
            this.EndTimeInput.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.EndTimeInput.CalendarTitleBackColor = System.Drawing.Color.Peru;
            this.EndTimeInput.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.EndTimeInput.CalendarTrailingForeColor = System.Drawing.Color.Chocolate;
            this.EndTimeInput.Checked = false;
            this.EndTimeInput.Location = new System.Drawing.Point(9, 199);
            this.EndTimeInput.Name = "EndTimeInput";
            this.EndTimeInput.Size = new System.Drawing.Size(255, 22);
            this.EndTimeInput.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Окончание спора:";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(9, 78);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(254, 55);
            this.DescriptionInput.TabIndex = 2;
            this.DescriptionInput.Text = "Описание нового спора";
            // 
            // RoomNameInput
            // 
            this.RoomNameInput.Location = new System.Drawing.Point(93, 23);
            this.RoomNameInput.Name = "RoomNameInput";
            this.RoomNameInput.Size = new System.Drawing.Size(171, 22);
            this.RoomNameInput.TabIndex = 1;
            this.RoomNameInput.Text = "Новый спор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Название:";
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.MenuButton.Location = new System.Drawing.Point(0, 386);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(270, 48);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "В меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.usernameLabel);
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(868, 41);
            this.UpperPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usernameLabel.Font = new System.Drawing.Font("MV Boli", 12F);
            this.usernameLabel.ForeColor = System.Drawing.Color.PeachPuff;
            this.usernameLabel.Location = new System.Drawing.Point(691, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(173, 37);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppName
            // 
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("MV Boli", 22F);
            this.AppName.ForeColor = System.Drawing.Color.PeachPuff;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AppName.Size = new System.Drawing.Size(864, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 479);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание спора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRoomForm_FormClosed);
            this.WorkPanel.ResumeLayout(false);
            this.RoomPages.ResumeLayout(false);
            this.AllPlayersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RoomPlayersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayersGrid)).EndInit();
            this.TaskPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.RoomInfo.ResumeLayout(false);
            this.RoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeInput)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TabControl RoomPages;
        private System.Windows.Forms.TabPage AllPlayersPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayerSearchInput;
        private System.Windows.Forms.TabPage RoomPlayersPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox RoomInfo;
        private System.Windows.Forms.RichTextBox DescriptionInput;
        private System.Windows.Forms.TextBox RoomNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ToolsPanel;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button CreateRoom;
        private System.Windows.Forms.DataGridView AllUsersDataGrid;
        private System.Windows.Forms.DateTimePicker EndTimeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RoomPlayersGrid;
        private System.Windows.Forms.DataGridView RoomTasksGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PrizeInput;
        private System.Windows.Forms.TextBox PrefixInput;
        private System.Windows.Forms.Label label8;
    }
}