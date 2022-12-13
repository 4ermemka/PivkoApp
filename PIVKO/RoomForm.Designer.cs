
namespace PIVKO
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.RoomPages = new System.Windows.Forms.TabControl();
            this.PlayersPage = new System.Windows.Forms.TabPage();
            this.PlayerToolsPanel = new System.Windows.Forms.Panel();
            this.DelPlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.RoomPlayersGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerSearchInput = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TaskToolsPanel = new System.Windows.Forms.Panel();
            this.DelTaskButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.RoomTasksGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskSearchInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RoomInfo = new System.Windows.Forms.GroupBox();
            this.PrefixInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrizeInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionInput = new System.Windows.Forms.RichTextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.RoomNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminNickname = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.RoomPages.SuspendLayout();
            this.PlayersPage.SuspendLayout();
            this.PlayerToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayersGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TaskToolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.RoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeInput)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.WorkPanel.Controls.Add(this.RoomPages);
            this.WorkPanel.Controls.Add(this.ButtonsPanel);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(793, 536);
            this.WorkPanel.TabIndex = 1;
            // 
            // RoomPages
            // 
            this.RoomPages.Controls.Add(this.PlayersPage);
            this.RoomPages.Controls.Add(this.tabPage2);
            this.RoomPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomPages.Location = new System.Drawing.Point(270, 41);
            this.RoomPages.Margin = new System.Windows.Forms.Padding(7);
            this.RoomPages.Name = "RoomPages";
            this.RoomPages.Padding = new System.Drawing.Point(101, 10);
            this.RoomPages.SelectedIndex = 0;
            this.RoomPages.Size = new System.Drawing.Size(523, 495);
            this.RoomPages.TabIndex = 5;
            // 
            // PlayersPage
            // 
            this.PlayersPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PlayersPage.Controls.Add(this.PlayerToolsPanel);
            this.PlayersPage.Controls.Add(this.RoomPlayersGrid);
            this.PlayersPage.Controls.Add(this.panel1);
            this.PlayersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersPage.Location = new System.Drawing.Point(4, 39);
            this.PlayersPage.Name = "PlayersPage";
            this.PlayersPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayersPage.Size = new System.Drawing.Size(515, 452);
            this.PlayersPage.TabIndex = 0;
            this.PlayersPage.Text = "Игроки";
            // 
            // PlayerToolsPanel
            // 
            this.PlayerToolsPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PlayerToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerToolsPanel.Controls.Add(this.DelPlayerButton);
            this.PlayerToolsPanel.Controls.Add(this.AddPlayerButton);
            this.PlayerToolsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerToolsPanel.Location = new System.Drawing.Point(3, 363);
            this.PlayerToolsPanel.Name = "PlayerToolsPanel";
            this.PlayerToolsPanel.Size = new System.Drawing.Size(509, 43);
            this.PlayerToolsPanel.TabIndex = 4;
            // 
            // DelPlayerButton
            // 
            this.DelPlayerButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DelPlayerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DelPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelPlayerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.DelPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.DelPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.DelPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelPlayerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelPlayerButton.ForeColor = System.Drawing.Color.Lavender;
            this.DelPlayerButton.Location = new System.Drawing.Point(254, 0);
            this.DelPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelPlayerButton.Name = "DelPlayerButton";
            this.DelPlayerButton.Size = new System.Drawing.Size(251, 39);
            this.DelPlayerButton.TabIndex = 6;
            this.DelPlayerButton.Text = "Удалить игрока";
            this.DelPlayerButton.UseVisualStyleBackColor = false;
            this.DelPlayerButton.Click += new System.EventHandler(this.DelPlayerButton_Click);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddPlayerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddPlayerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.AddPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.AddPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.AddPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPlayerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerButton.ForeColor = System.Drawing.Color.Lavender;
            this.AddPlayerButton.Location = new System.Drawing.Point(0, 0);
            this.AddPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(250, 39);
            this.AddPlayerButton.TabIndex = 4;
            this.AddPlayerButton.Text = "Добавить игрока";
            this.AddPlayerButton.UseVisualStyleBackColor = false;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // RoomPlayersGrid
            // 
            this.RoomPlayersGrid.AllowUserToAddRows = false;
            this.RoomPlayersGrid.AllowUserToDeleteRows = false;
            this.RoomPlayersGrid.AllowUserToResizeColumns = false;
            this.RoomPlayersGrid.AllowUserToResizeRows = false;
            this.RoomPlayersGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.RoomPlayersGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomPlayersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomPlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomPlayersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPlayersGrid.Location = new System.Drawing.Point(3, 3);
            this.RoomPlayersGrid.MultiSelect = false;
            this.RoomPlayersGrid.Name = "RoomPlayersGrid";
            this.RoomPlayersGrid.ReadOnly = true;
            this.RoomPlayersGrid.RowHeadersVisible = false;
            this.RoomPlayersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RoomPlayersGrid.RowTemplate.ReadOnly = true;
            this.RoomPlayersGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomPlayersGrid.Size = new System.Drawing.Size(509, 403);
            this.RoomPlayersGrid.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PlayerSearchInput);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 43);
            this.panel1.TabIndex = 0;
            // 
            // PlayerSearchInput
            // 
            this.PlayerSearchInput.Location = new System.Drawing.Point(78, 4);
            this.PlayerSearchInput.Multiline = true;
            this.PlayerSearchInput.Name = "PlayerSearchInput";
            this.PlayerSearchInput.Size = new System.Drawing.Size(372, 31);
            this.PlayerSearchInput.TabIndex = 3;
            this.PlayerSearchInput.TextChanged += new System.EventHandler(this.PlayerSearchInput_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(0, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SearchLabel.Size = new System.Drawing.Size(72, 39);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Поиск:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.TaskToolsPanel);
            this.tabPage2.Controls.Add(this.RoomTasksGrid);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задания";
            // 
            // TaskToolsPanel
            // 
            this.TaskToolsPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TaskToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaskToolsPanel.Controls.Add(this.DelTaskButton);
            this.TaskToolsPanel.Controls.Add(this.AddTaskButton);
            this.TaskToolsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TaskToolsPanel.Location = new System.Drawing.Point(3, 363);
            this.TaskToolsPanel.Name = "TaskToolsPanel";
            this.TaskToolsPanel.Size = new System.Drawing.Size(509, 43);
            this.TaskToolsPanel.TabIndex = 5;
            // 
            // DelTaskButton
            // 
            this.DelTaskButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DelTaskButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DelTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelTaskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.DelTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.DelTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.DelTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelTaskButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelTaskButton.ForeColor = System.Drawing.Color.Lavender;
            this.DelTaskButton.Location = new System.Drawing.Point(254, 0);
            this.DelTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelTaskButton.Name = "DelTaskButton";
            this.DelTaskButton.Size = new System.Drawing.Size(251, 39);
            this.DelTaskButton.TabIndex = 7;
            this.DelTaskButton.Text = "Удалить задание";
            this.DelTaskButton.UseVisualStyleBackColor = false;
            this.DelTaskButton.Click += new System.EventHandler(this.DelTaskButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddTaskButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddTaskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.AddTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.AddTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTaskButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.Lavender;
            this.AddTaskButton.Location = new System.Drawing.Point(0, 0);
            this.AddTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(250, 39);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "Добавить задание";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RoomTasksGrid
            // 
            this.RoomTasksGrid.AllowUserToAddRows = false;
            this.RoomTasksGrid.AllowUserToDeleteRows = false;
            this.RoomTasksGrid.AllowUserToResizeColumns = false;
            this.RoomTasksGrid.AllowUserToResizeRows = false;
            this.RoomTasksGrid.BackgroundColor = System.Drawing.Color.LightBlue;
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
            this.RoomTasksGrid.Size = new System.Drawing.Size(509, 403);
            this.RoomTasksGrid.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TaskSearchInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 43);
            this.panel2.TabIndex = 1;
            // 
            // TaskSearchInput
            // 
            this.TaskSearchInput.Location = new System.Drawing.Point(78, 4);
            this.TaskSearchInput.Multiline = true;
            this.TaskSearchInput.Name = "TaskSearchInput";
            this.TaskSearchInput.Size = new System.Drawing.Size(372, 31);
            this.TaskSearchInput.TabIndex = 4;
            this.TaskSearchInput.TextChanged += new System.EventHandler(this.TaskSearchInput_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(72, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Поиск:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonsPanel.Controls.Add(this.RoomInfo);
            this.ButtonsPanel.Controls.Add(this.MenuButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 41);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(270, 495);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // RoomInfo
            // 
            this.RoomInfo.Controls.Add(this.PrefixInput);
            this.RoomInfo.Controls.Add(this.label8);
            this.RoomInfo.Controls.Add(this.PrizeInput);
            this.RoomInfo.Controls.Add(this.label7);
            this.RoomInfo.Controls.Add(this.AdminNickname);
            this.RoomInfo.Controls.Add(this.EndDateLabel);
            this.RoomInfo.Controls.Add(this.label6);
            this.RoomInfo.Controls.Add(this.DescriptionInput);
            this.RoomInfo.Controls.Add(this.SaveChangesButton);
            this.RoomInfo.Controls.Add(this.RoomNameInput);
            this.RoomInfo.Controls.Add(this.label2);
            this.RoomInfo.Controls.Add(this.label4);
            this.RoomInfo.Controls.Add(this.label1);
            this.RoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomInfo.Location = new System.Drawing.Point(0, 0);
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.Size = new System.Drawing.Size(270, 445);
            this.RoomInfo.TabIndex = 4;
            this.RoomInfo.TabStop = false;
            this.RoomInfo.Text = "Информация о комнате";
            // 
            // PrefixInput
            // 
            this.PrefixInput.Location = new System.Drawing.Point(10, 279);
            this.PrefixInput.Name = "PrefixInput";
            this.PrefixInput.Size = new System.Drawing.Size(253, 22);
            this.PrefixInput.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Префикс для администратора:";
            // 
            // PrizeInput
            // 
            this.PrizeInput.Location = new System.Drawing.Point(9, 367);
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
            this.PrizeInput.TabIndex = 13;
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Призовой фонд:";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.EndDateLabel.Location = new System.Drawing.Point(9, 323);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(98, 20);
            this.EndDateLabel.TabIndex = 10;
            this.EndDateLabel.Text = "DATATIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(10, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Окончание спора:";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(9, 145);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(254, 112);
            this.DescriptionInput.TabIndex = 9;
            this.DescriptionInput.Text = "";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SaveChangesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveChangesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.SaveChangesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.SaveChangesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Lavender;
            this.SaveChangesButton.Location = new System.Drawing.Point(3, 404);
            this.SaveChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(264, 38);
            this.SaveChangesButton.TabIndex = 4;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // RoomNameInput
            // 
            this.RoomNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNameInput.Location = new System.Drawing.Point(9, 95);
            this.RoomNameInput.Name = "RoomNameInput";
            this.RoomNameInput.Size = new System.Drawing.Size(254, 22);
            this.RoomNameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Lavender;
            this.MenuButton.Location = new System.Drawing.Point(0, 445);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(270, 50);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "В меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.usernameLabel);
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(793, 41);
            this.UpperPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Lavender;
            this.usernameLabel.Location = new System.Drawing.Point(616, 0);
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
            this.AppName.Font = new System.Drawing.Font("MV Boli", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.Lavender;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AppName.Size = new System.Drawing.Size(789, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Название:";
            // 
            // AdminNickname
            // 
            this.AdminNickname.AutoSize = true;
            this.AdminNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminNickname.ForeColor = System.Drawing.Color.LightCyan;
            this.AdminNickname.Location = new System.Drawing.Point(9, 36);
            this.AdminNickname.Name = "AdminNickname";
            this.AdminNickname.Size = new System.Drawing.Size(91, 16);
            this.AdminNickname.TabIndex = 10;
            this.AdminNickname.Text = "AdminName";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комната";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomForm_FormClosed);
            this.WorkPanel.ResumeLayout(false);
            this.RoomPages.ResumeLayout(false);
            this.PlayersPage.ResumeLayout(false);
            this.PlayerToolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomPlayersGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.TaskToolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl RoomPages;
        private System.Windows.Forms.TabPage PlayersPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox RoomInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RoomNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button DelTaskButton;
        private System.Windows.Forms.Button DelPlayerButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.TextBox PlayerSearchInput;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TaskSearchInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrefixInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PrizeInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox DescriptionInput;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DataGridView RoomPlayersGrid;
        private System.Windows.Forms.DataGridView RoomTasksGrid;
        private System.Windows.Forms.Panel PlayerToolsPanel;
        private System.Windows.Forms.Panel TaskToolsPanel;
        private System.Windows.Forms.Label AdminNickname;
        private System.Windows.Forms.Label label4;
    }
}