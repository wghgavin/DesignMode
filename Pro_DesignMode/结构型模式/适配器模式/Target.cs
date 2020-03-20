using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.适配器模式
{
    //Target 类代表能够被客户端使用的接口
    public abstract class Target
    {
        public virtual void MyAdapter()
        {
            Console.WriteLine("苹果插头");
        }
    }
}
