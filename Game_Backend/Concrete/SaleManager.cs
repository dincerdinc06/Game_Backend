using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    class SaleManager : ISaleManager
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+ " Oyunu "+gamer.FirstName.ToUpper()+ " "+ gamer.LastName.ToUpper()+ " Adlı Oyuncuya "+game.Price+ " TL'ye satılmıştır.");
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " Oyunu " + gamer.FirstName.ToUpper() + " " + gamer.LastName.ToUpper() + " Adlı Oyuncuya " + (game.Price-(game.Price*campaign.Discount)/100) + " TL'ye satılmıştır.");
        }
    }
}
