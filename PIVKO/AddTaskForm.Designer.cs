
namespace PIVKO
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.ApplyTaskButton = new System.Windows.Forms.Button();
            this.RoomInfo = new System.Windows.Forms.GroupBox();
            this.PointsCountInput = new System.Windows.Forms.NumericUpDown();
            this.TaskNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.RoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCountInput)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.WorkPanel.Controls.Add(this.ApplyTaskButton);
            this.WorkPanel.Controls.Add(this.RoomInfo);
            this.WorkPanel.Controls.Add(this.ExitButton);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(296, 195);
            this.WorkPanel.TabIndex = 1;
            // 
            // ApplyTaskButton
            // 
            this.ApplyTaskButton.BackColor = System.Drawing.Color.Gold;
            this.ApplyTaskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ApplyTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ApplyTaskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.ApplyTaskButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.ApplyTaskButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ApplyTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyTaskButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ApplyTaskButton.Location = new System.Drawing.Point(0, 131);
            this.ApplyTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyTaskButton.Name = "ApplyTaskButton";
            this.ApplyTaskButton.Size = new System.Drawing.Size(296, 32);
            this.ApplyTaskButton.TabIndex = 7;
            this.ApplyTaskButton.Text = "Добавить задание";
            this.ApplyTaskButton.UseVisualStyleBackColor = false;
            this.ApplyTaskButton.Click += new System.EventHandler(this.ApplyTaskButton_Click);
            // 
            // RoomInfo
            // 
            this.RoomInfo.BackColor = System.Drawing.Color.Khaki;
            this.RoomInfo.Controls.Add(this.PointsCountInput);
            this.RoomInfo.Controls.Add(this.TaskNameInput);
            this.RoomInfo.Controls.Add(this.label4);
            this.RoomInfo.Controls.Add(this.label5);
            this.RoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomInfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RoomInfo.Location = new System.Drawing.Point(0, 41);
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.Size = new System.Drawing.Size(296, 122);
            this.RoomInfo.TabIndex = 6;
            this.RoomInfo.TabStop = false;
            this.RoomInfo.Text = "Информация о задании";
            // 
            // PointsCountInput
            // 
            this.PointsCountInput.Location = new System.Drawing.Point(112, 53);
            this.PointsCountInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PointsCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PointsCountInput.Name = "PointsCountInput";
            this.PointsCountInput.Size = new System.Drawing.Size(171, 22);
            this.PointsCountInput.TabIndex = 2;
            this.PointsCountInput.ThousandsSeparator = true;
            this.PointsCountInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TaskNameInput
            // 
            this.TaskNameInput.Location = new System.Drawing.Point(112, 23);
            this.TaskNameInput.Name = "TaskNameInput";
            this.TaskNameInput.Size = new System.Drawing.Size(171, 22);
            this.TaskNameInput.TabIndex = 1;
            this.TaskNameInput.Text = "Задание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кол-во очков:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Название:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Olive;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Honeydew;
            this.ExitButton.Location = new System.Drawing.Point(0, 163);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(296, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.Olive;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.usernameLabel);
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(296, 41);
            this.UpperPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usernameLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.usernameLabel.ForeColor = System.Drawing.Color.OldLace;
            this.usernameLabel.Location = new System.Drawing.Point(119, 0);
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
            this.AppName.Size = new System.Drawing.Size(292, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 195);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить задание";
            this.WorkPanel.ResumeLayout(false);
            this.RoomInfo.ResumeLayout(false);
            this.RoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCountInput)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox RoomInfo;
        private System.Windows.Forms.TextBox TaskNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PointsCountInput;
        private System.Windows.Forms.Button ApplyTaskButton;
    }
}