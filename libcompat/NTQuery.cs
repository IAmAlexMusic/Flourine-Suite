using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libcompat
{
    public class NTQuery
    {
        public static string GetNTKernal()
        {
            OperatingSystem osver = System.Environment.OSVersion;
            return osver.VersionString;
        }
    }
}
