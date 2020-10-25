using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    static public class GameLot
    {
        static private int PRICE_TICK = 100;
        static private int SMALL_WIN = 150;
        static private int BIG_WIN = 500;
        static public int amountMoney { get; set; }
        static public int amountSmallWin;
        static public int amountBigWin;

        static public bool normalMode = true;
        static public bool controlMode = false;
        static public bool salvoMode = false;

        /*
         * Начало игры
         */
        static public void startGame()
        {
            amountMoney = 1000;
            amountSmallWin = 0;
            amountBigWin = 0;
        }


        /*
         * выбор поля
         */
        static public void buyTick()
        {
            amountMoney -= PRICE_TICK;
        }

        /*
        * выбор поля
        */
        static public void checkWin(bool minWin, bool bigWin)
        {
            amountMoney += bigWin ? BIG_WIN :
                minWin ? SMALL_WIN : 0;
            if (bigWin)
            {
                amountBigWin++;
            }
            else if (minWin)
            {
                amountSmallWin++;
            }
        }


        /*
         * Методы возврата
         */
        static public int getAmountMoney()
        {
            return amountMoney;
        }

    }
}
