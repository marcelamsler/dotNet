using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string SafeToString(this object o)
        {
           if (o != null) {
               return o.ToString();
           }
           else
           {
               return "null";
           }
       }
    }
}

