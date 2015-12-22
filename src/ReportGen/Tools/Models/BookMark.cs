using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportGen.Tools.Models
{
    public class BookMark
    {
        [Key]
        public string BookMarkID { get; set; }

        public string BookmarkName { get;  set; }
        
        public string BookMarkTypeID { get; set; }
        [ForeignKey("BookMarkTypeID")]
        public BookMarkType BookMarkType { get; set; }

        public string TemplateID { get; set; }
        [ForeignKey("TemplateID")]
        public virtual Template Template { get; set; }

    }
}
