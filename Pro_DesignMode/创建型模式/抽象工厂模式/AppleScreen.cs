using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式
{
   public class AppleScreen:Screen
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机屏幕！");
        }
    }
}
