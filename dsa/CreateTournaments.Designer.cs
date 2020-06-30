namespace dsa
{
    partial class CreateTournaments
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.txtNameT = new System.Windows.Forms.TextBox();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblMaxplayers = new System.Windows.Forms.Label();
            this.txtMaxplayers = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(406, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 13);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "Время:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(315, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 13);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "(год,месяц,день)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(328, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Дата:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(251, 16);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(29, 13);
            this.lblMode.TabIndex = 27;
            this.lblMode.Text = "Тип:";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(125, 15);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(35, 13);
            this.lblGame.TabIndex = 26;
            this.lblGame.Text = "Игра:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(18, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Название:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(328, 32);
            this.txtDate.Mask = "0000-00-00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(60, 20);
            this.txtDate.TabIndex = 24;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(409, 32);
            this.txtData.Mask = "00:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(33, 20);
            this.txtData.TabIndex = 23;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(254, 31);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(57, 21);
            this.cbMode.TabIndex = 22;
            // 
            // txtNameT
            // 
            this.txtNameT.Location = new System.Drawing.Point(20, 32);
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.Size = new System.Drawing.Size(100, 20);
            this.txtNameT.TabIndex = 21;
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Location = new System.Drawing.Point(126, 31);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(121, 21);
            this.cbGame.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 86);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(768, 212);
            this.txtDescription.TabIndex = 31;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(22, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Описание:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(544, 415);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(119, 23);
            this.btnAccept.TabIndex = 33;
            this.btnAccept.Text = "Подтвердить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblMaxplayers
            // 
            this.lblMaxplayers.AutoSize = true;
            this.lblMaxplayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxplayers.Location = new System.Drawing.Point(17, 314);
            this.lblMaxplayers.Name = "lblMaxplayers";
            this.lblMaxplayers.Size = new System.Drawing.Size(210, 13);
            this.lblMaxplayers.TabIndex = 34;
            this.lblMaxplayers.Text = "Максимальное кол-во команд/игроков:";
            // 
            // txtMaxplayers
            // 
            this.txtMaxplayers.Location = new System.Drawing.Point(21, 330);
            this.txtMaxplayers.Name = "txtMaxplayers";
            this.txtMaxplayers.Size = new System.Drawing.Size(43, 20);
            this.txtMaxplayers.TabIndex = 35;
            this.txtMaxplayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxplayers_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(669, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMaxplayers);
            this.Controls.Add(this.lblMaxplayers);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.txtNameT);
            this.Controls.Add(this.cbGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTournaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание турнира";
            this.Load += new System.EventHandler(this.CreateTournaments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.TextBox txtNameT;
        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblMaxplayers;
        private System.Windows.Forms.TextBox txtMaxplayers;
        private System.Windows.Forms.Button btnBack;
    }
}