using System;

namespace Library
{
    public static  class Services_Validations
    {
        public const string sep = ";";
        public const string Exitword = "exit";

        public static bool Isexpressionvalid(string[] Gamedata)
        {
            bool retval = false;
            string Errmsg = "";
            
            try
            {
                if (Gamedata !=null)
                {
                    switch (Gamedata[0])
                    {
                        case "1":

                            if (!(Gamedata.Length == 3))
                                Errmsg = Services_MsgsCtrl.ErrorsControl("val.1");
                            break;
                        case "2":
                            if (!(Gamedata.Length == 2))
                                Errmsg = Services_MsgsCtrl.ErrorsControl("val.2");

                            break;
                        case "3":
                            if (Gamedata.Length == 4)
                            {
                                int parseout = 0;

                                //VERIFY IF THE PARAMETER IS NUMERIC (INT)
                                if (!int.TryParse(Gamedata[1], out parseout))
                                    Errmsg = Services_MsgsCtrl.ErrorsControl("val.3.1");
                                else
                                //VERIFY IF THE PARAMETER IS NUMERIC (INT)
                                    if (!int.TryParse(Gamedata[2], out parseout))
                                    Errmsg = Services_MsgsCtrl.ErrorsControl("val.3.2");
                            }
                            else
                                Errmsg = Services_MsgsCtrl.ErrorsControl("val.4");

                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            Errmsg = Services_MsgsCtrl.ErrorsControl("default");
                            break;
                    }
                }
                else
                {
                    Errmsg = Services_MsgsCtrl.ErrorsControl("val.1");
                }

                //RETURN THE ERROR MESSAGE, IF EXISTS
                if (Errmsg.Length > 0)
                {
                    retval = false;
                    Console.WriteLine(Errmsg);
                }
                else
                    retval = true;

            }
            catch (Exception ex)
            {
                retval = false;
                Console.WriteLine(ex.Message);
            }

            return retval;
        }

        public static void Operationssuccededmsg(string Idop)
        {
           
            switch (Idop)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(Services_MsgsCtrl.ErrorsControl("val.5"));
                    
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(Services_MsgsCtrl.ErrorsControl("val.6"));
                    
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(Services_MsgsCtrl.ErrorsControl("val.7"));
                    
                    break;
                
                default:
                    break;
            }

        }

        public static string[] Treatdatainput(string gamedatainput)
        {
            string[] gamedata = null;

            try
            {
                //GET THE GAME DATA AND OPERATIONS
                gamedata = gamedatainput.Split(Services_Validations.sep);
            }
            catch (Exception ex)
            {

                Console.WriteLine(Services_MsgsCtrl.ErrorsControl("op.5") + " -> " + ex.Message);
            }

            return gamedata;

        }
    }
}
