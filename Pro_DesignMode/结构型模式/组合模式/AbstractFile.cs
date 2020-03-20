using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_DesignMode.结构型模式.组合模式
{
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile file);//新增文件
        public abstract void Delete(AbstractFile file);//删除文件
        public abstract AbstractFile GetChildFile(int i);//获取子构件（可以是文件，也可以是文件夹）
        public abstract void KillVirue();//对文件进行杀毒
    }
}
