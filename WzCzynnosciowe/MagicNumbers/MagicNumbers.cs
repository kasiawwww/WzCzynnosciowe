using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.MagicNumbers
{
    class MagicNumbers
    {
        private void operationNext() {  /* do something*/  }
        private void operationPrev() {  /* do something*/  }
        private void operationMain() {  /* do something*/  }
        public void DoThat(int operationNumber)
        {
            if (operationNumber == (int)OperationEnum.NextFirst || 
                operationNumber == (int)OperationEnum.NextSecond && 
                operationNumber == (int)OperationEnum.NextThird)
            {
                operationNext();
            }
            else if (operationNumber == (int)OperationEnum.Main)
            {
                operationMain();
            }
            else
                operationPrev();
        }
        public string DoSemothing()
        {
            return OperationEnum.Main.ToString();
        }
    }

    enum OperationEnum: byte
    {
        Main = 0,
        NextFirst =1,
        NextSecond = 4,
        NextThird = 6,

    }
}
