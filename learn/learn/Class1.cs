﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
	public class A
	{
		public virtual void Fun1(int i)
		{
			Console.WriteLine(i);
		}
		public void Fun2(A a)
		{
			a.Fun1(1);
			Fun1(5);
		}
	}
	public class B : A
	{
		public override void Fun1(int i)
		{
			base.Fun1(i + 1);
		}
	}
}
