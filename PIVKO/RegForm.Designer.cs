
namespace PIVKO
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.TogglePasswordVisibility = new System.Windows.Forms.Button();
            this.ToggleRepeatPasswordVisibility = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RepLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SecondPasswordInput = new System.Windows.Forms.TextBox();
            this.PhoneInput = new System.Windows.Forms.TextBox();
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
            this.WorkPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WorkPanel.Controls.Add(this.RegButton);
            this.WorkPanel.Controls.Add(this.TogglePasswordVisibility);
            this.WorkPanel.Controls.Add(this.ToggleRepeatPasswordVisibility);
            this.WorkPanel.Controls.Add(this.LoginButton);
            this.WorkPanel.Controls.Add(this.RepLabel);
            this.WorkPanel.Controls.Add(this.PhoneLabel);
            this.WorkPanel.Controls.Add(this.PasswordLabel);
            this.WorkPanel.Controls.Add(this.loginLabel);
            this.WorkPanel.Controls.Add(this.SecondPasswordInput);
            this.WorkPanel.Controls.Add(this.PhoneInput);
            this.WorkPanel.Controls.Add(this.PasswordInput);
            this.WorkPanel.Controls.Add(this.LoginInput);
            this.WorkPanel.Controls.Add(this.UpperPanel);
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(406, 243);
            this.WorkPanel.TabIndex = 1;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Turquoise;
            this.RegButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RegButton.Location = new System.Drawing.Point(184, 202);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(214, 32);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // TogglePasswordVisibility
            // 
            this.TogglePasswordVisibility.BackColor = System.Drawing.Color.Turquoise;
            this.TogglePasswordVisibility.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TogglePasswordVisibility.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.TogglePasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.TogglePasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.TogglePasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TogglePasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglePasswordVisibility.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TogglePasswordVisibility.Location = new System.Drawing.Point(373, 127);
            this.TogglePasswordVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.TogglePasswordVisibility.Name = "TogglePasswordVisibility";
            this.TogglePasswordVisibility.Size = new System.Drawing.Size(25, 24);
            this.TogglePasswordVisibility.TabIndex = 3;
            this.TogglePasswordVisibility.Text = "*";
            this.TogglePasswordVisibility.UseVisualStyleBackColor = false;
            this.TogglePasswordVisibility.Click += new System.EventHandler(this.TogglePasswordVisibility_Click);
            // 
            // ToggleRepeatPasswordVisibility
            // 
            this.ToggleRepeatPasswordVisibility.BackColor = System.Drawing.Color.Turquoise;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.ToggleRepeatPasswordVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ToggleRepeatPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToggleRepeatPasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleRepeatPasswordVisibility.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ToggleRepeatPasswordVisibility.Location = new System.Drawing.Point(373, 157);
            this.ToggleRepeatPasswordVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.ToggleRepeatPasswordVisibility.Name = "ToggleRepeatPasswordVisibility";
            this.ToggleRepeatPasswordVisibility.Size = new System.Drawing.Size(25, 24);
            this.ToggleRepeatPasswordVisibility.TabIndex = 3;
            this.ToggleRepeatPasswordVisibility.Text = "*";
            this.ToggleRepeatPasswordVisibility.UseVisualStyleBackColor = false;
            this.ToggleRepeatPasswordVisibility.Click += new System.EventHandler(this.ToggleRepeatPasswordVisibility_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Turquoise;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LoginButton.Location = new System.Drawing.Point(9, 202);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(171, 32);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RepLabel
            // 
            this.RepLabel.AutoSize = true;
            this.RepLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RepLabel.Location = new System.Drawing.Point(10, 157);
            this.RepLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RepLabel.Name = "RepLabel";
            this.RepLabel.Size = new System.Drawing.Size(118, 21);
            this.RepLabel.TabIndex = 2;
            this.RepLabel.Text = "Повтор пароля";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PhoneLabel.Location = new System.Drawing.Point(10, 77);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(74, 21);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Телефон";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PasswordLabel.Location = new System.Drawing.Point(10, 129);
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
            this.loginLabel.Location = new System.Drawing.Point(10, 48);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 21);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // SecondPasswordInput
            // 
            this.SecondPasswordInput.BackColor = System.Drawing.Color.Cornsilk;
            this.SecondPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPasswordInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SecondPasswordInput.Location = new System.Drawing.Point(132, 157);
            this.SecondPasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.SecondPasswordInput.Name = "SecondPasswordInput";
            this.SecondPasswordInput.Size = new System.Drawing.Size(237, 24);
            this.SecondPasswordInput.TabIndex = 1;
            this.SecondPasswordInput.UseSystemPasswordChar = true;
            // 
            // PhoneInput
            // 
            this.PhoneInput.BackColor = System.Drawing.Color.Cornsilk;
            this.PhoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PhoneInput.Location = new System.Drawing.Point(133, 76);
            this.PhoneInput.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(236, 24);
            this.PhoneInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.Cornsilk;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.PasswordInput.Location = new System.Drawing.Point(132, 127);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(237, 24);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // LoginInput
            // 
            this.LoginInput.BackColor = System.Drawing.Color.Cornsilk;
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LoginInput.Location = new System.Drawing.Point(133, 48);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(2);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(236, 24);
            this.LoginInput.TabIndex = 1;
            // 
            // UpperPanel
            // 
            this.UpperPanel.AutoScroll = true;
            this.UpperPanel.BackColor = System.Drawing.Color.Turquoise;
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpperPanel.Controls.Add(this.AppName);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(406, 41);
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
            this.AppName.Size = new System.Drawing.Size(402, 37);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "Pivko";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 243);
            this.Controls.Add(this.WorkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
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
        private System.Windows.Forms.Label RepLabel;
        private System.Windows.Forms.TextBox SecondPasswordInput;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.Button TogglePasswordVisibility;
        private System.Windows.Forms.Button ToggleRepeatPasswordVisibility;
    }
}