using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace task5tap1
{
    public partial class Form1 : Form
    {
        private readonly string notesPath = Path.Combine(Application.StartupPath, "qeydler.txt");

        public Form1()
        {
            InitializeComponent();
            ShowAllNotes();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string text = txtNote.Text.Trim();
            if (text == "")
            {
                MessageBox.Show("Qeyd boş ola bilməz.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(notesPath, true, Encoding.UTF8)) // append
                {
                    sw.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {text}");
                }
                txtNote.Clear();
                ShowAllNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Qeyd yazılarkən xəta: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowNotes_Click(object sender, EventArgs e)
        {
            ShowAllNotes();
        }

        private void ShowAllNotes()
        {
            lstNotes.Items.Clear();
            try
            {
                if (!File.Exists(notesPath))
                {
                    lstNotes.Items.Add("(Hələ qeyd yoxdur)");
                    return;
                }

                using (StreamReader sr = new StreamReader(notesPath, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        lstNotes.Items.Add(line);
                }

                if (lstNotes.Items.Count == 0)
                    lstNotes.Items.Add("(Hələ qeyd yoxdur)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Qeydlər oxunarkən xəta: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchNote_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword == "")
            {
                MessageBox.Show("Açar söz daxil edin.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstNotes.Items.Clear();
            try
            {
                if (!File.Exists(notesPath))
                {
                    lstNotes.Items.Add("(Qeyd faylı yoxdur)");
                    return;
                }

                int found = 0;
                using (StreamReader sr = new StreamReader(notesPath, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            lstNotes.Items.Add(line);
                            found++;
                        }
                    }
                }

                if (found == 0)
                    lstNotes.Items.Add("(Heç nə tapılmadı)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Axtarış zamanı xəta: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(notesPath))
                {
                    MessageBox.Show("Silinəcək qeyd faylı yoxdur.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult dr = MessageBox.Show("Bütün qeydlər silinsin? (y/n)", "Təsdiq",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                File.Delete(notesPath);
                lstNotes.Items.Clear();
                lstNotes.Items.Add("(Bütün qeydlər silindi)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silinmə zamanı xəta: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
