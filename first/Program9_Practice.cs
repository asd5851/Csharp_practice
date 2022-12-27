using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program9_Practice
    {
        /*
         * 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x,y,z)를 정의 할 것
         */
        /*
         * 화면에 "Hello"를 출력하는 SayHello() 함수를 작성
         * -int 타입 매개변수 바당서 그 횟수 만큼 Hello를 반복해서 출력
         */
        /*
        * 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것
        * -매개변수는 2개 타입은 double형
        * -리턴 타입도 double 형
        */
        /*
        * 주어진 숫자가 소수인지 여부를 찾는 함수 Prime() 작성
        * - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
        */
        
        static int find_Max(int []arr)
        {
            int max = arr[0];
           for(int i=0;i<arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
            
        }
        static void SayHello(int n)
        {
            for(int i=0; i < n; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        static double triangle(double x, double y)
        {
            return Math.Sqrt(x*x +y*y);
        }

        static void Prime()
        {
            Console.WriteLine("소수 : ");
            for(int i=2;i<=100; i++)
            {
                bool flag = false;
                for(int j=2;j<i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    Console.Write("{0}\n", i);
                }
                
            }
        }


        static void Main(string[] args)
        {
            Console.Write("3개의 정수를 입력하세요 : ");
            string find = Console.ReadLine();
            string[] find_m = find.Split(' ');
            int[] arr = new int[3] { 1, 2, 3 };
            int.TryParse(find_m[0], out arr[0]);
            int.TryParse(find_m[1], out arr[1]);
            int.TryParse(find_m[2], out arr[2]);
            int max = find_Max(arr);
            Console.WriteLine("제일 큰 수 : {0}", max);

            Console.Write("Hello를 출력할 횟수 : ");
            int.TryParse(Console.ReadLine(), out int hello_num);
            SayHello(hello_num);

            Console.Write("삼각형의 두개의 변의 길이를 입력하세요 : ");
            find = Console.ReadLine();
            string[] find_d = find.Split(' ');
            double.TryParse(find_d[0], out double tr_x);
            double.TryParse(find_d[1], out double tr_y);
            Console.WriteLine("빗변의 길이 : {0:F2}", triangle(tr_x, tr_y));

            Prime();

            Console.WriteLine("전화번호를 입력하세요 : ");
            string phone_num = Console.ReadLine();
            int cnt = 0;
            while (true)
            {
                

                if(cnt == 0)
                {
                    /*Do nothing*/
                }
                else
                {
                    phone_num = Console.ReadLine();
                }
                if (phone_num.Equals("quit"))
                {
                    break;
                }
                cellphone(phone_num);
                cnt++;

            }


        }

        static void cellphone(string phone_num)
        {
            for(int i=0;i<phone_num.Length; i++)
            {

                if (phone_num[i] == '(' || phone_num[i] == ')')
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}", phone_num[i]);
                }

            }
            Console.WriteLine();
        }
        /*
       * 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성
       * - 전화번호를 입력한다 -> 소괄호를 삭제한 형태로 출력한다.
       * - quit 입력하면 프로그램을 종료한다
       * - 프로그램 종료 전 까지 전화번호를 입력 받는다.
       */
    }
}
