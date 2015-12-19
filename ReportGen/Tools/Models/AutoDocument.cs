using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.Models
{
    public class AutoDocument
    {
        [Key]
        public string AutoDocumentID { get; set; }

        public string Name { get; set; }

        public string TemplateID { get; set; }
        [ForeignKey("TemplateID")]
        public virtual Template Template { get; set; }
        
        public ICollection<BookMarkData> BookMarkDatas { get; set; }
    }
}
