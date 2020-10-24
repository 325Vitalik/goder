using System;

namespace Goder.DAL.Models
{
    public class Test
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        
        public Guid ProblemId { get; set; } 
        public Problem Problem { get; set; }
        
    }
}