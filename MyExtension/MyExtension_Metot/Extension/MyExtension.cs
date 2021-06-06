using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MyExtension_Metot
{
   public static class MyExtension
    {
        public static int HarfSayisi(this string yazi)
        {

            string BosluksuzYazi = yazi.Replace(" ", "");

            
           


           

            return BosluksuzYazi.Length;

        }


    }
}
