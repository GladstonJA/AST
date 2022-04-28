using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Command
{
    public class ItemDeMenu : Menu
    {
        public IMenuAction Action { get; set; }

        public override void Draw()
        {
        }

        public override void Executar()
        {
            Action?.Execute();
        }
    }
}
