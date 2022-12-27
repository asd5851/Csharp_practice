using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program9
    {
        static int number1 = 1;
        static int number2 = 3;
        static void result(int first, int second)
        {
            if(first < second)
            {
                Console.WriteLine("큰 값 : {0}", second);
                Console.WriteLine("작은 값 : {0}", first);
            }
            else
            {
                Console.WriteLine("큰 값 : {0}", first);
                Console.WriteLine("작은 값 : {0}", second);
            }
            if(first < 0)
            {
                first = -first;
            }
            if(second < 0)
            {
                second = -second;
            }
            Console.WriteLine("절대 값 : {0} , {1}", first, second);
        }
        static int sum(int first, int second) { 
            return first + second;
        }
        static void Hello() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a * b);
        static void Main(string[] args)
        {
            //int.TryParse(Console.ReadLine(), out int first);
            //int.TryParse(Console.ReadLine(), out int second);

            //Console.Write("두수의 합 : ");
            //Console.WriteLine(sum(first, second));
            //result(first, second);
            //Multi();
            //Multi("반갑습니다.");
            //Multi("또만나요", 3);

            //Console.WriteLine("피보 : {0}", Factorial(5) );
            //int number1 = 10;
            //int number2 = 30;

            Swap(number1,number2);
            Console.WriteLine("바뀐 후의 값 : {0} {1}", number1, number2);

            Hello();
            Multiply(4, 5);

        }
        static void Swap(int intValue1, int intValue2)
        {
            Console.WriteLine("바뀌기 전의 값 : {0} {1}", intValue1, intValue2);

            int temp;
            temp = intValue1;
            intValue1= intValue2;
            intValue2= temp;

            Console.WriteLine("바뀐 후의 값 : {0} {1}", intValue1, intValue2);
        }
        static void FunctionOverLoading()
        {
            /*
             * 함수 오버로드 : 다중 정의
             * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러개를 정의할 수 있는데
             * 이를 함수 오버로드라고한다. 우리말로는 여러 번 정의한다는 뜻
             */
        }

        // 1. 숫자를 받아서 출력하는 함수
        /*
         * @param number int type number for print
         */
        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32: {number}");
            Console.WriteLine($"4바이트 정수: {number}");
        }
        static void GetNumber(long number)
        {
            Console.WriteLine($"Int64: {number}");
            Console.WriteLine($"8바이트 정수: {number}");
        }
        static void Multi()
        {
            Console.WriteLine("안녕하세요.");
        }
        static void Multi(string message) {
            Console.WriteLine(message);
        }
        static void Multi(string message, int count)
        {
            for(int i=0;i<count; i++)
            {
                Console.WriteLine("{0}", message);
            }
        }
        static void RecursionFunction()
        {
            /*
             * 재귀 함수
             * 함수에서 함수 자신을 호출하는 것을 재귀(Recursion) 또는 재귀 함수라고 한다.
             */
        }
        
        static int Factorial(int n)
        {
            
            if (n == 0 || n == 1) {
                return 1; 
            }
           
            return Factorial(n-1)+Factorial(n-2);
        }
        static void FunctionScope()
        {
            /*
             * 함수 범위 : 전역 변수와 지역 변수
             * 클래스와 같은 레벨에서 선언된 변수를 전역 변수(Global variable) 또는 필드(Field)라고 하며,
             * 함수 레벨에서 선언된 변수를 지역 변수(Local Variable)라고 한다.
             * 이때 동일한 이름으로 변수를 전역 변수와 함수내의 지역 변수로 선언할 수 있다.
             * 함수내에서는 범위에 있는 지역 변수를 사용하고, 함수 범위 내에 선언된 변수가 없으면
             * 전역 변수 내에 선언된 변수를 사용한다.
             * 단, C#에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 언더스코어(_) 또는
             * m_ 접두사를 붙이는 경향이 있다.
             */
        }

        static void ArrowFunction()
        {
            /*
             * 화살표 함수
             * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용하여 메서드 코드를 줄 일 수있다.
             * 이를 화살표 함수(Arrow Function)라고 한다. 프로그래밍에서 화살표 함수 또는
             * 메서드는 람다식(Lambda expression)의 또다른 이름이다.
             * 화살표 함수를 사용하면 함수를 줄여서 표현할 수있다. 함수 고유의 표현을 줄여서
             * 사용하면 처음에는 어색할 수 있다.
             * 하지만 이 방식에 익숙해지면 차후에는 코드의 간결함을 유지할 수 있다.
             */
        }

        
    }
}
