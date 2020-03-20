using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.创建型模式.抽象工厂模式
{
    /// <summary>
    /// 抽象工厂类：提供创建不同品牌的手机屏幕和手机主板
    /// /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Screen CreateScreen();
        public abstract MotherBoard CreateMotherBoard();
    }
}
