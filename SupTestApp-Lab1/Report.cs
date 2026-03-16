using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SupTestApp_Lab1

{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public Report(string title, string content, DateTime creationDate)
        {
            Title = title;
            Content = content;
            CreationDate = creationDate;
        }
    }
}
