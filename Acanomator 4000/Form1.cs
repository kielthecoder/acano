using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Acanomator_4000
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile;
        bool dirty;

        public Form1()
        {
            InitializeComponent();

            // Create the Open File dialog our application will use
            openFile = new OpenFileDialog();
            openFile.FileOk += openFile_FileOk;

            // Make sure our form resizes properly
            Form1_Resize(this, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the filter and filter index
            openFile.Filter = "CSV Files (.csv)|*.csv|Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFile.FilterIndex = 1;

            // One file at a time for now
            openFile.Multiselect = false;

            DialogResult result = openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            Activate();

            // Open the file that user selected
            Stream fileStream = openFile.OpenFile();

            using (TextFieldParser parser = new TextFieldParser(fileStream))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool once = false;
                int count = 0;

                while (!parser.EndOfData)
                {
                    // Read in the next user record
                    string[] fields = parser.ReadFields();

                    // First line is header (can skip)
                    if (once)
                    {
                        int n = dgvUsers.Rows.Add();

                        for (int m = 0; m < 8; m++)
                        {
                            dgvUsers.Rows[n].Cells[m].Value = fields[m];
                        }

                        count = count + 1;
                    }

                    once = true;
                }

                // Show how many user records we added
                lblStatus.Text = "Imported " + count + " user records";
            }

            fileStream.Close();
            dirty = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmAbout = new Acanomator_4000.Form2();
            frmAbout.ShowDialog(this);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // removed
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dirty)
            {
                if (MessageBox.Show("Changes have not been synchronized to the server. Do you still want to exit?",
                                    "Unsaved Changes", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
