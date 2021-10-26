using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class Boss:Enemy
    {
        private float att;
        public Boss() { }
        public Boss( float att,float hp,float speed) : base(hp,speed) {
            this.att = att;
        }
        //调用父类的构造函数
        public void attack() {
            Console.WriteLine(att);
            Console.WriteLine(this.Hp);//this.当前类标识
            Console.WriteLine(base.Speed);//base.基类表示
            Console.WriteLine("正在攻击");
        }
        public override void Move()
        //可添加关键词sealed密封重写的方法，表示该方法不能被重写
        {
            Console.WriteLine("这是boss的move方法");
        }
    }
}
