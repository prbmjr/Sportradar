using System;

namespace Library
{
    public class GamesDto
    {
        public int Id_game { get; set; }
        public string Home_team { get; set; }
        public int Home_team_score { get; set; }
        public string Away_team { get; set; }
        public int Away_team_score { get; set; }
        public bool endgame { get; set; }


    }
}
