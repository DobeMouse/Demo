using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class Enemy
    // sealed密封类无法被继承
    {
        private float hp;
        private float speed;
        //定义变量，在类中称为字段
        public float Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        //属性：用于对字段的赋值，增加安全性，可添加一些限制，如：只读，只写，数据有效性
        public float Speed {
            get { return speed; }
            set { speed = value; }
        }
        public Enemy() { }//无参构造函数
        /// <summary>
        /// Enemy构造函数给字段（属性）在声明时赋值
        /// </summary>
        /// <param name="hp">血量</param>
        /// <param name="speed">速度</param>
        public Enemy(float hp, float speed) {
            Hp = hp;
            Speed = speed;
        }
        public void AI()
        {
            
            Console.WriteLine("这里是Enemy1的公有ai方法");
        }
        //方法，可以被继承
        public virtual void Move() {
            Console.WriteLine("这里是Enemy1的公有move方法");
        }
        //虚方法（virtual）：可以在子类里使用override进行重写
        
    }
}
