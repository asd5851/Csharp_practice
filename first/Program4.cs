
// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와서 사용할 것이다.
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;


// 내 프로그램 이름
namespace first
{
    // 클래스 라는 것인데, C#에서는 모든 요소들이 클래스 안에 있어야 한다.
    internal class Program4
    {
        // 무조건 1개는 있어야 한다. -> C# 콘솔(검은 창, 터미널, 커맨드 창, 쉘 창)을 사용할 때
        int[] c = new int [101];

        
        static void Main(string[] args)
        {
            // 프로그램은 여기서부터 읽기 시작한다.

            /*
             * 별찍기
             */

            //string word = Console.ReadLine();
            //string[] text = word.Split(' ');
            //Console.Write("별 찍기 숫자 입력 : ");
            //int.TryParse(Console.ReadLine(), out int star_n);
            //for(int i=0; i<star_n; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("별 찍기 숫자 입력 : ");
            //int.TryParse(Console.ReadLine(), out int dia_n);

            //if (dia_n % 2 == 0)
            //{
            //    for (int i = 1; i <= dia_n / 2; i++)
            //    {
            //        for (int j = i; j <= dia_n / 2; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();

            //    }
            //    for (int i = 1; i <= dia_n / 2; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = dia_n / 2; j >= i; j--)
            //        {
            //            Console.Write("*");
            //        }
            //        for (int j = dia_n / 2; j >= i; j--)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();

            //    }
            //    Console.WriteLine();
            //}

            //else
            //{

            //    for (int i = 1; i < dia_n / 2 + 1; i++)
            //    {
            //        for (int j = i; j <= dia_n / 2 + 1; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        for (int j = 1; j < i; j++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();

            //    }
            //    for (int i = 1; i <= dia_n / 2 + 1; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int j = dia_n / 2; j >= i; j--)
            //        {
            //            Console.Write("*");
            //        }
            //        for (int j = dia_n / 2 + 1; j >= i; j--)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();

            //    }
            //    Console.WriteLine();
            //}

            /*
             * 야구게임
             */

            //int one=1, two=2, three=3;

            //while(true)
            //{

            //    Random random = new Random();
            //    one = random.Next(1, 10);
            //    two = random.Next(1, 10);
            //    three= random.Next(1, 10);
            //    if(one != two && two !=three && three!=one) {
            //        break;
            //    }
            //}
            //Console.WriteLine("{0} {1} {2}", one, two, three);
            //for(int i=1;i<=9; i++)
            //{
            //    int strike = 0;
            //    int ball = 0;
            //    int outt = 0;
            //    Console.Write("{0} 번째 시도 -> 숫자 세개를 입력하시오 : ", i);
            //    string text = Console.ReadLine();
            //    string[] text_tmp = text.Split(' ');
            //    int.TryParse(text_tmp[0], out int first);
            //    int.TryParse(text_tmp[1], out int second);

            //    int.TryParse(text_tmp[2], out int third);


            //    if (first == one)
            //    {
            //        strike++;
            //    }
            //    else if(first == two)
            //    {
            //        ball++;
            //    }
            //    else if(first == three)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        outt++;
            //    }

            //    if (second == two)
            //    {
            //        strike++;
            //    }
            //    else if (second == one)
            //    {
            //        ball++;
            //    }
            //    else if (second == three)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        outt++;
            //    }

            //    if (third == three)
            //    {
            //        strike++;
            //    }
            //    else if (third == one)
            //    {
            //        ball++;
            //    }
            //    else if (third == two)
            //    {
            //        ball++;
            //    }
            //    else
            //    {
            //        outt++;
            //    }



            //    Console.WriteLine("{0}[S] {1}[B] {2}[O]", strike, ball, outt);
            //    if (strike == 3)
            //    {
            //        Console.WriteLine("이겼습니다.");
            //        break;
            //    }

            //    if (i == 9)
            //    {
            //        Console.WriteLine("아쉽지만 끝나셨어용 ^^ ");
            //        break;
            //    }
            //}

            //프로그램은 여기서 끝난다.
            int[] numbers = new int[5] {1, 2, 3, 4, 5 };
            for(int i=0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            foreach(int element in numbers) // numbers라는 배열에서 0부터 length까지 element에 저장한다.
            {
                Console.WriteLine(element);
            }
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            
            Console.WriteLine(number1);


        }
    }
}

/*
 * 정렬 CTRL + K + F
 * 주석 CTRL + K + C
 * 주석 해제 CTRL + K + U
 * 
 * int variable_ = 100; 
 * bool isRealMultipleOfThree = (variable_%3==0); <= 참 거짓을 bool 설정하여 가독성 늘리기
 * if(isRealMultipleOfThree){
 * 
 * } // 이런식으로 코딩하기!
 * 
 * loop 에러는 loop 밖에서 해결하고 안으로 집어넣는 방식으로 생각해보자!
 * 
 * 컬렉션
 * 이름 하나로 데이터 여러개를 담을 수 있는 자료 구조를 Collection 또는 Container 라고 한다.
 * C#에서 다루는 Collection은 array, list, dictionary 등이 있다.
 * 
 * Array
 * Array는 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다.
 * 각각의 데이터들은 인덱스를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서
 * 관리할 수 있다.
 * 
 * 배열의 특징
 * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
 * 2. 배열은 메모리에 연속된 공간을 미리 할당하고 이를 대괄호[]와 0부터 시작하는 정수형 인덱스를 사용하여
 * 접근할 수 있다.
 * 3. 배열을 선언할 때는 new 키워드로 생성한 후 사용할 수 있다.
 * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
 * 5. 필요한 데이터 갯수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.
 * 
 * 배열에는 3가지 종류가 있다.
 * 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
 * 다차원 배열 : 첨자 2개 이상을 사용하는 배열 (2차원, 3차원..)
 * 가변(Jagged) 배열 : '배열의 배열' 이라고도 하며, 이름 하나로 다양한 자원의 배열을 표현할 때 쓴다.
 * 
 */

