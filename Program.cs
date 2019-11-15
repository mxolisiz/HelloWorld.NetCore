using System;
using System.Diagnostics;
using System.Linq;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
			/*string mxo = "Mxo";
			string zondi = "Zondi";
			System.Console.WriteLine(mxo.Equals(zondi));
			System.Console.WriteLine(mxo == zondi);
			System.Console.WriteLine(Object.ReferenceEquals(mxo, zondi));
			return;*/
            string instruction="Enter a palindrome to test:";
            Debug.WriteLine(instruction);
            Console.WriteLine(instruction);
            string userInput=Console.ReadLine();
            Console.WriteLine($"\"{userInput.ToUpper()}\" is a palindrome: {IsPalindromeAaron(userInput).ToString()}");
        }

        
        static bool IsPalindromeAaron(string word)=> String.Join("",word.Reverse())==word;

        static bool IsPalindrome(string word)
        {
            
            string testWord="";
            for(int i = word.Length-1 ; i>=0 ;i--)
                testWord+=word[i];


            if(testWord.Equals(word))
                return true;

            return false;
        }

        static bool IsPalindromeFunc(string word)
        {
            string testWord="";
            word.Split("",StringSplitOptions.None).ToList().ForEach(l=>{
                testWord+=l;
            });

            if(testWord.Equals(word))
                return true;

            return false;
        }

        static bool IsPalindromeFunctional(string word)
        {
            string testWord="";
            int counter = word.Length;
            
            while(word.Length != testWord.Length){
                testWord += word[counter];
                counter--;
            }

            if(testWord.Equals(word))
                return true;

            return false;
        }

        static bool IsPalindromeSuperFunctional(string word)
        {
            string testWord="";

            while(word.Length != testWord.Length){
                testWord += word[GetIndex()];
				Console.WriteLine($"{testWord}: {GetIndex()}");
			}
            Console.WriteLine(testWord);
            return testWord==word;
			

            int GetIndex()=> (word.Length - 1) - testWord.Length;
        }


        static bool IsPalindromeSuperFunctionalClean(string word)
        {
            string testWord="";

            while(word.Length != testWord.Length)
                testWord += word[GetIndex()];

            return testWord==word;			

            int GetIndex()=> (word.Length - 1) - testWord.Length;
        }

        

    }
}