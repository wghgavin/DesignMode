using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.建造者模式
{
   public class Director
    {
        public static Product Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            return builder.GetResult();
        }
    }
}
