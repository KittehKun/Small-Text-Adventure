namespace Small_Text_Adventure.classes
{
    public class Outcome
    {
        //Fields
        private int outcomeCode;

        //Constructor
        public Outcome()
        {
            this.outcomeCode = 0;
        }

        /// <summary>
        /// Outputs to console an outcome depending on the method's parameter code.
        /// </summary>
        public void GenerateAptOutcome(int outcomeCode, DateTime currentTime)
        {
            this.outcomeCode = outcomeCode;
            switch(outcomeCode)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"You begin to explore around your apartment. Finding that the place is still in a clean condition. You decide to take a look at some of the smaller details of your humble abode. Eventually, time began to accelerate and you begin to lose track of time. You check the time oncemore. The time is now {currentTime.AddHours(6).ToString()}. You spend the rest of the time in your apartment.");
                    Console.WriteLine("\n== A P A R T M E N T  E N D I N G ==\n");
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"You check the weather. The weather shows clear skies with a slight chance of rainfall. You took a gander outside as the sun beams began to shine on you. You felt your body get lifted into the sun beams and you began to close your eyes. You open your eyes and find yourself in white robes and in a room seemingly made out of clouds. You step outside the room and find an empty plane of white clouds. You thought about the room you stepped out of, wondering how it got there. As the thought crossed your mind, another identical room begins to form from the clouds. You then begin to think of various other things. In this 'world' above the clouds, your thoughts come to reality. You spend the rest of eternity here, building your own world above the clouds");
                    Console.WriteLine("\n== A B O V E  T H E  C L O U D S  E N D I N G ==\n");
                    Environment.Exit(0);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"You walk back to your bed and lay down with the blanket halfway. You begin to stare at the ceiling wondering if you should go back to sleep.");
                    Console.WriteLine("\nWhat will you do?");

                    Console.WriteLine("\n1. Go back to sleep");
                    Console.WriteLine("2. Continue to stare at the ceiling");

                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                Console.WriteLine("\nYou begin to fall back asleep and begin to dream about your apartment. In your dream, you see your body laying in the bed resting peacefully. Out of curiosity, you attempt to wake yourself from your sleep. As you touch your body, a warm shockwave feeling courses through your dream world. Suddenly, the dream collapses into a swirl and you find yourself in darkness. Moments later, you spawn into an empty plane devoid of anything. You sit down and begin to think. Suddenly, your thoughts begin to swirl into the plane of exsistence. You begin to spend a great deal of time here in your dream world.");
                                Console.WriteLine("\n== L U C I D  D R E A M  E N D I N G ==");
                                break;
                            case 2:
                                Console.WriteLine($"\nYou continue to stare at the ceiling. Some time passes and you check the time. It is {currentTime.AddHours(3).ToString()}. You continue to stare at the ceiling for the rest of the day.");
                                Console.WriteLine("\n== C E I L I N G  E N D I N G ==");
                                break;
                            default:
                                Console.WriteLine("Something went wrong. Exiting program...");
                                Environment.Exit(0);
                                break;
                        }
                    } catch (Exception error)
                    {
                        Console.WriteLine($"UH OH! Something went wrong: {error.Message}");
                    }
                    Environment.Exit(0);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"You begin to walk towards the kitchen and open the fridge. You breifly think of a dish you want to eat and begin to grab the ingredients. You start to cook the food and prepare the drink of choice. When it's all done, you plate the food, take a seat, and begin to eat into your delicious meal.");
                    Console.WriteLine("\n== C H E F  E N D I N G ==");
                    Environment.Exit(0);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine($"You walk outside to the street and begin walking in one direction. As you walk, you begin to observe the people around the area going about their daily lives. You turn to a different street and begin walking in that direction. A shiny glint catches your eye as you walk closer towards it. Someone had dropped a quarter and it had been sitting in the sun for a bit. You decided to pick it up and pocket it. Later on your walk, you grab a soda from a vending machine and using the quarter, you were able to get the soda with exact change.");
                    Console.WriteLine("\n== V E N D I N G  M A C H I N E  E N D I N G ==\n");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Outputs to console an outcome depending on the method's parameter code.
        /// </summary>
        public void GenerateStreetsOutcome(int outcomeCode)
        {
            this.outcomeCode = outcomeCode;
        }
    }
}