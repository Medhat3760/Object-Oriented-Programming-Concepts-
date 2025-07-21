namespace String_Library_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsString string1 = new clsString();
            clsString string2 = new clsString("Abdelrahman");

            string1.Value = "Ali Maher";
            Console.WriteLine("String1 = " + string1.Value);
            Console.WriteLine("String2 = " + string2.Value);

            Console.WriteLine("__________________________________________");

            Console.WriteLine("\nNumber of string1 words: " + string1.CountWords());

            string1.PrintEachWord();

            string1.PrintFirstLetterOfEachWord();

            Console.WriteLine("\nNumber of words (static): " + clsString.CountWords("Mohammed Saqer Abu-Hadhoud"));

            clsString String3 = new clsString("hi how are you?");
            Console.WriteLine("\nstring3 = " + String3.Value);
            Console.WriteLine("\nString Length = " + String3.Length());

            Console.WriteLine("\nAfter Upper First Letter Each Word:");
            String3.UpperFirstLetterOfEachWord();
            Console.WriteLine("\nstring3 = " + String3.Value);

            Console.WriteLine("\nAfter Lower First Letter Each Word:");
            String3.LowerFirstLetterOfEachWord();
            Console.WriteLine("\nstring3 = " + String3.Value);
            ;
            Console.WriteLine("\nAfter Upper All String:");
            String3.UpperAllString();
            Console.WriteLine("\nstring3 = " + String3.Value);

            Console.WriteLine("\nAfter Lower All String:");
            String3.LowerAllString();
            Console.WriteLine("\nstring3 = " + String3.Value);


            Console.WriteLine("\nAfter inverting 'a' (static): " + clsString.InvertLetterCase('a'));

            String3.Value = "AbCdEfg";
            String3.InvertAllLettersCase();
            Console.WriteLine('\n' + String3.Value);
            String3.InvertAllLettersCase();
            Console.WriteLine(String3.Value);

            Console.WriteLine("\nCapital Letters count (static): " + clsString.CountLetters("Abdelrahman Medhat", clsString.enWhatToCount.capitalLetters));

            String3.Value = "Welcome to Egypt";
            Console.WriteLine("\nString = " + String3.Value);
            Console.WriteLine("\nCapital Letters count: " + String3.CountCapitalLetters());
            Console.WriteLine("Small Letters count: " + String3.CountSmallLetters());
            Console.WriteLine("Vowels count: " + String3.CountVowels());
            String3.PrintAllVowels();
            Console.WriteLine("\nLetter E count: " + String3.CountSpecificLetter('E', false));
            Console.WriteLine("\nIs letter 'a' vowel? " + clsString.IsVowel('a'));

            Console.WriteLine("\nWords Count: " + String3.CountWords());

            List<string> lString = String3.Split();
            Console.WriteLine("\nTokens = " + lString.Count);
            foreach (string s in lString)
            {
                Console.WriteLine(s);
            }

            String3.Value = "    Abdelrahman Medhat     ";
            Console.WriteLine("\nString = " + String3.Value);

            String3.Value = "    Abdelrahman Medhat     ";
            String3.TrimLeft();
            Console.WriteLine("\nTrim Left = " + String3.Value);

            String3.Value = "    Abdelrahman Medhat     ";
            String3.TrimRight();
            Console.WriteLine("Trim Right = " + String3.Value);

            String3.Value = "    Abdelrahman Medhat     ";
            String3.Trim();
            Console.WriteLine("Trim = " + String3.Value);

            List<string> lString1 = new List<string> { "Mohammed", "Faid", "Ali", "Maher" };
            Console.WriteLine("\nJoin String From List: \n" + clsString.JoinString(lString1));

            string[] arrString = { "Mohammed", "Faid", "Ali", "Maher" };
            Console.WriteLine("\nJoin String From Array: \n" + clsString.JoinString(arrString));

            String3.Value = "Abdelrahman Medhat";
            Console.WriteLine("\nString = " + String3.Value);
            String3.ReverseWordsInString();
            Console.WriteLine("\nReverse Words: " + String3.Value);

            String3.Value = "Abdelrahman Medhat";
            String3.ReplaceWord("Medhat", "Abdelrahman");
            Console.WriteLine("\nReplace: " + String3.Value);

            String3.Value = "This is: a sample text, with punctuations.";
            Console.WriteLine("\nString = " + String3.Value);
            String3.RemovePunctuations();
            Console.WriteLine("\nRemove Punctuations: " + String3.Value);

            Console.ReadKey();

        }
    }
}