using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2Anchor9
{
    class Game
    {
        private Player players;
        private Player activePlayer;
        private bool endGame;
        private Board boardGame;

        //public Game(Player name, string buffType, string type, string effect);
        public Player player { get => players; set => players = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool EndGame { get => endGame; set => endGame = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }


    }
}
