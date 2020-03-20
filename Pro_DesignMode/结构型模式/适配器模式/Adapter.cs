using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.适配器模式
{
    //适配器
    public class Adapter:Target
    {
        private Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public override void MyAdapter()
        {
            adaptee.AndroidAdapter();
        }
    }
}
