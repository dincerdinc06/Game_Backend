using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" Adlı Oyun Başarıyla Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Güncellendi.");
        }
    }
}
