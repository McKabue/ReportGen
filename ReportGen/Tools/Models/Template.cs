using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReportGen.Tools.Models
{
    public class Template
    {
        [Key]
        public string TemplateID { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public string Path { get; set; }
        
        public ICollection<BookMark> BookMarks { get; set; }

        public ICollection<AutoDocument> AutoDocuments { get; set; }
        
    }
}
