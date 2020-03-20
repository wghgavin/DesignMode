using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.装饰模式
{
    public class Decorator : Component
    {
        private Component component;
        public Decorator(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            component.Operation();
        }
    }
}
