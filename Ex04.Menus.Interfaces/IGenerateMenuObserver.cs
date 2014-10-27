namespace Ex04.Menus.Test
{
     using System;
     using System.Collections.Generic;
     using System.Text;
     using System.Reflection;

     public interface IGenerateMenuObserver
     {
          void GenerateMenu(object i_ClassToGenerateMenuTo);
     }
}
