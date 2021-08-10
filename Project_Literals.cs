namespace CS
{

    public static class ProjectLiterals
    {

        ////////////////////////////////////////////////////////////////////////////////
        // Learning Topics and Types

        public static string[] Topics =
        {
    "dataTypes",
    "branchingTypes",
    "loopTypes",
    "formatting",
    "usefulFunctions",
    "advancedTopics"
  };

        public static string[] DataTypes =
        {
      "ints",
      "doubles",
      "strings",
      "bools",
      "chars",
      "floats",
      "decimals",
      "longs",
      "unsigned"
  };

        public static string[] BranchingTypes =
        {
    "if",
    "else-if",
    "switch"
  };

        public static string[] LoopTypes =
        {
    "while",
    "do while",
    "for",
    "foreach"
  };

        public static string[] Formatting =
        {
    "semicolons",
    "brackets",
    "tabs",
    "keywords",
    "comments",
  };

        public static string[] UsefulFunctions =
        {
    "WriteLine",
    "ReadLine",
    "ReadKey"
  };

        public static string[] AdvancedTopics =
        {
    "functions",
    "namespaces",
    "arrays",
    "objects",
    "classes"
  };

        ////////////////////////////////////////////////////////////////////////////////
        // Misc

        public static string UNDER_CONSTRUCTION = "--DESCRIPTION UNDER CONSTRUCTION--";

        public static string DIVIDER = "========================================";

        ////////////////////////////////////////////////////////////////////////////////
        // General Statements and Instructions

        // Navigation
        public static string BACK = "To go back, press enter in the Console window without a valid operation";
        public static string RETURN = "To go back, type return";
        public static string PAGE = "To go back, press enter in the Console window. To swap between pages type < or > in the Console window";
        public static string HOW_TO_EXIT = "To close the app, type \"close\" or \"exit\" in the Console window";

        // Recommendations & Encouragement
        public static string RECOMMENDATION = "It is highly recommended that you use Visual Studio to follow along with these tutorials";
        public static string TRY_IT = "Try running this yourself. What happens?";

        // Invalid Commands
        public static string INVALID_COMMAND = "Command not recognized. Please try again.";
        public static string INVALID_KEYPRESS = "Keypress not recognized.";

        // Page Strings
        public static string PAGE_INSTRUCTIONS = "Press < or > to navigate pages, or press enter to go back";
        public static string FIRST_PAGE = "You are already on the first page";
        public static string LAST_PAGE = "You are already on the last page";

        ////////////////////////////////////////////////////////////////////////////////
        // Options to Choose From

        public static string WHAT_TO_LEARN = "What would you like to learn about? Options are encased in square brackets.";

        public static string WHAT_DATA_TYPE = "Which data type would you like to learn about? Options are encased in square brackets.";

        public static string WHAT_BRANCHING_TYPE = "Which branching statement would you like to learn about? Options are encassed in square brackets.";

        public static string WHAT_LOOP_TYPE = "Which loop type would you like to learn about? Options are encased in square brackets.";

        public static string WHAT_FORMATTING = "Which formatting would you like to learn about? Options are encased in square brackets.";

        public static string WHAT_FUNCTIONS = "Which function would you like to learn about? Options are encased in square brackets.";

        public static string WHAT_ADVANCED = "Which advanced topic would you like to learn about? Options are encassed in square brackets.";

        ////////////////////////////////////////////////////////////////////////////////
        // Data Type Strings

        public static string INT_DESCRIPTION = "An int is short for integer. An integer can store whole numbers from -2,147,483,648 to 2,147,483,648";
        public static string INT_CREATION = "To create an int, you type \"int exampleInt = 0;\"";

        public static string DOUBLES_DESCRIPTION = "A \"double\" is a form of data storage that can hold negative and positive decimals. Side note, I don't know the maximum or minimum range of a double";
        public static string DOUBLES_CREATION = "To make a double, you type \"double exampleDouble = 0.1;\", doubles can also store whole numbers just like ints.";

        public static string STRING_DESCRIPTION = "Strings are actually not data types, they are \"strings\" of characters.";
        public static string STRING_CREATION = "To make a string, you would type \"string exampleString = \"exampleWords\";\", we can now use this string to store usernames of accounts for a company if we so wished ";

        public static string BOOLEAN_DESCRIPTION = "Bools, or booleans, are statements that are either true or false. to make a boolean, we type \"bool exampleBool = True;\"";
        public static string BOOLEAN_CREATION = "One use for bools is you can use an if statement to check whether or not exampleInt is equal to 0, and if it is, you can set exampleBool to True.";

        public static string CHAR_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string CHAR_CREATION = UNDER_CONSTRUCTION;

        public static string FLOAT_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string FLOAT_CREATION = UNDER_CONSTRUCTION;

        public static string DECIMAL_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string DECIMAL_CREATION = UNDER_CONSTRUCTION;

        public static string LONG_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string LONG_CREATION = UNDER_CONSTRUCTION;

        public static string UNSIGNED_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string UNSIGNED_CREATION = UNDER_CONSTRUCTION;

        ////////////////////////////////////////////////////////////////////////////////
        // Branching Type Strings

        public static string IF_DESCRIPTION = "An if statement works by evaluating and checking if an expression is true or false.";
        public static string IF_CREATION = "The way you make an if statement is by typing: \n if(exampleInt = 0) \n { \n\t exampleInt = 1; \n } \n This makes an if statement that checks if the variable exampleInt is equal to 0. If it is, it sets it 1. If it's not, it skips the statement and goes to the ending curly brace.";

        public static string ELSEIF_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string ELSEIF_CREATION = UNDER_CONSTRUCTION;

        public static string SWITCH_DESCRIPTION = "=== It is suggested that you read the if statement else if description before this first ===\n\nA switch statement is similar to an if statement but is also  ";
        public static string SWITCH_CREATION = UNDER_CONSTRUCTION;

        ////////////////////////////////////////////////////////////////////////////////
        // Loop Type Strings

        public static string WHILE_DESCRIPTION = "A while loop is a loop that functions while something is true";
        public static string WHILE_CREATION = "For example: \n while(exampleInt < 100) \n { \n\t exampleInt++; \n } \n";

        public static string DO_WHILE_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string DO_WHILE_CREATION = UNDER_CONSTRUCTION;

        public static string FOR_DESCRIPTION = "The for loop will execute the code within it's brackets for as long as the middle statement in it's parantheses remain true. \n It has 3 components in it's parantheses. \n The first section is known as the initializer section. It is for initializing any variables (typically the counter for the loop). \n The second section is known as the condition section. It is for the statement that it will evaluate to see if it should continue executing. If it finds this to be false, it will exit the loop. \n The third section is known as the iterator section. It is typically used for incrementing the counter variable.";
        public static string FOR_CREATION = "An example of a for loop is \n for(int i = 0; i <= 0; i++) \n { \n \n } \n";
        public static string FOR_PAGE_2 = "You saw nothing. However what happened was that the loop ran 10 times before stopping. \n This time try putting a print function call in the empty space that uses the counter variable i. Like so: Console.WriteLine(i); \n What do you think will happen?";
        public static string FOR_PAGE_3 = "It printed the numbers 0-10 and then stopped. \n This is due to the i++ parameter. It increases the variable by one each loop. We could name i whatever we want as well, like exampleInt and it would have done the same thing as long as we replaced every instance of i with exampleInt.";

        public static string FOREACH_DESCRIPTION = UNDER_CONSTRUCTION;
        public static string FOREACH_CREATION = UNDER_CONSTRUCTION;

        ////////////////////////////////////////////////////////////////////////////////
        // Formatting

        public static string SEMICOLON_DESCRIPTION = "The semicolon is a termination character to indicate the end of statements. It is required at the end of statements that are not block statements. You've probably already noticed the presence of the semicolon in the other examples";
        public static string SEMICOLON_BLOCKS = "Blocks/Scope are chunks of code designated between two curly braces {}. These blocks can be things like if statement blocks, for/while loop blocks, functions, classes, and more. There will be no semicolons necessary at the end of the statement or at the end of either curly brace. \n If you have a scope inside of another (like an if condition inside of another if condition), the inner scope will be able to see variables *declared* in the outer scope, but the outer scope will not be able to read variables that are *declared* in the inner scope. Declaring a variable is something like: \n int a; \n or \n int a = 5; \n Assigning a variable would be something like (if a was already declared above) \n a = 5; \n For more info you can search for the differences between assignment and declaration for variables.";

        public static string BRACKETS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string TABS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string KEYWORDS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string COMMENTS_DESCRIPTION = UNDER_CONSTRUCTION;

        ////////////////////////////////////////////////////////////////////////////////
        // Functions

        public static string WRITELINE_DESCRIPTION = "The WriteLine function allows you to print text to the console.";
        public static string WRITELINE_CREATION = "The WriteLine function is used as follows: \n Console.WriteLine(\"Hello World\"); \n This would print Hello World out to the console. It automatically goes to the next line after printing the text to the console. To use WriteLine you will also need to have the line: \n using System; \n at the top of your file.";

        public static string READLINE_DESCRIPTION = "The ReadLine function allows you to get input from the user. The function will pause the program and wait for the user to input something and press enter. It will give you the input in the form of a string that you can print back out at them or you can use it to check what they want. For example, this program checks to see what you want to learn about and if you want to exit.";
        public static string READLINE_CREATION = "The ReadLine function is used as follows: \n string input = ConsoleReadLine(); \n In this example, I made a string called input to get back the return value from ReadLine which will be the input of the user. Now we can perform operations on the variable input. To use ReadLine you will also need to have the line: \n using System; \n at the top of your file.";

        public static string READKEY_DESCRIPTION = "The ReadKey function allows you to get the next keypress from the user. The function will pause the program and wait for the user to press a key. You can use this to pause the program to wait for the user to press any key to continue. Or you can use it to check for specific keypresses from the user. For example, in this program on multipage descriptions, this function is used to check for keypresses to change pages and go up a menu";
        public static string READKEY_CREATION = "The ReadKey function is used as follows: \n if(Console.ReadKey() == ConsoleKey.Enter) \n { \n //do some stuff \n } \n Obviously you would replace the comment of do some stuff with some actual programming. The above is simply checking to see if the user presses the Enter key. If the user pressed another key, the function would return and the if condition wouldn't trigger. To use ReadKey you will also need to have the line: \n using System; \n at the top of your file.";

        ////////////////////////////////////////////////////////////////////////////////
        // Advanced Topics

        public static string FUNCTIONS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string NAMESPACES_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string ARRAYS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string OBJECTS_DESCRIPTION = UNDER_CONSTRUCTION;

        public static string CLASSES_DESCRIPTION = UNDER_CONSTRUCTION;
    }

}