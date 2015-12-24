using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDocx.Tools.Models
{
    public class BookMarkData
    {
        [Key]
        public string BookMarkDataID { get; set; }

        public string BookMarkValue { get; set; }

        public string BookMarkID { get; set; }
        [ForeignKey("BookMarkID")]
        public BookMark BookMark { get; set; }

        public string AutoDocumentID { get; set; }
        [ForeignKey("AutoDocumentID")]
        public virtual AutoDocument AutoDocument { get; set; }
    }
}
