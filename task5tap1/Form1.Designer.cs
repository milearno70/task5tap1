namespace task5tap1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchNote = new System.Windows.Forms.Button();
            this.btnShowNotes = new System.Windows.Forms.Button();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblNote.Text = "Yeni qeyd:";
            this.lblNote.Location = new System.Drawing.Point(15, 20);
            this.lblNote.AutoSize = true;

            this.txtNote.Location = new System.Drawing.Point(100, 17);
            this.txtNote.Size = new System.Drawing.Size(450, 23);
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.btnAddNote.Text = "Əlavə et";
            this.btnAddNote.Location = new System.Drawing.Point(565, 15);
            this.btnAddNote.Size = new System.Drawing.Size(120, 28);
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);

            this.lblSearch.Text = "Açar söz:";
            this.lblSearch.Location = new System.Drawing.Point(15, 60);
            this.lblSearch.AutoSize = true;

            this.txtSearch.Location = new System.Drawing.Point(100, 57);
            this.txtSearch.Size = new System.Drawing.Size(450, 23);
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.btnSearchNote.Text = "Axtar";
            this.btnSearchNote.Location = new System.Drawing.Point(565, 55);
            this.btnSearchNote.Size = new System.Drawing.Size(120, 28);
            this.btnSearchNote.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchNote.Click += new System.EventHandler(this.btnSearchNote_Click);

            this.btnShowNotes.Text = "Bütün qeydlər";
            this.btnShowNotes.Location = new System.Drawing.Point(15, 97);
            this.btnShowNotes.Size = new System.Drawing.Size(150, 30);
            this.btnShowNotes.Click += new System.EventHandler(this.btnShowNotes_Click);

            this.btnDeleteNotes.Text = "Bütün qeydləri sil";
            this.btnDeleteNotes.Location = new System.Drawing.Point(175, 97);
            this.btnDeleteNotes.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);

            this.btnExit.Text = "Çıxış";
            this.btnExit.Location = new System.Drawing.Point(335, 97);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.lstNotes.Location = new System.Drawing.Point(15, 140);
            this.lstNotes.Size = new System.Drawing.Size(670, 300);
            this.lstNotes.HorizontalScrollbar = true;
            this.lstNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchNote);
            this.Controls.Add(this.btnShowNotes);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstNotes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qeydlər Dəftəri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchNote;
        private System.Windows.Forms.Button btnShowNotes;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstNotes;
    }
}
