
namespace PIVKO
{
    partial class JudgeRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JudgeRoomsForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomSearchInput = new System.Windows.Forms.TextBox();
            this.JudgedRoomsTable = new System.Windows.Forms.DataGridView();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.CheckRoomButton = new System.Windows.Forms.Button();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgedRoomsTable)).BeginInit();
            this.ButtonsPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.WorkPanel.Controls.Add(this.panel1);
            this.WorkPanel.Controls.Add(this.JudgedRoomsTable);
            this.WorkPanel.Controls.Add(this.ButtonsPanel);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(793, 479);
            this.WorkPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RoomSearchInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(206, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 43);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(167, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск по комнатам:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomSearchInput
            // 
            this.RoomSearchInput.Location = new System.Drawing.Point(173, 4);
            this.RoomSearchInput.Multiline = true;
            this.RoomSearchInput.Name = "RoomSearchInput";
            this.RoomSearchInput.Size = new System.Drawing.Size(400, 31);
            this.RoomSearchInput.TabIndex = 3;
            this.RoomSearchInput.TextChanged += new System.EventHandler(this.RoomSearchInput_TextChanged);
            // 
            // JudgedRoomsTable
            // 
            this.JudgedRoomsTable.AllowUserToAddRows = false;
            this.JudgedRoomsTable.AllowUserToDeleteRows = false;
            this.JudgedRoomsTable.AllowUserToResizeColumns = false;
            this.JudgedRoomsTable.AllowUserToResizeRows = false;
            this.JudgedRoomsTable.BackgroundColor = System.Drawing.Color.Plum;
            this.JudgedRoomsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JudgedRoomsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JudgedRoomsTable.Location = new System.Drawing.Point(206, 41);
            this.JudgedRoomsTable.Margin = new System.Windows.Forms.Padding(2);
            this.JudgedRoomsTable.Name = "JudgedRoomsTable";
            this.JudgedRoomsTable.ReadOnly = true;
            this.JudgedRoomsTable.RowHeadersVisible = false;
            this.JudgedRoomsTable.RowHeadersWidth = 51;
            this.JudgedRoomsTable.RowTemplate.Height = 24;
            this.JudgedRoomsTable.Size = new System.Drawing.Size(587, 438);
            this.JudgedRoomsTable.TabIndex = 5;
            this.JudgedRoomsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Thistle;
            this.ButtonsPanel.Controls.Add(this.DeleteRoomButton);
            this.ButtonsPanel.Controls.Add(this.CheckRoomButton);
            this.ButtonsPanel.Controls.Add(this.CreateRoomButton);
            this.ButtonsPanel.Controls.Add(this.MenuButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 41);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(206, 438);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.DeleteRoomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteRoomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteRoomButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.DeleteRoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.DeleteRoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.DeleteRoomButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoomButton.ForeColor = System.Drawing.Color.Honeydew;
            this.DeleteRoomButton.Location = new System.Drawing.Point(0, 70);
            this.DeleteRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(206, 35);
            this.DeleteRoomButton.TabIndex = 6;
            this.DeleteRoomButton.Text = "Удалить спор";
            this.DeleteRoomButton.UseVisualStyleBackColor = false;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // CheckRoomButton
            // 
            this.CheckRoomButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.CheckRoomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckRoomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckRoomButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.CheckRoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.CheckRoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.CheckRoomButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRoomButton.ForeColor = System.Drawing.Color.Honeydew;
            this.CheckRoomButton.Location = new System.Drawing.Point(0, 35);
            this.CheckRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckRoomButton.Name = "CheckRoomButton";
            this.CheckRoomButton.Size = new System.Drawing.Size(206, 35);
            this.CheckRoomButton.TabIndex = 5;
            this.CheckRoomButton.Text = "Посмотреть спор";
            this.CheckRoomButton.UseVisualStyleBackColor = false;
            this.CheckRoomButton.Click += new System.EventHandler(this.CheckRoomButton_Click);
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.CreateRoomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateRoomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateRoomButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.CreateRoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.CreateRoomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.CreateRoomButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRoomButton.ForeColor = System.Drawing.Color.Honeydew;
            this.CreateRoomButton.Location = new System.Drawing.Point(0, 0);
            this.CreateRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(206, 35);
            this.CreateRoomButton.TabIndex = 4;
            this.CreateRoomButton.Text = "Создать спор";
            this.CreateRoomButton.UseVisualStyleBackColor = false;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.MenuButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Honeydew;
            this.MenuButton.Location = new System.Drawing.Point(0, 395);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(206, 43);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "В меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.DarkMagenta;
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
            this.usernameLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Honeydew;
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
            this.AppName.ForeColor = System.Drawing.Color.Honeydew;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AppName.Size = new System.Drawing.Size(789, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JudgeRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 479);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JudgeRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судейства";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JudgeRoomsForm_FormClosed);
            this.WorkPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgedRoomsTable)).EndInit();
            this.ButtonsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView JudgedRoomsTable;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.Button CheckRoomButton;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomSearchInput;
    }
}