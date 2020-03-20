using Pro_DesignMode.创建型模式.抽象工厂模式.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式.ConcreteProduct
{
    /// <summary>
    /// 小米手机屏幕
    /// </summary>
    public class XiaoMiScreen : Screen
    {
        public override void Print()
        {
            Console.WriteLine("小米手机屏幕！");
        }
    }
}
