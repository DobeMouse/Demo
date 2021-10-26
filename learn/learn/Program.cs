using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Console.WriteLine("请输入第一个数字");
            //while (true)
            //{
            //    try
            //    {
            //        num1 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch {
            //        Console.WriteLine("输入错误请重新输入一个整数.");
            //    }
            //}
            //Console.WriteLine("请输入第二个数字");
            //while (true)
            //{
            //    try
            //    {
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch {
            //        Console.WriteLine("输入错误请重新输入一个整数.");
            //    }
            //}
            //Console.WriteLine("最终结果是：" + (num1 + num2));
            Enemy enemy1 = new Enemy();
            Enemy enemy2 = new Enemy(12.1f,33f);
            Console.WriteLine(enemy2.Hp);
            //使用构造函数进行声明赋值
            Boss boss = new Boss();
            boss.AI();
            //继承：父类里面所有数据成员和函数成员都会继承到子类里面
            Enemy enemy = new Boss();
            //父类声明的对象，可以用子方法进行构造。子类生命的对象不可以使用父类构造
            Boss boss1 = (Boss)enemy;
            //父类声明子类构造的对象，可以强制类型转换成子类类型
            boss.Move();
            //子类重写虚方法
            boss.AI();
            //当子类里面重写，不管在父类方法调用还是子类方法调用，都是调用重写后的方法
            
            Console.ReadLine();
        }
    }
}
