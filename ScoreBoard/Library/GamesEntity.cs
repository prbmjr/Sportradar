using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class GamesEntity
    {
        public int Id_game;
        public string Home_team;
        public int Home_team_score;
        public string Away_team;
        public int Away_team_score;
        public int Total_score;
        public bool endgame;


        public GamesEntity(int id,string home_team,string away_team)
        {
            Id_game = id;
            Home_team = home_team;
            Home_team_score = 0;
            Away_team = away_team;
            Away_team_score = 0;
            endgame = false;
            Total_score = 0;
        }

        public static string Create(int id_game, string home_team,  string away_team,List<GamesEntity> Games)
        {
            string retval = "";
            try
            {
                var gamefound = Games.Where(c => c.Home_team.ToLower() == home_team.ToLower() && c.Away_team.ToLower() == away_team.ToLower() );

                if (!gamefound.Any())
                    Games.Add(new GamesEntity(id_game, home_team, away_team));
                else
                {
                    retval = Services_MsgsCtrl.ErrorsControl("ent.1"); 
                }
                
            }
            catch (Exception ex)
            {

                retval = ex.Message;
            }
            return retval;
            
        }

        public static string Update(int id_game, string home_team, int home_team_score, string away_team, int away_team_score, List<GamesEntity> Games)
        {
            string retval = "";

            var game = Games.Find(c => c.Id_game == id_game);

            if (game != null)
            {
                game.Home_team_score = home_team_score;
                game.Away_team_score = away_team_score;
                game.Total_score = home_team_score + away_team_score;

            }
            else
            {
                retval = Services_MsgsCtrl.ErrorsControl("ent.2");
            }

            return retval;
        }

        public static string Finishgame(int id_game, List<GamesEntity> Games)
        {
            string retval = "";

            var game = Games.Find(c => c.Id_game == id_game);

            if (game != null)
            {
                game.endgame = true;
                
            }
            else
            {
                retval = Services_MsgsCtrl.ErrorsControl("ent.2");
            }

            return retval;
        }

    }
}
