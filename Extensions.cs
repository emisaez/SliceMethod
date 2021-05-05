using System;

namespace SliceMethod
{
    public static class Extensions
    {
        public static string Slice(string str, int startIndex, int endIndex = 0)
        {
            if (startIndex < 0) 
            {
                startIndex = str.Length + startIndex;
            }
            
            if (endIndex < 0) 
            {
                endIndex = str.Length + endIndex;
            }
            
            if (endIndex == 0)
            {
                endIndex = str.Length;
            }
            
            int len = endIndex - startIndex;
            return str.Substring(startIndex, len);
        }  
    }
}
