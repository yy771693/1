using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExample2
{
    class MyClass
    {
        /// <summary>
        /// 定义加法运算
        /// </summary>
        /// <param name="x">加数</param>
        /// <param name="y">加数</param>
        /// <returns></returns>
        public int JiaFa(int x, int y) {
            int z;
            z = x + y;
            Console.WriteLine(z);
            return z;
        }
        /// <summary>
        /// 定义减法运算
        /// </summary>
        /// <param name="a">减数</param>
        /// <param name="b">被减数</param>
        /// <returns></returns>
        public int JianFa(int a, int b) {
            int c;
            c = a - b;
            Console.WriteLine(c);
            return c;
        }
        /// <summary>
        /// 定义乘法运算
        /// </summary>
        /// <param name="m">乘数</param>
        /// <param name="n">乘数</param>
        /// <returns></returns>
        public int ChengFa(int m, int n) {
            int p;
            p = m * n;
            Console.WriteLine(p);
            return p;
        }
        /// <summary>
        /// 定义除法运算
        /// </summary>
        /// <param name="h">被除数</param>
        /// <param name="k">除数</param>
        /// <returns></returns>
        public int ChuFa(int h, int k) {
            int j;
            j = h / k;
            Console.WriteLine(j);
            return j;
        }
    }
}
