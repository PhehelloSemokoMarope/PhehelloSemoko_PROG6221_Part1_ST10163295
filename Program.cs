using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PhehelloSemoko_PROG6221_Part1_ST10163295
{
    class fullRecipe
    {
        public String[] nameIngred { get; set; }
        public String[] unitOfIngred { get; set; }
        public int[] quantityOfIngred { get; set; }
        public int numIngred { get; set; }
        public int numOfSteps { get; set; }
        public string[] listSteps { get; set; }
        public string recipeName { get; set; }


        public void createRecipe()
        {

            Console.Write("Enter the name of the Recipe: ");
            recipeName = Console.ReadLine();



            Console.WriteLine("Please enter the amount of ingredients you'd like to add.");
            numIngred = Convert.ToInt32(Console.ReadLine());

            nameIngred = new string[numIngred];
            quantityOfIngred = new int[numIngred];
            unitOfIngred = new String[numIngred];

            for (int i = 0; i < numIngred; i++)
            {
                Console.Write("Enter the name of the ingredient: ");
                nameIngred[i] = Console.ReadLine();

                Console.Write("Enter the Quantity: ");
                quantityOfIngred[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the unit of measurement: ");
                unitOfIngred[i] = Console.ReadLine();
            }

            Console.WriteLine("Please enter the amount of steps there are: ");
            numOfSteps = Convert.ToInt32(Console.ReadLine());
            listSteps = new string[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.Write("Enter the steps below: ");
                listSteps[i] = Console.ReadLine();
                        }
            

        }
        public void exitMenu()
        {
            Environment.Exit(0);
        }

        public void showRecipe()
        {

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"                      RECIPE NAME: {recipeName}");
            Console.WriteLine("---------------------------------------------------------");

            for (int i = 0; i < numIngred; i++)
            {
                Console.WriteLine($"{quantityOfIngred[i]} {unitOfIngred[i]} Of  {nameIngred[i]}");
            }

            Console.WriteLine("Here are the steps: ");

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"{listSteps[i]}");
            }

        }

        public void clearRecipe()
        {
            nameIngred = new string[0];
            quantityOfIngred = new int[0];
            unitOfIngred = new String[0];
            listSteps = new string[0];
            recipeName = "" ;

            Console.Write("");
            Console.Write("Everything has been cleared!");
            Console.Write("");


        }


        internal class Program
        {

            static void Main(string[] args)
            {
                fullRecipe myRecipe = new fullRecipe();
                bool exit = false;


               
                while (!exit)
                {
                   
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("                      Recipe Maker");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Select one of the following menu items:");
                    Console.WriteLine("(1) Create menu");
                    Console.WriteLine("(2) Show Recipe");
                    Console.WriteLine("(3) Clear Recipe");
                    Console.WriteLine("(4) Exit Menu");
                    Console.WriteLine("");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            myRecipe.createRecipe();
                            break;

                        case "2":
                            myRecipe.showRecipe();
                            break;

                        case "3":  
                            myRecipe.clearRecipe();
                            Console.Write("");
                            break;

                        case "4":
                            myRecipe.exitMenu();
                            break;
                    }

                }
            

            }
        }
    }
}
