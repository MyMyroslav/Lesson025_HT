using System;
namespace Lesson025_HT_Task3
{
    public class Dictionary
    {
        public dynamic[] uaWords = new dynamic[10];
        public dynamic[] enWords = new dynamic[10];
        public Dictionary()
        {
        }
        public Dictionary(dynamic[] uaArr, dynamic[] enArr)
        {
            uaWords = uaArr;
            enWords = enArr;
        }
    }
}
