using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.Write("태어난 달 입력: ");
            month = int.Parse(Console.ReadLine());
            switch (month % 12)
            {
                case 0:
                    Console.WriteLine("원숭이 띠");
                    break;
                case 1:
                    Console.WriteLine("닭 띠");
                    break;
                case 2:
                    Console.WriteLine("개 때");
                    break;
                case 3:
                    Console.WriteLine("돼지 띠");
                    break;
                case 4:
                    Console.WriteLine("쥐 띠");
                    break;
                case 5:
                    Console.WriteLine("소 띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이 띠");
                    break;
                case 7:
                    Console.WriteLine("토끼 띠");
                    break;
                case 8:
                    Console.WriteLine("용 띠");
                    break;
                case 9:
                    Console.WriteLine("뱀 띠");
                    break;
                case 10:
                    Console.WriteLine("말 띠");
                    break;
                case 11:
                    Console.WriteLine("양 띠");
                    break;
                default:
                    Console.WriteLine("???????");
                    break;
            }
        }
    }
}
