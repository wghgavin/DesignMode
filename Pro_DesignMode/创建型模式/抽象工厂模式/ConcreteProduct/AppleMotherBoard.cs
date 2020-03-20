using Pro_DesignMode.创建型模式.抽象工厂模式.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式.ConcreteProduct
{
    public class AppleMotherBoard : MotherBoard
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机主板！");
        }
    }
}
