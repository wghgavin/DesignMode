using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.装饰模式
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            AddBegavior();
        }
        //新增业务方法
        private void AddBegavior()
        {

        }
    }
}
