using System;
using System.Collections.Generic;

namespace Goder.DAL.Models
{
    public class Problem
    {
        public Guid Id { get; set;  }
        public DateTimeOffset CreatedAt { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int TimeLimit { get; set; }
        public int MemoryLimit { get; set; }
        
        // foreign keys
        public Guid CreatorId { get; set;  }
        public User Creator { get; set; } // 

        public ICollection<Test> Tests { get; set; }
        public ICollection<Solution> Solutions { get; set; }

    }
}