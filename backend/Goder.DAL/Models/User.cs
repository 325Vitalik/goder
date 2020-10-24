using System;
using System.Collections;
using System.Collections.Generic;
using Goder.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Goder.DAL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime  Birthday { get; set; }
        public string Email { get; set; }
        public string AvatarURL { get; set; }
        
        public ICollection<Problem> CreatedProblems { get; set; }
        public ICollection<Solution> CreatedSolutions { get; set; }

        
    }
}