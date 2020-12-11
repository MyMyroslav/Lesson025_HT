using System;

namespace Lesson025_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var word1 = "Slovo";
            var word2 = "Svit";
            var word3 = "Telephone";
            var word4 = "Chashka";
            var word5 = "Imya";
            var word6 = "Prizvushche";
            var word7 = "Ruchka";
            var word8 = "Blocknot";
            var word9 = "Marker";
            var word10 = "Olivec";
            //var word11 = "Noutbuk";
            var word1en = "Word";
            var word2en = "World";
            var word3en = "Phone";
            var word4en = "Cup";
            var word5en = "Name";
            var word6en = "Surname";
            var word7en = "Pan";
            var word8en = "Notepad";
            var word9en = "Mark";
            var word10en = "Pencil";
            //var word11en = "Laptop";
            dynamic[] uaDict = new dynamic[10];
            dynamic[] enDict = new dynamic[10];
            uaDict[0] = word1;
            uaDict[1] = word2;
            uaDict[2] = word3;
            uaDict[3] = word4;
            uaDict[4] = word5;
            uaDict[5] = word6;
            uaDict[6] = word7;
            uaDict[7] = word8;
            uaDict[8] = word9;
            uaDict[9] = word10;
            //uaDict[10] = word11;
            enDict[0] = word1en;
            enDict[1] = word2en;
            enDict[2] = word3en;
            enDict[3] = word4en;
            enDict[4] = word5en;
            enDict[5] = word6en;
            enDict[6] = word7en;
            enDict[7] = word8en;
            enDict[8] = word9en;
            enDict[9] = word10en;
            //enDict[10] = word11en;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"UA: {uaDict[i]} -- EN: {enDict[i]}");
            }
        }
    }
}
