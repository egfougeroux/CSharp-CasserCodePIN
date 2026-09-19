using System;
using System.Threading;

namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Saisie du code par l'utilisateur (Bonus 1)
            Console.Write("Définissez le code PIN à 4 chiffres à trouver : ");
            int codeSecret = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDébut du programme");
            DateTime start = DateTime.Now;

            bool trouve = false;
            int i = 0;
            
            // Limite de tentatives (Bonus 2 : modifier la valeur si besoin)
            int limiteTentatives = 10000; 

            // 2. Boucle de force brute
            while (i < 10000 && !trouve && i < limiteTentatives)
            {
                // Affichage du code testé
                Console.Write(i + " ");

                // Temporisation pour ralentir l'attaque (Mission 5 : mettre 5 ou 1000 ms)
                // Thread.Sleep(5);

                // Vérification du code
                if (i == codeSecret)
                {
                    trouve = true;
                    Console.WriteLine("\n\nLe code secret est : " + i);
                }

                i++;
            }

            // Si le code n'a pas été trouvé dans la limite
            if (!trouve)
            {
                Console.WriteLine("\n\nÉchec : Nombre maximal de tentatives atteint !");
            }

            Console.WriteLine("Fin du programme");

            // 3. Calcul et affichage de la durée
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme: " + duree);

            Console.Write("Press any key to continue... ");
            Console.ReadKey(true);
        }
    }
}