using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzCzynnosciowe.Memento;

namespace WzCzynnosciowe
{
    class Program
    {
        static string path = @"D:\kasia.txt";
        static WzCzynnosciowe.Memento.Memento memento;
        static void Main(string[] args)
        {

            File.WriteAllText(path, "kasia");

            //pierwsza instancja memento
            if (path != "" && File.Exists(path))
            {
                memento = new WzCzynnosciowe.Memento.Memento(path, File.ReadAllBytes(path));
            }

            //zapis nowej wartości do pliku
            File.WriteAllText(path, "kasia2");

            //przywrócenie z memento
            memento.RevertFromMemento();

            File.WriteAllText(path, "kasia3");
            //nowe dane w obiekcie memento
            memento.SetNewData(path);
            File.WriteAllText(path, "kasia4");
            memento.RevertFromMemento();

            Console.Read();
        }
    }
}
