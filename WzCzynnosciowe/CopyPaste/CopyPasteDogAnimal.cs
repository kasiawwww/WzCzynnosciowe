using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.CopyPaste
{
    public class CopyPasteDogAnimal
    {
        private string name { get; set; }
        public string AnimalType { get; set; }
        private int years { get; set; }
        private decimal legs { get; set; }
        private string color { get; set; }
        public CopyPasteDogAnimal(string animalType, string name)
        {
            this.AnimalType = animalType;
            this.name = name;
        }
        public string GetAnimalName()
        {
            return $"Pies nazywa się {name}";
        }
        public string GetAnimalType()
        {
            return $"Zwierzę jest typu {AnimalType}";
        }
        public void SetAnimalName(string name)
        {
            this.name = name;
        }
        public void SetAnimalType(string animalType)
        {
            this.AnimalType = animalType;
        }
    }
}
