using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    abstract class Brid//抽象类：不完整的模板，继承该类型时必须重写该类中的抽象方法
    {
        public abstract void Fly();
        //定义抽象方法，继承抽象类时必须重写（override）
        public void walk() {
            Console.Write("我在走路");
        }
        //抽象类中可以包含非抽象方法
    }
}
