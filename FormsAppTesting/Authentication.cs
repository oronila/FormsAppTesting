using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace FormsAppTesting
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            string username;
            string password;

            message = "Enter your username.";
            title = "Login";
            defaultValue = "Username";
            username = Interaction.InputBox(message, title, defaultValue);
            password = Interaction.InputBox("Enter your password", "Password", "password");
            addInfo(username, password);

        }

        public void addInfo(string username, string password)
        {

            //List<creds> data = new List<creds>();
            var jsonData = System.IO.File.ReadAllText(@"C:\Users\noor\Desktop\Java Projects\Authentication\data\accounts.json");
            List <creds> data = JsonConvert.DeserializeObject<List<creds>>(jsonData)
                      ?? new List<creds>();
            data.Add(new creds()
            {
                user = username,
                pass = password
            }) ;

            string json = JsonConvert.SerializeObject(data);
            //string json = JsonSerializer.Serialize(_data);
            //File.Create(@"C:\Users\noor\Desktop\Java Projects\Authentication\data\"+ username+ ".json");
            File.WriteAllText(@"C:\Users\noor\Desktop\Java Projects\Authentication\data\accounts.json", json);
        }
        
    }
}
