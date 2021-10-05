using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opgave1;

namespace ObligatoriskOpgave4.Manager
{
    public class PlayerManager
    {
        private static int _nextId = 1;

        private static readonly List<FootballPlayer> Players = new List<FootballPlayer>
        {
            new FootballPlayer() {ID = _nextId++, Name = "Ronaldo", Price = 1000, ShirtNumber = 8}
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Players);
        }

        public FootballPlayer GetById(int id)
        {
            return Players.Find(player => player.ID == id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.ID = _nextId++;
            Players.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Players.Find(player1 => player1.ID == id);
            if (player == null) return null;
            Players.Remove(player);
            return player;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer player = Players.Find(player1 => player1.ID == id);
            if (player == null) return null;
            if(updates.Name != null ) player.Name = updates.Name;
            player.Price = updates.Price;
            if (updates.ShirtNumber != 0) player.ShirtNumber = updates.ShirtNumber;
            return player;
        }
    }
}
