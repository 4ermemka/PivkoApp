
namespace PIVKO
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DelUserButton = new System.Windows.Forms.Button();
            this.JudgeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.WorkPanel.Controls.Add(this.panel1);
            this.WorkPanel.Controls.Add(this.JudgeButton);
            this.WorkPanel.Controls.Add(this.ExitButton);
            this.WorkPanel.Controls.Add(this.PlayerButton);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(296, 386);
            this.WorkPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DelUserButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 32);
            this.panel1.TabIndex = 6;
            // 
            // DelUserButton
            // 
            this.DelUserButton.BackColor = System.Drawing.Color.DarkGreen;
            this.DelUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelUserButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.DelUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.DelUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.DelUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelUserButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelUserButton.ForeColor = System.Drawing.Color.Honeydew;
            this.DelUserButton.Location = new System.Drawing.Point(0, 0);
            this.DelUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.DelUserButton.Name = "DelUserButton";
            this.DelUserButton.Size = new System.Drawing.Size(296, 32);
            this.DelUserButton.TabIndex = 3;
            this.DelUserButton.Text = "Удалить аккаунт";
            this.DelUserButton.UseVisualStyleBackColor = false;
            this.DelUserButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // JudgeButton
            // 
            this.JudgeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.JudgeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JudgeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.JudgeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.JudgeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.JudgeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.JudgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JudgeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudgeButton.ForeColor = System.Drawing.Color.Honeydew;
            this.JudgeButton.Location = new System.Drawing.Point(0, 76);
            this.JudgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(296, 35);
            this.JudgeButton.TabIndex = 5;
            this.JudgeButton.Text = "Судья";
            this.JudgeButton.UseVisualStyleBackColor = false;
            this.JudgeButton.Click += new System.EventHandler(this.JudgeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Honeydew;
            this.ExitButton.Location = new System.Drawing.Point(0, 354);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(296, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayerButton
            // 
            this.PlayerButton.BackColor = System.Drawing.Color.SeaGreen;
            this.PlayerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.PlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.PlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.PlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerButton.ForeColor = System.Drawing.Color.Honeydew;
            this.PlayerButton.Location = new System.Drawing.Point(0, 41);
            this.PlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(296, 35);
            this.PlayerButton.TabIndex = 3;
            this.PlayerButton.Text = "Участник";
            this.PlayerButton.UseVisualStyleBackColor = false;
            this.PlayerButton.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.SeaGreen;
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
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Lime;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 386);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.WorkPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button JudgeButton;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DelUserButton;
        private System.Windows.Forms.Panel panel1;
    }
}