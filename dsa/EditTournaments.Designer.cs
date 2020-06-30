namespace dsa
{
    partial class EditTournaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTournaments));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtMaxplayers = new System.Windows.Forms.TextBox();
            this.lblMaxplayers = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnBracket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(667, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtMaxplayers
            // 
            this.txtMaxplayers.Location = new System.Drawing.Point(19, 329);
            this.txtMaxplayers.Name = "txtMaxplayers";
            this.txtMaxplayers.Size = new System.Drawing.Size(43, 20);
            this.txtMaxplayers.TabIndex = 52;
            // 
            // lblMaxplayers
            // 
            this.lblMaxplayers.AutoSize = true;
            this.lblMaxplayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxplayers.Location = new System.Drawing.Point(15, 313);
            this.lblMaxplayers.Name = "lblMaxplayers";
            this.lblMaxplayers.Size = new System.Drawing.Size(210, 13);
            this.lblMaxplayers.TabIndex = 51;
            this.lblMaxplayers.Text = "Максимальное кол-во команд/игроков:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(542, 414);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(119, 23);
            this.btnAccept.TabIndex = 50;
            this.btnAccept.Text = "Подтвердить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(20, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 49;
            this.lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 85);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(768, 212);
            this.txtDescription.TabIndex = 48;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(404, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 13);
            this.lblTime.TabIndex = 47;
            this.lblTime.Text = "Время:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(313, 54);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 13);
            this.lbl2.TabIndex = 46;
            this.lbl2.Text = "(год,месяц,день)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(326, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Дата:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(249, 15);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(29, 13);
            this.lblMode.TabIndex = 44;
            this.lblMode.Text = "Тип:";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(123, 14);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(35, 13);
            this.lblGame.TabIndex = 43;
            this.lblGame.Text = "Игра:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(16, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Название:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(326, 31);
            this.txtDate.Mask = "0000-00-00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(60, 20);
            this.txtDate.TabIndex = 41;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(407, 31);
            this.txtData.Mask = "00:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(33, 20);
            this.txtData.TabIndex = 40;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(252, 30);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(57, 21);
            this.cbMode.TabIndex = 39;
            // 
            // txtNameT
            // 
            this.txtNameT.Location = new System.Drawing.Point(18, 31);
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.Size = new System.Drawing.Size(100, 20);
            this.txtNameT.TabIndex = 38;
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Location = new System.Drawing.Point(124, 30);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(121, 21);
            this.cbGame.TabIndex = 37;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(417, 414);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 23);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.Location = new System.Drawing.Point(38, 378);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(0, 13);
            this.lblAccepted.TabIndex = 55;
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(12, 399);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(79, 39);
            this.btnMembers.TabIndex = 56;
            this.btnMembers.Text = "Список участников";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnBracket
            // 
            this.btnBracket.Location = new System.Drawing.Point(97, 399);
            this.btnBracket.Name = "btnBracket";
            this.btnBracket.Size = new System.Drawing.Size(79, 39);
            this.btnBracket.TabIndex = 57;
            this.btnBracket.Text = "Сетка";
            this.btnBracket.UseVisualStyleBackColor = true;
            this.btnBracket.Click += new System.EventHandler(this.btnBracket_Click);
            // 
            // EditTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBracket);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.lblAccepted);
            this.Controls.Add(this.btnEdit);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTournaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditTournaments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMaxplayers;
        private System.Windows.Forms.Label lblMaxplayers;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAccepted;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBracket;
    }
}