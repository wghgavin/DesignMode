using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式
{
  public abstract class XiaoMiMotherBoard:MotherBoard
    {
        public override void Print()
        {
            Console.WriteLine("小米手机主板！");
        }
    }
}
