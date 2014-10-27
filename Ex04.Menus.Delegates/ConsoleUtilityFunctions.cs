namespace Ex04.Menus.Delegates
{
     using System;
     using System.Text;

     /// <summary>
     /// This class holds useful console methods
     /// </summary>
     public class ConsoleUtilityFunctions
     {
          public static string SpaceEnumString(string currentEnumString)
          {
               StringBuilder spacedEnumString = new StringBuilder();

               spacedEnumString.Append(currentEnumString[0]);
               foreach (char currentCharInEnumString in currentEnumString.Substring(1))
               {
                    if (char.IsUpper(currentCharInEnumString))
                    {
                         spacedEnumString.Append(' ').Append(char.ToLower(currentCharInEnumString));
                    }
                    else
                    {
                         spacedEnumString.Append(currentCharInEnumString);
                    }
               }

               return spacedEnumString.ToString();
          }
          
          private static int auxGetGeneralMenuUserSelection(int i_NumberOfOptions)
          {
               int userMenuSelection;

               do
               {
                    try
                    {
                         if (!int.TryParse(System.Console.ReadLine(), out userMenuSelection))
                         {
                              throw new FormatException(string.Format("Exception: input was not a legal integer, please enter an integer between 1-{0}" + Environment.NewLine, i_NumberOfOptions));
                         }

                         if (userMenuSelection < 1 || userMenuSelection > i_NumberOfOptions)
                         {
                              System.Console.WriteLine("Illegal input, please enter a number between 1-{0}" + Environment.NewLine, i_NumberOfOptions);
                         }
                         else
                         {
                              break;
                         }
                    }
                    catch (FormatException fe)
                    {
                         System.Console.WriteLine(fe.Message);
                    }
               }
               while (true);

               System.Console.WriteLine();

               return userMenuSelection;
          }
          
          private static void auxShowEnumOptions(Type i_EnumType)
          {
               string[] enumNames = Enum.GetNames(i_EnumType);
               string enumToSpacedString;
               int enumValueRange = enumNames.Length;
               System.Console.WriteLine("Please choose an option from 1-{0}" + Environment.NewLine, enumValueRange);
               int foreachCtr = 1;
               foreach (string currentEnumString in enumNames)
               {
                    enumToSpacedString = SpaceEnumString(currentEnumString);
                    System.Console.WriteLine("{0}. {1}", foreachCtr, enumToSpacedString);
                    foreachCtr++;
               }

               System.Console.WriteLine();
          }
              
          public static string getEnumStringFromEnumValues(Type i_EnumType)
          {
               string stringEnumSelection;
               int intEnumValueSelection;
               auxShowEnumOptions(i_EnumType);
               intEnumValueSelection = auxGetGeneralMenuUserSelection(Enum.GetNames(i_EnumType).Length);
               string[] enumNames = Enum.GetNames(i_EnumType);
               stringEnumSelection = enumNames[intEnumValueSelection - 1];
               return stringEnumSelection;
          }
          
          public static int GetPositiveValidInt()
          {
               int positiveIntValueToGenerate;
               do
               {
                    try
                    {
                         if (!int.TryParse(System.Console.ReadLine(), out positiveIntValueToGenerate))
                         {
                              throw new FormatException("Exception: expecting a legal integer");
                         }

                         if (positiveIntValueToGenerate < 0)
                         {
                              System.Console.WriteLine("Please insert a positive integer");
                         }

                         if (positiveIntValueToGenerate >= 0)
                         {
                              break;
                         }                    
                    }
                    catch (Exception fe)
                    {
                         System.Console.WriteLine(fe.Message);
                    }
               }
               while (true);

               return positiveIntValueToGenerate;
          }

          public static int getValidMenuOptionFromRange(int i_NumberOfOptions)
          {
               int optionNumber;

               System.Console.WriteLine("please choose method to add from the following 1-{0}", i_NumberOfOptions);
               do
               {
                    optionNumber = GetPositiveValidInt();
                    if (optionNumber <= i_NumberOfOptions)
                    {
                         break;
                    }
                    else
                    {
                         System.Console.WriteLine("Please insert an option between 1-{0}", i_NumberOfOptions);
                    }
               }
               while (true);

               return optionNumber;
          }
     }
}
