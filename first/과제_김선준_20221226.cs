using System;
using System.Collections.Generic;
using System.Linq;
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
        static void Main(string[] args)
        {
            char[,] arr = new char[5,5]; // 5x5의 배열 생성

            // 가로 세로 사이즈는 5로 고정
            const int X_SIZE = 5;
            const int Y_SIZE = 5;
             
            // 맨끝에는 벽인 '□' 로 설정하고 벽 이 아닌곳은 '.'
            // 사람의 초기위치는 가운데인 2x2로 '옷'으로 설정한다.
            for(int i=0;i<X_SIZE; i++)
            {
                for( int j=0;j<Y_SIZE; j++)
                {
                    bool edge = (i == 0 || i == 4 || j == 0 || j == 4); // 배열의 맨끝을 edge로 표현
                    if (edge)
                    {
                        arr[i, j] = '□'; // 배열의 맨끝을 '□'로 표현
                    }
                    else
                    {
                        arr[i, j] = '.'; // 배열의 맨끝이 아닌곳을 '.'으로 표현
                    }
                    if (i==2 && j == 2)
                    {
                        arr[i, j] = '옷'; // 플레이어는 가장 가운데에 있다.
                    }
                }
            }

            // 초기 출력
            for (int i = 0; i < X_SIZE; i++)
            {
                for (int j = 0; j < Y_SIZE; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            // { 게임시작
            while (true)
            {
                // 명령어를 입력받는다.

                Console.Write("명령어를 입력하세요(w,a,s,d) : ");
                
                char.TryParse(Console.ReadLine(), out char command);
                
                bool flag = true; // FOR문을 도는 동안 두번씩 입력이 되지않게 flag를 초기화한다.
                for(int i=0; i < X_SIZE; i++)
                {
                    for(int j=0; j < Y_SIZE; j++)
                    {
                        if (arr[i,j] == '옷' && flag == true) // for문을 돌면서 플레이어를 찾고
                         // 아직 for문을 돌지않아 flag가 true일때
                        {
                            
                            if (command == 'w') // if : 명령어가 w일떄
                            {
                                if (i - 1!=0) // if: 위쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    // '.'과 '옷'을 swap한다.
                                    char temp = arr[i, j];
                                    arr[i, j] = arr[i - 1, j];
                                    arr[i - 1, j] = temp;
                                    flag = false;
                                }
                                else { continue; }
                                
                            }
                            else if (command == 'a') // if : 명령어가 a일떄
                            {
                                if (j - 1 != 0) // if: 왼쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    // '.'과 '옷'을 swap한다.
                                    char temp = arr[i, j];
                                    arr[i, j] = arr[i, j - 1];
                                    arr[i, j - 1] = temp;
                                    flag = false;
                                }
                                else { continue; }

                            }
                            else if (command == 's') // if : 명령어가 s일떄
                            {
                                if (i + 1 != 4) // if: 아래쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    // '.'과 '옷'을 swap한다.
                                    char temp = arr[i, j];
                                    arr[i, j] = arr[i + 1, j];
                                    arr[i + 1, j] = temp;
                                    flag = false;
                                }
                                else { continue; }
                                
                            }
                            else if (command == 'd') // if : 명령어가 d일떄
                            {
                                if (j + 1 != 4) // if: 오른쪽으로 이동할때 □를 넘으면 실행하지 않는다. 
                                {
                                    // '.'과 '옷'을 swap한다.
                                    char temp = arr[i, j];
                                    arr[i, j] = arr[i, j + 1];
                                    arr[i, j + 1] = temp;
                                    flag = false;
                                }
                                else { continue; }
                                
                            }
                        }
                       
                    }
                }

                // 이동한 사람을 출력한다.
                for(int i=0; i < X_SIZE; i++)
                {
                    for(int j=0; j < Y_SIZE; j++)
                    {
                        Console.Write("{0}\t", arr[i, j]);
                    }
                    Console.WriteLine();
                }// loop : 이동한 사람을 출력하는 루프
               
            }// } 게임 종료


        }
    }
}
