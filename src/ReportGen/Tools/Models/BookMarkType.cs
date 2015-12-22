using System.ComponentModel.DataAnnotations;

namespace ReportGen.Tools.Models
{
    public class BookMarkType
    {
        [Key]
        public string BookMarkTypeID { get; set; }

        public string BookMarkTypeString { get; set; }
    }
}