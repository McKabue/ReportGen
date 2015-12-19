using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.Models
{
    public class Template
    {
        [Key]
        public string TemplateID { get; set; }

        public string Name { get; set; }

        public decimal Number { get; set; }

        public string Path { get; set; }
        
        public ICollection<BookMark> BookMarks { get; set; }

        public ICollection<AutoDocument> AutoDocuments { get; set; }
        
    }
}
