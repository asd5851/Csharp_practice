using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class _
    {
        static void Main(string[] args)
        {
            // { 입력부분 / dy. kive
            //Console.Write("현재 가지고 있는 돈 : ");
            //string money = Console.ReadLine();
            //int money_n = default;
            //int.TryParse(money, out money_n);

            //const int candy = 300;
            //Console.WriteLine("캔디의 가격 : {0}",candy);
            //Console.WriteLine("최대로 살 수 있는 캔디의 갯수 = {0}", money_n/candy);
            //Console.WriteLine("캔디 구입 후 남은 돈 = {0}", money_n%candy);
            //Console.WriteLine("");

            //Console.Write("화씨온도를 입력하세요 : ");

            //float temper_f = default;
            //float.TryParse(Console.ReadLine(), out temper_f);

            //Console.WriteLine("화씨온도 {0}도는 섭씨온도 {1} 입니다", temper_f,(temper_f-32)*5/9);
            //Console.WriteLine("");


            //Random random = new Random();
            //int firstdice = random.Next(1,7);
            //int seconddice = random.Next(1,7);


            //Console.WriteLine("첫번쨰 주사위 : {0}",firstdice);
            //Console.WriteLine("두번쨰 주사위 : {0}",seconddice);
            //Console.WriteLine("두 주사위의 합 : {0}",firstdice+seconddice);


            //const char comcode = 'h';
            //char code = default;
            //Console.Write("코드를 입력하세요 : ");
            //char.TryParse(Console.ReadLine(), out code);
            //if(code < comcode)
            //{
            //    Console.WriteLine("{0} 뒤에 있음", code);
            //}
            //else if(code > comcode)
            //{
            //    Console.WriteLine("{0} 앞에 있음", code);

            //}
            //else
            //{
            //    Console.WriteLine("정답입니다");

            //}

            Console.Write("3개의 정수를 입력하시오 : ");
            string words = Console.ReadLine(); // 입력받아서
            string[] words_tmp = words.Split(' '); // word_tmp를 띄어쓰기대로 나눠서 그것을
            int first, second, third;
            int.TryParse(words_tmp[0], out first);
            int.TryParse(words_tmp[1], out second);
            int.TryParse(words_tmp[2], out third);

            if (first < second)
            {
                if (second < third)
                    Console.WriteLine("가장 큰 정수는 : {0}", third);
                else if (second > third)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", second);

                }
            }
            else if (second < third)
            {
                if (third < first)
                    Console.WriteLine("가장 큰 정수는 : {0}", first);
                else if (third > first)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", third);

                }

            }
            else if (third < first)
            {
                if (first < second)
                    Console.WriteLine("가장 큰 정수는 : {0}", second);
                else if (second < first)
                {

                    Console.WriteLine("가장 큰 정수는 : {0}", first);

                }

            }


        } // M
    }
}
/*
 * 현재 1000원 사탕가격 300원 최대살수있는 사탕의 갯수 와 나머지 돈은 얼마인가?
 * 랜덤에는 시드 써주면 고정값이 나옴
 * Random dice = new Random(100);
 * 
 * 제어문 소개
 * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문), 반복 구조(반복문)이 있다.
 * 
 * 순차문
 * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로 실행 후 종료된다
 * 
 * 제어문
 * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로 조건문과 반복문으로 구분
 * 
 * 조건문
 * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조, 분기문 또는 비교판단문이라고한다.
 * 
 * 반복문
 * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
 * 
 * if/ else 문
 * 프로그램 흐름을 여러 가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if 문을 사용한다.
 * if 문은 조건을 비교해서 판단하는 구문으로 if, else, else if 세가지 키워드가 있다.
 * 
 */