using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreBoardTest
{
    [TestClass]
    public class Test_Services_Validations
    {

        [TestMethod]
        public void Test_Treatdatainput_OK()
        {

            string Gamedatainput = "1;Mexico;Canada";

            string[] Gamedata = Services_Validations.Treatdatainput(Gamedatainput);

            Assert.AreNotEqual(null, Gamedata);

        }

        [TestMethod]
        public void Test_Treatdatainput_NOTOK()
        {

            string Gamedatainput = null;

            string[] Gamedata = Services_Validations.Treatdatainput(Gamedatainput);

            Assert.AreEqual(null, Gamedata);

        }

        [TestMethod]
        public void Test_Isexpressionvalid_CreateNewGame_OK()
        {

            string[] Gamedatainput = { "1", "Mexico", "Canada" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_Isexpressionvalid_UpdateGame_OK()
        {

            string[] Gamedatainput = { "3", "0", "0","5" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_Isexpressionvalid_UpdateGame_FinishGame_OK()
        {

            string[] Gamedatainput = { "2", "0"};

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_expressionvalid_Invalid_OP()
        {

            string[] Gamedatainput = { "2323", "Mexico", "Canada" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_expressionvalid_Invalid_Qtd_FieldsData_Creategame()
        {

            string[] Gamedatainput = { "1", "Mexico", "Canada","Spain" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_expressionvalid_Invalid_Qtd_FieldsData_Updategame()
        {

            string[] Gamedatainput = { "3", "Mexico", "Canada" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_expressionvalid_Invalid_Qtd_FieldsData_Updategame_Finish()
        {

            string[] Gamedatainput = { "2" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }

        [TestMethod]
        public void Test_expressionvalid_UpdateNewGame_NOTOK()
        {

            string[] Gamedatainput = { "3", "Mexico", "Canada" };

            bool retval = Services_Validations.Isexpressionvalid(Gamedatainput);

            Assert.AreEqual(true, retval);

        }


    }
}
