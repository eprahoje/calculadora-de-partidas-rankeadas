using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resolucaoCSharp.Models
{
    public class PlayerStats
    {

        public int victories;
        public int defeats;

        public int WinBalanceCalculator() 
        {
            return victories - defeats;
        }


        public string LevelCalculator() 
        {
            int rankedBalance = WinBalanceCalculator();

            if (rankedBalance <= 10)
            {
                return "Ferro";
            }
            else if (rankedBalance >= 11 && rankedBalance <= 20)
            {
                return "Bronze";
            }
            else if (rankedBalance >= 21 && rankedBalance <= 50)
            {
                 return "Prata";
            }
            else if (rankedBalance >= 51 && rankedBalance <= 80)
            {
                return "Ouro";
            }
            else if (rankedBalance >= 81 && rankedBalance <= 90)
            {
                return "Diamante";
            }
            else if (rankedBalance >= 91 && rankedBalance <= 100)
            {
                return "Lendário";
            }
            else
            {
                return "Imortal";
            }
        }
    }
}