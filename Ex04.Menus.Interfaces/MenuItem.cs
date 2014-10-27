namespace Ex04.Menus.Interfaces
{                    
     /// <summary>
     /// This class represents a menu item which is either a menu or an action item
     /// </summary>     
    // $G$ DSN-999 (0) Abstract classes constructors should always be protected.
     public abstract class MenuItem
     {
          protected string m_MenuTitle;

          public MenuItem(string i_MenuTitle)
          {
               m_MenuTitle = i_MenuTitle;
          }

          /// <summary>
          /// This method is performed when menu item is seleceted
          /// </summary>
          // $G$ DSN-008 (-3) This method should not have been made public.
          public abstract void Excute();
                
          public string MenuItemTitle
          {
               get { return m_MenuTitle; }
          }
     }
}
