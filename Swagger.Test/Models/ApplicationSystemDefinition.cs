using System;

namespace Swagger.Test.Models
{
    public class ApplicationSystemDefinition
    {
        public int Id { get; set; }
        public string ProcessPriority { get; set; } = string.Empty;
        public string ThreadsCount { get; set; } = string.Empty;

        public ApplicationSystemDefinition(int Id, string ProcessPriority, string ThreadsCount)
        {
            this.Id = Id;
            this.ProcessPriority = ProcessPriority;
            this.ThreadsCount = ThreadsCount;
        }
    }
}