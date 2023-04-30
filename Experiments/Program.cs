using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticassBasicas
{
    public class Experiments
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!, puedes elegir de mis experimentos el que prefieras. Estos experimentos están hechos gracias a un tutorial que usé de apoyo, más aquí amplío todo, con la ayuda de Dios, ya que tengo conocimientos previos.");
            Console.WriteLine("¿Cuál experimento deseas iniciar?");
            Console.WriteLine("Guessing word game (1) / Juego de adivinanzas de palabra (1)");
            Console.WriteLine("Bible matching verses game (2) / Juego para machear (comprobar igualdad en una o varias palabras) de dos versiculos (2)");
            Console.WriteLine("Gain by being honest (3)"); // In development

            Console.WriteLine("Por favor, selecciona: (1), (2), (3)");
            int expOptionSelected = Convert.ToInt16(Console.ReadLine());

            switch (expOptionSelected)
            {
                case 1:
                    WordGuessGame();
                    break;
                case 2:
                    verseMatchingGame();
                    break;
                case 3:
                    // honestyGame();
                    break;
            }
        }

        public static void WordGuessGame()
        {
            Console.WriteLine("Saludos, este juego esta realizado con el proposito de experimentar con C#.");
            Console.WriteLine("Esto es un juego de adivinanzas...");

            string guessWord = "Manuel";
            Console.WriteLine("Por favor, ingresa la palabra que usted desea que sea adivinada, ahora hay una por defecto que es: " + guessWord);
            Console.WriteLine("Si no ingresa ninguna palabra nueva, entenderemos que quiere continuar con la que está por defecto, ingrese la suya a continuación:");
            guessWord = Console.ReadLine();

            if (guessWord == "")
            {
                guessWord = "Manuel";
            }

            string inputWord;
            string question = "S";
            int limit = 0;
            int maxLimit = 4;



            do
            {
                string welcomeWord = "Bienvenido. Por favor, ingrese la palabra que usted considera que es la elegida en el juego";
                if (limit > 1)
                {
                    welcomeWord = welcomeWord.Remove(0, 12);
                }

                Console.WriteLine(welcomeWord);
                inputWord = Console.ReadLine();

                limit++;

                if (guessWord == inputWord)
                {
                    Console.WriteLine("Has ganado!");
                }
                else if (limit == maxLimit)
                {
                    Console.WriteLine("Ninguna de las palabras elegidas por usted, es la correcta");
                    Console.WriteLine("¿Desea volver a iniciar el programa? S/N");
                    question = Console.ReadLine();

                    if (question != "S")
                    {
                        question = "";
                        Console.ReadLine();
                    }
                }

            } while (guessWord != inputWord && question == "S" && limit <= maxLimit); ;

        }

        public static void verseMatchingGame()
        {
            Console.WriteLine("Por favor, veamos si dos versículos que introduces, tienen algunas palabras en común.");
            Console.WriteLine("¿Cuántos versos desea ingresar? (maximo de 100) ");
            int totalOfVersesCount = Convert.ToInt16(Console.ReadLine());
            int counterOfVerses = 0;

            string firstVerseContainer = "";
            string secondtVerseContainer = "";

            while (counterOfVerses < totalOfVersesCount) // Why "<", because Jesus assigns us an exact number, but he is the one who handles the changes so, he never tryes to makes us feel trap on ANY way or circunstances (theology again, hhh, I Love Jesus).
            {
                try
                {
                    // ¿Me preocupa el contador mío (el de aquellos que me ven) y que me ayudará a ser bien visto?
                    counterOfVerses++; // Como me preocupa cómo contarán de mí, inicio aumentando mi contador que me ha sido dado en 0 (como me gusta la teología, digamos que eso significa que nazco con ningún pecado en mi historial).

                    firstVerseContainer = "";
                    secondtVerseContainer = "";

                    Console.WriteLine("Por favor inserta el versículo, numero " + counterOfVerses);
                    
                    if (counterOfVerses == 1) // By the moment this is just 0, but this must/should be dynamic
                    {
                        firstVerseContainer = Console.ReadLine();
                    } else if (counterOfVerses == 2)
                    {
                        secondtVerseContainer = Console.ReadLine();
                    }
                    
                    if (counterOfVerses == 2 && Contains(firstVerseContainer, secondtVerseContainer))
                    {
                        Console.WriteLine("¡Si!, contienen una o varias palabras similares");
                    }
                    else if (counterOfVerses == 2)
                    {
                        Console.WriteLine("¡No, que lastima!, no contienen una o varias palabras similares");
                    }
                } catch (Exception e)
                {
                    string error = e.Message;
                    Console.WriteLine(error);
                }
            }
        }


        // Helper functions
        private static bool Contains(string container, string element)
        {
            foreach (char ch in element)
            {
                if (container.Contains(ch) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}