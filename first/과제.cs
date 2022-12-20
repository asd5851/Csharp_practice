using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class 과제
    {
        static void Main(string[] args)
        {
            int mo_Count = 0;
            int za_Count = 0;
           
            for (int i = 0; ; i++)
            {
                Console.Write("문자를 입력 하세요 : ");
                char.TryParse(Console.ReadLine(), out char charater); // 문자를 입력받음
                bool chec = false;

                if (charater == 'a' || charater == 'o' || charater == 'e' || charater == 'u' || charater == 'i' || charater == 'A' || charater == 'E' || charater == 'U' || charater == 'I' || charater == 'O')
                { // 입력받은 문자가 모음일 경우 chec을 참으로 할당
                    chec = true;
                }
                
                if (chec)// 입력받은 문자가 모음일 경우
                { 
                    mo_Count++; // 모음카운트를 증가
                }
                else if (charater == '#') // 입력받은 문자가 #일 경우
                {
                    break; // 반복문 종료
                }
                else // 입력받은 문자가 자음일 경우
                {
                    za_Count++; // 자음 카운트를 증가
                }
            }

            Console.WriteLine("모음 : {0}", mo_Count); 
            Console.WriteLine("자음 : {0}", za_Count);// 출력받기
            Console.WriteLine("=========================="); // 문제 나누기


            Console.Write("숫자를 입력하세요 : "); // 숫자를 입력받는다.
            int.TryParse(Console.ReadLine(), out int key);

            int first = 1, second = 100;
            Random random = new Random(); // 랜덤 할당
            int count = 0;
            for (int i = 0; ; i++)
            {
                Console.Write("숫자를 입력하세요 : ");
                int guess = (first + second) / 2; // 컴퓨터가 추측하는 값을 처음과 끝의 절반으로 설정
                Console.WriteLine(guess);
                if (guess < key) // 추측하는 값보다 키값이 크다면
                {
                    first = guess; // 처음값을 추측값으로 바꾸고
                    count++; // 카운터 증가
                    Console.WriteLine("{0} 보다 큽니다", guess);

                }
                else if (guess > key) // 추측하는 값보다 키값이 작다면
                {
                    second = guess; // 끝 값을 키값으로 바꾸고
                    count++; // 카운트 증가
                    Console.WriteLine("{0} 보다 작습니다.", guess);
                }
                else // 키값과 추측값이 맞다면
                {
                    count++;
                    Console.WriteLine("맞았어용");
                    Console.WriteLine("{0} 번 실행 하셨습니다.", count); // 정답 출력

                    break;
                }
            }

            Console.WriteLine("=========================="); // 과제 라인
            
            Random random_n = new Random(); // 랜덤 할당
            char[] text = new char[] { '+', '-', '/', '*' }; // 배열로 산수규칙을 저장해놨다.
            for (int i = 0; ; i++)
            {
                int first_n = random_n.Next(0, 100);
                int second_n = random_n.Next(0, 100); // 산술계산을 할 두개의 정수를 0~99사이의 수로 랜덤할당
                int problem_n = random_n.Next(0, 4); // 배열안에 있는 인덱스를 랜덤으로 0~3까지 할당

                Console.Write("{0} {1} {2} = ", first_n, text[problem_n], second_n); // 숫자 계산 숫자 = 답
                int.TryParse(Console.ReadLine(), out int result); // 결과를 입력받는다.
                if (second == 0 && text[problem_n] == '/') // 나누기의 뒤에숫자가 0일 경우 문제를 다시출제
                {
                    Console.WriteLine("문제다시출제");
                }
                else if (text[problem_n] == '+') // 더하기 일 경우
                {
                    if (result == first_n + second_n) // 더하기 수행이 결과 값과 같다면 
                    {
                        Console.WriteLine("정답입니다"); // 정답
                        break;

                    }
                    else // 틀리다면
                    {
                        Console.WriteLine("틀렸습니다."); // 다시 출제
                        continue;
                    }
                }
                else if (text[problem_n] == '-') // 빼기 일 경우
                {
                    if (result == first_n - second_n) // 빼기 수행이 결과 값과 같다면 
                    {
                        Console.WriteLine("정답입니다");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다.");
                        continue;
                    }
                }
                else if (text[problem_n] == '*') // 곱하기 일 경우
                {
                    if (result == first_n * second_n) // 곱하기 수행이 결과 값과 같다면 
                    {
                        Console.WriteLine("정답입니다");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다.");
                        continue;
                    }

                }
                else if (text[problem_n] == '/') // 나누기 일 경우
                {

                    if (result == first_n / second_n) // 나누기 수행이 결과 값과 같다면 
                    {
                        Console.WriteLine("정답입니다");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다.");
                        continue;
                    }
                } // if

            } // for
        }
    }
}
/*
 * LAB 1 ~ LAB 3
 * 주석으로 설명해서 제출
 * zip파일, gitignore참고, 용량포기
 * 파일명 : 과제_이름_날짜.zip
 */

