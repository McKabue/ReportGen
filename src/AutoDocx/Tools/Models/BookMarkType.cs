using System.ComponentModel.DataAnnotations;

namespace AutoDocx.Tools.Models
{
    public class BookMarkType
    {
        [Key]
        public string BookMarkTypeID { get; set; }

        public string BookMarkTypeString { get; set; }
    }
}