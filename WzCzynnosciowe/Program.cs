using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzCzynnosciowe.Memento;
using WzCzynnosciowe.Iterator;

namespace WzCzynnosciowe
{
    class Program
    {

        //MEMENTO
        //static string path = @"D:\kasia.txt";
        //static WzCzynnosciowe.Memento.Memento memento;
        static void Main(string[] args)
        {

            //    File.WriteAllText(path, "kasia");

            //    //pierwsza instancja memento
            //    if (path != "" && File.Exists(path))
            //    {
            //        memento = new WzCzynnosciowe.Memento.Memento(path, File.ReadAllBytes(path));
            //    }

            //    //zapis nowej wartości do pliku
            //    File.WriteAllText(path, "kasia2");

            //    //przywrócenie z memento
            //    memento.RevertFromMemento();

            //    File.WriteAllText(path, "kasia3");
            //    //nowe dane w obiekcie memento
            //    memento.SetNewData(path);
            //    File.WriteAllText(path, "kasia4");
            //    memento.RevertFromMemento();
            // Console.Read();

            //STATE
            //Context c = new Context(new BigState());
            //Console.ReadLine();
            //c.Change();
            //Console.ReadLine();
            //c.Change();
            //Console.ReadLine();
            //c.Change();
            //Console.Read();

            //STRATEGY
            //Context c = null;
            //while (true)
            //{
            //    var strategy = Console.ReadLine();
            //    switch (strategy)
            //    {
            //        case "N":
            //            c = new Context(new NormalPerson());
            //            break;
            //        case "D":
            //            c = new Context(new Lumberman());
            //            break;
            //        case "K":
            //            c = new Context(new StrongKickPerson());
            //            break;
            //        default:
            //            Console.WriteLine("N - noramlna osoba " +
            //             "D - drwal " +
            //            "K - osoba ktora silnie kopie");
            //            break;
            //    }
            //    if (c != null)
            //    {
            //        foreach (var item in c.Person.Data())
            //        {
            //            Console.WriteLine(item.ToString());
            //        }
            //    }


            //}

            //ITERATOR
            //List<string> MyList = new List<string> { "kasia", "asia", "basia" };
            ConcreteIterable ci = new ConcreteIterable();
            ci[0] = "kasia";
            ci[1] = "basia";
            ci[2] = "asia";

            var it = ci.GetIterator();
            var i = it.First();
           // Console.WriteLine(it.First());

            while (!it.IsEnd())
            {
                
                Console.WriteLine(it.Current());
                it.Next();
                if (it.IsEnd())
                {
                    Console.WriteLine(it.Current());
                }
            }

            Console.ReadLine();
        }

    }
}

