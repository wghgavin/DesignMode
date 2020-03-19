using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pro_DesignMode.装饰模式;
namespace Pro_DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        #region 装饰模式调用
        private static void DecoratorModeTest()
        {
            Component component, component1, component2;
            component = new ConcreteComponent();
            component1 = new ConcreteDecorator(component);
            //二次装饰
            component2 = new ConcreteDecorator2(component1);
            component2.Operation();
        }
        #endregion
    }
}
