using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreBoardTest
{
    [TestClass]
    public class Test_GameEntity
    {
        [TestMethod]
        public void Test_CreateNewGame_OK()
        {

            GamesDto gamedto = new GamesDto();

            List<GamesEntity> Gameslist = new List<GamesEntity>();

            string[] Gamedatainput = { "1", "Mexico", "Canada" };

            gamedto.Home_team = Gamedatainput[1];
            gamedto.Away_team = Gamedatainput[2];

            string retval = gamedto.CreateMaptoentidy(Gameslist);

            Assert.AreEqual("", retval);

        }

        [TestMethod]
        public void Test_CreateNewGame_NOT_OK_Duplicate()
        {

            GamesDto gamedto = new GamesDto();

            List<GamesEntity> Gameslist = new List<GamesEntity>();

            string[] Gamedatainput = { "1", "Mexico", "Canada" };

            gamedto.Home_team = Gamedatainput[1];
            gamedto.Away_team = Gamedatainput[2];

            string retval = gamedto.CreateMaptoentidy(Gameslist);
            
            retval = gamedto.CreateMaptoentidy(Gameslist);

            Assert.AreEqual("", retval);

        }

        [TestMethod]
        public void Test_UpdateGame_OK()
        {

            GamesDto gamedto = new GamesDto();

            List<GamesEntity> Gameslist = new List<GamesEntity>();

            string[] Gamedatainput = { "1", "Mexico", "Canada" };

            gamedto.Home_team = Gamedatainput[1];
            gamedto.Away_team = Gamedatainput[2];

            string retval = gamedto.CreateMaptoentidy(Gameslist);


            gamedto.Home_team_score = 5;
            gamedto.Away_team_score = 1;

            retval = gamedto.UpdateMaptoentidy(Gameslist);

            Assert.AreEqual("", retval);

        }

        [TestMethod]
        public void Test_UpdateGame_Finish_OK()
        {

            GamesDto gamedto = new GamesDto();

            List<GamesEntity> Gameslist = new List<GamesEntity>();

            string[] Gamedatainput = { "1", "Mexico", "Canada" };

            gamedto.Home_team = Gamedatainput[1];
            gamedto.Away_team = Gamedatainput[2];

            string retval = gamedto.CreateMaptoentidy(Gameslist);


            string[] Gamedatainputfinish = { "2", gamedto.Id_game.ToString()};


            gamedto.Id_game = Convert.ToInt32(Gamedatainputfinish[1]);

            
            retval = gamedto.UpdateMaptoentidy_finishgame(Gameslist);

            Assert.AreEqual("", retval);

        }
    }
}
