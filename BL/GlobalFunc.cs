using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public static class GlobalFunc
    {
        private static Random random = new Random();
        public static string RandomCode(int l)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, l)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        
        
    }

    
}
