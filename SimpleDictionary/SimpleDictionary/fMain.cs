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
        int maxColumsCount = 3;
        PanelManager panelManager = new PanelManager();
        List<List<string>> dictionary = new List<List<string>>();
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
                updateDictionaryTable(readedText);
                updateDgvDictionaryTable();
            }
            
        }
        private void WriteToTxtFile(List<List<string>> data, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var record in data)
                {
                    string line = string.Join(" - ", record);
                    writer.WriteLine(line);
                }
            }
        }
        private void updateDictionaryTable(string text)
        {
            List<string> lines = text.Split('\n').ToList();
            foreach(string line in lines)
            {
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
        private void updateDgvDictionaryTable()
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
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteToTxtFile(dictionary, saveFileDialog1.FileName);
            }
        }
    }
}
