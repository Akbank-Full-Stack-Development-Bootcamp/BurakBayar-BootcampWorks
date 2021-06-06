using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MyExtension_Metot
{
   public static class MyExtension
    {
        public static int LetterCount(this string word)
        {

            string Count = word.Replace(" ", "");

            
           


           

            return Count.Length;

        }


    }
}
