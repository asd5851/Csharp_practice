using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace first
{
    internal class 과제_김선준_20221226
    {
        /*
         * □ □ □ □ □
         * □ . . . □
         * □ .옷 . □
         * □ . . . □
         * □ □ □ □ □
         * 5x5보드
         * . = 빈곳
         * □ = 벽
         * w,a,s,d 입력받아서 빈곳을 자유롭게 이동하는 프로그램 작성
         * 사람은 빈 곳을 다닐 수 있음
         * 사람은 벽을 넘어다닐 수 없음
         */
        
        static int coin_num = 2; // 시작 코인은 2개
        static int take_coin = 0; // 내가 먹은 코인의 갯수
        static int first_coin; 
        const int X_SIZE = 10; // 맵의 크기
        const int Y_SIZE = 10;

        static Random random = new Random();

        //플레이어 좌표를 랜덤으로 설정한다.
        static int Player_X = random.Next(1, 8 + 1);
        static int Player_Y = random.Next(1, 8 + 1);

        //코인의 좌표를 랜덤으로 설정한다.
        static int[] Coin_X = new int[8];
        static int[] Coin_Y = new int[8];

        static int count = 1; 
        public static void set_(char[,]arr)
        {
            for (int i = 0; i < X_SIZE; i++)
            {
                for (int j = 0; j < Y_SIZE; j++)
                {
                    bool edge = (i == 0 || i == 9 || j == 0 || j == 9); // 배열의 맨끝을 edge로 표현
                    if (edge)
                    {
                        arr[i, j] = '■'; // 배열의 맨끝을 '□'로 표현
                    }
                    else if (i == Player_X && j == Player_Y) // 플레이어의 좌표가 랜덤
                    {
                        if (arr[i, j] != '$') // 코인의 위치가 아니라면
                        {
                            arr[i, j] = '옷'; // 플레이어를 위치시킨다.

                        }
                    }
                    else
                    {
                        if (arr[i, j] != '$') // 코인의 위치가 아니라면
                        {
                            arr[i, j] = '.'; // .으로 표현
                        }
                    }
                }
            }
            
        }

        // 랜덤으로 위치한 코인의 위치를 중복되지 않게하기 위한 함수
        public static void random_go(char[,] arr)
        {
            for (int i = 0; i < 8; i++)
            {
                Coin_X[i] = i + 1;
                Coin_Y[i] = i + 1;
            }
            while (coin_num > 0)
            {
                for (int i = 0; i < 100; i++) // 100번 섞는다.
                {
                    int sidx = random.Next(0, 7 + 1);
                    int didx = random.Next(0, 7 + 1);
                    int ssidx = random.Next(0, 7 + 1);
                    int ddidx = random.Next(0, 7 + 1);

                    int ttemp = Coin_X[sidx];
                    Coin_X[sidx] = Coin_X[didx];
                    Coin_X[didx] = ttemp;

                    int tttemp = Coin_Y[ssidx];
                    Coin_Y[ssidx] = Coin_Y[ddidx];
                    Coin_Y[ddidx] = tttemp;
                }
                if (Coin_X[0] != Player_X || Coin_Y[0] != Player_Y) // 코인의 위치가 플레이어의 위치가 아닌경우
                {

                    arr[Coin_X[0], Coin_Y[0]] = '$'; // 그 위치에 코인을 넣는다.
                    coin_num--;
                }

            }
        }

        // 시작코인을 정해준다.
        public static void Insert_Coin()
        {
            coin_num = 2;
            first_coin = coin_num;
        }

        // 현재 보드판의 상태를 보여주는 함수
        public static void Show(char[,]arr) {
            for (int i = 0; i < X_SIZE; i++)
            {
                for (int j = 0; j < Y_SIZE; j++)
                {

                    Console.Write("{0}\t", arr[i, j]);
                   
                }
                Console.WriteLine();
            }
        }

        // 메인함수
        static void Main(string[] args)
        {
            char[,] arr = new char[10, 10]; // 10x10의 배열 생성
            // 가로 세로 사이즈는 10로 고정
            int gx, gy;

            Insert_Coin();
            set_(arr);
            Show(arr);// 초기 출력

            Console.WriteLine();
            Task.Delay(1000).Wait();
            Console.Clear();

            random_go(arr);
            Show(arr);// 초기 출력
            int cnt = 0;
            bool fflag = true;

            // { 게임시작
            while (true)
            {
                // 명령어를 입력받는다.
                fflag = true;
                Console.Write("명령어를 입력하세요(w,a,s,d) : ");
                char.TryParse(Console.ReadLine(), out char command);
                count++;
                if (count % 5 == 1) // 일정한 차례가 되면 자동으로 코인을 생성한다.(랜덤위치)
                {
                    for (int i = 0; i < 100; i++) // 코인 랜덤위치를 설정한다.
                    {
                        int sidx = random.Next(0, 7 + 1);
                        int didx = random.Next(0, 7 + 1);
                        int ssidx = random.Next(0, 7 + 1);
                        int ddidx = random.Next(0, 7 + 1);

                        int ttemp = Coin_X[sidx];
                        Coin_X[sidx] = Coin_X[didx];
                        Coin_X[didx] = ttemp;

                        int tttemp = Coin_Y[ssidx];
                        Coin_Y[ssidx] = Coin_Y[ddidx];
                        Coin_Y[ddidx] = tttemp;
                    }
                    bool nowhere = Coin_X[0] == Player_X - 1 && Coin_Y[0] == Player_Y - 1 && Coin_Y[0] == Player_Y + 1 && Coin_Y[0] == Player_X + 1 && Coin_X[0] == Player_X && Coin_Y[0] == Player_Y;
                    if (nowhere)
                    {
                        /* DO NOTHING */
                    }
                    else// 코인 랜덤위치를 설정한다.
                    {
                        arr[Coin_X[0], Coin_Y[0]] = '$';
                        first_coin++;
                    }
                }

                bool flag = true; // FOR문을 도는 동안 두번씩 입력이 되지않게 flag를 초기화한다.
                for (int i = 0; i < X_SIZE; i++)
                {
                    for (int j = 0; j < Y_SIZE; j++)
                    {
                        if (arr[i, j] == '옷' && flag == true) // for문을 돌면서 플레이어를 찾고                                                             // 아직 for문을 돌지않아 flag가 true일때
                        {
                            Player_X = i;
                            Player_Y = j;
                            cnt++;
                            if (command == 'w' && flag == true) // if : 명령어가 w일떄
                            {
                                if (i - 1 != 0) // if: 위쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    // '.'과 '옷'을 swap한다.
                                    if (arr[i - 1, j] == '$')
                                    {
                                        take_coin++;
                                        flag = false;
                                        arr[i - 1, j] = '옷';
                                        arr[i, j] = '.';
                                    }
                                    else
                                    {
                                        char temp = arr[i, j];
                                        arr[i, j] = arr[i - 1, j];
                                        arr[i - 1, j] = temp;
                                        flag = false;
                                    }

                                }

                                else { continue;}

                            }
                            else if (command == 'a' && flag == true) // if : 명령어가 a일떄
                            {
                                if (j - 1 != 0) // if: 왼쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    if (arr[i, j - 1] == '$')
                                    {
                                        take_coin++;
                                        flag = false;
                                        arr[i, j - 1] = '옷';
                                        arr[i, j] = '.';

                                    }
                                    else
                                    {
                                        // '.'과 '옷'을 swap한다.
                                        char temp = arr[i, j];
                                        arr[i, j] = arr[i, j - 1];
                                        arr[i, j - 1] = temp;
                                        flag = false;
                                    }

                                }
                                else { continue; }

                            }
                            else if (command == 's' && flag == true) // if : 명령어가 s일떄
                            {
                                if (i + 1 != 9) // if: 아래쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    if (arr[i + 1, j] == '$')
                                    {
                                        take_coin++;
                                        flag = false;
                                        arr[i + 1, j] = '옷';
                                        arr[i, j] = '.';

                                    }
                                    else
                                    {
                                        char temp = arr[i, j];
                                        arr[i, j] = arr[i + 1, j];
                                        arr[i + 1, j] = temp;
                                        flag = false;
                                    }
                                }
                                // '.'과 '옷'을 swap한다.

                                else { continue; }

                            }
                            else if (command == 'd' && flag == true) // if : 명령어가 d일떄
                            {
                                if (j + 1 != 9) // if: 오른쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    if (arr[i, j + 1] == '$')
                                    {
                                        take_coin++;
                                        flag = false;
                                        arr[i, j + 1] = '옷';
                                        arr[i, j] = '.';
                                    }
                                    else
                                    {
                                        // '.'과 '옷'을 swap한다.
                                        char temp = arr[i, j];
                                        arr[i, j] = arr[i, j + 1];
                                        arr[i, j + 1] = temp;
                                        flag = false;
                                    }
                                }
                                else { continue; }
                            }
                        }
                    }
                }

                // 이동한 사람을 출력한다.
                Console.Clear();
                Show(arr);
                for(int i=0;i<X_SIZE; i++) // 보드판을 둘러보면서 코인이 없으면 fflag에 false를 리턴한다
                {
                    for(int j=0;j<Y_SIZE; j++)
                    {
                        if (arr[i,j] == '$')
                        {
                            fflag = false;
                        }
                    }
                }
                Console.WriteLine("먹은 갯수 : {0}", take_coin);
                Console.WriteLine("움직인 횟수 : {0}", cnt);
                if (fflag == true) // 보드판을 둘러보면서 $가없으면 종료한다.
                {
                    Console.WriteLine("게임이 종료되었습니다.");
                    break;
                }

            }// } 게임 종료


        }
    }
}
