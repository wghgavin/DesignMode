using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.桥接模式
{
   public  class MediumCupCoffee:Coffee
    {
        public override void Make()
        {
            MakeCoffee makeCoffee = this._makeCoffee;
            Console.Write("中杯");
            makeCoffee.Making();
        }
    }
}
