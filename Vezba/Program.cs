using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d, e;

            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
            
            bool res3 = a > b;
            Console.WriteLine(res3);

            bool res4 = a == b;
            Console.WriteLine(res4);
            
            bool res5 = true;
            res5 = res3 || res4;
            Console.WriteLine(res5);

            int res = a = ++b;
            Console.WriteLine(res);

            

            string s1, s2, s3, s4, s5;
            s1 = "aleks1";
            s3 = "aleks2";
            s4 = "aleks4";
            s5 = "aleks5";
            s5 = "aleks5";

            char c1, c2, c3, c4, c5;
            c1 = 'a';
            c2 = '*';
            c3 = '1';
            c4 = '\"';
            c5 = '\n';

            bool b1, b2, b3, b4, b5;
            b1 = true;
            b2 = true;
            b3 = false;
            b4 = true;
            b5 = true;

            int a1 = 1;
            int a2 = 1;
            int a3 = 333;
            int a4 = 3;
            int a5 = 33;
            //SABIRANJE
            int resault = a3 + a4 + a5;
            Console.WriteLine(resault);
            //ODUYIMANJE
            int resault1 = a1 + a2;
            Console.WriteLine(resault1);
            //MNOZENJE
            int resault2 = a1 * a1 * a2 * a4;
            Console.WriteLine(resault2);
            //Deljenje
            int resault3 = a4 * a4;
            Console.WriteLine(resault3);

            int increase = a1++;



            a1 = 7;
            a1 = -7856;
            a1 = 1456;

            string s12 = "asdg";
            string s21 = "asdg";
            string s31 = "adg";
            string s41 = "adsd";
            string s51 = "ad";

            char c11 = c11 = 'a';
            char c22 =c22 = '*';
            char c33 = c33 = '1';
            char c44 = c44 = '\"';
            char c55 = c55 = '\n';

            bool b11 = b11 = true;
            bool b22 = b22 = true;
            bool b33 = b33 = false;
            bool b44 = b44 = true;
            bool b55 = b55 = true;

             
        }
    }
}
