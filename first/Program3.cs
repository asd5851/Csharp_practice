﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace first
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            /*
             * 선택문인 switch문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용
             * switch, case, default 키워드사용 -> 조건처리
             * 
             * 1. case절에서 break문을 생략하면 어떻게 되느냐?
             * 
             * goto 문은 쓰지 않는것을 추천
             */

            //Console.WriteLine("정수 1, 2, 3중에 하나를 입력하시오 : ");
            //int switchnumber = 0;
            //int.TryParse(Console.ReadLine(), out switchnumber);
            //switch(switchnumber)
            //{
            //    case 1 : Console.WriteLine("1 입력");
            //        break;
            //    case 2 : Console.WriteLine("2 입력");
            //        break;
            //    case 3: Console.WriteLine("3 입력");
            //        break;
            //    default: Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;

            //}// switch

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.WriteLine("1.C \t 2.C++ \t 3.C# \t 4.JAVA \t");
            //int choice = default;
            //int.TryParse(Console.ReadLine(),out choice);

            //switch(choice) // dy. kive  / 22.12.20
            //{
            //    case 1 : Console.WriteLine("C");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++");
            //        break;
            //    case 3:
            //        Console.WriteLine("C#");
            //        break;
            //    case 4:
            //        Console.WriteLine("JAVA");
            //        break;
            //    default: Console.WriteLine("처리하지않는 예외 입력");
            //        break;
            //} // switch

            //Console.WriteLine("오늘의 날씨는 어떤가요?");
            //string weather = Console.ReadLine();

            //switch (weather)
            //{
            //    case "맑음": Console.WriteLine("맑아요");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("흐려용");
            //        break;
            //    case "비":
            //        Console.WriteLine("비와용");
            //        break;
            //    case "눈":
            //        Console.WriteLine("눈와ㅕㅛ");
            //        break;
            //}

            ///*
            // * while 문은 조건식이 참일 동안 문장을 반복 실행한다.
            // */
            //int loopcounter = 0;
            //while(loopcounter < 5)
            //{
            //    loopcounter++;
            //    Console.WriteLine("{0} LOOPCOUNTER", loopcounter);
            //}

            //int baam = 10;
            //while(baam > 0)
            //{

            //    Console.WriteLine("{0}",baam);
            //    baam--;
            //}

            //Console.Write("숫자를 입력 하세요 : ");
            //int mul = default;
            //int.TryParse(Console.ReadLine(), out mul);
            //int i = 1;
            //const int gugu_count = 10;
            //while(i < gugu_count)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", mul, i, mul * i);
            //    i++;

            //}

            //Console.Write("양의 정수를 입력하세요 : ");
            //int hello_count = default;
            //int.TryParse(Console.ReadLine(), out hello_count);
            //int i = 0;
            //if(hello_count < 0)
            //{
            //    Console.WriteLine("잘못입력하셨습니다.");
            //}
            //else
            //{
            //    while (i < hello_count)
            //    {
            //        Console.WriteLine("\tHello world!");
            //        i++;
            //    }
            //}
            //Console.WriteLine("=====================================");

            //i = 1;
            //Console.Write("양의 정수를 입력하세요 : ");
            //int thmulti = 0;
            //int.TryParse(Console.ReadLine(), out thmulti);
            //if (thmulti < 0)
            //{
            //    Console.WriteLine("잘못입력하셨습니다.");
            //}
            //else
            //{

            //    while (i <= thmulti)
            //    {
            //        Console.Write("{0} ", i * 3);
            //        i++;
            //    }
            //    Console.WriteLine("");
            //    Console.WriteLine("=====================================");
            //}

            //int input_num = 1;
            //int sum = 0;
            //while(input_num != 0)
            //{
            //    Console.Write("user input : ");
            //    int.TryParse(Console.ReadLine(),out input_num);
            //    sum = sum+ input_num;
            //}
            //Console.WriteLine("모든정수의 합 : {0}", sum);
            //Console.WriteLine("=====================================");


            //int reverse_multi;
            //Console.Write("User input -> ");
            //int.TryParse(Console.ReadLine(),out reverse_multi);
            //i = 9;
            //while (i > 0)
            //{
            //    Console.Write("{0} ", i * reverse_multi);
            //    i--;
            //}
            //Console.WriteLine("");
            //Console.WriteLine("=====================================");

            //int loop_count = 0;
            //i = 0;
            //sum = 0;
            //float avl = 0f;
            //Console.Write("User input(LOOP COUNT) -> ");
            //int.TryParse(Console.ReadLine(), out loop_count);
            //while(i < loop_count)
            //{
            //    i++;
            //    Console.Write("User input -> ");
            //    int input_n;
            //    int.TryParse(Console.ReadLine(), out input_n);

            //    sum = sum+ input_n;
            //    avl = (float)sum/loop_count;
            //}
            //Console.WriteLine("평균값 : {0}", avl);
            //Console.WriteLine("=====================================");


            //float first, second;
            //Console.WriteLine("두 실수를 입력 하시오 : ");
            //float.TryParse(Console.ReadLine(), out first);
            //float.TryParse(Console.ReadLine(), out second);
            //if(first == second)
            //{
            //    Console.WriteLine("같다");
            //}
            //else
            //{
            //    Console.WriteLine("다르다");
            //}

            //float first_f = default;
            //float second_f = default;
            //Console.Write("두 실수를 입력 하시오 : ");
            //string word = Console.ReadLine();
            //string[] words_tmp = word.Split(' ');
            //float.TryParse(words_tmp[0], out first_f);
            //float.TryParse(words_tmp[1], out second_f);

            //if(first_f == second_f)
            //{
            //    Console.WriteLine("같다");
            //}
            //else
            //{
            //    Console.WriteLine("다르다");
            //}
            /*
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이
             * 실행된다.
             */
            //int sum  = 0;
            //for(int i=0;i<=10; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("1부터 10까지의 합 : {0}",sum);
            //// 1~ 100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
            //sum = 0;
            //for(int i=1;i<=100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //        Console.WriteLine("되냐");
            //        /* Do nothing */
            //    }
            //    else {
            //        sum = sum + i;

            //    }

            //}// loop : 100번 도는 루프
            //Console.WriteLine("{0}", sum);
            /*
             * break 문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue문
             * continue문은 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로 시작하게만든다.
             * 반복 루프에서 continue 문을 만나게 되면 continue문 다음에 있는 후속 코드들은 실행되지 않고 건너뛴다.
             */

            //int mo_Count = 0;
            //int za_Count = 0;
            //for (int i = 0; ; i++)
            //{
            //    char.TryParse(Console.ReadLine(), out char charater);
            //    if (charater == 'a' || charater == 'o' || charater == 'e' || charater == 'u' || charater == 'i' || character == 'A' || character == 'E' || character == 'U' || character == 'I' || character == 'O')
            //    {
            //        mo_Count++;
            //    }
            //    else if (charater == '#')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        za_Count++;
            //    }
            //}
            //Console.WriteLine("모음 : {0}", mo_Count); 49

            //Console.WriteLine("자음 : {0}", za_Count);
            //Console.WriteLine("==========================");


            //Console.Write("숫자를 입력하세요 : "); // 숫자를 입력받는다.
            //int.TryParse(Console.ReadLine(), out int key);

            //int first = 1, second = 100;
            //Random random = new Random(); // 랜덤 할당
            //int count = 0;
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("숫자를 입력하세요 : ");
            //    int guess = (first + second) / 2; // 컴퓨터가 추측하는 값을 
            //    Console.WriteLine(guess);
            //    if (guess < key) // 
            //    {
            //        first = guess;
            //        count++;
            //        Console.WriteLine("{0} 보다 큽니다", guess);

            //    }
            //    else if (guess > key)
            //    {
            //        second = guess; // 
            //        count++;
            //        Console.WriteLine("{0} 보다 작습니다.", guess);
            //    }
            //    else
            //    {
            //        count++;
            //        Console.WriteLine("맞았어용");
            //        Console.WriteLine("{0} 번 실행 하셨습니다.", count);

            //        break;
            //    }
            //}


            //Random random = new Random(); // 랜덤 할당

            //char[] text = new char[] { '+', '-', '/', '*' }; // 배열로 산수규칙을 저장해놨다.
            //for (int i = 0; ; i++)
            //{
            //    int first = random.Next(0, 100); 
            //    int second = random.Next(0, 100); // 산술계산을 할 두개의 정수를 0~99사이의 수로 랜덤할당
            //    int problem_n = random.Next(0, 4); // 배열안에 있는 인덱스를 랜덤으로 0~3까지 할당

            //    Console.Write("{0} {1} {2} = ", first, text[problem_n], second); // 숫자 계산 숫자 = 답
            //    int.TryParse(Console.ReadLine(), out int result); // 결과를 입력받는다.
            //    if (second == 0 && text[problem_n] == '/') // 나누기의 뒤에숫자가 0일 경우 문제를 다시출제
            //    {
            //        Console.WriteLine("문제다시출제");
            //    }
            //    else if (text[problem_n] == '+') // 더하기 일 경우
            //    {
            //        if (result == first + second) // 더하기 수행이 결과 값과 같다면 
            //        {
            //            Console.WriteLine("정답입니다"); // 정답
            //            break;

            //        }
            //        else // 틀리다면
            //        {
            //            Console.WriteLine("틀렸습니다."); // 다시 출제
            //            continue;
            //        }
            //    }
            //    else if (text[problem_n] == '-') // 빼기 일 경우
            //    {
            //        if (result == first - second) // 빼기 수행이 결과 값과 같다면 
            //        {
            //            Console.WriteLine("정답입니다");
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("틀렸습니다.");
            //            continue;
            //        }
            //    }
            //    else if (text[problem_n] == '*') // 곱하기 일 경우
            //    {
            //        if (result == first * second) // 곱하기 수행이 결과 값과 같다면 
            //        {
            //            Console.WriteLine("정답입니다");
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("틀렸습니다.");
            //            continue;
            //        }

            //    }
            //    else if (text[problem_n] == '/') // 나누기 일 경우
            //    {

            //        if (result == first / second) // 나누기 수행이 결과 값과 같다면 
            //        {
            //            Console.WriteLine("정답입니다");
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("틀렸습니다.");
            //            continue;
            //        }
            //    } // if

            //} // for

            /*
             *foreach 문은 배열 이나 컬렉션(Collection) 같은 값을 여러개 담고 있는 데이터 구조에서 
             *각각의 데이터가 들어잇는 만큼 반복하는 반복문이다. 데이터 갯수나 반복 조건을 처리할 필요가 없다.
             */
            // string에서 글자를 하나씩 출력
            //string stringText = "Hello World!";
            //int count = 0;
            //foreach(char oneCharactor in stringText){
            //    Console.Write("{0} ", oneCharactor);
            //    count++;
            //}// loop :: stringText의 길이만큼 도는 루프
            //Console.WriteLine("\ncount : {0}, string length : {1}",count, stringText.Length);
            int sum = 0;
            for(int i=1;i<=100; i++)
            {
                if(i%3==0 && i % 4 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("3의배수이면서 4의배수인 숫자의 합 : {0}",sum);
            Console.WriteLine("=======================");

            Console.Write("숫자 두개를 입력하세요 : ");
            string text = Console.ReadLine();
            string[] text_tmp = text.Split(' ');
            int.TryParse(text_tmp[0], out int first);
            int.TryParse(text_tmp[1],out int second);
            if(first > second)
            {
                Console.WriteLine("두개를 뺀 값 : {0}", first - second);
            }
            else
            {
                Console.WriteLine("두개를 뺀 값 : {0}", second - first);
            }
            Console.WriteLine("=======================");

            
            for (int i = 1; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                    }
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("=======================");

            for (int i=1;i<=9; i++)
            {
                for(int j=1;j<=9; j++)
                {
                    if(i*10+j + j*10+i == 99)
                    {
                        Console.WriteLine("A = {0} Z = {1}", i, j);
                    }
                }
            }
        }// main
    }// class
}
/*
 * 과제===================
 * 부동소수점 에러
 * 앱실론
 */

