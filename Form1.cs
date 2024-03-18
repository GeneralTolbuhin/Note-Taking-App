using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 noteManager = new Class1();
            noteManager.LoadNotes(list);
            LoadNotes();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.AutoSize = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            // Clear existing note content
            textbox.Clear();
            // Clear existing title
            Title.Clear();
            // Set focus to title textbox
            Title.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title.Text))
            {
                MessageBox.Show("Please enter a title before saving the note.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
            {
                sqlCon.Open();
                string insertQuery = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp)";
                SqlCommand command = new SqlCommand(insertQuery, sqlCon);
                command.Parameters.AddWithValue("@Title", Title.Text);
                command.Parameters.AddWithValue("@Content", textbox.Text);
                command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                command.ExecuteNonQuery();
                MessageBox.Show("Note saved successfully!");
                LoadNotes();
            }
        }
        private void LoadNotes()
        {
            list.Items.Clear(); // Clear existing items

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
            {
                sqlCon.Open();
                string selectQuery = "SELECT NoteID, Title, Content, Timestamp FROM Notes ORDER BY Timestamp DESC"; // Assuming Timestamp is the column name for the timestamp
                SqlCommand command = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Title"].ToString());
                    item.SubItems.Add(reader["Timestamp"].ToString());
                    item.Tag = reader["NoteID"]; // Store NoteID in Tag for future reference (e.g., deleting a note)
                    list.Items.Add(item);
                }
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {

            if (list.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = list.SelectedItems[0];
                int noteID = Convert.ToInt32(selectedItem.Tag);

                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    string deleteQuery = "DELETE FROM Notes WHERE NoteID = @NoteID";
                    SqlCommand command = new SqlCommand(deleteQuery, sqlCon);
                    command.Parameters.AddWithValue("@NoteID", noteID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Note deleted successfully!");
                    LoadNotes();
                }
            }
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.Font = fontDialog.Font;
                Title.Font = fontDialog.Font;
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
