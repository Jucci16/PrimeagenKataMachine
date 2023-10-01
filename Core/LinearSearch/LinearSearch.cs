using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.LinearSearch;
public static class LinearSearch
{
    public static bool Search(IEnumerable<int> haystack, int needle)
    {
        foreach(var check  in haystack)
        {
            if (check == needle) return true;
        }

        return false;
    }

}
