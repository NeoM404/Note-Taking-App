using System;
using System.Windows.Forms;
using System.Data;

namespace Notes
{
    public partial class Form1 : Form
    {
        DataTable noteTable;
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noteTable = new DataTable();
            noteTable.Columns.Add("Title", typeof(string));
            noteTable.Columns.Add("Notes", typeof(string));
            dataGridView1.DataSource = noteTable;

           // noteTable.Columns["Notes"].Visible = false;
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            title_textBox.Clear();
            notes_textBox.Clear();
        }

        private void read_button_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                title_textBox.Text = noteTable.Rows[index].ItemArray[0].ToString();
                notes_textBox.Text = noteTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void dlt_button_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                noteTable.Rows.RemoveAt(index);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show($"{ex.Message}: Cannot delete an empty Message!!");
            }


        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(notes_textBox.Text) && !string.IsNullOrEmpty(title_textBox.Text))
            {
                noteTable.Rows.Add(title_textBox.Text, notes_textBox.Text);
                notes_textBox.Clear();
                title_textBox.Clear();
            }
        }
    }
}