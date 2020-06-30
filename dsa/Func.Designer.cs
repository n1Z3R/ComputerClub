namespace dsa
{
    partial class Func
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Func));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTournaments = new System.Windows.Forms.Button();
            this.btnComputers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstNews = new System.Windows.Forms.ListBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTournaments
            // 
            this.btnTournaments.Location = new System.Drawing.Point(37, 38);
            this.btnTournaments.Name = "btnTournaments";
            this.btnTournaments.Size = new System.Drawing.Size(136, 23);
            this.btnTournaments.TabIndex = 1;
            this.btnTournaments.Text = "Турниры";
            this.btnTournaments.UseVisualStyleBackColor = true;
            this.btnTournaments.Click += new System.EventHandler(this.btnTournaments_Click);
            // 
            // btnComputers
            // 
            this.btnComputers.Location = new System.Drawing.Point(37, 85);
            this.btnComputers.Name = "btnComputers";
            this.btnComputers.Size = new System.Drawing.Size(136, 23);
            this.btnComputers.TabIndex = 2;
            this.btnComputers.Text = "Компьютеры";
            this.btnComputers.UseVisualStyleBackColor = true;
            this.btnComputers.Click += new System.EventHandler(this.btnComputers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstNews
            // 
            this.lstNews.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNews.FormattingEnabled = true;
            this.lstNews.ItemHeight = 26;
            this.lstNews.Location = new System.Drawing.Point(216, 38);
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(533, 342);
            this.lstNews.TabIndex = 4;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(37, 131);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(136, 23);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(37, 177);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(136, 23);
            this.btnTeams.TabIndex = 6;
            this.btnTeams.Text = "Команды";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 444);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lstNews);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComputers);
            this.Controls.Add(this.btnTournaments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEET1337";
            this.Load += new System.EventHandler(this.Func_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnComputers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstNews;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTeams;
    }
}