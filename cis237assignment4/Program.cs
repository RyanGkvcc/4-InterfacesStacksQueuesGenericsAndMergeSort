///Programmer:  Ryan Gowan
///Date:        3/25/2016
///POV:         What are you suppossed to learn from this project.
///                 Interfaces, Stackes, Queues, Generics, and Merge Sort
///             Populate collection of Droids that ara all similarly based on an abstract class, yet are different
///             based on the user input. Have the ability to print out the entire unsorted collection of Droids, including the 
///             price. Also have the ability to sort by model or by total cost and print out the sorted collection.
///                            
///BOV:         Purpose of this project, if any.
///                 The ability to implement a interfaces.
///                 The ability to create and utilize stacks and queues.
///                 The ability to create and utilize generics.
///                 The ability to utilize merge sort.
///                 The ability to display information within the console terminal.

//  This project shows Documentation comments, above.
/*  Notes:
 *  ???/100
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            //Test content
            //
            droidCollection.Add("Carbonite", "Protocol", "Bronze", 1);
            droidCollection.Add("Vandanium", "Utility", "Silver", true, true, true);
            droidCollection.Add("Quadranium", "Janitor", "Gold", true, true, true, true, true);
            droidCollection.Add("Quadranium", "Astromech", "Gold", true, true, true, true, 12);
            droidCollection.Add("Vandanium", "Protocol", "Silver", 2);
            droidCollection.Add("Carbonite", "Utility", "Bronze", false, false, false);
            droidCollection.Add("Carbonite", "Janitor", "Bronze", false, false, false, false, false);
            droidCollection.Add("Vandanium", "Astromech", "Silver", false, false, false, false, 11);
            droidCollection.Add("Quadranium", "Protocol", "Gold", 3);
            droidCollection.Add("Quadranium", "Utility", "Gold", true, false, true);
            droidCollection.Add("Vandanium", "Janitor", "Silver", true, false, true, false, true);
            droidCollection.Add("Carbonite", "Astromech", "Bronze", true, false, true, false, 10);
            //
            //

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 5, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;

                    //Choose to Sort and Print by Model
                    case 3:
                        droidCollection.SortByModel();
                        userInterface.PrintDroidList();
                        break;

                    //Choose to Sort and Print by Total Cost
                    case 4:
                        droidCollection.SortByTotalCost();
                        userInterface.PrintDroidList();
                        break;
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }


        }
    }
}
