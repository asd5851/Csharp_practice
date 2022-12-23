using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program6
    {
        static int []sorted = new int[10];
        //void conquer(int start, int end, int mid, int []arr)
        //{
        //    int i = start;
        //    int j = mid + 1;
        //    int k = start;
        //    while(i<=mid && j<=end)
        //    {
        //        if (arr[i] <= arr[j]) // 3 1 2 5
        //        {
        //            Console.WriteLine("1. arr[i] = {0} vs arr[j] = {1} ",arr[i], arr[j]);
        //            sorted[k] = arr[i];
        //            i++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("2. arr[i] = {0} vs arr[j] = {1} ", arr[i], arr[j]);

        //            sorted[k] = arr[j];
        //            j++;
        //        }
        //        k++;
        //    }

        //    if (i > mid)
        //    {
        //        for(int index=j; index <= end; index++) {
        //            sorted[k] = arr[index];
        //            k++;
        //        }
        //    }
        //    else
        //    {
        //        for(int index = i; index <=mid ;index++) {
        //            sorted[k] = arr[index];
        //            k++;
        //        }
        //    }

        //    for(int index = start; index <= end ; index++)
        //    {
        //        arr[index] = sorted[index];
        //    }
        //}
        //void merge_divide(int start, int end, int []arr)
        //{
        //    if(start < end)
        //    {
        //        int mid = (start + end) / 2;
        //        merge_divide(start, mid, arr);
        //        merge_divide(mid + 1, end, arr);

        //        conquer(start, end, mid, arr);
        //    }
        //}
        static void Main(string[] args)
        {

            /*
             *  1. 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
             */
            Console.Write("입력하세요 : ");
            string first = Console.ReadLine();
            Console.Write("입력하세요 : ");
            string second = Console.ReadLine();

            bool flag = true;
            if(first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        flag = false;
                        break;
                    }

                }
            }
            else
            {
                flag = false;
            }
            

            if (flag)
            {
                Console.WriteLine("두개의 문자열은 같습니다.");
            }
            else
            {
                Console.WriteLine("두개의 문자열은 다릅니다.");
            }
            /*
             * 5개의 음료(콜라,물,스프,주스,커피)를 판매하는 자판기 머신을 구현하기
             * 사용자가 1~5사이의 숫자입력
             * 선택한 음료 출력
             */
            Console.WriteLine("1.콜라 2.물 3.스프라티 4.주스 5.커피");

            string[] bev_name = new string[5] { "콜라","물","스프라티","주스","커피"};
            Console.Write("숫자를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out int bev);
            if(1<=bev && bev <= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (bev == i + 1)
                    {
                        Console.WriteLine("{0}을 선택하셨습니다", bev_name[i]);

                    }
                }
            }
            else
            {
                Console.WriteLine("잘못 누르셨습니다.");
            }
            

            /*
             * 배열 days[]를 아래와 같이 초기화 하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성
             * days[] -> 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
             * ex) 1월은 31일까징비니다.
             *      2월은 29일까지입니다
             */
            int[] days = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for(int i=0;i<12; i++)
            {
                Console.WriteLine("{0}월은 {1}일 까지입니다.", i + 1, days[i]);
            }

            //int[] arr = new int[10] { 3, 1, 2, 5, 4, 6, 7, 8, 10, 9 };

            //var mc = new Program6();

            //mc.merge_divide(0, 9, arr);
            //for(int i=0;i<9; i++)
            //{
            //    Console.Write("{0} ", sorted[i]);

            //}

        }
    }
}
/*
 * doxygen 클래스 다이어그램을 뽑아줌
 * commit -m "[닉네임] feat(내가 개발한 내용이 영향을 끼칠 수 있는 범위) : 내가 한 일(퀘스트창에 알림 기능 추가)"
 * feat : 기능추가
 * fix : 수정
 * design : 디자인 변경
 * !HOTFIX : 치명적인 버그고쳐야함
 * Style : 코드 포맷 변경
 * Comment : 필요한 주석 추가 및 변경
 * 등등
 * 
 * fetch로 내려받아서 소스트리로 항상 보기
 * 
 * 레퍼런스 게임 작업 해보면서 내가 지금까지 배운 것들로 무엇을 어디까지 구현 할 수 있을지
 * 마인드맵으로 그려보기
 * - 타이틀 씬
 * - 선택지를 포함한 이벤트 -> 유저가 뭔가 선택 가능한 형태
 * - 보상 or 패널티를 얻을 수 있는 이벤트 -> 유저가 골드 얻거나 아이템을 얻거나 스탯치가 떨어지거나 하는 형태
 * - 전투 씬
 */
