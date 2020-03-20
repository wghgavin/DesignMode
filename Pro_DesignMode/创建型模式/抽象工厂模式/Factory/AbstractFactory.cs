using Pro_DesignMode.创建型模式.抽象工厂模式.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式.Factory
{
    public abstract class AbstractFactory
    {
        //工厂生产屏幕
        public abstract Screen CreateScreen();
        //工厂生产主板
        public abstract MotherBoard CreateMotherBoard();
    }
}
