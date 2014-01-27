using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormCSharp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());

            Console.WriteLine("Calcul somme entier : " + calculSommeEntier(0, 10));
            List<double> liste = new List<double>{1.0,5.5,9.9,2.8,9.6};
            Console.WriteLine("Calcul Moyenne : " + calculMoyenne(liste));

         

        }

        static int calculSommeEntier(int debut, int fin)
        {
            int res = 0;
            for(int i = debut; i <= fin; i++)
            {
                res += i;
            }
            return res;
        }
        
        static double calculMoyenne(List<double> liste)
        {
            double res = 0.0, numerateur = 0.0, denominateur = 0.0;
            foreach(double d in liste)
            {
                numerateur += d;
            }
            denominateur = liste.Count;
            res = numerateur / denominateur;
            return res;
        }
    }
}
