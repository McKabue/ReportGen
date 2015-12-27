using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDocx.Tools
{
    public class EmailViewModel
    {
        public string From { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Attachment { get; set; }
    }
}
