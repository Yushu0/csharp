using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectedApplication.problemdomain
{
    public class userinfo
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Birthday { get; set; }
        public string ReceiveUpdates { get; set; }
        public string LoginName { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
    }
}
