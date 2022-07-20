using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public static class Services_Operations
    {

        public static void ExecuteOper(string[] Gamedata, List<GamesEntity> Gameslist)
        {
            string retval = "";

            GamesDto gamedto = new GamesDto();

            try
            {
                switch (Gamedata[0])
                {
                    case "1":

                        gamedto.Home_team = Gamedata[1];
                        gamedto.Away_team = Gamedata[2];

                        retval = gamedto.CreateMaptoentidy(Gameslist);

                        break;
                    case "2":
                        gamedto.Id_game = Convert.ToInt32(Gamedata[1]);

                        retval = gamedto.UpdateMaptoentidy_finishgame(Gameslist);

                        break;
                    case "3":
                        gamedto.Id_game = Convert.ToInt32(Gamedata[1]);
                        gamedto.Home_team_score = Convert.ToInt32(Gamedata[2]);
                        gamedto.Away_team_score = Convert.ToInt32(Gamedata[3]);

                        retval = gamedto.UpdateMaptoentidy(Gameslist);

                        break;
                    case "4":
                        printoutSummaryScoreBoard(Gameslist);
                        break;
                    case "5":
                        ExampleScoreBoardCommands();
                        break;
                    default:
                        retval = Services_MsgsCtrl.ErrorsControl("op.1");
                        break;
                }

                if (retval.Length > 0)
                    Console.WriteLine(retval);
                else
                    Services_Validations.Operationssuccededmsg(Gamedata[0]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public static void printoutSummaryScoreBoard(List<GamesEntity> Gameslist)
        {
            Console.Clear();

            if (Gameslist.Count > 0)
            {
                List<GamesEntity> SortedList = Gameslist.OrderByDescending(g => g.Total_score).ThenByDescending(g => g.Id_game).ToList();
                int contgame = 1;

                Console.WriteLine(Services_MsgsCtrl.ErrorsControl("op.2"));
                Console.WriteLine("");

                foreach (var game in SortedList)
                {
                    if (!game.endgame)
                    {
                        Console.WriteLine(contgame + " - (id:" + game.Id_game + ") - " + game.Home_team + " " + game.Home_team_score.ToString() + " - " + game.Away_team + " " + game.Away_team_score.ToString());
                        contgame += 1;
                    }

                }
            }
            else
                Console.WriteLine(Services_MsgsCtrl.ErrorsControl("op.3"));
        }

        public static void ExampleScoreBoardCommands()
        {
            Console.Clear();

            Console.WriteLine("############ Football World Cup Score Board Help ############");
            Console.WriteLine("");

            Console.WriteLine("Operation id available: 1 - Start new game .:. 2 - Finish a game .:. 3 - Update score .:. 4 - Show Summary of games");
            Console.WriteLine("");
            Console.WriteLine("To select a game, use the Id of the game to update or finish the game, this info appears in the summary like e.g.: (Id:0) ");
            Console.WriteLine("");
            Console.WriteLine("Examples of the input formats:");
            Console.WriteLine("");
            Console.WriteLine("Data format input for a new game (fields: operation id;hometeam;awayteam):");
            Console.WriteLine("e.g.--> 1;Mexico;Brasil");
            Console.WriteLine("");
            Console.WriteLine("Data format input for a finish a game (fields: operation id;idgame):");
            Console.WriteLine("e.g.--> 2;0");
            Console.WriteLine("");
            Console.WriteLine("Data format input for a update an score game (fields: operation id;idgame;hometeamscore;awayteamscore):");
            Console.WriteLine("e.g.--> 3;0;0;3");
            Console.WriteLine("");
            Console.WriteLine("Data format input to show the summary board game (fields: operation id):");
            Console.WriteLine("e.g.--> 4");


        }

        public static void ShowWelcomemsg()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(Services_MsgsCtrl.ErrorsControl("op.4"));
            Console.WriteLine("");

        }

        public static void Printoutmsg(string msg)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(msg);
            Console.WriteLine("");

        }

    }
}
