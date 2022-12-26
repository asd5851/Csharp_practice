using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace first
{
    internal class Program7
    {
        enum TicTacToePlayerType
        {
            None = 0, PLAYER, COMPUTER
        }
        static void Main(string[] args)
        {


            /*
             * tic-tac-toe 게임
             * 컴퓨터와 사람이 번갈아 가면서 o,x를 둔다
             * 보드 크기는 3x3
             * 컴퓨터의 룰은 간단하게
             * 1. 중앙이 비었으면 중앙을 선점 하려고함
             * 2. 이후에 빈자리 아무곳이나 적당히 찾아서 푼다.
             */
            int[,] GAMEBOARD = new int[3, 3];
            int playerX, playerY = 0;
            bool isValidLocation = false;
            bool isPlayerturn = false;
            bool isGameover = false;

            string playerIcon = string.Empty;
            string playerType = string.Empty;
            while (isGameover == false)
            {
                isPlayerturn = true;
                playerType = "[플레이어]";
                playerX = 0;
                playerY = 0;
                isValidLocation = false;

                while (true)
                {
                    if (isValidLocation == true)
                    {
                        break;
                    }
                    Console.Write("[플레이어] (x) 좌표 : ");
                    int.TryParse(Console.ReadLine(), out playerX);
                    Console.Write("[플레이어] (y) 좌표" +
                        " : ");
                    int.TryParse(Console.ReadLine(), out playerY);

                    // enum쓰는 이유 이해하기쉬우니까 -> 가독
                    // 성, 코드보기
                    // 보드가 빈 곳인 경우
                    if (GAMEBOARD[playerY, playerX].Equals((int)TicTacToePlayerType.None))
                    {
                        GAMEBOARD[playerY, playerX] = (int)(TicTacToePlayerType.PLAYER);
                    }
                    // 보드가 빈 곳이 아닌경우
                    else
                    {
                        Console.WriteLine("[System] 해당 좌표는 비어있지 않습니다. / 다른 좌표를 입력하세요 : ");
                        isValidLocation = false;
                    }



                    // 플레이어에게 좌표를 입력받는다.
                    // 플레이어의 턴 진행을 보드에 출력한다.
                    for (int y = 0; y <= GAMEBOARD.GetUpperBound(0); y++)
                    {
                        Console.WriteLine("---|---|---");
                        for (int x = 0; x <= GAMEBOARD.GetUpperBound(1); x++)
                        {
                            switch (GAMEBOARD[y, x])
                            {
                                case (int)TicTacToePlayerType.PLAYER:
                                    playerIcon = "O";
                                    break;
                                case (int)TicTacToePlayerType.COMPUTER:
                                    playerIcon = "X";
                                    break;
                                default:
                                    playerIcon = " ";
                                    break;

                            }
                            Console.Write(" {0} ", playerIcon);

                            if (x == GAMEBOARD.GetUpperBound(1)) { /* Do Nothing */}
                            else
                            { Console.Write("|"); }


                        }// loop : 한 줄에서 출력할 내용을 연산한다.
                        Console.WriteLine();
                    }// loop
                    Console.WriteLine("---|---|---");

                    Console.WriteLine();
                    isGameover = false;
                    for (int y = 0; y <= GAMEBOARD.GetUpperBound(0); y++)
                    {
                        if (GAMEBOARD[y, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                            GAMEBOARD[y, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                            GAMEBOARD[y, 2].Equals((int)TicTacToePlayerType.PLAYER))
                        {
                            isGameover = true;

                        }
                        else
                        {
                            continue;
                        }
                    } // loop : 가로 방향으로 검사하는 루프
                    for (int x = 0; x <= GAMEBOARD.GetUpperBound(1); x++)
                    {
                        if (GAMEBOARD[0, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                            GAMEBOARD[1, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                            GAMEBOARD[2, x].Equals((int)TicTacToePlayerType.PLAYER))
                        {
                            isGameover = true;
                        }
                        else
                        {
                            continue;
                        }

                    } // loop : 세로 방향으로 검사하는 루프

                    // 대각선 방향으로 검사
                    if (GAMEBOARD[0, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                        GAMEBOARD[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                        GAMEBOARD[2, 2].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameover = true;
                    }
                    if (GAMEBOARD[0, 2].Equals((int)TicTacToePlayerType.PLAYER) &&
                       GAMEBOARD[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                       GAMEBOARD[2, 0].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameover = true;
                    }
                    if (isGameover)
                    {
                        break;
                    }

                    isPlayerturn = false;
                    playerType = "[컴퓨터]";
                    bool isComputerDoing = false;
                    Console.WriteLine("{0}의 턴", playerType);

                    //컴퓨터는 간단한 룰
                    //{ 1. 중앙이 비어있으면 선점
                    if (isComputerDoing == false)
                    {
                        if (GAMEBOARD[1, 1].Equals((int)TicTacToePlayerType.None))
                        {
                            GAMEBOARD[1, 1] = (int)TicTacToePlayerType.COMPUTER;
                            isComputerDoing = true;
                        }// if: 중앙이 비어있는 경우
                        else
                        {/* Do Nothing */}
                    } // if:컴퓨터가 아직 아무것도 하지 않은 경우
                    else
                    {/* Do Nothing */}
                    // } 1. 중앙이 비어있으면 선점

                    // { 2. 적당히 빈자리 찾아서 착수
                    if (isComputerDoing == false)
                    {
                        for (int y = 0; y <= GAMEBOARD.GetUpperBound(0); y++)
                        {
                            for (int x = 0; x <= GAMEBOARD.GetUpperBound(1); x++)
                            {
                                if (isComputerDoing == false &&
                                    GAMEBOARD[y, x].Equals((int)TicTacToePlayerType.None))
                                {
                                    GAMEBOARD[y, x] = (int)TicTacToePlayerType.COMPUTER;
                                    isComputerDoing = true;
                                    break;
                                } // if : 서치한 자리가 비어있는 경우
                                else
                                { continue; }

                            }// loop : search horizontal
                        } // loop : search vertical
                    } // if : 컴퓨터가 아직 아무것도 하지 않은 경우
                    else {/*Do Nothing*/ };
                    //} 2. 적당히 빈 자리 찾아서 착수

                    // { 컴퓨터의 턴 진행을 보드에 출력한다.
                    for (int y = 0; y <= GAMEBOARD.GetUpperBound(0); y++)
                    {
                        Console.WriteLine("---|---|---");
                        for (int x = 0; x <= GAMEBOARD.GetUpperBound(1); x++)
                        {
                            switch (GAMEBOARD[y, x])
                            {
                                case (int)TicTacToePlayerType.PLAYER:
                                    playerIcon = "O";
                                    break;
                                case (int)TicTacToePlayerType.COMPUTER:
                                    playerIcon = "X";
                                    break;
                                default:
                                    playerIcon = " ";
                                    break;
                                    //swich
                            }
                            Console.Write(" {0} ", playerIcon);
                            if (x == GAMEBOARD.GetUpperBound(1))
                            {/*Do nothing*/ }
                            else
                            { Console.Write("|"); }
                        }// loop : 한 줄에서 출력할 내용을 연산한다.
                        Console.WriteLine();
                    } // loop
                    Console.WriteLine("---|---|---");
                    // } 컴퓨터의 턴 진행을 보드에 출력한다.

                    // {게임이 끝났는지 보드검사
                    Console.WriteLine();
                    isGameover = false;
                    for (int y = 0; y <= GAMEBOARD.GetUpperBound(0); y++)
                    {
                        if (GAMEBOARD[y, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                           GAMEBOARD[y, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                            GAMEBOARD[y, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                        {
                            isGameover = true;
                        }
                        else { continue; }
                    }// loop : 가로방향으로 검사

                    for (int x = 0; x <= GAMEBOARD.GetUpperBound(1); x++)
                    {
                        if (GAMEBOARD[0, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                           GAMEBOARD[1, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                            GAMEBOARD[2, x].Equals((int)TicTacToePlayerType.COMPUTER))
                        {
                            isGameover = true;
                        }
                        else
                        { continue; }
                    } // loop : 세로방향으로 검사

                    if (GAMEBOARD[0, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        GAMEBOARD[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        GAMEBOARD[2, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameover = true;
                    }
                    if (GAMEBOARD[0, 2].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        GAMEBOARD[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        GAMEBOARD[2, 0].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameover = true;
                    }

                    // 대각선 방향으로 검사
                    // }게임이 끝났는지 보드검사
                    if (isGameover == true)
                        break;
                    // 누가이겼는지 출력
                    
                }
                Console.WriteLine("{0}의 승리!", playerIcon);


            }


        }// 플레이어의 턴 진행을 보드에 출력한다.

    }
}

/*
 * git fetch -p : 깃 기능중에 패치를 받아오는 기능 -> 깃에서 기록한 변경사항을 내려받아서
 * 어떤 것이 변경된 것인지 확인할 수 있도록 하는 기능
 * 
 * git pull origin  main :
 * git pull [원격리포지토리이름]
 * pull 이라는 기능은 push와는 반대의 기능
 * 내 로컬 리포지토리를 원격 리포지토리의 내용으로 덮어 쓰는 기능(원격 -> 로컬)
 * 
 * git push
 * 원격 리포지토리의 내용을 로컬 리포지토리로 덮어쓴다.
 * 
 *  git fetch
 *  git pull
 *  무슨 패치내용인지 확인한 다음에 내 컴퓨터에 깃의 내용을 덮어쓴다.
 * 
 * clone vs pull
 * clone은 리포지토리를 통쨰로 다운받는 개념 (새롭게 다운로드)
 * pull은 내가 로컬로 작업하고있는 프로젝트와의 병합을 위해서 수행 (업데이트)
 */