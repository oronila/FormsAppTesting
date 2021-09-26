using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAppTesting
{
    class creds
    {
        public string user {get;set;}
        public string pass {get;set;}
        public creds()
        {
        }
        public creds(string username, string password)
        {
            user = username;
            pass = password;
        }
    }
}
