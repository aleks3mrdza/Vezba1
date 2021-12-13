using System;
using System.Collections.Generic;


namespace Vezba
{
    public class Program
    {
        static void Main()
        {
            Types();

            Arrays();

            Lists();

            Loops();

            FunThreeConsol("sa", "sfd", "dd");

            FunStringArray("ili", "ja");

            FunListOfString("ss", "df", "gh", " ", " ", " ", " ", " ", " ", " ");

            FunIncrease(333);

            FirstGreterThenThrd(1, "aliluja", 3);

            FirstLessThenSecond(3, 1);

            FirstGreterThenSecond(11, 31);

            FunLong(9999999, 3333333, 777);

            FunInteger3(13, 11, 31);

            FunThreeConsol("as", "s", "hit");

            FuncSixDoNothing(3, "tdi", '\u006a', "porok", 13, true);

            FuncFiveDoNothng(11, 31, "drug", "stari", "ss");

            FunInt2(13, 11);

            FunInt(31, 13);

            FunString("probudi se");

            FunEmpety();
        }

        public static void Types()
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

            int number10 = 10;
            bool isNumber10 = number10 == 10 ? true : false;

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
        }

        public static void Arrays()
        {
            int[] intiger5 = new int[5];
            int[] intiger51 = new int[5] { 3, 2, 1, 2, 3 };
            int[] intiger52 = new int[5] { 4, 5, 7, 6, -5 };

            int[] list = { 29, 16, 33, 97 };
            Array.Reverse(list);
            Console.WriteLine(list);

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
        }

        public static void Lists()
        {
            //1. Kreiraj listu integera
            List<int> list1 = new List<int>();

            //2. Kreiraj listu integera i inicijalizuj listu
            List<int> list2 = new List<int> { 1, 2, 3, 2, 1 };

            //3. Dodaj 5 integera u listu, možeš dodati proizvoljne vrednost
            List<int> list3 = new List<int>();
            list3.Add(2);
            list3.Add(1);
            list3.Add(3);
            list3.Add(1);
            list3.Add(2);

            //4. Kreiraj listu stringova i inicijalizuj je
            List<string> string11 = new List<string>(5);

            //5. Dodaj u listu sledeće stringove "abvc", "dgdf", "htfh", "dfhf"
            string11.Add("abvc");
            string11.Add("dgdf");
            string11.Add("htfh");
            string11.Add("dfhf");
            string11.Insert(4, "dfhf");
            string11.Insert(7, "dfhf");

            //6. Izbaci iz liste string "dgdf"
            string11.Remove("dgdf");

            //Bonus 7. Izbaci iz liste element sa index-om 0
            string11.Remove(string11[0]);
            string11.RemoveAt(0);
        }

        //1. Kreiraj funkciju proizvoljnog imena koja ne vraca nista i nema ulaznih parametara
        public static void FunEmpety() { }

        //2. __koja vraca string i jedan ulazni parametar tipa string koji se vraca kao rezultat funkcije
        public static string FunString(string s)
        {
            return s;
        }

        //3. __koja vraca integer, ima dva ulazna parametra, oba tipa int, 
        //rezultat funkcije je proizvod dva parametra
        public static int FunInt(int a, int b)
        {
            return a * b;
        }

