using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsAndPlayerLibrary
{
    public class OneDayTeam:ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        private const int TeamCapacity = 11;

        public OneDayTeam()
        {
            oneDayTeam.Capacity = TeamCapacity;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine($"Player is added successfully");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => p.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }

}

