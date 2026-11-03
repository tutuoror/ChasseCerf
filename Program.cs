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

        int usedarrow = 0;
        int hits = 0;
        string accuracy;
        Console.WriteLine("vous etes parti en chasse et vous tomber enfin sur un cerf");
               

        while (hits < 3 && usedarrow < 5) 
        {
            Console.WriteLine("vous allez tirer une fleche, va-t-elle toucher sa cible(Y/N) ?");
            accuracy = Console.ReadLine();

            if (accuracy == "Y")
            {
                Console.WriteLine("vous tirez une fleche et touchez le cerf !");

                usedarrow += 1;
                hits += 1;
            }
            else if (accuracy == "N")
            {
                Console.WriteLine("vous ratez le cerf...");

                usedarrow += 1;
            }
            else if (accuracy == "Je veux me promener")
            {
                Console.WriteLine("vous laissez le cerf tranquil et partez vous promenez..");

                break;
            }    
            else
            {
                Console.WriteLine("saisie invalide, veuillez selectionner l'un des choix proposer.");
            }
        }
        if (hits == 3)
        {
            Console.WriteLine("vous aurez une bonne venaison fraiche pour le repas de ce soir!");
        }
        else if (usedarrow == 5)
        {
            Console.WriteLine("vous n'avez plus de fleche et ne pourrez pas goutez au cerf ce soir...");
        }
        Console.WriteLine("vous avez utilise " + usedarrow + " fleches et vous avez touche le cerf " + hits + " fois.");
    }
}