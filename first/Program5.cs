using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program5
    {
        int[] sorted = new int[8];


        void merge(int left, int right, int mid, int[] arr) // 합치는 함수 3, 1, 2, 5, 4, 6, 7, 8
                                                            //                                                0 1  2 3 4 5 6 7
        {

            int L = left;  // 0
            int R = mid + 1; // 1
            //3 1 2 5
           //Console.WriteLine("right = {0}",right);
            int index = left;
            Console.Write("L = {0}, R = {1}", L, R);
            Console.WriteLine("");
            while (L <= mid && R <= right) // 0 <= 1 && 1 <= 1
                                              // 2 <= 2 && 2 <= 3
            {
                
                Console.Write("arr[{0}] = {1} vs arr[{2}] = {3}", L, arr[L], R, arr[R]);
                Console.WriteLine();

                if (arr[L] <= arr[R])
                {
                    sorted[index] = arr[L];
                    Console.Write("");
                    L++;

                }
                else
                {
                    sorted[index] = arr[R];
                    R++;
                }
                index++;
            }

            if (L > mid)// 왼쪽으로 커지다가 mid를 넘어버린 경우
                // 
            {
                for (int i = R; i <= right; i++) // 오른쪽애를 나머지 인덱스다 전부다 집어넣기
                {
                    sorted[index] = arr[i];
                    index++;
                }

            }

            else // 아닌경우
            {
                for (int i = L; i <= mid; i++) // 왼쪽애를 나머지 인덱스에 전부다 집어넣기
                {
                    sorted[index] = arr[i];
                    index++;
                }
            }
           

            Console.Write("sort = ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0} ", sorted[i]);

            }

            Console.WriteLine();

            for (int i = left ; i <= right; i++) // sorted에 있는 값들을 arr에 복사
            {
                arr[i] = sorted[i];
                Console.WriteLine("==arr[{0}] = {1}==", i, arr[i]);
            }
            Console.WriteLine();

        }
        void merge_sort(int left, int right, int[] arr) // 나눠!
        {

            if (left < right)
            {
                int mid = (left + right) / 2; // 0 3 = 1
                merge_sort(left, mid, arr); // 처음부터 중간까지 나눈다

                merge_sort(mid + 1, right, arr); // 중간부터 마지막 까지 나눈다.
                merge(left, right, mid, arr); // 다시 합친다.
            }

        }
        static void Main(string[] args)
        {

            //int[] person = new int[5];
            //for (int i = 0; i < 5; i++)
            //{

            //    Random random = new Random();
            //    person[i] = random.Next(100, 1001);
            //    Console.Write("{0} ", person[i]);
            //}
            //Console.WriteLine("");

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = i + 1; j < 5; j++)
            //    {
            //        if (person[i] == person[j])
            //        {
            //            person[i] = int.MaxValue;
            //        }
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (person[i] < person[j])
            //        {
            //            int temp = person[i];
            //            person[i] = person[j];
            //            person[j] = temp;
            //        }
            //    }
            //}
            
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0} ", person[i]);
            //}
            //Console.WriteLine("");

            //Console.WriteLine("제일 적게 먹은 사람 = {0}", person[0]);

            int[]apple = new int[8] { 3, 1, 2, 5, 4, 6, 7, 8 };
            //for (int i = 0; i < apple.Length; i++)
            //{
            //    Random random = new Random();
            //    apple[i] = random.Next(1, 10001);
            //}
            var mc = new Program5();
            mc.merge_sort(0, 7, apple);



            // int a = 1;
            //int number = 1_0821;
            //Console.WriteLine("64로 모드 연산 : {0}", number%64);

            //int[] oneArray = new int[2] { 1, 2 };
            //int[,] twoArray = new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } }; // 2차원 배열
            //int[,] twoArray2 = new int[3, 2] { { 1, 2}, { 3, 4} , { 5, 6 } }; // 2차원 배열
            //int[,,] threeArray = new int[2, 2, 2]
            //{
            //    {{1,2},{3,4 }},
            //    {{1,2},{3,4 }}
            //};

            ////3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력
            //twoArray = new int[3, 3];
            //for(int i=0;i<3; i++)
            //{
            //    for(int j=0;j<3; j++)
            //    {
            //        if (i == j)
            //        {
            //            twoArray[i, j] = 1;
            //        }
            //        Console.Write("{0} ", twoArray[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //// 가변배열
            //int[][] zagArray = new int[2][]; // 앞의 2개는 fix하고 뒤에는 가변으로 넣겠다.
            //zagArray[0] = new int[] { 1, 2 };
            //zagArray[1] = new int[] { 3, 4 ,5};
            //for(int i = 0;i<2; i++)
            //{
            //    for(int j=0;j<zagArray[i].Length; j++)
            //    {
            //        Console.Write("{0} ", zagArray[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr; // int 형 데이터 타입의 arr라는 배열을 선언
            //arr = new int[3]; // int 형 데이터 타입의 변수를 3개 메모리에 할당

            //arr[0] = 1; // arr 0번쨰 인덱스에 1이라는 정수값 대입
            //arr[1] = 2;//  arr 1번쨰 인덱스에 2이라는 정수값 대입


            //for (int i=0;i<arr.Length; i++) // 배열의 크기만큼 돌장
            //{
            //    Console.WriteLine("{0} 번째 인덱스의 값 -> {1}",i, arr[i]);
            //}

            //// arr 배열에서 int 형 데이터 타입의 값을 하나씩 뽑아서 i에 저장할거임
            //// foreach는 그냥 i=0부터 시작해서 배열의 길이만큼 배열의 값을 result에 저장하는거네~
            //foreach(int result in arr) // arr의 길이 만큼 돈다.
            //{
            //    Console.WriteLine("arr의 값 : {0}", result);

            //}

            //int[] student;
            //student = new int[3];
            //int sum = 0;
            //int cnt = 0;
            //for (int i=0;i<3; i++)
            //{
            //    cnt++;
            //    Console.Write("{0}번째 학생의 점수 : ",i+1);
            //    int.TryParse(Console.ReadLine(), out student[i]);
            //    if (student[i] >=1 && student[i] <= 100)
            //    {
            //        sum = sum + student[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine("잘못입력하셨습니다.");
            //        cnt--;
            //    }
            //}
            //float avl = 0.0f;
            //if(cnt <= 0)
            //{
            //    Console.WriteLine("다 잘못입력했어요");
            //}
            //else
            //{
            //    avl = (float)sum / cnt;
            //    Console.WriteLine("총점 : {0} \t 평균 : {1}", sum, avl);

            //}
            /*
             * 크기가 100인 배열을 1부터 100사이의 난수로 채우고 배열 요소 중에서 최대값을 찾자
             */
            //int[]nansu= new int[10];
            // int max = 0;
            // for(int i=0;i<10; i++)
            // {
            //     Random random= new Random();
            //     nansu[i] = random.Next(1,101);
            //     Console.WriteLine("{0} ",nansu[i]);

            //     if(max < nansu[i])
            //     {
            //         max = nansu[i];
            //         Console.WriteLine("값 : {0}, 최댓 값 인덱스 갱신 : {1}", nansu[i],i);
            //     }

            // }
            // Console.WriteLine("최대 값 : {0}", max);
            /*
             * 사과를 제일좋아하는 사람찾기
             * 사람들 10명에게 아침에 먹는 사과 갯수를 입력하도록 요청하는 프로그램
             * 데이터 입력이 마무리 되면 누가 가장 많은 사과를 먹었는지 출력
             */
        }
        /*
         * 다차원 배열
         * 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
         * c#에서 배열을 선언할 때는 콤마를 기준으로 자원을 구분한다.
         * 
         * 가변 배열
         * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
         * 
         * LAB 1,2 코딩했던 내용 주석달아서 해석해서 제출
         * 미완성일 경우 이해하고 있는 내용까지만이라도 제출 -> 어느단계까지 도전했는지 포함
         * 용량조심
         * 
         * ===조금만 알아보자===
         * GetUpperBound
         * 
         */

    }
}
