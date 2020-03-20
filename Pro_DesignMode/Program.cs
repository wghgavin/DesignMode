using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pro_DesignMode.结构型模式.装饰模式;
using Pro_DesignMode.结构型模式.组合模式;
using Pro_DesignMode.结构型模式.桥接模式;
using Pro_DesignMode.结构型模式.适配器模式;
namespace Pro_DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterModeTest();
        }
        #region 装饰模式调用
        private static void DecoratorModeTest()
        {
            Component component, component1, component2;
            component = new ConcreteComponent();
            component1 = new ConcreteDecorator(component);
            //二次装饰
            component2 = new ConcreteDecorator2(component1);
            component2.Operation();
        }
        #endregion
        #region 组合模式调用
        private static void CompositeModeTest()
        {
            AbstractFile folder1 = new Folder("文件夹1");
            AbstractFile folder2 = new Folder("文件夹2");
            AbstractFile fileImg1 = new ImageFile("图片文件1");
            AbstractFile fileTxt1 = new TextFile("文本文件1");
            folder2.Add(fileImg1);
            folder2.Add(fileTxt1);
            folder1.Add(folder2);
            folder1.KillVirue();
            Console.ReadKey();
        }
        #endregion
        #region 桥接模式调用
        private static void BridgeModeTest()
        {
            MakeCoffee make = new BlackCoffee();
            Coffee blackmidCoffe = new MediumCupCoffee();
            blackmidCoffe.MakeCoffee = make;
            blackmidCoffe.Make();
            Console.ReadKey();
        }
        #endregion
        #region 适配器模式调用
        private static void AdapterModeTest()
        {
            Target target = new Adapter(new Adaptee());
            target.MyAdapter();
            Console.ReadKey();
        }
        #endregion
    }
}
