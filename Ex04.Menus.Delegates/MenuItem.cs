namespace Ex04.Menus.Delegates
{                    
     /// <summary>
     /// This class represents a menu item which is either a menu or an action item
     /// </summary>     
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
          public abstract void Excute();
                
          public string MenuItemTitle
          {
               get { return m_MenuTitle; }
          }
     }
}
