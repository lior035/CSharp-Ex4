namespace Ex04.Menus.Test
{
     using System.Globalization;
     using System;  
     using Ex04.Menus.Delegates;

     public class DataManagerDelegats
     {
          public const int k_LevelOfMainMenu = 0;
          private MainMenu m_DataManagerMainMenu;
        
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

          public DataManagerDelegats()
          {
               m_DataManagerMainMenu = generateSpecificMainMenuRequiredForEx04();
          }

          /// <summary>
          /// This method generates a main menu for data manager methods as requested in Ex04.
          /// The menu construction is done by creating actions and adding event handlers to each action.
          /// </summary>
          /// <returns></returns>
          private Delegates.MainMenu generateSpecificMainMenuRequiredForEx04()
          {
               MainMenu specificEx04Menu = new MainMenu("Main Menu");
               ActionItem actionToAdd = new ActionItem("Show Welcome");
               actionToAdd.ActionSelected += new ActionEventHandler(showWelcomeAction_Selected);
               specificEx04Menu.AddMenuItemToMenu(actionToAdd);
               specificEx04Menu.AddMenuItemToMenu(generateSpecificSubMenuRequiredForEx04());
               actionToAdd = new ActionItem("Show Version");
               actionToAdd.ActionSelected += new ActionEventHandler(showVersionAction_Selected);
               specificEx04Menu.AddMenuItemToMenu(actionToAdd);

               return specificEx04Menu;
          }

          /// <summary>
          /// Method completing the main menu generation
          /// </summary>
          /// <returns></returns>
          private SubMenu generateSpecificSubMenuRequiredForEx04()
          {
               SubMenu result = new SubMenu("Show Date/Time", k_LevelOfMainMenu);
               ActionItem actionToAdd = new ActionItem("Show Date");
               actionToAdd.ActionSelected += new ActionEventHandler(showDateAction_Selected);
               result.AddMenuItemToMenu(actionToAdd);
               actionToAdd = new ActionItem("Show Time");
               actionToAdd.ActionSelected += new ActionEventHandler(showTimeAction_Selected);
               result.AddMenuItemToMenu(actionToAdd);

               return result;
          }
              
          public void ShowMainMenu()
          {
               m_DataManagerMainMenu.Show();
          }

          public void showWelcomeAction_Selected()
          {
               ShowWelcome();
          }

          public void showVersionAction_Selected()
          {
               ShowVersion();
          }

          public void showDateAction_Selected()
          {
               ShowDate();
          }

          public void showTimeAction_Selected()
          {
               ShowTime();
          }
     }
}