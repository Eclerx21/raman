using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raman
{
    class Program
    {
        static void Main(string[] args)
        {
            new Gematria().Run();
        }
        class Gematria
        {
            public static Dictionary<string, int> LetterValue = new Dictionary<string, int>()
              {
                {"A",1 },
                {"B",2 },
                {"C",3 },
                {"D",4 },
                {"E",5 },
                {"F",6 },
                {"G",7 },
                {"H",8 },
                {"I",9 },
                {"J",10 },
                {"K",11 },
                {"L",12 },
                {"M",13 },
               };
            string name;
            public void Run()
            {
                Console.WriteLine("i will tell your future name!---what is your name?");
                name = Console.ReadLine();
                Console.WriteLine("{0}--that's best your parents could come up with", name);
                Console.WriteLine("Never mind,let's get started...");
                Console.WriteLine(this.RunGematriaCalculation(name) );

            }

            public void RunGematriaCalculation(string thename)
            {
                foreach (char letter in thename)
                {
                    // Console.WriteLine(letter);
                    //this.ReturnGematriaValueOfLetter(letter);
                }
            }
            public void RunGematriaValueOfLetter(char letter)
            {
                int temp = LetterValue[letter.ToString()];
                Console.WriteLine(temp);
            }
        }
        class playground
        {
            public void Run()
            {
                Dictionary<string, int> LetterValue = new Dictionary<string, int>()
              {
                {"A",1 },
                {"B",2 },
                {"C",3 },
                {"D",4 },
                {"E",5 },
                {"F",6 },
                {"G",7 },
                {"H",8 },
                {"I",9 },
                {"J",10 },
                {"K",11 },
                {"L",12 },
                {"M",13 },

               };
                int temp = LetterValue["B"];
                Console.WriteLine(temp);
            }
        }
    }
}