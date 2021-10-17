using System;
using System.Collections.Generic;

namespace ClassmatesRedux
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Students> studentList = new List<Students>();
            studentList.Add(new Students(1, "Andy", "Berkley", "French Fries", "Stone Cold Steve Austin"));
            studentList.Add(new Students(2, "Cassly", "Detroit", "Steak", "The Rock"));
            studentList.Add(new Students(3, "Phillip", "Canton", "Fried Chicken", "Macho Man Randy Savage"));
            studentList.Add(new Students(4, "Cortez", "Detroit", "Chicken Fettucini Alfredo", "Rey Mysterio"));
            studentList.Add(new Students(5, "Erin", "Troy", "Tacos", "Kenny Omega"));
            studentList.Add(new Students(6, "Richard", "Canton", "Sushi", "Bryan Danielson"));
            studentList.Add(new Students(7, "Cullin", "Fowlerville", "Pad Thai", "Bret 'The Hitman' Hart"));
            studentList.Add(new Students(8, "Cordero", "Berkley", "BBQ Chicken", "Eddie Guerrero"));
            studentList.Add(new Students(9, "Huy", "Lansing", "Korean BBQ", "John Cena"));
            studentList.Add(new Students(10, "Tommy", "Raleigh", "Curry", "Nick Gage"));

            bool goOn1 = true;
            bool goOn2 = true;

            while (goOn1)
            {
                string selection = GetInput("Please enter a number from 1-10.\n");
                int studentNum = ValidateAnswer(selection);

                string studentName = studentList[studentNum - 1].Name;
                string homeTown = studentList[studentNum - 1].Hometown;
                string studentFood = studentList[studentNum - 1].Food;
                string studentWrestler = studentList[studentNum - 1].Wrestler;
                string studentInfo;

                if (studentNum > studentList.Count)
                {
                    Console.WriteLine("Welcome to Get To Know Your Classmates: REDUX!");
                    Console.WriteLine("Please select a valid number 1-10.");
                }
                else
                {
                    Console.WriteLine($"You have selected {studentNum}: {studentName}");
                    goOn2 = true;

                    while (goOn2)
                    {
                        studentInfo = GetInput($"Would you like to know more about {studentName}? Type 'h' for hometown, 'f' for food, or 'w' for wrestler!\n").ToLower();

                        if (studentInfo == "h")
                        {
                            Console.WriteLine($"{studentName} is from {homeTown}");
                            goOn2 = Continue($"Would you like to learn more about {studentName}? y/n\n");
                        }
                        else if (studentInfo == "f")
                        {
                            Console.WriteLine($"{studentName}'s favorite food is {studentFood}");
                            goOn2 = Continue($"Would you like to learn more about {studentName}? y/n\n");
                        }
                        else if (studentInfo == "w")
                        {
                            Console.WriteLine($"{studentName}'s favorite wrestler is {studentWrestler}. OH YEEEAHHH!");
                            goOn2 = Continue($"Would you like to learn more about {studentName}? y/n\n");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid response.");
                        }
                    }
                }
                goOn1 = Continue("Would you like to continue? y/n\n");
            }





            //foreach (Students stu in students)
            //{
            //    if(stu.StudentID == id)
            //    {
            //        Console.WriteLine($"You have selected {stu.Name}! Would you like to know more?\nType 'hometown' to learn about their hometown." +
            //            $"\nType 'food' to learn about their favorite food.\nType 'wrestler' to learn their favorite wrestler.");
            //        string option = Console.ReadLine().ToLower();
            //        if(option == "hometown")
            //        {
            //            Console.WriteLine($"{stu.Name}'s hometown is {stu.Hometown}!");
            //        }
            //        else if(option == "food")
            //        {
            //            Console.WriteLine($"{stu.Name}'s favorite food is {stu.Food}...yum!");
            //        }
            //        else if (option == "wrestler")
            //        {
            //            Console.WriteLine($"{stu.Name}'s favorite wrestler is {stu.Wrestler}, OHH YEAHH!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter a valid option.");
            //        }
            //    }

            //}
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public static int ValidateAnswer(string input)
        {
            int output;
            if (int.TryParse(input, out output) && output > 0)
            {
                return output;
            }
            else
            {
                input = GetInput("That is not a valid response.  Please Try again.  (Enter a number 1-10): ");
                return ValidateAnswer(input);
            }
        }

        public static bool Continue(string prompt)
        {
            string answer = GetInput(prompt).ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Sayonara!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand, please try again. Enter only y/n.");
                return Continue(prompt);
            }
        }
    }
}
