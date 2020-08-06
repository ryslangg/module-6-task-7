using System;
using System.Collections.Generic;
using System.Text;
using Module_6_Task_7.Entities;
using Module_6_Task_7.UI;

namespace Module_6_Task_7.MenuElements
{
    public class Exit : ElementMenu
    {
        public Exit()
        {
            Title = "Exit";
            Description = "Turn off program";
            Key = '3';
        }

        public override void Do(ref Storage storage, Menu menu)
        {
            menu.Active = false;
        }
    }
}
