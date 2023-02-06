using System;

namespace Swagger.Test.Models
{
    public class ApplicationSystemPerformance
    {
        public int Id{ get; set; }
        public string MainWindowTitle { get; set; } = string.Empty;
        public bool HasExited { get; set; }

        public ApplicationSystemPerformance(int Id, string MainWindowTitle, bool HasExited = false)
        {
            this.Id = Id;
            this.MainWindowTitle = MainWindowTitle;
            this.HasExited = HasExited;
        }
    }
}