namespace Ex04.Menus.Interfaces
{
     public class ActionItem : MenuItem
     {
          private string m_MethodNameToPeform;
          private IPerformable m_ObjectWithMenu;

          /// <summary>
          /// 
          /// </summary>
          /// <param name="i_MenuTitle"></param>
          /// <param name="i_Performable">IPerformable object that will listen to action notification</param>
          /// <param name="i_MethodNameToPeform">represent the method to perform</param>
          public ActionItem(string i_MenuTitle, object i_Performable, string i_MethodNameToPeform) : base(i_MenuTitle)
          {
               m_MethodNameToPeform = i_MethodNameToPeform;
               m_ObjectWithMenu = i_Performable as IPerformable;
          }

          /// <summary>
          /// Notifies the interface action was selected
          /// </summary>
          public override void Excute()
          {
               m_ObjectWithMenu.PerformMenuMethodByName(m_MethodNameToPeform);               
          }
     }
}
