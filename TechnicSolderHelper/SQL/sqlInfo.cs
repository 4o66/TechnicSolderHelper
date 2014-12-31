﻿using System;
using System.Windows.Forms;
using TechnicSolderHelper.Confighandler;
using TechnicSolderHelper.cryptography;
using TechnicSolderHelper.Properties;

namespace TechnicSolderHelper.SQL
{
    public partial class SqlInfo : Form
    {
        public SqlInfo()
        {
            InitializeComponent();
            Crypto crypto = new Crypto();
            ConfigHandler ch = new ConfigHandler();
            database.Text = ch.GetConfig("mysqlDatabase");
            serveraddress.Text = ch.GetConfig("mysqlAddress");
            password.Text = crypto.DecryptString(ch.GetConfig("mysqlPassword"));
            username.Text = ch.GetConfig("mysqlUsername");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsEverythingFilledIn())
            {
                SolderSqlHandler sqh = new SolderSqlHandler(serveraddress.Text, username.Text, password.Text, database.Text);
                sqh.TestConnection();
            }
            else
            {
                MessageBox.Show("Please_fill_out_all_the_data");
            }
        }

        private bool IsEverythingFilledIn()
        {
            return !String.IsNullOrWhiteSpace(database.Text) && !String.IsNullOrWhiteSpace(serveraddress.Text) && !String.IsNullOrWhiteSpace(username.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsEverythingFilledIn())
            {
                ConfigHandler ch = new ConfigHandler();
                Crypto crypto = new Crypto();
                ch.SetConfig("mysqlUsername", username.Text);
                ch.SetConfig("mysqlPassword", crypto.EncryptToString(password.Text));
                ch.SetConfig("mysqlAddress", serveraddress.Text);
                ch.SetConfig("mysqlDatabase", database.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill out all the data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
