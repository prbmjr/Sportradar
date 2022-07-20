using System;
using System.Collections.Generic;
using System.Text;


namespace Library
{
    public static class GamesMapper
    {
        public static GamesDto Map(this GamesEntity entity) 
        {
            return new GamesDto()
            {
                Id_game = entity.Id_game,
                Home_team = entity.Home_team,
                Home_team_score = entity.Home_team_score,
                Away_team = entity.Away_team,
                Away_team_score = entity.Away_team_score,
                
            };

        }

        public static string CreateMaptoentidy(this GamesDto dto, List<GamesEntity> Games)
        {
            

            return GamesEntity.Create(Games.Count, dto.Home_team, dto.Away_team, Games);
            
            
            
        }

        public static string UpdateMaptoentidy(this GamesDto dto, List<GamesEntity> Games)
        {


            return GamesEntity.Update(dto.Id_game, dto.Home_team, dto.Home_team_score, dto.Away_team, dto.Away_team_score, Games);


        }

        public static string UpdateMaptoentidy_finishgame(this GamesDto dto, List<GamesEntity> Games)
        {


            return GamesEntity.Finishgame(dto.Id_game, Games);


        }

    }
}
