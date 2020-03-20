using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.适配器模式
{
    //客户端识别不了的适配器
    public  class Adaptee
    {
        public  void AndroidAdapter()
        {
            Console.WriteLine("适配安卓的插头");
        }
    }
}
