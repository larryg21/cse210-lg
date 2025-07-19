using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        PromptGenerator promptGen = new PromptGenerator();




        while (true)
        {
            Console.WriteLine($" Welcome to your Daily Journal Program");
            Console.WriteLine(" Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");

            Console.WriteLine($" What would like to do?");


            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {

                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    myJournal.AddEntry(new Entry(date, prompt, response));
                    break;


                case "2":

                    myJournal.DisplayEntries();
                    break;


                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    Console.WriteLine($"Journal saved");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    Console.WriteLine($"Journal loaded. ");
                    break;

                case "5":
                    Console.WriteLine("Have a good sleep, keep writing and see you tomorrow!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, try again. ");
                    break;
            }
        }


    }


}