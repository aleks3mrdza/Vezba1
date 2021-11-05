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

            if (a > b)
            {
                Console.WriteLine("a je vece od b");
            }
            else if (a == b)
            {
                Console.WriteLine("a je jednako b");
            }
            else
            {
                Console.WriteLine("a nije vece od b");
            }

            bool res3 = a > b;
            Console.WriteLine(res3);

            bool res4 = a == b;
            Console.WriteLine(res4);

            bool res5 = true;
            res5 = res3 || res4;
            Console.WriteLine(res5);

            bool res6 = true;
            res6 = res3 && res4;
            Console.WriteLine(res6);

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
            //ODUZIMANJE
            int resault1 = a1 - a2;
            Console.WriteLine(resault1);
            //MNOZENJE
            int resault2 = a1 * a1 * a2 * a4;
            Console.WriteLine(resault2);
            //Deljenje
            int resault3 = a4 / a4;
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

            char c11 = 'a';
            char c22 = '*';
            char c33 = '1';
            char c44 = '\"';
            char c55 = '\n';

            bool b11 = true;
            bool b22 = true;
            bool b33 = false;
            bool b44 = true;
            bool b55 = true;

            int[] intiger5 = new int[5];
            int[] intiger51 = new int[5] { 3, 2, 1, 2, 3 };
            int[] intiger52 = new int[5] { 4, 5, 7, 6, -5 };
            bool res8 = intiger52[2] > intiger52[1];
            Console.WriteLine(res8);

            /*4. Kreiraj niz stringova veličine 9;
            Na prvu poziciju u nizu postavi vrednost "abcd"
            Na devetu poziciju u nizu postavi vrednost "abcd 9"*/
            string[] string1 = new string[9];
            string1[0] = "abcd";
            string1[8] = "abcd 9";
            //Isčitaj vrednost petog elementa u nizu i smesti u novu promenljivu
            string s = string1[4];
            Console.WriteLine(s);

            //1. Kreiraj listu integera
            List<int> list1 = new List<int>();

            //2. Kreiraj listu integera i inicijalizuj listu
            List<int> list2 = new List<int>{1, 2, 3, 2, 1};

            //3. Dodaj 5 integera u listu, možeš dodati proizvoljne vrednost
            List<int> list3 = new List<int>();
            list3.Add(2);
            list3.Add(1);
            list3.Add(3);
            list3.Add(1);
            list3.Add(2);

            //4. Kreiraj listu stringova i inicijalizuj je
            List<string> string11 = new List<string>();

            //5. Dodaj u listu sledeće stringove "abvc", "dgdf", "htfh", "dfhf"
            string11.Add("abvc");
            string11.Add("dgdf");
            string11.Add("htfh");
            string11.Add("dfhf");

            //6. Izbaci iz liste string "dgdf"
            string11.Remove("dgdf");

            //Bonus 7. Izbaci iz liste element sa index-om 0
            string11.Remove(string11[0]);

            //
        }
    }
}
