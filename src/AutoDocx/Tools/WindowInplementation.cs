using System;

namespace AutoDocx.Tools
{
    public class WindowInplementation : System.Windows.Forms.IWin32Window
    {
        private readonly IntPtr _hwnd;

        public WindowInplementation(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get
            {
                return _hwnd;
            }
        }
    }
}
