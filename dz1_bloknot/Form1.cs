using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace dz1_bloknot
{
    public partial class Form1 : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public string filename;
        public bool isFileChanged;
        public FontSettings fontSetts;
        public Spravka spravka;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle(); 
        }
        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }
        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";           
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("невозможно откртыть файл!");
                }
            }
            UpdateTextWithTitle();
        }
        public void SaveFile(string _filename)
        {
            if(_filename == "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename + ".txt");
                sw.Write(textBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("невозможно сохранить файл!");
            }
            UpdateTextWithTitle();
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }
        private void OnTextChanged(object sender, EventArgs args)
        {     
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("сохранить изменения?", "сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }
        public void UpdateTextWithTitle()
        {
            if (filename!= "")          
            this.Text = filename + " - блокнотик";           
            else this.Text = "безымянный - блокнотик";

        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }
        private void OnFontClick(object sender, EventArgs e)
        {
            fontSetts = new FontSettings();
            fontSetts.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSetts != null)
            {
                fontSize = fontSetts.fontSize;
                fs = fontSetts.fs;
                textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize, fs);
                fontSetts.Close();
            }
        }

        private void Spravka(object sender, EventArgs e)
        {
            spravka = new Spravka();
            spravka.Show();
        }
    } 
}
