using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class TrumpCard
    {
        const int StartMoney = 10000; // 시작금액
        public int TotalMoney, int_bet; // 게임을 한 뒤 총 금액, 베팅 금액
        public string FirstCard, SecondCard; // 컴퓨터가 뽑는 카드
        public int int_FirstCard, int_SecondCard; // 컴퓨터가 뽑는 카드
        public string Who, bet; // 누가뽑는지 확인, 베팅금액
        public bool Whois; // 컴퓨터가 뽑는지 플레이어가 뽑는지 구분

        /*
         * 1 ~ 10 K Q J -> 13개(하트,다이아,스페이드,클로버)
         * 13*4 -> 52개의 카드가 있음 -> 선형구조(배열)
         * 1 ~ 13  : ♥
         * 14 ~ 26 : ♠
         * 27 ~ 39 : ◆
         * 40 ~ 52 : ♣
         * 카드 뽑기 게임을 작성해서 제출
         * - 컴퓨터가 2장을 뽑아서 보여줌.
         * - 플레이어가 베팅을 함.(패스 가능)
         * - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 2배 벌어감.
         * - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 없다면 플레이어는 베팅금액을 잃음.
         * - 카드의 대, 소 비교는 오직 숫자로만
         * - 게임 종료는 100,000 포인트를 벌거나, 모두 잃을 때
         * - 플레이어는 10,000 포인트 들고 게임을 시작함.
         */

        //! 컴퓨터가 카드를 선택하는 함수
        public void ComputerPickTrump()
        {
            Whois = true; // 컴퓨터의 차례 = true, 플레이어의 차례 = false
            FirstCard = RollCard();     // 첫번째 카드 선택
            SecondCard = RollCard();    // 두번째 카드 선택
            
            int.TryParse(FirstCard, out int_FirstCard);         
            int.TryParse(SecondCard, out int_SecondCard);   // 첫번째 두번째 카드 정수화
        }

        //! 플레이어가 카드를 선택하는 함수
        public void PlayerPickTrump()
        {
            Whois = false; // 플레이어의 차례 = false
            string myCard = RollCard(); // 카드를 선택한다.
            Wincheck(myCard); // 게임에서 승리하였는지 확인하는 함수호출

        }

        // !게임에서 승리하엿는지 확인하는 함수
        // 내가 뽑은 카드가 컴퓨터가 뽑은 카드 사이에 있는지 확인한다.
        public void Wincheck(string myCard)
        {
            int.TryParse(myCard, out int int_myCard);
            if (int_FirstCard < int_SecondCard) // 컴퓨터가 뽑은 두번째 카드가 더 큰경우
            {
                if (int_FirstCard < int_myCard && int_myCard < int_SecondCard) // 카드사이에 플레이어가 뽑은 카드가 있다면
                {
                    Console.WriteLine("승리하셨습니다 축하합니다."); // 승리
                    Console.WriteLine();
                    HowManyEarn(); // 총 금액에 베팅금액을 더한다
                }
                else // 플레이어의 카드가 컴퓨터의 카드사이에 없을 경우
                {
                    Console.WriteLine("패배하셨습니다."); // 패배
                    Console.WriteLine();
                    HowManyLoose(); // 총 금액에 베팅 금액을 뺀다.
                }
            }
            else if (int_FirstCard > int_SecondCard) // 컴퓨터가 뽑은 첫번째 카드가 더 큰경우
            {
                if (int_FirstCard > int_myCard && int_myCard > int_SecondCard) // 카드사이에 플레이어가 뽑은 카드가 있다면
                {
                    Console.WriteLine("승리하셨습니다 축하합니다."); // 승리
                    Console.WriteLine();
                    HowManyEarn(); // 총 금액에 베팅금액을 더한다
                }
                else // 플레이어의 카드가 컴퓨터의 카드사이에 없을 경우
                {
                    Console.WriteLine("패배하셨습니다.");
                    Console.WriteLine();
                    HowManyLoose();

                }
            }
            else// 컴퓨터의 카드가 같을 경우 이길 방법이없다.
            {
                Console.WriteLine("패배하셨습니다.");
                Console.WriteLine();
                HowManyLoose();

            }
        }

        // 게임에서 졌을 경우 돈을 뺀다.
        // 총 금액에 베팅금액을 뺀다
        public void HowManyLoose()
        {
            TotalMoney = TotalMoney - int_bet;
            Console.WriteLine("{0}만큼 잃으셔서 남은금액은 {1} 입니다.",int_bet,TotalMoney);
        }

        // 게임에서 이겼을 경우 돈을 더한다.
        // 총 금액에 2*베팅금액을 더한다
        public void HowManyEarn()
        {
            TotalMoney = TotalMoney + 2*int_bet;
            Console.WriteLine("{0}만큼 얻으셔서 남은금액은 {1} 입니다.", 2*int_bet, TotalMoney);

        }

        // 플레이어가 베팅하는 함수
        // 플레이어가 베팅을한다.
        public void BetPlayer()
        {
            TotalMoney = StartMoney;
            while (true)
            {
                if(TotalMoney >= 100000 || TotalMoney <= 0) // 총 금액이 10만원 이상인 경우 승리 , 0원 이하일 경우 패배
                {
                    if(TotalMoney >= 100000) {
                        Console.WriteLine("★★ 게임에서 승리하셨습니다 ★★");
                    }
                    else
                    {
                        Console.WriteLine("ㅠㅠ 게임에서 패배하셨습니다 ㅠㅠ");
                    }
                    break;
                }
                ComputerPickTrump(); // 컴퓨터가 카드를 뽑는 함수 호출
                Console.WriteLine("현재 금액 : {0}", TotalMoney);
                Console.Write("베팅금액을 알려주세요 : ");
                bet = Console.ReadLine(); // 베팅금액 입력
                Console.WriteLine();

                if (bet.Equals("pass")){ // pass를 입력할 경우 넘어간다.
                    Console.WriteLine("넘어가겠습니다.");
                }
                else // pass가 아닌경우
                {
                    bool flag = int.TryParse(bet, out int_bet); 
                    if(0 <= int_bet && int_bet <= TotalMoney && flag == true) // 금액이 적당한 경우
                    {
                        PlayerPickTrump(); // 플레이어가 카드를 뽑는다.
                    }
                    else if (int_bet < 0 || int_bet > TotalMoney && flag == true) // 돈이 이상한 경우
                    {
                        Console.WriteLine("그 정도 돈은 없으신데요"); // 돈이 없다는 출력
                    }
                    else // 잘못입력했을 경우
                    {
                        Console.WriteLine("잘못입력하셨습니다.");
                    }

                }
                Console.ReadLine();
                Console.Clear();

            }
        }
        private int[] trumpCardSet;         // 내가 사용할 카드 세트뭉치
        private string[] trumpCardSetMark;  // 트럼프 카드의 마크
        private void PrintCardSet()
        {
            foreach (int card in trumpCardSet)
            {
                Console.Write("{0} ", card);
            }
            Console.WriteLine();
        }// PrintCardSet()
        private int[] ShuffleOnce(int[] intArray) // 카드를 한번 섞는 메서드
        {
            Random random = new Random();
            int soutindex = random.Next(0, intArray.Length);
            int destindex = random.Next(0, intArray.Length);

            int temp = intArray[soutindex];
            intArray[soutindex] = intArray[destindex];
            intArray[destindex] = temp;
            return intArray;
        }// ShuffleOnce()
        //! 셔플 하고서 카드를 한 장 뽑아서 출력하는 함수
        public void ReRollCard()
        {
            ShuffleCards();
            RollCard();
        }
        //! 셔플 하고서 카드를 한 장 뽑아서 출력하는 함수

        //! 한장의 카드를 뽑아서 보여주는 함수
        public string RollCard()
        {
            ShuffleCards();
            int card = trumpCardSet[0];
            string cardMark = trumpCardSetMark[(card-1) / 13];
            string cardNumber = Math.Ceiling(card % (13.1)).ToString();

            switch (cardNumber)
            {
                case "11": cardNumber = "J";
                    break;
                case "12": cardNumber = "Q";
                    break;
                case "13": cardNumber = "K";
                    break;
                default:
                    /* Do Nothing */
                    break;
            }
            if(Whois == true)
            {
                Who = "컴퓨터";
            }
            else
            {
                Who = "플레이어";
            }
            Console.WriteLine("{0}가 뽑은 카드는 {1}{2} 입니다.", Who ,cardMark, cardNumber);
            Console.WriteLine(" ----");            
            Console.WriteLine("|{0} {1}|",cardMark,cardNumber);
            Console.WriteLine("|    |");
            Console.WriteLine("|{0} {1}|",cardNumber,cardMark);
            Console.WriteLine(" ----");
            switch (cardNumber)
            {
                case "J":
                    cardNumber = "11";
                    break;
                case "Q":
                    cardNumber = "12";
                    break;
                case "K":
                    cardNumber = "13";
                    break;
                default:
                    /* Do Nothing */
                    break;
            }
            return cardNumber;

        }
        //! 한장의 카드를 뽑아서 보여주는 함수


        //! 카드를 섞는 함수
        public void ShuffleCards()
        {
            ShuffleCards(200);
        }
        //! 카드를 섞는 함수
        public void ShuffleCards(int howManyLoop)
        {
            for(int i=0;i<howManyLoop; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);

            }
        }// ShuffleCards()    
        public void SetupTrumpCards()
        {
            trumpCardSet = new int[52];
            for(int i=0;i<trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i+1;
                
            }// loop : 카드를 셋업하는 루프
            // 트럼프 카드의 마크를 셋업
            trumpCardSetMark = new string[4] { "♥", "♠", "◆", "♣" };
        }// SetupTrumpCards()
      
    }
}
