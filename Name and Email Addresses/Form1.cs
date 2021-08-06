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

namespace Name_and_Email_Addresses
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> addressBook = new Dictionary<string, string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile();
            DisplayAll(); 
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            string nameString = NameInput.Text;
            string emailString = EmailInput.Text;
            if (nameString.Length > 0 && emailString.Length > 0)
            {
                if (EmailOk(emailString))
                {
                    addressBook.Add(nameString, emailString);
                    NamesListBox.Items.Add(nameString);
                    NameInput.Clear();
                    EmailInput.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
            }
            else
            {
                MessageBox.Show("Error. Ensure both fields are not empty"); 
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            SaveFile(); 
            this.Close(); 
        }


        private bool EmailOk(string emailString)
        {
            bool emailOk = false;

            if (emailString.Contains('@'))
                {
                emailOk = true; 
                }

            return emailOk; 
        }

        private void NamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = NamesListBox.SelectedIndex;

            NameOutput.Text = addressBook.Keys.ElementAt(index);
            EmailOutput.Text = addressBook.Values.ElementAt(index);
        }


        private void SaveFile()
        {
            try
            {
                StreamWriter fileOut = new StreamWriter("Address.txt");
                foreach (var element in addressBook)
                {
                    fileOut.WriteLine(element.Key + "," + element.Value); 
                }
                fileOut.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }


        private void OpenFile()
        {
            try
            {
                StreamReader fileIn = new StreamReader("Address.txt");
                char delim = ',';
                string line;

                while (!fileIn.EndOfStream)
                {
                    line = fileIn.ReadLine();
                    string[] entry = line.Split(delim);
                    addressBook.Add(entry[0], entry[1]); 
                }

                fileIn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NamesListBox.SelectedIndex > -1)
            {
                string deleteKey = addressBook.ElementAt(NamesListBox.SelectedIndex).Key;
                addressBook.Remove(deleteKey);
                SaveFile();
                addressBook.Clear();
                NamesListBox.Items.Clear(); 
                OpenFile(); 
                DisplayAll();              
            }
        }


        private void DisplayAll()
        {
            foreach (var element in addressBook)
            {
                NamesListBox.Items.Add(element.Key);
            }
        }
    }
}