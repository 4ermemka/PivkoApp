namespace PIVKO
{
    partial class ChooseTaskToCountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTaskToCountForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerSearchInput = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.RoomTasksGrid = new System.Windows.Forms.DataGridView();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.WorkPanel.Controls.Add(this.panel2);
            this.WorkPanel.Controls.Add(this.panel4);
            this.WorkPanel.Controls.Add(this.RoomTasksGrid);
            this.WorkPanel.Controls.Add(this.dataTable);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(357, 479);
            this.WorkPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PlayerSearchInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 43);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(70, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поиск:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerSearchInput
            // 
            this.PlayerSearchInput.Location = new System.Drawing.Point(76, 4);
            this.PlayerSearchInput.Multiline = true;
            this.PlayerSearchInput.Name = "PlayerSearchInput";
            this.PlayerSearchInput.Size = new System.Drawing.Size(267, 31);
            this.PlayerSearchInput.TabIndex = 3;
            this.PlayerSearchInput.TextChanged += new System.EventHandler(this.PlayerSearchInput_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.MenuButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 43);
            this.panel4.TabIndex = 10;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkRed;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.MistyRose;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(353, 39);
            this.MenuButton.TabIndex = 9;
            this.MenuButton.Text = "В меню";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RoomTasksGrid
            // 
            this.RoomTasksGrid.AllowUserToAddRows = false;
            this.RoomTasksGrid.AllowUserToDeleteRows = false;
            this.RoomTasksGrid.AllowUserToResizeColumns = false;
            this.RoomTasksGrid.AllowUserToResizeRows = false;
            this.RoomTasksGrid.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.RoomTasksGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomTasksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomTasksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomTasksGrid.Location = new System.Drawing.Point(0, 41);
            this.RoomTasksGrid.MultiSelect = false;
            this.RoomTasksGrid.Name = "RoomTasksGrid";
            this.RoomTasksGrid.ReadOnly = true;
            this.RoomTasksGrid.RowHeadersVisible = false;
            this.RoomTasksGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.RoomTasksGrid.RowTemplate.ReadOnly = true;
            this.RoomTasksGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomTasksGrid.Size = new System.Drawing.Size(357, 438);
            this.RoomTasksGrid.TabIndex = 8;
            this.RoomTasksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomTasksGrid_CellDoubleClick);
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
            this.dataTable.Location = new System.Drawing.Point(0, 41);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(357, 438);
            this.dataTable.TabIndex = 5;
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.DarkRed;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(357, 41);
            this.UpperPanel.TabIndex = 0;
            // 
            // AppName
            // 
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.AppName.ForeColor = System.Drawing.Color.MistyRose;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AppName.Size = new System.Drawing.Size(353, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChooseTaskToCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 479);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseTaskToCountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Какое задание засчитать?";
            this.WorkPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTasksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlayerSearchInput;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView RoomTasksGrid;
    }
}