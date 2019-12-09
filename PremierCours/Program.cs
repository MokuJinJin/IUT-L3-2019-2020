using System;
using System.Collections.Generic;
using System.Linq;

namespace PremierCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List<PremiereClasse>();
            list.Add(new PremiereClasse(){myProperty = 1, monNom = "un"});
            list.Add(new PremiereClasse(){myProperty = 2, monNom = "deux" });
            list.Add(new PremiereClasse(){myProperty = 3, monNom = "trois" });
            list.Add(new PremiereClasse(){myProperty = 4, monNom = "quatre" });
            list.Add(new PremiereClasse(){myProperty = 5, monNom = "cinq" });
            list.Add(new PremiereClasse(){myProperty = 6, monNom = "six" });

            List<PremiereClasse> nombrePair = list.Where(item => item.myProperty % 2 == 0).ToList();
            List<string> listNom = list.Select(item => item.monNom).ToList();
            List<string> list1 = list.Where(item => item.myProperty % 2 == 0)
                                    .Select(itemFiltered => itemFiltered.monNom)
                                    .ToList();
            bool any = list.Any(item => item.myProperty % 2 == 0);

            Console.ReadLine();
        }
    }
}
