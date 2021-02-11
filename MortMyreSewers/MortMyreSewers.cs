using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp
{
    class MortMyreSewers

    {
        static void Main(string[] args)
        {
            //This is the program that will control the flow of the overall experience for the user. All classes will be created in seperate files and refered to in this program to allow us to use instances of monsters, players, weapons, rooms, etc. 

            Console.Title = "_-{THE SEWERS OF MORT MYRE}-_";
            Console.WriteLine(" Welcome, Maggot.\n Fight your way out of the sewers, or die trying.\n");
            int score = 0;

            //TODO 1. CREATE THE PLAYER - NEED TO CREATE A CLASS FOR THIS.
            //TODO 2. WEAPON(S).
            //TODO 3. CREATE A LOOP FOR THE ARENA(S) AND MONSTER(S).
            bool exit = false;
            do
            {
                //Enter a room. 
                //TODO 4. CALL GetRoom()
                Console.WriteLine(GetRoom());

                //TODO 5. Create a monster for the room - learn about creating objects and then randomly selecting them. 

                //TODO 6. CREATE LOOP FOR THE ROOM.

                bool reload = false;
                do
                {
                    //TODO 7. CREATE A MENU
                    Console.WriteLine
                        ("\n\n PLEASE SELECT AN OPTION:\n\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit \n\n" +
                        "Current Score: {0}\n\n", score);

                    //TODO 8. CATCH USER CHOICE

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Above will execute upon input without having to hit enter.

                    //TODO 9. CLEAR THE CONSOLE AND BUILD THE SWITCH BASED ON USERCHOICE
                    Console.Clear();
                    #region Switch(User Choice)
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("You attack the monster in front of you.\n");
                            //TODO 10. BUILD ATTACK LOGIC
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("You cower with your tail between your legs like the pathetic dog you are.\n");
                            //TODO 11. BUILD RUN AWAY LOGIC
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Your player is as follows:\n");
                            break;
                        //TODO 12. ADD PLAYER INFORMATION 
                        case ConsoleKey.M:
                            Console.WriteLine("The monster is as follows:\n");
                            break;
                        //TODO 13. ADD MONSTER INFORMATION
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Thank you for playing adventurer, hopefully you return to the dungeon once again.\n");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("User interaction not recognized, please try again.");
                            break;
                    }

                    //TODO 14. HANDLE PLAYER LIFE
                    #endregion
                } while (!reload && !exit);
            } while (!exit);

        }


        //TODO 15. CREATE GetRoom() & PLUG IT IN TO THE TODO ABOVE
        private static string GetRoom()
        {
            string[] rooms =
            {
                //a variety of rooms will go here. 
                "The walls ooze green slime and the cobblestone that makes up the rounded corners of the room is cracked and faded. You notice theres a constant 'drip, drip, drip' from somewhere unknown. It looks like the only thing thats been down here for years has been rats and theives, going to and from their den. Taking steps into the room you notice that it's bigger than you originally noticed. Every step echoes against the wall as you head further in. You begin to realize the room is darkening around you as you step away from the door. Eventually, you reach a point where you can barely see your hand in front of your face."
            };
            //generate a random object and get a random room description. 
            Random rand = new Random();
            //since the maxValue in the Next() is exclusive, we can just use the Length property to include all indexes from our array.
            int indexNbr = rand.Next(rooms.Length);
            string room = "****** NEW ROOM ******\n" + rooms[indexNbr] + "\n";
            //create an array of room descriptions - string datatype
            return room;
        }
    }

}

