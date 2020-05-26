using System.Collections.Generic;
using Coursach.Entities;

namespace Coursach
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string MiddleName { get; set; }

        public bool HasParticipatedInSocialEvents { get; set; }

        public bool IsAdmin { get; set; }

        public List<Mark> Marks { get; set; }
    }
}