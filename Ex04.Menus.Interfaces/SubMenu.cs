namespace Ex04.Menus.Interfaces
{
     public class SubMenu : Menu
     {                              
          public SubMenu(string i_MenuTitle, int i_LevelOfPreviousMenu) : base(i_MenuTitle, i_LevelOfPreviousMenu + 1)
          {
          }       
     }
}
