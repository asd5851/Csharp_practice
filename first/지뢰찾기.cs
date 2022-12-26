using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace first
{
    internal class 지뢰찾기
    {
        /*
         * 지뢰 찾기
         * 10 x 10 보드에 지뢰를 숨김 (n%의 확률로 지뢰 매설)
         * debug mode에서 지뢰가 아닌 곳은 .(닷), 지뢰 인곳은 #(샵)으로 표현
         * play mode에서 확인 되지 않은 곳은 전부 □(스퀘어)로 표현
         * 첫 턴에 지뢰를 밟으면 해당 칸애 지뢰를 지워 줌
         */
        static void Main(string[] args)
        {
            Random randomMine = new Random();
            const int MINE_PERCENTAGE = 30;
            const int BOARD_SIZE_X = 5;
            const int BOARD_SIZE_Y = 5;

            bool isDebugMode = true;
            bool isGameOver = false;
            bool isPlayerwin = false;
            int playerTurncnt = 0;

            /*
             * 10 x 10 보드에 지뢰 초기화 한다.
             * gameboard 상태 
             * 지뢰 : MINE_PERCENTAGE(30) 미만의 값
             * 빈칸 : MINE_PERCENGATE(30) 이상의 값
             * 
             * playboard 상태
             *  -2 : 지뢰 있음
             *  -1 : 초기값
             *   n : 주변 9타일 이내의 지뢰 수 (0일 경우 ■, 양수일 경우 정수 표기)
             *   
             * mineCntBoard 상태
             *  -1 : 지뢰 있음
             *   n : 주변 9타일 이내의 지뢰 수
             *
             */

            int[,] gameboard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] playboard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] mineCntMap = new int[BOARD_SIZE_Y, BOARD_SIZE_X];

            // 지뢰 초기화
            for(int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for(int x=0; x < BOARD_SIZE_X; x++)
                {
                    gameboard[y, x] = randomMine.Next(1,100+1);
                    playboard[y, x] = -1;

                    if (gameboard[y, x] < MINE_PERCENTAGE) {
                        mineCntMap[y, x] = -1; // 게임보드에서 30%보다 작은경우 mine맵에 -1로 지뢰설정
                    }
                    // 30보다 작은 숫자는 모두 지뢰 (지뢰가 setup된 경우)
                    else
                    {
                        mineCntMap[y, x] = 0; // 지뢰가 아니면 0으로 설정
                    }// else : 지뢰가 없는 경우
                }
            } // loop : 지뢰를 초기화 하는 루프

            // 게임 시작
            while(isGameOver == false)
            {
                // { 현재 보드의 상태를 플레이 시점으로 보여준다.
                for(int y=0;y<BOARD_SIZE_Y; y++)
                {
                    for(int x=0;x<BOARD_SIZE_X; x++)
                    {
                        switch(playboard[y, x])
                        {
                            case -2:
                                Console.Write("X".PadRight(3, ' ')); // 지뢰
                                break;
                            case-1:
                                Console.Write("□".PadRight(2,' ')); // 안열린곳
                                break;
                            case 0:
                                Console.Write("■".PadRight(2, ' ')); // 0 = 열린곳
                                break;
                            default:
                                Console.Write("{0}".PadRight(5,' '), playboard[y, x]);
                                break;
                        } // switch
                    }
                    Console.WriteLine();
                }// loop : 현재 보드의 상태를 출력하는 루프
                Console.WriteLine();
                // } 현재 보드의 상태를 플레이 시점으로 보여준다.
                int playerX = 0, playerY = 0;
                bool isLocationValid = false;
                // { 플레이어 좌표 입력
                while(isLocationValid== false)
                {
                    Console.Write("[플레이어] x 좌표 입력 : ");
                    int.TryParse(Console.ReadLine(), out playerX);
                    Console.Write("[플레이어] y 좌표 입력 : ");
                    int.TryParse(Console.ReadLine(), out playerY);

                    // 플레이어가 입력한 좌표의 유효성을 검사한다.
                    isLocationValid = (0 <= playerX && playerX <= BOARD_SIZE_X) &&
                        (0 <= playerY && playerY <= BOARD_SIZE_Y);
                    if(isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 유효하지 않습니다.",
                            "다른 좌표를 입력하세요\n");
                        continue;
                    }
                  

                    // 플레이 보드에서 선택 가능한지 검사한다.
                    isLocationValid = isLocationValid && playboard[playerY, playerX].Equals(-1);
                    if(isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 이미 오픈되었습니다.",
                            "다른 좌표를 입력하세요\n");
                         continue;
                    }// if : 오픈된 좌표를 선택한 경우
                     // 좌표를 제대로 입력한 경우만 이 아래로 코드가 진행됨.
                     // 유효하지 않은 경우 위에서 continue 만나기 때문에
                } // loop
                playerTurncnt++;
                // } 플레이어 좌표 입력

                // 현재 첫 턴이라면 해당 좌표에 지뢰가 있어도 지워준다.
                if(playerTurncnt.Equals(1)) {
                    gameboard[playerY, playerX] = MINE_PERCENTAGE + 1; // 지뢰로 세지 않겠다.
                    // 첫턴에 걸리면 30보다 큰수를 넣어서 지뢰없애버림
                    mineCntMap[playerY, playerX] = 0; // 마인 맵에서 지워버리고
                    playboard[playerY, playerX] = -1;

                    // { 지뢰의 수를 세어서 지도를 생성한다.
                    for(int y=0; y < BOARD_SIZE_Y; y++)
                    {
                        for(int x=0;x<BOARD_SIZE_X; x++)
                        {
                            // 지뢰가 없는 곳은 넘어간다.
                            if (mineCntMap[y,x].Equals(-1) == false) { continue; }

                            // 지뢰 주변 9타일에 수를 1씩 추가한다.
                            bool isSearchTileValid = false;
                            for(int searchY = y-1; searchY<=y+1 ;searchY++) {
                                for (int searchX = x - 1; searchX <= x + 1; searchX++)
                                {
                                    // 유효하지 않은 좌표는 패스한다.
                                    isSearchTileValid =
                                        (0 <= searchX && searchX < BOARD_SIZE_X) &&
                                        (0 <= searchY && searchY < BOARD_SIZE_Y);
                                    if (isSearchTileValid == false) { continue; }
                                    // 9타일 서치중에 지뢰가 있다면 패스한다.
                                    if (mineCntMap[searchY, searchX].Equals(-1)) { continue; }
                                    mineCntMap[searchY, searchX]++;
                                }
                            } // loop : 지뢰 주변 9타일을 순회하는 루프
                        }
                    } // loop : 게임 보드를 순회하는 루프
                    // } 지뢰의 수를 세어서 지도를 생성한다.

                }// if : 첫턴인 경우

                //{ 선택한 좌표에서 지뢰를 검사한다.
                if (gameboard[playerY,playerX] < MINE_PERCENTAGE)
                {
                    isGameOver= true;
                    isPlayerwin= false;
                    playboard[playerY,playerX] = -2;

                }// if : 지뢰를 선택한 경우
                else
                {
                    // { 선택한 타일 인근 9칸의 숫자를 오픈한다.
                    bool isSearchTileValid = false;
                    for(int searchY= playerY-1; searchY <= playerY+1 ;searchY++) {
                        for(int searchX = playerX-1; searchX<=playerX+1 ;searchX++) {
                            // 유효하지 않은 좌표는 패스한다.
                            isSearchTileValid =
                                (0<=searchX&& searchX < BOARD_SIZE_X) &&
                                (0<=searchY&& searchY < BOARD_SIZE_Y);
                            if(isSearchTileValid == false) {continue;}
                            if (mineCntMap[searchY,searchX].Equals(-1)) {
                                playboard[searchY, searchX] = -2;
                            } // if : 지뢰인 경우
                            else
                            {
                                playboard[searchY, searchX] = mineCntMap[searchY,searchX];
                            } // else : 지뢰 아닌 경우

                        }
                    }// loop : 선택한 타일 인근 9칸을 순회하는 루프
                    // } 선택한 타일 인근 9칸의 숫자를 오픈한다.

                }// else : 지뢰 아닌 빈땅을 선택했을 경우
                //} 선택한 좌표에서 지뢰를 검사한다.

                // { 게임 승리 조건을 검사한다.
                int unknownTileCnt = 0;
                for(int y=0; y < BOARD_SIZE_Y; y++)
                {
                    if (0 < unknownTileCnt) { break; }

                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        if (0 < unknownTileCnt) { break; }
                        if (playboard[y, x].Equals(-1) && mineCntMap[y, x].Equals(-1) == false)
                        {
                            unknownTileCnt++;
                        }
                    }
                }// loop : 플레이 보드를 순회하는 루프
               
                if (unknownTileCnt.Equals(0))
                {
                    isGameOver = true;
                    isPlayerwin = true;
                }
                // } 게임 승리 조건을 검사한다.
                // { 게임 종료 조건을 검사한다.
                if(isGameOver) { break; }
                // } 게임 종료 조건을 검사한다.
                if (isDebugMode)
                {
                    // { 현재 보드의 상태를 숫자 지도로 보여준다.
                    Console.WriteLine();
                    for(int y=0; y < BOARD_SIZE_Y; y++)
                    {
                        for(int x=0;x<BOARD_SIZE_X; x++)
                        {
                            Console.Write("{0} ", mineCntMap[y,x]);
                        }
                        Console.WriteLine();
                    } // loop : 현재 보드의 상태를 출력
                    // } 현재 보드의 상태를 숫자 지도로 보여준다.

                    // { 현재 게임 보드의 상태를 보여준다
                    Console.WriteLine();
                    for( int y=0;y<BOARD_SIZE_Y; y++)
                    {
                        for(int x =0;x<BOARD_SIZE_X; x++)
                        {
                            if (gameboard[y,x] > MINE_PERCENTAGE)
                            {
                                Console.Write("# ");
                            }
                            else
                            {
                                Console.Write(". ");
                            }
                        }
                        Console.WriteLine();
                    } // loop : 현재 게임 보드의 상태를 출력하는 루프
                    Console.WriteLine();
                    // } 현재 게임 보드의 상태를 보여준다

                } // if: 디버그 모드에서 출력

            }// loop : 게임 루프

            // { 현재 보드의 상태를 플레이 시점으로 보여준다
            Console.WriteLine();
            for(int y=0;y<BOARD_SIZE_Y; y++)
            {
                for(int x=0;x<BOARD_SIZE_X; x++)
                {
                    switch (playboard[y, x])
                    {
                        case -2:
                            Console.Write("X".PadRight(3, ' '));
                            break;
                        case -1:
                            Console.Write("□".PadRight(2, ' '));
                            break;
                        case 0:
                            Console.Write("■".PadRight(2, ' '));
                            break;
                        default:
                            Console.Write("{0}".PadRight(5, ' '), playboard[y, x]);
                            break;
                    }
                   

                }
                Console.WriteLine();
            } // loop : 현재 보드의 상태를 플레이 시점으로 출력하는 루프
            Console.WriteLine();
            // } 현재 보드의 상태를 플레이 시점으로 보여준다
            if(isPlayerwin)
            {
                Console.WriteLine("[플레이어] 지뢰를 모두 찾고 승리했습니다.");
            }
            else
            {
                Console.WriteLine("[플레이어] 지뢰를 밟고 패배했습니다.");
            }

        } // Main()
    }
}
