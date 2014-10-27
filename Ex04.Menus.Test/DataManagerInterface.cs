namespace Ex04.Menus.Test
{
     using System;
     using System.Globalization;

     public class DataManagerInterface : Ex04.Menus.Interfaces.IPerformable
     {
          public const int k_LevelOfMainMenu = 0;
          private Ex04.Menus.Interfaces.MainMenu m_DataManagerMainMenu;

          public static void ShowWelcome()
          {
               System.Console.WriteLine("Please enter your name");
               System.Console.WriteLine("Hello {0}!{1}", System.Console.ReadLine(), Environment.NewLine);
          }

          public static void ShowDate()
          {               
               System.Console.WriteLine(DateTime.Now.ToString("d", CultureInfo.CurrentCulture));                              
          }

          public static void ShowTime()
          {               
               System.Console.WriteLine(DateTime.Now.ToString("t", CultureInfo.CurrentCulture));
          }

          public static void ShowVersion()
          {
               System.Console.WriteLine("The current version is: 14.1.4.0{0}", Environment.NewLine);
          }
          
          public DataManagerInterface()
          {
                 m_DataManagerMainMenu = generateSpecificMainMenuRequiredForEx04();                                                    
          }

          /// <summary>
          /// This method generates a main menu for data manager methods as requested in Ex04
          /// This construction is done by adding actions (each action gets title, Interface object and Method Name that represents which
          /// method to perform
          /// </summary>
          /// <returns></returns>
          private Interfaces.MainMenu generateSpecificMainMenuRequiredForEx04()
          {
               Ex04.Menus.Interfaces.MainMenu specificEx04Menu = new Ex04.Menus.Interfaces.MainMenu("Main Menu");

               specificEx04Menu.AddMenuItemToMenu(new Ex04.Menus.Interfaces.ActionItem("Show Welcome", this, "ShowWelcome"));
               specificEx04Menu.AddMenuItemToMenu(generateSpecificSubMenuRequiredForEx04());
               specificEx04Menu.AddMenuItemToMenu(new Ex04.Menus.Interfaces.ActionItem("Show Version", this, "ShowVersion"));

               return specificEx04Menu;
          }

          /// <summary>
          /// Method completing the main menu generation
          /// </summary>
          /// <returns></returns>
          private Ex04.Menus.Interfaces.SubMenu generateSpecificSubMenuRequiredForEx04()
          {
               Ex04.Menus.Interfaces.SubMenu result = new Ex04.Menus.Interfaces.SubMenu("Show Date/Time", k_LevelOfMainMenu);
               result.AddMenuItemToMenu(new Ex04.Menus.Interfaces.ActionItem("Show Date", this, "ShowDate"));
               result.AddMenuItemToMenu(new Ex04.Menus.Interfaces.ActionItem("Show Time", this, "ShowTime"));

               return result;
          }
          
          /// <summary>
          /// Interface's implementation executing the notifier specific method
          /// </summary>
          /// <param name="i_MethodNameToPerform"></param>
          public void PerformMenuMethodByName(string i_MethodNameToPerform)
          {
               switch (i_MethodNameToPerform)
               {
                    case "ShowWelcome":
                         ShowWelcome();
                         break;
                    case "ShowDate":
                         ShowDate();
                         break;
                    case "ShowTime":
                         ShowTime();
                         break;
                    case "ShowVersion":
                         ShowVersion();
                         break;
               }
          }

          public void ShowMainMenu()
          {
               m_DataManagerMainMenu.Show();
          }
     }
}