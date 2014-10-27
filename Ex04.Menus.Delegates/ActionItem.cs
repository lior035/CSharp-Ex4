namespace Ex04.Menus.Delegates
{
     public delegate void ActionEventHandler();
     
     public class ActionItem : MenuItem
     {          
          public event ActionEventHandler ActionSelected;

          public ActionItem(string i_MenuTitle) : base(i_MenuTitle)
          {
          }

          public override void Excute()
          {
               OnActionSelcted();
          }
          
          /// <summary>
          /// Invokes all listeners of action
          /// </summary>
          protected virtual void OnActionSelcted()
          {
               if (ActionSelected != null)
               {
                    ActionSelected.Invoke();
               }
          }          
     }
}
