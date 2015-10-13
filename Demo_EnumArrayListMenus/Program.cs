using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Demo_EnumArrayListMenus
{
    class Program
    {
        //
        // enumerable of player actions
        //
        public enum ActionChoice
        {
            // "None" is used to indicate no choice or an empty choice
            // enum can also be made nullable
            None,
            QuitGame,
            Move
        }

        static void Main(string[] args)
        {
            //
            // initialize the hall array
            //
            string[] hall = new string[4] {
                "The Great Room", 
                "The Master Bedroom", 
                "The Den", 
                "The Kitchen"};

            //
            // initialize the inventory list
            //
            List<string> inventory = new List<string>
            {
                "A Backpack",
                "A knife"
            };

            DisplayActionChoices();

            DisplayRoomChoice(hall);

            DisplayItemChoice(inventory);

            Console.ReadKey();
        }

        public static void DisplayActionChoices()
        {
            Console.WriteLine();
            Console.WriteLine("You have the following actions available to you.");
            Console.WriteLine("(With Enum Formated)");
            Console.WriteLine();

            foreach (ActionChoice choice in Enum.GetValues(typeof(ActionChoice)))
            {
                string actionChoiceText;

                // skip the first enum value that is the default value of "none"
                if (choice != ActionChoice.None)
                {
                    actionChoiceText = "(" + ((int)choice) + ") " +
                    ConsoleUtil.ToLabelFormat(choice.ToString());
                    Console.WriteLine(actionChoiceText);
                }
            }

            Console.WriteLine();
            Console.WriteLine("You have the following actions available to you.");
            Console.WriteLine("(Without Enum Formated)");
            Console.WriteLine();

            foreach (ActionChoice choice in Enum.GetValues(typeof(ActionChoice)))
            {
                string actionChoiceText;

                // skip the first enum value that is the default value of "none"
                if (choice != ActionChoice.None)
                {
                    actionChoiceText = "(" + ((int)choice) + ") " +
                    choice.ToString();
                    Console.WriteLine(actionChoiceText);
                }
            }
        }

        public static void DisplayRoomChoice(string[] hall)
        {
            Console.WriteLine();
            Console.WriteLine("Choose one of the following rooms.");
            Console.WriteLine();

            int displayedRoomNumber;

            foreach (string room in hall)
            {
                // add one to the array indes to start the diplayed numbering at 1
                // remember to convert player's choice by subtracting 1 to get the correct index
                displayedRoomNumber = Array.IndexOf(hall, room) + 1;

                Console.WriteLine("(" + displayedRoomNumber + ") " + room);
            }
        }

        public static void DisplayItemChoice(List<string> inventory)
        {
            Console.WriteLine();
            Console.WriteLine("Choose one of the following items.");
            Console.WriteLine();

            int displayedItemNumber;

            foreach (string item in inventory)
            {
                // add one to the list indes to start the diplayed numbering at 1
                // remember to convert player's choice by subtracting 1 to get the correct index
                displayedItemNumber = inventory.IndexOf(item) + 1;

                Console.WriteLine("(" + displayedItemNumber + ") " + item);
            }
        }
    }
}
