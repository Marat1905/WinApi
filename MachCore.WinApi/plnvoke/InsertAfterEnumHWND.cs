using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachCore.WinApi.plnvoke
{
    /// <summary>Window handles (HWND) used for hWndInsertAfter</summary>
    public static class InsertAfterEnumHWND
    {
        public static readonly IntPtr
            NoTopMost = new IntPtr(-2),
            TopMost = new IntPtr(-1),
            Top = new IntPtr(0),
            Bottom = new IntPtr(1);
    }
}
