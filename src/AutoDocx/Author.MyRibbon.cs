using AutoDocx.Tools;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace AutoDocx
{

	//https://msdn.microsoft.com/en-us/library/bb736142%28v=office.12%29.aspx
    public partial class MyRibbon
    {
        private int itemCount = 4; // Used with GetItemCount.
        private int itemHeight = 35; // Used with GetItemHeight.
        private int itemWidth = 35; // Used with GetItemWidth.









        public Bitmap LoadImage(string imageName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("AutoDocx." + imageName);
            return new Bitmap(stream);
        }

        public string GetLabel(Office.IRibbonControl control)
        {
			string strText = "";
			switch (control.Id)
			{
			   case "gallery1" : strText = "Developer"; break;
			   case "button1" : strText = "Product of Sitepoa Softwares"; break;
			   default : strText = "Error"; break;
			}
			return strText;
		}

        public bool GetShowImage(Office.IRibbonControl control)
        {
            return true;
        }

        public bool GetShowLabel(Office.IRibbonControl control)
        {
            return true;
        }

        public Bitmap GetItemImage(Office.IRibbonControl control, int itemIndex)
        {
            string imageName;
            switch (itemIndex)
            {
                case 0: imageName = "twitter.jpg"; break;
                case 1: imageName = "wordpress-sleep-compress.gif"; break;
                case 2: imageName = "email.jpg"; break;
                default: imageName = "google.jpg"; break;
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("AutoDocx." + imageName);

            return new Bitmap(stream);
        }

        public Office.RibbonControlSize GetSize(Office.IRibbonControl control)
        {
            Office.RibbonControlSize ctrlSize;
            switch (control.Id)
            {
                case "gallery1": ctrlSize = Office.RibbonControlSize.RibbonControlSizeLarge; break;
                case "button1": ctrlSize = Office.RibbonControlSize.RibbonControlSizeRegular; break;
                default: ctrlSize = Office.RibbonControlSize.RibbonControlSizeRegular; break;
            }
            return ctrlSize;
        }

        public void galleryOnAction(Office.IRibbonControl control, string selectedId, int selectedIndex)
        {
            object missing = Type.Missing;
            switch (selectedIndex)
            {
                case 0:
                    Process.Start("http://twitter.com/mckabue"); break;
                case 1:
                    Process.Start("http://mckabue.wordpress.com"); break;
                case 2:
                    Process.Start("http://mckabue.wordpress.com/contact/"); break;
                case 3:
                    Process.Start("https://plus.google.com/111879587183052623919/posts"); break;
                default:
                    Process.Start("http://twitter.com/mckabue"); break;
            }
        }

        public void buttonOnAction(Office.IRibbonControl control)
        {
            System.Windows.Forms.MessageBox.Show("Hello world.");
        }








        public bool GetEnabled(Office.IRibbonControl control)
        {
            return true;
        }

        public int GetItemCount(Office.IRibbonControl control)
        {
            return itemCount;
        }

        public int getItemHeight(Office.IRibbonControl control)
        {
            return itemHeight;
        }

        public int getItemWidth(Office.IRibbonControl control)
        {
            return itemWidth;
        }

        public string getItemLabel(Office.IRibbonControl control, int index)
        {
            string strLabel;
            switch (index)
            {
                case 0: strLabel = "Twitter"; break;
                case 1: strLabel = "Blog"; break;
                case 2: strLabel = "Email"; break;
                case 3: strLabel = "Google+"; break;
                default: strLabel = "Error."; break;
            }
            return strLabel;
        }

        public string GetItemScreenTip(Office.IRibbonControl control, int index)
        {
            string tipText = "This is a screentip for the item.";
            return tipText;
        }



        public string GetItemSuperTip(Office.IRibbonControl control, int index)
        {
            string tipText = "This is a supertip for the item.";
            return tipText;
        }
		
		public string GetKeyTip(Office.IRibbonControl control)
        {
            string strKeyTip;
            switch (control.Id)
            {
                case "gallery1": strKeyTip = "GL"; break;
                case "button1": strKeyTip = "A1"; break;
                default: strKeyTip = "GL"; break;
            }
            return strKeyTip;
        }

		public string GetScreenTip(Office.IRibbonControl control)
        {
            string strTip;
            switch (control.Id)
            {
                case "gallery1": strTip = "Click to open a gallery of choices."; break;
                case "button1": strTip = "This is a screentip for the button."; break;
                default: strTip = "There is a problem."; break;
            }
            return strTip;
        }


    }
}
