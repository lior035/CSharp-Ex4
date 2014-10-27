namespace Ex04.Menus.Interfaces
{
     using System;
     using System.Collections.Generic;
     
     /// <summary>
     /// This class represents a menu consisting of menu items which will hold actions or menus.
     /// Menu can be instantiated as MainMenu Or Submenu
     /// </summary>
     public abstract class Menu : MenuItem
     {
          protected const int k_IndexOfExitOrBackInMenu = 0;
          // $G$ DSN-999 (-3) This List should be readonly.     
          protected List<MenuItem> m_MenuOptionArray;
          protected int m_MenuLevel;

          protected Menu(string i_MenuTitle, int i_CurrentMenuLevel) : base(i_MenuTitle)
          {
               m_MenuLevel = i_CurrentMenuLevel;
               m_MenuOptionArray = new List<MenuItem>();
          }
          
          /// <summary>
          /// This method gets a menuItem and adds it to the menu's ltems list
          /// </summary>
          /// <param name="i_MenuItem"></param>
          public void AddMenuItemToMenu(MenuItem i_MenuItem)
          {
               m_MenuOptionArray.Add(i_MenuItem);
          }
         
          /// <summary>
          /// This method is menu's main function.  It shows all menu options then gets valid input option to perform -
          /// goes to submenu or performs action.  this is repeated until exit or back is selected.
          /// </summary>
          public void Show()
          {
               showMenuOptions();
               getMenuSelectionAndPerformUntilExitOrBack();                              
          }

          private void getMenuSelectionAndPerformUntilExitOrBack()
          {
               int optionSelection;
               
               do
               {
                    optionSelection = ConsoleUtilityFunctions.getValidMenuOptionFromRange(this.m_MenuOptionArray.Count);
                    if (optionSelection == k_IndexOfExitOrBackInMenu)
                    {
                         System.Console.Clear();
                         break;
                    }
                    else
                    {
                         System.Console.WriteLine();
                         System.Console.Clear();
                         // $G$ SFN-999 (-7) Screen should be cleared before/after executing an action.
                         m_MenuOptionArray[optionSelection - 1].Excute();
                         showMenuOptions();
                    }
               }
               while (true);
          }

          private void showMenuOptions()
          {        
               System.Console.WriteLine("Interface implementation version");               
               System.Console.WriteLine("Menu Level: {0}", m_MenuLevel);
               System.Console.WriteLine("{0}{1}", m_MenuTitle, Environment.NewLine);
               // $G$ DSN-008 (-5) You should have used polymorphism to implement the different behavior between a sub menu and the main menu.
               if (this is MainMenu)
               {
                    System.Console.WriteLine("0.Exit");
               }
               else if (this is SubMenu)
               {
                    System.Console.WriteLine("0.Back");
               }

               int foreachCtr = 1;
               
               foreach (MenuItem optionInMenu in m_MenuOptionArray)
               {
                    System.Console.WriteLine("{0}.{1}", foreachCtr, optionInMenu.MenuItemTitle);
                    foreachCtr++;
               }

               System.Console.WriteLine();
          }
          
          /// <summary>
          /// method done when a menu is selected
          /// </summary>
          public override void Excute()
          {
               Show();
          }                                
     }
}
