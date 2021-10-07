// Sleep sandbox check
namespace Sleep
{
    public class Program
    {      
        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);
		
	public static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            Sleep(8000);
            double t2 = DateTime.Now.Subtract(t1).TotalSeconds;
            if (t2 < 7.0)
            {
                return;
            }
        }
		
    }
}
