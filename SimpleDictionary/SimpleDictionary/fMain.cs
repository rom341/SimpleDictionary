using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDictionary
{
    public partial class fMain : Form
    {
        int maxColumsCount = 0;
        List<List<string>> dictionary = new List<List<string>>();
        string lastOpenedFile = "";
        public fMain()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string readedText = sr.ReadToEnd();
                sr.Close();
                dgvDictionaryTable.Rows.Clear();
                dictionary.Clear();
                AddRowsToDictionaryTable(readedText);
                AddRowsToDvgTable();
                lastOpenedFile = openFileDialog1.FileName;
            }
        }
        private void WriteToTxtFile(List<List<string>> data, StreamWriter writer)
        {
            string line = "";
            foreach (var row in data)
            {
                line = string.Join(" - ", row);
                writer.WriteLine(line);
            }
        }
        private void AddRowsToDictionaryTable(string text)
        {
            List<string> lines = text.Split('\n').ToList();
            foreach(string line in lines)
            {
                if(line == string.Empty) continue;
                List<string> values = line.Split(new string[] { " - " }, StringSplitOptions.None).ToList();
                for (int i = 0; i < values.Count; i++) 
                {
                    values[i] = values[i].Trim();
                }
                if (values.Count > maxColumsCount)
                {
                    maxColumsCount = values.Count;
                }
                dictionary.Add(values.ToList());                
            }
        }

        private void updateDictionaryTable(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    List<string> values = new List<string>();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            values.Add(cell.Value.ToString());
                        }
                        else
                        {
                            values.Add(string.Empty);
                        }
                    }
                    dictionary.Add(values);
                }
            }
        }
        private void AddRowsToDvgTable()
        {
            dgvDictionaryTable.Columns.Clear();
            for (int i = 0; i < maxColumsCount; i++)
            {
                dgvDictionaryTable.Columns.Add("Column" + i, "Column" + i);
            }
            foreach (List<string> line in dictionary)
            {
                dgvDictionaryTable.Rows.Add(line.ToArray());
            }
        }
        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            dgvDictionaryTable.Columns.Add(tbColumnName.Text, tbColumnName.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = lastOpenedFile;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            dictionary.Clear();
            updateDictionaryTable(dgvDictionaryTable);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    WriteToTxtFile(dictionary, writer);
                }
            }
        }
    }
}
