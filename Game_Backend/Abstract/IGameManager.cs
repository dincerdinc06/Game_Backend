using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
