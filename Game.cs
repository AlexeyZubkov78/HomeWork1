using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Game
    {
      public static void play(List<string> dictionary) { 
        Console.WriteLine("Игра в слова");
        Console.WriteLine("Введите слово и нажмите enter");
        bool isGame = true;
        string word = Console.ReadLine().ToLower();
        string lastLetter = word.Substring(word.Length - 1);

            while (isGame)
            {

                for (int item = 0; item < dictionary.Count; item++)
                {

                    if (dictionary[item].ToLower().StartsWith(lastLetter))
                    {
                        Console.WriteLine("Компьютер называет слово:  " + dictionary[item]);
                        word = dictionary[item].ToLower();
                        dictionary.Remove(dictionary[item]);
                        break;
                    }
                    if (item == dictionary.Count - 1 && !dictionary[item].ToLower().StartsWith(lastLetter))
                    {
                        Console.WriteLine("Компьютер исчерпал свой словарный запас");
                        isGame = false;
                        break;
                    }
                }

                if (isGame)
                {
                    lastLetter = word.Substring(word.Length - 1);
                    Console.WriteLine("Введите слово на букву:  {0}", lastLetter);
                    word = Console.ReadLine().ToLower();

                    //       for (int i = 0; i < dictionary.Count; i++)
                    //        {                                                                  // Ввиду ограниченности словаря, этот блок не имеет смысла
                    //           int control = String.Compare(dictionary[i].ToLower(), word);
                    //           if (control == 0)
                    //           {
                    //               dictionary.Remove(dictionary[i]);
                    //               break;
                    //           }
                    //           else if (i == dictionary.Count - 1)
                    //           {
                    //               Console.WriteLine("Такого слова нет в словаре или оно уже было использовано, вы проиграли");
                    //               isGame = false;
                    //           }
                    //       }


                    if (word.ToLower().StartsWith(lastLetter))
                    {
                        lastLetter = word.Substring(word.Length - 1);
                    }
                    else
                    {
                        Console.WriteLine("Ваше слово не начинается на необходимую букву, поэтому вы проиграли");
                        isGame = false;
                        break;
                    }
                }
            }
      }    
    }
}
