namespace dsa
{
    partial class Bracket
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
            this.lstBracket = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeamName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTeamName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsBracket = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBracket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBracket
            // 
            this.lstBracket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chStage,
            this.chTeamName1,
            this.chTeamName2,
            this.chResult});
            this.lstBracket.Location = new System.Drawing.Point(12, 40);
            this.lstBracket.Name = "lstBracket";
            this.lstBracket.Size = new System.Drawing.Size(406, 212);
            this.lstBracket.TabIndex = 19;
            this.lstBracket.UseCompatibleStateImageBehavior = false;
            this.lstBracket.View = System.Windows.Forms.View.Details;
            this.lstBracket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBracket_MouseUp);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 24;
            // 
            // chStage
            // 
            this.chStage.Text = "Стадия";
            this.chStage.Width = 107;
            // 
            // chTeamName1
            // 
            this.chTeamName1.Text = "Команда 1";
            this.chTeamName1.Width = 96;
            // 
            // chTeamName2
            // 
            this.chTeamName2.Text = "Команда 2";
            this.chTeamName2.Width = 98;
            // 
            // chResult
            // 
            this.chResult.Text = "Результат";
            this.chResult.Width = 65;
            // 
            // cmsBracket
            // 
            this.cmsBracket.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.cmsBracket.Name = "cmsTournament";
            this.cmsBracket.Size = new System.Drawing.Size(207, 70);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.EditToolStripMenuItem.Text = "Открыть/Редактировать";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // Bracket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.lstBracket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bracket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Турнирная сетка";
            this.Load += new System.EventHandler(this.Bracket_Load);
            this.cmsBracket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBracket;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chStage;
        private System.Windows.Forms.ColumnHeader chTeamName1;
        private System.Windows.Forms.ColumnHeader chTeamName2;
        private System.Windows.Forms.ColumnHeader chResult;
        private System.Windows.Forms.ContextMenuStrip cmsBracket;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}