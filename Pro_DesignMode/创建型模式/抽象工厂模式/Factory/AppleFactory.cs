using Pro_DesignMode.创建型模式.抽象工厂模式.AbstractProduct;
using Pro_DesignMode.创建型模式.抽象工厂模式.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式.Factory
{
    public class AppleFactory : AbstractFactory
    {
        public override MotherBoard CreateMotherBoard()
        {
            return new AppleMotherBoard();
        }

        public override Screen CreateScreen()
        {
            return new AppleScreen();
        }
    }
}
