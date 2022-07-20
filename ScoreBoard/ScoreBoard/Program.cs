using System;
using System.Collections.Generic;
using Library;


namespace ScoreBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<GamesEntity> Gameslist = new List<GamesEntity>();

            string retval ;

            do
            {
                
                retval = "";

                //PRINT OUT WELCOME MESSAGE
                Services_Operations.ShowWelcomemsg();

                //READ GAME DATA
                string gamedatainput = Console.ReadLine();

                //CONTROL IF THE USER WANT TO CLOSE PROGRAM
                if (!gamedatainput.Contains(Services_Validations.Exitword))
                {
                    //GET THE GAME DATA AND OPERATIONS
                    string[] partnergamedata = Services_Validations.Treatdatainput(gamedatainput);

                    //VALIDATE IF THE GAME DATA FORMAT IS VALID
                    if (Services_Validations.Isexpressionvalid(partnergamedata))
                        //EXECUTE THE GAME DATA OPERATION
                        Services_Operations.ExecuteOper(partnergamedata, Gameslist);
                    else
                        //PRINT OUT MESSAGES TO THE USER
                        Services_Operations.Printoutmsg(retval);
                    
                }
                else
                    break;

            } while (true);
        }
    }
}
