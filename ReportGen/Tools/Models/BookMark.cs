using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        
    }
}
