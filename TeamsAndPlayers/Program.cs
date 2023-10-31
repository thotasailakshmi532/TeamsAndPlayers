using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsAndPlayerLibrary;

namespace TeamsAndPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();

            string continueInput = "yes";
            do
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add Player
                        Console.WriteLine("Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();

                        Console.WriteLine("Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        team.Add(newPlayer);
                        break;

                    case 2:
                        // Remove Player by Id
                        Console.WriteLine("Enter Player Id to remove:");
                        int playerIdToRemove = int.Parse(Console.ReadLine());
                        team.Remove(playerIdToRemove);
                        break;

                    case 3:
                        // Get Player By Id
                        Console.WriteLine("Enter Player Id:");
                        int playerIdToGet = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(playerIdToGet);
                        Console.WriteLine($"{playerById.PlayerId} {playerById.PlayerName} {playerById.PlayerAge}");
                        break;

                    case 4:
                        // Get Player by Name
                        Console.WriteLine("Enter Player Name:");
                        string playerNameToGet = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(playerNameToGet);
                        Console.WriteLine($"{playerByName.PlayerId} {playerByName.PlayerName} {playerByName.PlayerAge}");
                        break;

                    case 5:
                        // Get All Players
                        List<Player> allPlayers = team.GetAllPlayers();
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"{player.PlayerId} {player.PlayerName} {player.PlayerAge}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Do you want to continue (yes/no)?");
                continueInput = Console.ReadLine();
            } while (continueInput.ToLower() == "yes");
        }

    }
    }
