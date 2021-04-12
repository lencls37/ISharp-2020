using System;
using System.Diagnostics;
using InstagramApiSharp.Classes.Models;

namespace ISharp_Temiz_Kod
{
    // Token: 0x02000005 RID: 5
    public static class DebugUtils
    {
        // Token: 0x06000026 RID: 38 RVA: 0x00004BDC File Offset: 0x00002DDC
        public static string PrintMedia(string header, InstaMedia media)
        {
            string[] array = new string[5];
            array[0] = header;
            array[1] = ": ";
            int num = 2;
            InstaCaption caption = media.Caption;
            array[num] = ((caption != null) ? caption.Text.Truncate(30) : null);
            array[3] = ", ";
            array[4] = media.Code;
            string content = string.Concat(array);
            Debug.WriteLine(content);
            return content;
        }

        // Token: 0x06000027 RID: 39 RVA: 0x00004C3C File Offset: 0x00002E3C
        public static string Truncate(this string value, int maxChars)
        {
            return (value.Length <= maxChars) ? value : (value.Substring(0, maxChars) + "...");
        }
    }
}
