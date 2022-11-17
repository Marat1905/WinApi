using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MachCore.WinApi.plnvoke
{
    [Serializable]
    [return: MarshalAs(UnmanagedType.Bool)]
    public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr lParam);
}
