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

namespace IncOutMessages
{
    public partial class Form1 : Form
    {
        //private string login = "Denis228";
        //private string name = "Denis Vasjanovich";
        private string login = "Vova322";
        private string name = "Władimir Jakowlew";
        private string comboBoxChat = "";
        private string message = "";
        private string file = "";
        private string readText = "";
        private bool buttonClick = false;
        //private bool first = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem == null || buttonClick == false || string.IsNullOrEmpty(textBoxMessage.Text.Trim()))
                return;
            file = @"C:\Users\Владимир\Documents\Visual Studio 2015\Projects\IncOutMessages\IncOutMessages\Chats\" + comboBoxChat + "-" + login + " (" + name + ")" + ".txt";
            if (!(File.Exists(file)))
                file = @"C:\Users\Владимир\Documents\Visual Studio 2015\Projects\IncOutMessages\IncOutMessages\Chats\" + login + " (" + name + ")" + "-" + comboBoxChat + ".txt";
            /*if (first == false)
            {
                message = login + " (" + name + ") : " + textBoxMessage.Text;
                first = true;
            }
            else*/
            message = login + " (" + name + ") : " + textBoxMessage.Text + Environment.NewLine;
            File.AppendAllText(file, message);
            readText = File.ReadAllText(file);
            labelMessage.Text = readText;
            textBoxMessage.Text = null;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChat = comboBoxUser.SelectedItem.ToString();
            buttonClick = false;

    }

        private void buttonPick_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem == null)
                return;
            file = @"C:\Users\Владимир\Documents\Visual Studio 2015\Projects\IncOutMessages\IncOutMessages\Chats\" + comboBoxChat + "-" + login + " (" + name + ")" + ".txt";
            if (!(File.Exists(file)))
                file = @"C:\Users\Владимир\Documents\Visual Studio 2015\Projects\IncOutMessages\IncOutMessages\Chats\" + login + " (" + name + ")" + "-" + comboBoxChat + ".txt";
            message = "";
            File.AppendAllText(file, message);
            readText = File.ReadAllText(file);
            labelMessage.Text = readText;
            buttonClick = true;
        }
    }
}
