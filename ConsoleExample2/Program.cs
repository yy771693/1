using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExample2
{
    class Program
    {
        public static void Equals(int x,int y) {
            if (x == y)
                Console.WriteLine("两数相等！");
            else
                Console.WriteLine("两数不同！");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用此计算器！");
            Console.WriteLine("***进行加法运算请输入1***");
            Console.WriteLine("***进行减法运算请输入2***");
            Console.WriteLine("***进行乘法运算请输入3***");
            Console.WriteLine("***进行除法运算请输入4***");
            Console.WriteLine("请先依次输入所要计算的两个数，并选择对应的运算方法：");
            int x, y;
            int i = 0;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            i =Convert.ToInt32(Console.ReadLine());
            Equals(x, y);
            MyClass MC = new MyClass();
            try
            {
                if (i == 1)
                    MC.JiaFa(x, y);
                else if (i == 2)
                    MC.JianFa(x, y);
                else if (i == 3)
                    MC.ChengFa(x, y);
                else if (i == 4)
                    MC.ChuFa(x, y);
                else
                    Console.WriteLine("功能选择输入有误！");
            }
            catch
            {
                Console.WriteLine("分母不可为0！计算错误！");
            }
            finally {
                Console.WriteLine("计算结束！");
            }
            Console.ReadLine();

        }
    }
}
