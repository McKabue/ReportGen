using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoDocx.Tools.Models
{
    public class Template
    {
        [Key]
        public string TemplateID { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public string TemplatePath { get; set; }

        public string AutoDocumentsPath { get; set; }

        public ICollection<BookMark> BookMarks { get; set; }

        public ICollection<AutoDocument> AutoDocuments { get; set; }
        
    }
}
