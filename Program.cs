// Decompiled with JetBrains decompiler
// Type: CS.Program
// Assembly: CS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE15C00B-E04E-4529-972E-A3D318F4B228
// Assembly location: C:\Users\Daniel\Downloads\CS.exe

using System;

namespace CS
{
    internal class Program
    {
        private static void Main()
        {
            string read = ""; // general string to store input from the user
            bool exit = false; // boolean that controls the main loop of the program
            bool innerMenuExit = false; // boolean that controls any inner loops of the program

            while (exit != true)
            {
                // chunk of text displayed to user when accessing the main menu
                consoleWrapper.Clear();
                consoleWrapper.WriteLine(ProjectLiterals.HOW_TO_EXIT);
                consoleWrapper.WriteLine(ProjectLiterals.DIVIDER);
                consoleWrapper.WriteLine(ProjectLiterals.WHAT_TO_LEARN);
                consoleWrapper.WriteLine();
                consoleWrapper.printOptions(ProjectLiterals.Topics); // display the main topics to learn from
                consoleWrapper.WriteLine(ProjectLiterals.RECOMMENDATION);
                consoleWrapper.WriteLine();

                read = consoleWrapper.ReadCommand(); // wait for user to input a command
                if (read == "DATATYPES" || read == "DTYPES") // DATA TYPES OPTIONS
                {
                    innerMenuExit = false; // the user has not yet wanted to exit the menu
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_DATA_TYPE);
                        consoleWrapper.printOptions(ProjectLiterals.DataTypes); // list all data types defined in the project literals file
                        read = consoleWrapper.ReadCommand();
                        switch (read)
                        {
                            case "INTS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.INT_DESCRIPTION, ProjectLiterals.INT_CREATION);
                                break;
                            case "DOUBLES":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.DOUBLES_DESCRIPTION, ProjectLiterals.DOUBLES_CREATION);
                                break;
                            case "STRINGS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.STRING_DESCRIPTION, ProjectLiterals.STRING_CREATION);
                                break;
                            case "BOOLS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.BOOLEAN_DESCRIPTION, ProjectLiterals.BOOLEAN_CREATION);
                                break;
                            case "CHARS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.CHAR_DESCRIPTION, ProjectLiterals.CHAR_CREATION);
                                break;
                            case "FLOATS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.FLOAT_DESCRIPTION, ProjectLiterals.FLOAT_CREATION);
                                break;
                            case "DECIMALS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.DECIMAL_DESCRIPTION, ProjectLiterals.DECIMAL_CREATION);
                                break;
                            case "LONGS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.LONG_DESCRIPTION, ProjectLiterals.LONG_CREATION);
                                break;
                            case "UNSIGNED":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.UNSIGNED_DESCRIPTION, ProjectLiterals.UNSIGNED_CREATION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT": // stack cases without breaks and it functions as an OR in a conditional statement
                            case "CLOSE": // these are here so the user can exit within any sub menu
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "BRANCHINGTYPES")
                {
                    innerMenuExit = false;
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_BRANCHING_TYPE);
                        consoleWrapper.printOptions(ProjectLiterals.BranchingTypes);
                        read = consoleWrapper.ReadCommand();

                        switch (read)
                        {
                            case "IF":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.IF_DESCRIPTION, ProjectLiterals.IF_CREATION);
                                break;
                            case "ELSE-IF":
                            case "ELSEIF":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.ELSEIF_DESCRIPTION, ProjectLiterals.ELSEIF_CREATION);
                                break;
                            case "SWITCH":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.SWITCH_DESCRIPTION, ProjectLiterals.SWITCH_CREATION);
                                break;
                            case "COMMENTS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.COMMENTS_DESCRIPTION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT":
                            case "CLOSE":
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "LOOPTYPES")
                {
                    innerMenuExit = false;
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_LOOP_TYPE);
                        consoleWrapper.printOptions(ProjectLiterals.LoopTypes);
                        read = consoleWrapper.ReadCommand();
                        switch (read)
                        {
                            case "WHILE":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.WHILE_DESCRIPTION, ProjectLiterals.WHILE_CREATION);
                                break;
                            case "DOWHILE":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.DO_WHILE_DESCRIPTION, ProjectLiterals.DO_WHILE_CREATION);
                                break;
                            case "FOR":
                                // create a new instance of an array of string arrays
                                string[][] pages = new string[3][];
                                // set the instances of each page to new string arrays of the page descriptions
                                pages[0] = new string[] { ProjectLiterals.FOR_DESCRIPTION, ProjectLiterals.FOR_CREATION, ProjectLiterals.TRY_IT };
                                pages[1] = new string[] { ProjectLiterals.FOR_PAGE_2 };
                                pages[2] = new string[] { ProjectLiterals.FOR_PAGE_3 };
                                // Send it to the multipage handler with starting page 0, and the angle brackets as forward and back keys
                                consoleWrapper.MultipageHandler(pages, 0, ConsoleKey.OemComma, ConsoleKey.OemPeriod);
                                break;
                            case "FOREACH":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.FOREACH_DESCRIPTION, ProjectLiterals.FOREACH_CREATION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT":
                            case "CLOSE":
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "FORMATTING")
                {
                    innerMenuExit = false;
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_FORMATTING);
                        consoleWrapper.printOptions(ProjectLiterals.Formatting);
                        read = consoleWrapper.ReadCommand();

                        switch (read)
                        {
                            case "SEMICOLONS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.SEMICOLON_DESCRIPTION, ProjectLiterals.SEMICOLON_BLOCKS);
                                break;
                            case "BRACKETS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.BRACKETS_DESCRIPTION);
                                break;
                            case "TABS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.TABS_DESCRIPTION);
                                break;
                            case "KEYWORDS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.KEYWORDS_DESCRIPTION);
                                break;
                            case "COMMENTS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.COMMENTS_DESCRIPTION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT":
                            case "CLOSE":
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "USEFULFUNCTIONS")
                {
                    innerMenuExit = false;
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_FUNCTIONS);
                        consoleWrapper.printOptions(ProjectLiterals.UsefulFunctions);
                        read = consoleWrapper.ReadCommand();

                        switch (read)
                        {
                            case "WRITELINE":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.WRITELINE_DESCRIPTION, ProjectLiterals.WRITELINE_CREATION);
                                break;
                            case "READLINE":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.READLINE_DESCRIPTION, ProjectLiterals.READLINE_CREATION);
                                break;
                            case "READKEY":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.READKEY_DESCRIPTION, ProjectLiterals.READKEY_CREATION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT":
                            case "CLOSE":
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "ADVANCEDTOPICS")
                {
                    innerMenuExit = false;
                    while (innerMenuExit != true)
                    {
                        consoleWrapper.Clear();
                        consoleWrapper.WriteLine(ProjectLiterals.RETURN);
                        consoleWrapper.WriteLine(ProjectLiterals.WHAT_ADVANCED);
                        consoleWrapper.printOptions(ProjectLiterals.AdvancedTopics);
                        read = consoleWrapper.ReadCommand();

                        switch (read)
                        {
                            case "FUNCTIONS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.FUNCTIONS_DESCRIPTION);
                                break;
                            case "NAMESPACES":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.NAMESPACES_DESCRIPTION);
                                break;
                            case "ARRAYS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.ARRAYS_DESCRIPTION);
                                break;
                            case "OBJECTS":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.OBJECTS_DESCRIPTION);
                                break;
                            case "CLASSES":
                                consoleWrapper.PrintDescriptionBlockAndWait(ProjectLiterals.CLASSES_DESCRIPTION);
                                break;
                            case "RETURN":
                                innerMenuExit = true;
                                break;
                            case "EXIT":
                            case "CLOSE":
                                innerMenuExit = true;
                                exit = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (read == "CLOSE" || read == "EXIT")
                {
                    exit = true;
                }
                else
                {
                    consoleWrapper.WriteLine(ProjectLiterals.INVALID_COMMAND); // currently useless as the top of the loop clears the console. Could fix later

                }
            }
        }
    }
}