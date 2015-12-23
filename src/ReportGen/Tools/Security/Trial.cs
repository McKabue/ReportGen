using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.Security
{
    public class Trial
    {
        public static DateTime Now { get { return DateTime.UtcNow; } }
        public static DateTime ExpirationDate { get { return DateTime.UtcNow.AddDays(7); } }


        public static bool CheckTrial()
        {

            






            Licence _licence = new Licence();
            if (_licence.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                


                _licence.Dispose();
            }

            return true;
        }
    }
}
