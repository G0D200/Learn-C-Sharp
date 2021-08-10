using System; // needed to use the console commands

// keep namespace the same between this and the main file for easy access to everything
namespace CS
{

    // Static class so it cannot be instantiated
    // Class to manage all helpher functions
    public static class consoleWrapper
    {

        // wrapper function around Console.WriteLine in case we need to do any other things when writing to the console
        // gives us flexibility if we instead want to change the behavior to write the line to a file or other output stream
        public static void WriteLine(string line = "")
        {
            Console.WriteLine(line);
        }

        // Simple wrapper function around Console.Clear() in case we want to change behavior or do more
        public static void Clear()
        {
            Console.Clear();
        }

        // wrapper function around reading basic input if we want to change behavior
        public static string Read()
        {
            return Console.ReadLine();
        }

        // Wrapper function around reading commands, so we can take the user's input, uppercase it, and remove spaces
        public static string ReadCommand()
        {
            return Console.ReadLine().ToUpper().Replace(" ", "");
        }

        // prints all options on a single line and wraps them in square brackets, with the input being an amount of strings. Also prints a separator line after it
        public static void printOptions(params string[] stringList)
        {
            string allTypes = "";
            foreach (string s in stringList)
                allTypes = allTypes + $"[{s}] ";
            WriteLine(allTypes);
            WriteLine();
        }

        // takes a string list and prints them on multiple different lines and writes another line after it
        public static void PrintMultiLineString(params string[] stringList)
        {
            foreach (string s in stringList)
                WriteLine(s);
            WriteLine();
        }

        // prints instructions on how to go back, divider, the information block given to it in an array of strings, and will wait to read input from the user to continue back to the previous options
        public static void PrintDescriptionBlockAndWait(params string[] stringList)
        {
            WriteLine(ProjectLiterals.BACK);
            WriteLine(ProjectLiterals.DIVIDER);
            PrintMultiLineString(stringList);
            WriteLine(ProjectLiterals.TRY_IT);
            WriteLine("Press Any Button to Continue...");
            Console.ReadKey();
        }

        // This is a function to handle multiple pages, with the inputs:
        // pages - an array of string arrays. Each string array represents a page and that page may contain multiple strings input together
        // currentPage - the starting page for the pageHandler to display
        // back - consolekey that users will press to go back a page
        // forward - consolekey that users will press to go forward a page
        public static void MultipageHandler(string[][] pages, int currentPage, ConsoleKey back, ConsoleKey forward)
        {
            // bool for outer loop condition to write pages when changed
            bool exit = false;

            // outer loop to manage page changes
            while (exit != true)
            {
                Clear();  // clear the screen
                PrintMultiLineString(pages[currentPage]); // write current page to screen
                WriteLine(ProjectLiterals.PAGE_INSTRUCTIONS); // write page instructions
                WriteLine($"You are on page {currentPage + 1} out of {pages.Length}"); // Update them on what page they are on and how many pages there are

                // inner loop which controls reading keypresses. Exit conditions handled by breaks
                while (true)
                {
                    ConsoleKey keypress = Console.ReadKey().Key; // wait to read keypress

                    // if they try to go back a page
                    if (keypress == back)
                    {
                        // check to make sure they are not on the first page
                        if (currentPage > 0)
                        {
                            // go down one page and exit the inner loop
                            currentPage--;
                            break;
                        }
                        else // else give warning about already being on first page
                        {

                            WriteLine(ProjectLiterals.FIRST_PAGE);
                        }
                    }
                    // check if they want to go forward a page
                    else if (keypress == forward)
                    {
                        // check to make sure they are not on the last page
                        if (currentPage < pages.Length - 1)
                        {
                            // go up one page and exit the inner loop
                            currentPage++;
                            break;
                        }
                        else // else give warning that they are on the last page
                        {
                            WriteLine(ProjectLiterals.LAST_PAGE);
                        }
                    }
                    // Check to see if they pressed enter and set exit to true and exit the inner loop, which will also trigger ending the outer loop
                    else if (keypress == ConsoleKey.Enter)
                    {
                        exit = true;
                        break;
                    }
                    else // else let the user know their keypress was invalid and continue in inner loop to read more keypresses
                        WriteLine(ProjectLiterals.INVALID_KEYPRESS);
                }
            }
        }
    }

}