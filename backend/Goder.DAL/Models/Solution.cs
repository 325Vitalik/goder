using System;
using Goder.DAL.Enums;

namespace Goder.DAL.Models
{
    public class Solution
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public SolutionResults Result { get; set; }
        public int ExecutionTime { get; set; }
        public int ExecutionMemory { get; set; }
        public int LastExecutedTest { get; set; }

        public Guid CreatorId { get; set; }
        public User Creator { get; set; }
        
        public Guid ProblemId { get; set; }
        public Problem Problem { get; set; }

    }
}