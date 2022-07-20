using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class Services_MsgsCtrl
    {
        public static string ErrorsControl(string op)
        {
            string Errmsg = "";

            switch (op)
            {
                case "val.1":
                    Errmsg = "The New game data format is not correct, please check";
                    break;
                case "val.2":
                    Errmsg = "The Finish game data format is not correct, please check";
                    break;
                case "val.3.1":
                    Errmsg = "The Home Team Score do not have a correct value, please check";
                    break;
                case "val.3.2":
                    Errmsg = "The Away Team Score do not have a correct value, please check";
                    break;
                case "val.4":
                    Errmsg = "The Away Team Score data format is not correct, please check"; 
                    break;
                case "val.5":
                    Errmsg = "The New Game was created correctly!";
                    break;
                case "val.6":
                    Errmsg = "The Game was finished correctly!"; 
                    break;
                case "val.7":
                    Errmsg = "The Game Score was updated correctly!"; 
                    break;
                case "ent.1":
                    Errmsg = "Game already exist!!";
                    break;
                case "ent.2":
                    Errmsg = "Game was not found!";
                    break;
                case "op.1":
                    Errmsg = "The operation ID is invalid, please check!";
                    break;
                case "op.2":
                    Errmsg = "############ Football World Cup Score Board ############";
                    break;
                case "op.3":
                    Errmsg = "No Games was found!!";
                    break;
                case "op.4":
                    Errmsg = "############ Football World Cup Score Board ############" + System.Environment.NewLine;
                    Errmsg += "Please Enter Data games (Enter 5 for help .:. Exit to close): ";
                    break;
                case "op.5":
                    
                    Errmsg = "The Game data input is invalid, please check!";
                    break;
                default:
                    Errmsg = "Operation ID is invalid, please check!";
                    break;
            }

            return Errmsg;
        }
    }
}