        //4. __ne vraca nista, ima dva ulazna parametra tipa int, u funkciji se ispisuje u konzolu
        //proizvod dva ulazna parametra.
        public static void FunInt2(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        //5. __ne vraca nista i ima pet ulaznih parametara, prva dva tipa int, ostali tipa string.
        //Funkcija ne radi nista.
        public static void FuncFiveDoNothng(int a, int b, string s1, string s2, string s3) { }

        //6. __ne vraca nista i ima 6 ulaznih parametara,  prvi tipa int, drugi string, treci char,
        //cetvrti string, peti int, sesti bool. Funkcija ne radi nista.
        public static void FuncSixDoNothing(int a, string s1, char c1, string s2, int b, bool bolean) { }

        //7. __ne vraca nista i ima tri ulazna parametara, sva tri tipa string. 
        //Funkcija ispisuje u konzoli sva tri prosledjena parametra.
        public static void FunThreeConsol(string s1, string s2, string s3)
        {
            Console.WriteLine(s1, s2, s3);
        }

        //8. __koja vraca zbir tri ulazna parametra koja su tipa int.
        public static int FunInteger3(int a, int b, int c)
        {
            int res = a + b + c;
            return res;
        }

        //9. __koja vraca zbir tri ulazna parametra koja su tipa long.
        public static long FunLong(long l1, long l2, long l3)
        {
            return l1 + l2 + l3;
        }

        //10. __koja vraca da li je prvi ulazni parametar veci od drugog.
        public static bool FirstGreterThenSecond(int num1, int num2)
        {
            return num1 > num2;
        }

        //11. __koja vraca da li je prvi ulazni parametar manji od drugog.
        //Prvi parametar je tipa int, drugi isto.
        public static bool FirstLessThenSecond(int par1, int par2)
        {
            return par1 < par2;
        }

        //12. __koja vraca da li je prvi ulazni parametar veci od treceg.
        //Prvi parametar je tipa int, drugi tipa string, treci tipa int.
        public static bool FirstGreterThenThrd(int par1, string s2, int par3)
        {
            return par1 > par3;
        }

        //13. __koja vraca vrednost ulaznog parametra uvecanu za jedan.
        //Ulazni parametar je tipa int.
        public static int FunIncrease(int increase)
        {
            return increase++;
        }

        //14. __koja vraca niz stringova. Ulazni parametri su dva stringa.
        //Izlazni niz treba da sadrzi oba stringa.
        public static string[] FunStringArray(string s1, string s2)
        {
            string[] twoStr = new string[2];
            twoStr[0] = s1;
            twoStr[1] = s2;
            return twoStr;
        }

        //15. __koja vraca listu stringova. Ulazni parametri su 10 stringova.
        //Izlazna lista treba da sadrzi svih deset stringova.
        public static List<string> FunListOfString(string v1, string v2, string v3, string v4,
        string v5, string v6, string v7, string v8, string v9, string v10)
        {
            List<string> Student = new List<string>(10);
            {
                Student.Add(v1);
                Student.Add(v2);
                Student.Add(v3);
                Student.Add(v4);
                Student.Add(v5);
                Student.Add(v6);
                Student.Add(v7);
                Student.Add(v8);
                Student.Add(v9);
                Student.Add(v10);
                Student.Add("");
            }
            return Student;
        }

        //16. __Pozovi sve funkcije
        //Funkcije pozvane u Main klasi


        public static void Loops()
        {
            //1. Definisi promenljivu tipa integer sa proizvoljnom vrednošću.
            //Ako je vrednost veća od 5 ispiši u konzoli vrednost je veća od 5,
            //inače ispiši vredost je manja od 5.
            int a = 31;

            if (a > 5)
            {
                Console.WriteLine("Vrednost je vece od 5");
            }
            else
            {
                Console.WriteLine("Vrednost je manja od 5");
            }

            //2.Definisi promenljivu tipa string sa proizvoljnom vrednošću.
            //Ako je vrednost jednaka "abcdfg" ispiši u konzoli vrednost je "abcdfg",
            //inače ispiši vredost nije "abcdfg".
            string v = "abcdfg";

            if (v == "abcdfg")
            {
                Console.WriteLine("Vrednost je jednaka abcdfg");
            }
            else
            {
                Console.WriteLine("Vrednos nije abcdfg");
            }

            //3.Definisi promenljivu tipa char sa proizvoljnom vrednošću.
            //Ako je vrednost jednaka "n" ispiši u konzoli vrednost je "n",
            //inače ispiši vredost nije "n".
            char c = 'x';

            if (c == 'n')
            {
                Console.WriteLine("Vrednost je n");
            }
            else
            {
                Console.WriteLine("Vrednost nije n");
            }

            //4.Definisi promenljivu tipa bool sa proizvoljnom vrednošću.
            //Ako je vrednost true ispiši u konzoli vrednost je true,
            //inače ispiši vredost je false.
            bool bolean = true;

            if (bolean == true)
            {
                Console.WriteLine("Vrednos je true");
            }
            else
            {
                Console.WriteLine("Vrednost nije true");
            }

            //5.Definisi promenljivu tipa integer sa proizvoljnom vrednošću.
            //Ako je vrednost veća od 5 ispiši u konzoli vrednost je veća od 5,
            //ako je vrednost jednaka 5 ispiši u konzoli vrednost je jednaka 5,
            //inače ispiši vredost je manja od 5.
            int integer = 39931;

            if (integer > 5)
            {
                Console.WriteLine("Vrednos je veca od 5");
            }
            else if (integer == 5)
            {
                Console.WriteLine("Vrednost je jednaka 5");
            }
            else
            {
                Console.WriteLine("Vrednost je manja od 5");
            }

            //6.Definisi dve promenljivu tipa integer sa proizvoljnim vrednostima.
            //Ako je vrednost prve promenljive veća od 5 ispiši u konzoli vrednost je veća od 5.
            //Ako je vrednost druge promenljive veća od 5 ispiši u konzoli vrednost je veća od 5.
            int integer1 = 5;
            int integer3 = 3;
            if (integer1 > 5)
            {
                Console.WriteLine("Vrednost je veca od 5");
            }

            if (integer3 > 5)
            {
                Console.WriteLine("Vrednost je veca od 5");
            }

            //7.Definisi dve promenljivu tipa integer sa proizvoljnim vrednostima.
            //Ako je vrednost prve promenljive veća od 7 ispiši u konzoli vrednost je veća od 7.
            //Ako je vrednost druge promenljive veća od 9 ispiši u konzoli vrednost je veća od 9,
            //inače ispiši vredost je manja od 9.
            int integer4 = 23213;
            int integer5 = 7;

            if (integer4 > 7)
            {
                Console.WriteLine("Vrednost je veca od 7");
            }

            if (integer5 > 9)
            {
                Console.WriteLine("Vrednost je veca od 9");
            }
            else
            {
                Console.WriteLine("Vrednost je manja od 9");
            }

            //9.Definisi dve promenljivu tipa integer i string sa proizvoljnim vrednostima.
            //Ako je vrednost prve promenljive veća od 7 i vrednost druge promenljive jednaka "rtyu"
            //ispiši u konzoli vrednost prve promenljive je veća od 7 i vrednost druge promenljive je jednaka "rtyu".
            int num13 = 8;
            string s = "rtyu";

            if (num13 > 7 && s == "rtyu")
            {
                Console.WriteLine("Vrednost prve promenljive je veca od 7 i vrednost druge promenljive jednaka je rtyu");
            }

            //10.Definisi promenljivu tipa integer sa proizvoljnom vrednošću.
            //Ako je vrednost veća od 5 ispiši u konzoli vrednost je veća od 5,
            //inače ako je vrednost veća od 7 ispiši u konzoli vrednost je veća 7,
            //inače ako je vrednost veća od 9 ispiši u konzoli vrednost je veća 9,
            //inače ako je vrednost veća od 10 ispiši u konzoli vrednost je veća 10,
            //inače ako je vrednost veća od 12 ispiši u konzoli vrednost je veća 12,
            //inače ako je vrednost veća od 13 ispiši u konzoli vrednost je veća 13,
            //inače ako je vrednost veća od 14 ispiši u konzoli vrednost je veća 14,
            //inače ako je vrednost veća od 17 ispiši u konzoli vrednost je veća 17,
            //inače ako je vrednost veća od 19 ispiši u konzoli vrednost je veća 19,
            //inače ako je vrednost veća od 24 ispiši u konzoli vrednost je veća 24,
            //inače ako je vrednost veća od 25 ispiši u konzoli vrednost je veća 25,
            //inače ako je vrednost veća od 26 ispiši u konzoli vrednost je veća 26,
            //inače ako je vrednost veća od 28 ispiši u konzoli vrednost je veća 28,
            //inače ako je vrednost veća od 29 ispiši u konzoli vrednost je veća 29,
            //inače ispiši vredost je manja od 5.
            int num23 = 23;

            if (num23 > 5)
            {
                Console.WriteLine("Vrednost je veca od 5");
            }
            else if (num23 > 7)
            {
                Console.WriteLine("Vrednost je veca od 7");
            }
            else if (num23 > 9)
            {
                Console.WriteLine("Vrednost je veca od 9");
            }
            else if (num23 > 10)
            {
                Console.WriteLine("Vrednost je veca od 10");
            }
            else if (num23 > 12)
            {
                Console.WriteLine("Vrednost je veca od 12");
            }
            else if (num23 > 13)
            {
                Console.WriteLine("Vrednost je veca od 13");
            }
            else if (num23 > 14)
            {
                Console.WriteLine("Vrednost je veca od 14");
            }
            else if (num23 > 17)
            {
                Console.WriteLine("Vrednost je veca od 17");
            }
            else if (num23 > 19)
            {
                Console.WriteLine("Vrednost je veca od 19");
            }
            else if (num23 > 24)
            {
                Console.WriteLine("Vrednost je veca od 24");
            }
            else if (num23 > 25)
            {
                Console.WriteLine("Vrednos je veca od 25");
            }
            else if (num23 > 26)
            {
                Console.WriteLine("Vrednost je veca od 26");
            }
            else if (num23 > 28)
            {
                Console.WriteLine("Vrednost je veca od 28");
            }
            else if (num23 > 29)
            {
                Console.WriteLine("Vrednost je veca od 29");
            }
            else
            {
                Console.WriteLine("Vrednost je manja od 5");
            }

            // Ispisati brojeve od 1 do 100 koristeci while petlju
            int start = 0;

            while (start < 100)
            {
                start++;
                Console.WriteLine(start);
            }

            //Izracunati zbir prvih 100 brojeva koresteci while petlju
            int startNum = 0;
            int sum = 0;

            while (startNum < 100)
            {
                sum = sum + startNum;
                startNum++;
                Console.WriteLine(sum);
            }

            //Vezba switch1
            string s21 = "tri";

            switch (s21)
            {
                case "jedan":
                    Console.WriteLine("jedan");
                    break;

                case "dva":
                    Console.WriteLine("dva");
                    break;

                case "tri":
                    Console.WriteLine("tri");
                    break;

                case "cetiri":
                    Console.WriteLine("cetiri");
                    break;

                case "pet":
                    Console.WriteLine("pet");
                    break;
                default:
                    Console.WriteLine("Vrednost stringa nije od jedan do pet");
                    break;

            }

            //Vezba switch2
            int br1 = 3;
            int br2 = -1;
            string rezultat = "razlika";

            switch (rezultat)
            {
                case "zbir":
                    int zbir = br1 + br2;
                    Console.WriteLine("Zbir je", zbir);
                    break;

                case "razlika":
                    int razlika = br1 - br2;
                    Console.WriteLine("Razlika je", razlika);
                    break;

                case "proizvod":
                    int proizvod = br1 * br2;
                    Console.WriteLine("Proizvod je", proizvod);
                    break;

                case "kolicnik":
                    int kolicnik = br1 / br2;
                    Console.WriteLine("Kolicnik je", kolicnik);
                    break;
            }

        }
    }






}

