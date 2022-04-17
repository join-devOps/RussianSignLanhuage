using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SignLanguage.Core.Domain
{
    public class Link
    {
        public static void OpenInBrowser(string uri)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                uri = uri.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {uri}")
                { CreateNoWindow = true });
            }
        }
    }
}