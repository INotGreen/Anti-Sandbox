// Anti Sandbox - Non emulated API
namespace ProRub
{
	public class Program
	{
		[DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
    		static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);

    		[DllImport("kernel32.dll")]
    		static extern IntPtr GetCurrentProcess();
		
		public static void Main(string[] args)
    		{
        		IntPtr mem = VirtualAllocExNuma(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x4, 0);
        		if (mem == null)
        		{
            		return;
        		}
		}
		
	}
}
