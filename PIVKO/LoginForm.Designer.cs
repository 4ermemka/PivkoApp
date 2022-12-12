
namespace PIVKO
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.ToggleRepeatPasswordVisibility = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.WorkPanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkPanel
            // 
            this.WorkPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.WorkPanel.Controls.Add(this.RegButton);
            this.WorkPanel.Controls.Add(this.ToggleRepeatPasswordVisibility);
            this.WorkPanel.Controls.Add(this.LoginButton);
            this.WorkPanel.Controls.Add(this.PasswordLabel);
            this.WorkPanel.Controls.Add(this.loginLabel);
            this.WorkPanel.Controls.Add(this.PasswordInput);
            this.WorkPanel.Controls.Add(this.LoginInput);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(330, 188);
            this.WorkPanel.TabIndex = 1;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Khaki;
            this.RegButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RegButton.Location = new System.Drawing.Point(177, 145);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(142, 32);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ToggleRepeatPasswordVisibility
            // 
            this.ToggleRepeatPasswordVisibility.BackColor = System.Drawing.Color.Khaki;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ToggleRepeatPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToggleRepeatPasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRepeatPasswordVisibility.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ToggleRepeatPasswordVisibility.Location = new System.Drawing.Point(292, 106);
            this.ToggleRepeatPasswordVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.ToggleRepeatPasswordVisibility.Name = "ToggleRepeatPasswordVisibility";
            this.ToggleRepeatPasswordVisibility.Size = new System.Drawing.Size(27, 24);
            this.ToggleRepeatPasswordVisibility.TabIndex = 3;
            this.ToggleRepeatPasswordVisibility.Text = "*";
            this.ToggleRepeatPasswordVisibility.UseVisualStyleBackColor = false;
            this.ToggleRepeatPasswordVisibility.Click += new System.EventHandler(this.TogglePasswordVisibility_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Khaki;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LoginButton.Location = new System.Drawing.Point(9, 146);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(142, 32);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 106);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 21);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginLabel.Location = new System.Drawing.Point(9, 60);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 21);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.Cornsilk;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PasswordInput.Location = new System.Drawing.Point(82, 106);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(206, 24);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.UseSystemPasswordChar = true;
            this.PasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordInput_KeyPress);
            // 
            // LoginInput
            // 
            this.LoginInput.BackColor = System.Drawing.Color.Cornsilk;
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LoginInput.Location = new System.Drawing.Point(84, 60);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(2);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(204, 24);
            this.LoginInput.TabIndex = 1;
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.Khaki;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(330, 41);
            this.UpperPanel.TabIndex = 0;
            // 
            // AppName
            // 
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppName.Font = new System.Drawing.Font("MV Boli", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.AppName.Size = new System.Drawing.Size(326, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 188);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логин";
            this.WorkPanel.ResumeLayout(false);
            this.WorkPanel.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button ToggleRepeatPasswordVisibility;
    }
}

