using System;
using System.Collections.Generic;
using System.Text;

namespace FileStrings
{
    class TextHanterar
    {
        string minText;
        public TextHanterar()
        {
            minText = "Hejsan!";
        }
        public TextHanterar(string mintext)
        {
            this.minText = mintext;
        }
        public void UpperString()
        {
            Console.WriteLine("\nInnan:" + minText);
            Console.WriteLine("Visa texten i stora bokstäver:" + minText.ToUpper());
            Console.WriteLine("\nInnan Konvertera texten till stora bokstäver:" + minText);
           
            minText = minText.ToUpper();
            Console.WriteLine("Omvandlade:" + minText);
        }
        public void LowerString()
        {
            Console.WriteLine("\nInnan:" + minText);
            Console.WriteLine("Visa texten i lilla bokstäver:" + minText.ToLower());
            Console.WriteLine("\nInnan Konvertera texten till lilla bokstäver:" + minText);

            minText = minText.ToLower();
            Console.WriteLine("Omvandlade:" + minText);
        }
        public void IndexOf()
        {
            int index = minText.IndexOf('s');
            Console.WriteLine("\nIndex numret av en karaktär i texten " + minText + " är " + index);

        }
        public void SplitString()
        {
            minText = "Här är några ord";
            Console.WriteLine("\nDelar upp meningen:" + minText);
            string[] ordArray = minText.Split();
            foreach(string ord in ordArray)
            {
                Console.WriteLine("Substring:" + ord);
            }
        }
    }


}
