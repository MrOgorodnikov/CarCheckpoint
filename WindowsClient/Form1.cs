using CarCheckpoint.Models;
using CarCheckpoint.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsClient.BussinesLogic;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> adminSettings = new Dictionary<string, string>();
        const string password = "0988905606";
        public Form1()
        {
            InitializeComponent();

            foreach (var admSetting in Server.GetAdminSettings())
                adminSettings.Add(admSetting.Name, admSetting.Value);

            serialPort1.PortName = adminSettings.FirstOrDefault(a => a.Key == AdminSettingsNames.USBPort).Value;
            serialPort1.Open();
        }

        private void cardIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cardIdTextBox.Text.Length == 10)
            {
                var cardId = cardIdTextBox.Text;
                cardIdTextBox.Text = "";
                errorLabel.Text = "";

                if (cardId == password || adminSettings.Values.Contains(cardId))
                {
                    ReactionOnCard.Admin();
                    return;
                }

                var user = Server.GetUser(cardId);
                if (user.User == null)
                {
                    errorLabel.Text = "Unknown person";
                }
                else
                {
                    KnownUser(user);
                    if (user.User.Balance >= 0)
                    {
                        new Action(SendCommandOpen).BeginInvoke(null, null);
                        Server.AddEntrance(cardId);
                    }
                    else
                    {
                        errorLabel.Text = "No money";
                        new Action(SendCommandMoney).BeginInvoke(null, null);
                    }
                }
            }
        }


        private void SendCommandOpen()
        {        
            if (serialPort1.IsOpen)
                serialPort1.Write("H");
        }

        private void SendCommandMoney()
        {
            if (serialPort1.IsOpen)
                serialPort1.Write("A");
        }

        private void KnownUser(AllUserData user)
        {           
            nameLabel.Text = user.User.Name;
            surnameLabel.Text = user.User.Surname;
            garageLabel.Text = user.User.GarageNumber.ToString();            
            phoneLabel.Text = user.User.Phone;
            ballanceLabel.Text = user.User.Balance.ToString();
            errorLabel.Text = "";
        }
    }
}
