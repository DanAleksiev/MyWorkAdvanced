using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
    {
    public class Team
        {
        private List<Player> players;
        public Team(string name, int openPositions, char group)
            {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
            }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; } 
        public int Count => players.Count;

        public string AddPlayer(Player player)
            {
            if (player.Position == null || player.Name == null || player.Position == string.Empty || player.Name == string.Empty) 
                return "Invalid player's information.";
            if (OpenPositions == 0) 
                return "There are no more open positions.";
            if (player.Rating < 80)
                return "Invalid player's rating.";
            OpenPositions--;
            players.Add(player);
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }

        public bool RemovePlayer (string playerName)
            {
            foreach (Player player in players)
                {
                if (player.Name == playerName)
                    {
                    players.Remove(player);
                    OpenPositions++;
                    return true;
                    }
                }
            return false;
            }
        public int RemovePlayerByPosition(string position)
            {
            int numRemoved = players.RemoveAll(x => x.Position == position);
            OpenPositions -= numRemoved;
            return numRemoved;
            }
        public Player RetirePlayer (string playerName)
            {
            foreach (Player player in players)
                {
                if (player.Name == playerName)
                    {
                    player.Retired = true;
                    return player;
                    }
                }
            return null;
            }

        public List<Player> AwardPlayers(int games)
            {
            List<Player> list = new List<Player>();
            foreach (Player player in players)
                {
                if (player.Games > games)
                    {
                    list.Add(player);
                    }
                }
            return list;
            }

        public string Report()
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (Player player in players.Where(p=>p.Retired==false))
                {
                sb.AppendLine(player.ToString());
                }
            return sb.ToString().Trim();
            }
        }
    }
