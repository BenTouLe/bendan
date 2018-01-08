using System;
using System.Collections.Generic;
using System.Text;

namespace BenDan.ApplicationCore.Entities
{
    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public string Url { get; set; }

        public string ScreenNamee { get; set; }

        public string Group { get; set; }

        public int TopicCount { get; set; }

        public int TopicReplyCount { get; set; }

        public int Score { get; set; }

        public DateTime? CreateOn { get; set; }

        public DateTime? LastTime { get; set; }
       
    }
}
