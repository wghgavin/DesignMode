using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.装饰模式
{
   public class ConcreteComponent:Component
    {
        public override void Operation()
        {
            Console.WriteLine("我是具体组件");
        }
    }
}
