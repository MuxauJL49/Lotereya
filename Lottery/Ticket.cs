using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Ticket
    {
        static private int NUM_FIELD = 4;

        //поля основных характеристик лотерейного билета
        private bool[] fieldLottery = new bool[NUM_FIELD];
        public int numberTick { get; set; }
        public bool minWin { get; private set; }
        public bool bigWin { get; private set; }
        private bool loseTicket = false;

        /*
         * Создание билета
         */
        public Ticket()
        {

            Random random = new Random();
            fillFieldLottey();
            numberTick = random.Next(1, 29999);
            fillFieldLottey();
            minWin = false;
            bigWin = false;

        }

          
        /*
         * Заполнение выигрышных полей
         */
        private void fillFieldLottey()
        {
            for (int i = 0; i < NUM_FIELD; i++)
            {
                fieldLottery[i] = false;
            }
            Random random = new Random();
            fieldLottery[random.Next(0, NUM_FIELD)] = true;

            while (true)
            {
                int twoWinField = random.Next(0, NUM_FIELD);

                if (!fieldLottery[twoWinField])
                {
                    fieldLottery[twoWinField] = true;
                    break;
                }
            }
        }

        /*
         * проверка на выигрыш
         */
        public bool statusField(int numField)
        {
            numField--;
            if (loseTicket)
            {
            }
            else if (!fieldLottery[numField])
            {
                loseTicket = true;
                bigWin = false;
                minWin = false;
            }
            else 
            {
                if (minWin)
                {
                    bigWin = true;
                }
                else
                {
                    minWin = true;
                }              
            }
            return fieldLottery[numField];
        }
    }
}
