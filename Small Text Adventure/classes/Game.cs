using System.Collections;
using Small_Text_Adventure.classes;

namespace Small_Text_Adventure
{
    public class Game
    {
        //Fields
        private int startPoint; //Variable will be used to roll randomly
        private Random randomNumber;
        private string currentTime = DateTime.Now.ToString("hh:mmtt");
        private Player player;
        private ArrayList apartmentChoices, streetChoices;

        //Constructor
        public Game(Player player)
        {
            this.randomNumber = new Random();
            this.apartmentChoices = new ArrayList();
            this.streetChoices = new ArrayList();
            this.player = player;
            this.startPoint = randomNumber.Next(1, 13); //Generates a number from 1-12
        }

        //Methods

        public void BeginAdventure()
        {
            GenerateChoice(this.startPoint);
        }

        /// <summary>
        /// Generates a choice and outputs to the Console a situation based on the number.
        /// </summary>
        /// <param name="startPoint">Takes in a value and displays a situation based on the number given.</param>
        private void GenerateChoice(int startPoint) //Method will generate a start point to the story based on number generated
        {
            switch(startPoint)
            {
                //Zone 1 | Apartment Start
                case 1:
                    Console.Clear();
                    Console.WriteLine($"You wake up in your apartment bed - dazed for a brief second before everything began to focus. You began to ponder what had happened yesterday. You get up out of your bed and check the time. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    ApartmentChoices();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"You wake up on your apartment's couch. Seemingly comfortable, you take a few minutes to rest as the new day beckons. You get up from the couch and begin to perform a deep stretch before letting out a small relaxed sigh. The phone on the end-table buzzes and you check the time. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    ApartmentChoices();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"You awaken from what seemed like an endless day dream. You take a second to look around the room. There you are, sitting at a desk in front of a computer that is only displaying an empty webpage. You take a small breath before checking the time. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    ApartmentChoices();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"You begin falling from the sky headed straight for the ground. In a panic, you attempt to stabalize your fall mid-air but fail. Frantically, you look around and see yourself about the hit the ground. 'This is it' you thought to yourself. As your body was about to hit the ground, you wake up on your bed letting out the biggest sigh of relief. You look towards the clock. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    ApartmentChoices();
                    break;
                //Zone 2 | Street Start
                case 5:
                    Console.Clear();
                    Console.WriteLine($"It was a calm and quiet day. You walk into an empty parking lot near the local park. What was once a busy park has now been reduced to rubble as you look at the empty construction zone. You overhear some voices from around the corner before you check your watch. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    StreetChoices();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine($"You find yourself walking down a busy street. Cars and pedestrians littered the area as they went about their daily business. You began walking in a straight line and turned into an empty parking lot. The parking lot was empty and it was near a park - or what used to be one. What was once a busy park has now been reduced to rubble as you look at the empty construction zone. As you walked further into the park lot, you overhear some voices from around the corner. You check the time. It's currently {currentTime}.");
                    Console.WriteLine($"\nWhat would you like to do?\n");
                    StreetChoices();
                    break;
                case 7:
                    break;
                case 8:
                    break;
                //Zone 3 | Shop Start
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                default:
                    Console.WriteLine("UH OH! Something has broken.");
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// Outputs to Console the Apartment choices.
        /// </summary>
        private void ApartmentChoices()
        {
            apartmentChoices.Add("1. Explore Apartment");
            apartmentChoices.Add("2. Check the Weather");
            apartmentChoices.Add("3. Go to sleep");
            apartmentChoices.Add("4. Eat Food & Drink Water");
            apartmentChoices.Add("5. Go Outside");
            apartmentChoices.Add("0. Examine Self (Stats)");

            foreach(string option in apartmentChoices)
            {
                Console.WriteLine(option);
            }
            
        }

        /// <summary>
        /// Outputs to Console the Street choices.
        /// </summary>
        private void StreetChoices()
        {
            streetChoices.Add("1. Wander around the area");
            streetChoices.Add("2. Explore the construction zone");
            streetChoices.Add("3. Talk with the locals");
            streetChoices.Add("0. Examine Self (Stats)");

            foreach(string option in streetChoices)
            {
                Console.WriteLine(option);
            }
        }

    }
}