using System.Runtime.InteropServices.JavaScript;

namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */

        int arrow = 5;
        int hits = 0;
        string accuracy;
        int miss = 0;
        Console.WriteLine("vous etes parti en chasse et vous tomber enfin sur un cerf");
               

        while (hits < 3 && arrow > 0) 
        {
            Console.WriteLine("Vous allez tirer une fleche, va-t-elle toucher sa cible(Y/N) ?" +
                " il vous reste " + arrow + " fleches.");
            accuracy = Console.ReadLine();

            if ((accuracy == "Y") || (accuracy == "y"))
            {
                Console.WriteLine("Vous tirez une fleche et touchez le cerf !");

                hits += 1;
            }
            else if ((accuracy == "N") || (accuracy == "n"))
            {
                Console.WriteLine("Vous ratez le cerf...");

                miss++;
            }
            else if (accuracy == "Je veux me promener")
            {
                Console.WriteLine("Vous laissez le cerf tranquille et partez vous promenez..");

                break;
            }    
            else
            {
                Console.WriteLine("Saisie invalide, veuillez selectionner l'un des choix proposer.");
                continue;
            }
            arrow -= 1;
        }
        if (hits == 3)
        {
            Console.WriteLine("Vous aurez une bonne venaison fraiche pour le repas de ce soir!");
        }
        else if (arrow == 0)
        {
            Console.WriteLine("Vous n'avez plus de fleche et ne pourrez pas goutez au cerf ce soir...");
        }
        Console.WriteLine("Il vous reste " + arrow + " fleches et vous avez touche le cerf " + hits + " fois." +
            "\nVous l'avez rate " + miss + " fois.");
    }
}