using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.桥接模式
{
   public abstract class Coffee
    {
        protected MakeCoffee _makeCoffee;
       
        public MakeCoffee MakeCoffee
        {
            set
            {
                _makeCoffee = value;
            }
        }
        public virtual void Make()
        {
            _makeCoffee.Making();
        }
    }
}
