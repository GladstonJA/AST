using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SubMenu : Menu
    {
        private List<Menu> _subMenus = new List<Menu>();

        public override void Draw()
        {
        }

        public override void Add(Menu menu) { }

        public override void Remove(Menu menu) { }

        public override Menu GetChild(int menu)
        {
            return null;
        }

        public override void Executar()
        {
            // Desenha os submenus
            foreach (Menu menu in _subMenus)
                menu.Draw();
        }
    }
}
