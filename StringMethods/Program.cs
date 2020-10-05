using System;

namespace StringMethods
{
    public class Program
    {
        public const string V = " ";

        public static  void Main()
        {
            string word;
            string word2;
            /*Console.WriteLine("Uzunluğunu bulmak ve kopyalamak istediğiniz kelimeyi giriniz: ");
            word = Console.ReadLine();
            FindLength(word);
            CopyString(word);*/
            word = Console.ReadLine();
            word2 = Console.ReadLine();
            CompareString(word, word2);
            
            
        }

        public static void FindLength(string word)
        {
            int i = 0;
            
            foreach(char chr in word)
            {
                i += 1;
            }
            Console.WriteLine("Kelimenin uzunluğu: "+i);
        }
        public static void CopyString(string word)
        {
            int l;
            l = word.Length;
            string[] copyStr = new string[l];
            for(int i = 0; i < l ; i++)
            {
                string tmp = word[i].ToString();
                copyStr[i] = tmp;
            }
            Console.WriteLine("Orijinal kelime: {0}", word);
            Console.WriteLine("Kopyalanmış kelime: {0}",string.Join("",copyStr));
            Console.WriteLine("Kopyalanan char sayısı: {0}", l);
        }
        public static void CompareString(string firstword ,string secondword)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            
            
            
            if (a > b)
            {
                Console.WriteLine("İlk girilen kelime daha uzundur.");
            }
            else if (a < b)
            {
                Console.WriteLine("İkinci girilen kelime daha uzundur.");
            }
            else if (a == b)
            {
                for(int i = 0; i < a; i++)
                {
                    
                    if (firstword[i] == secondword[i])
                    {
                        c += 1;
                        Console.WriteLine(c);
                    }                   

                }
                if (c == a )
                {
                    Console.WriteLine("Girilen iki kelime aynıdır.");
                }

            }
        }
    }
}
