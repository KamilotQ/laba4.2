using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace L4_2
{
    interface InterFes
    {
        public void Sorting(string[] arr, string[] str, string[] s, int[] sts);
        public void Programming(string[] a);

    }
    class Books : InterFes
    {
        string[] Author = { "William Shakespeare", "Emily Dickinson", "Arthur Conan Doyle", "Leo Tolstoy", "Edgar Allan Poe", "Robert Ervin Howard", "Rabindranath Tagore", "Rudyard Kipling", "Sarah Williams", "John Donne" };
        string[] Title = { "As You Programming It", "Much Madness is divinest Sense", "A Study in Scarlet ", "Two Programmings", "Alone", "The Scarlet Programming", "The Gardener", "Kimprogramming", "Twilight Hours", "Biathanatos" };
        string[] PublishingHouse = { "Penguin Random House", "Hachette Livre", "HarperCollins", "Macmillan Publishers", "Simon & Schuster", "McGraw-Hill Education", "Houghton Mifflin Harcourt", "Pearson Education", "Scholastic", "Cengage Learning" };
        int[] YearOfPublication = { 1598, 1896, 1887, 1856, 1829, 1933, 1913, 1912, 1868, 1608 };
        public string[] AUTHOR
        {
            get
            {
                return Author;
            }
            set
            {
                Author = value;
            }
        }
        public string[] TITLE
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }
        public string[] PUBLISHING_HOUSE
        {
            get
            {
                return PublishingHouse;
            }
            set
            {
                PublishingHouse = value;
            }
        }
        public int[] YEAR_OF_PUBLICATION
        {
            get
            {
                return YearOfPublication;
            }
            set
            {
                YearOfPublication = value;
            }
        }
        public void Sorting(string[] arr, string[] str, string[] s, int[] sts)
        {
            if ((arr.Length != str.Length) || (arr.Length != s.Length) || (str.Length != s.Length) || (str.Length != sts.Length) || (arr.Length != sts.Length) || (sts.Length != s.Length)) throw new System.Exception("Information is missed.");
            int temp_1;
            string temp_2;
            string temp_3;
            string temp_4;
            string ex_1 = "";
            string ex_2 = "";
            string ex_3 = "";
            for (int i = 0; i < sts.Length - 1; i++)
                for (int j = i + 1; j < sts.Length; j++)
                    if (sts[i] < sts[j])
                    {

                        temp_1 = sts[i];
                        sts[i] = sts[j];
                        sts[j] = temp_1;

                        temp_2 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp_2;

                        temp_3 = str[i];
                        str[i] = str[j];
                        str[j] = temp_3;

                        temp_4 = s[i];
                        s[i] = s[j];
                        s[j] = temp_4;
                    }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > ex_1.Length) ex_1 = arr[i];
                if (str[i].Length > ex_2.Length) ex_2 = str[i];
                if (s[i].Length > ex_3.Length) ex_3 = s[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length != ex_1.Length)
                {
                    int dif = ex_1.Length - arr[i].Length;
                    for (int j = 0; j < dif; j++) arr[i] += " ";
                }
                if (str[i].Length != ex_2.Length)
                {
                    int dif = ex_2.Length - str[i].Length;
                    for (int j = 0; j < dif; j++) str[i] += " ";
                }
                if (s[i].Length != ex_3.Length)
                {
                    int dif = ex_3.Length - s[i].Length;
                    for (int j = 0; j < dif; j++) s[i] += " ";
                }
            }
        }

        public void Programming(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i].Contains("programming")==true)|| (a[i].Contains("Programming") == true))
                {
                    Console.WriteLine("\t" + Author[i] + "\t\t" + Title[i] + "\t\t" + PublishingHouse[i] + "\t\t" + YearOfPublication[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Books b = new Books();
            Console.WriteLine("\n\t\t\t\t\t\t\t\tBOOKS");
            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("\tAuthor\t\t\t\t\tTitle\t\t\t\tPublishing House\t\tYear of Publication");
            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            for (int i = 0; i < b.AUTHOR.Length; i++)
            {
                Console.WriteLine("\t" + b.AUTHOR[i] + "\t\t" + b.TITLE[i] + "\t\t" + b.PUBLISHING_HOUSE[i] + "\t\t" + b.YEAR_OF_PUBLICATION[i]);
            }

            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\n\tAfter the sorting:");
            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            b.Sorting(b.AUTHOR, b.TITLE, b.PUBLISHING_HOUSE, b.YEAR_OF_PUBLICATION);
            for (int i = 0; i < b.AUTHOR.Length; i++)
            {
                Console.WriteLine("\t" + b.AUTHOR[i] + "\t\t" + b.TITLE[i] + "\t\t" + b.PUBLISHING_HOUSE[i] + "\t\t" + b.YEAR_OF_PUBLICATION[i]);
            }
            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\n\tBooks with \"programming\" in the title:");

            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
            b.Programming(b.TITLE);
            Console.WriteLine("\t___________________________________________________________________________________________________________________________________________________");
        }
    }
}

