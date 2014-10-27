namespace Ex04.Menus.Test
{
     using System;

     public class Program
     {
          public static void Main()
          {
               DataManagerInterface dataManagerWithInterfaceMenuImplementation = new DataManagerInterface();
               DataManagerDelegats dataManagerWithDelegateMenuImplementation = new DataManagerDelegats();

               dataManagerWithInterfaceMenuImplementation.ShowMainMenu();
               dataManagerWithDelegateMenuImplementation.ShowMainMenu();
               System.Console.WriteLine("Thanks for using the menus!");
               System.Console.WriteLine("Press any key to Exit...");
               System.Console.ReadLine();
          }
     }
}
