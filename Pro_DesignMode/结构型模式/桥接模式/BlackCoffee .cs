using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.桥接模式
{
    public class BlackCoffee : MakeCoffee
    {
        public  void Making()
        {
            Console.WriteLine("原味咖啡");
        }
    }
}
