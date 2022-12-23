using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Adventure_Story
    {
        public string[] monster_name = new string[5] { "토끼", "늑대", "곰", "고블린", "드래곤" };
        public string[] weapon_name = new string[5] { "나무검", "돌검", "구리검", "철검", "은검" };
        public string[] armor_name = new string[5] { "나무갑옷", "돌 갑옷", "구리 갑옷", "철 갑옷", "은 갑옷" };

        public int[,] monster_stats = new int[5,4];

        

        struct user
        {
           public int HP;
           public int stamina;
           public int attack;
           public int defence;
        }


        // 몬스터의 스탯을 랜덤으로 배정한다.
        // 상위 몬스터가 하위 몬스터보다 강하게 설정한다.
        void monster_random()
        {
            for(int i=0;i<5; i++)
            {
                for(int j=0;j<4; j++)
                {
                    Random random= new Random();
                    int a = i * 10;
                    int b = (i * 10) + 10 - (j * 2);
                    monster_stats[i,j] = random.Next(a,b);     
                }
                
            }
        }

        // 타이틀 화면
        void reference_title()
        {
            Console.WriteLine("**********************************************");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("");

            }
            Console.WriteLine("***************** 랜덤 모험 ******************");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("");

            }
            Console.WriteLine("\t\tPress Any Burton");
            Console.WriteLine("**********************************************");

            Console.ReadLine();
        }
        
       
        // 도망을 선택했을때
        void run_monster(int HP, int stamina, int attack, int defence)
        {
            Random run_random = new Random();
            int run = run_random.Next(1,101);
            if(run <= 50)
            {
                Console.WriteLine("도망치지 못하였습니다.");
                battle_monster(HP,stamina,attack,defence);
            }
            else
            {
                Console.WriteLine("도망에 성공하셨습니다.");
            }
        }

        // 몬스터와 싸울때
        void battle_monster(int HP, int stamina, int attack, int defence)
        {
            monster_random(); // 전역변수에 몬스터 개체와 특성

            Random random = new Random();
            int sm = random.Next(0, 5);
            int[,] selected_monster = new int[5,4];

            for (int i = 0; i < 4; i++)
            {
                selected_monster[sm,i] = monster_stats[sm,i]; // 몬스터 스텟을 저장해놓고
            }
            Console.WriteLine("***************{0}을 만났습니다!***************", monster_name[sm]);

            while (true)
            {

                // 0 : hp, 1 : stamina, 2 : attack, 3 : defence

                Console.WriteLine("***************행동을 선택해 주세요***************");
                Console.WriteLine("************ 1. 공격한다 2. 방어한다 ****************");
                Console.WriteLine("");
                int.TryParse(Console.ReadLine(), out int activate);
                if (activate == 1)
                {
                    Console.WriteLine("***************나의 HP : {0}***************", HP);
                    Console.WriteLine("***************{0}의 HP : {1}***************", monster_name[sm], monster_stats[sm,0]);
                    Console.WriteLine("***************나의 공격력 : {0}***************", attack);
                    Console.WriteLine("***************{0}의 공격력 : {1}***************", monster_name[sm], monster_stats[sm, 2]);


                    Console.WriteLine("★★★★★★ 나의 공격! ★★★★★★");
                    if (monster_stats[sm,3] >= attack) // 고블린의 방어력이 내 공격보다 높다면
                    {
                        monster_stats[sm,0]--;

                    }
                    else
                    {
                        monster_stats[sm,0] = monster_stats[sm,0] - attack + monster_stats[sm,3];


                    }
                    Console.WriteLine("나의 남은 HP : {0}", HP);
                    Console.WriteLine("{0}의 남은 HP : {1}", monster_name[sm], monster_stats[sm,0]);

                    Console.WriteLine("★★★★★★ {0}의 공격! ★★★★★★", monster_name[sm]);
                    if (monster_stats[sm,2] <= defence)
                    {
                        HP--;
                    }
                    else
                    {
                        HP = HP - monster_stats[sm,2] + defence;
                    }
                    Console.WriteLine("나의 남은 HP : {0}", HP);
                    Console.WriteLine("{0}의 남은 HP : {1}", monster_name[sm], monster_stats[sm,0]);
                    Console.ReadLine();

                }

                else if (activate == 2)
                {
                    Console.WriteLine("***************{0}의 공격을 막았습니다.***************", monster_name[sm]);
                }
                else
                {
                    Console.WriteLine("***************잘못입력하셨습니다. 다시 입력해 주세요***************");

                }

                if (HP <= 0)
                {
                    Console.WriteLine("***************죽었습니다***************");
                    break;
                }
                else if (monster_stats[sm,0] <= 0)
                {
                    Console.WriteLine("***************승리하셨습니다***************");

                    break;
                }
            }
            Console.WriteLine("");



        }

        // 몬스터와 만났을 때
        void meet_monster(int HP, int stamina, int attack, int defence)
        {
            Console.WriteLine("*************** 몬스터를 만났습니다! ***************");
            Console.WriteLine("   ( 몬스터 종류, 스탯은 모두 랜덤 입니다 )");

            Console.WriteLine("\t\t행동을 결정해 주세요");
            Console.WriteLine("");

            Console.WriteLine("\t1. 싸운다\t 2. 도망간다");
            int.TryParse(Console.ReadLine(), out int activate);
            if(activate == 1)
            {
                battle_monster(HP,stamina, attack, defence);
            }
            else if(activate == 2)
            {
                run_monster(HP, stamina,attack,defence);
            }
            else
            {
                Console.WriteLine("\t잘못입력하셨습니다. 다시 입력해 주세요");
            }
        }

        static void Main(string[] args)
        {

            var ms = new Adventure_Story();
            ms.reference_title();
            Console.Write("\t   이름을 입력해 주세요 : ");
            string name = Console.ReadLine();

            Console.Write("\t 능력치는 랜덤으로 분배 합니다.");
            Console.WriteLine();
            Random random = new Random();

            user player;
            player.HP = random.Next(1, 100 + 1);
            player.stamina = random.Next(1, 100 + 1);
            player.attack = random.Next(1, 15 + 1);
            player.defence = random.Next(1, 15 + 1);

            Console.WriteLine("**********************************************");
            Console.WriteLine("이름\t : {0}", name);
            Console.WriteLine("체력\t : {0}", player.HP);
            Console.WriteLine("스태미나 : {0}", player.stamina);
            Console.WriteLine("공격력\t : {0}", player.attack);
            Console.WriteLine("방어력\t : {0}", player.defence);
            Console.WriteLine("**********************************************");
            

            Console.WriteLine("") ;

            Console.WriteLine("메인 퀘스트 : ") ;
            Console.WriteLine("랜덤마을의 랜덤용사여 랜덤마왕을 무찌르고 랜덤공주를 구출하라!");
            Console.WriteLine("");


            Console.WriteLine("랜덤 용사가 선택마을에 도착하였다") ;
            Console.WriteLine("??? : 용사님 저희마을을 괴롭히고 있는 몬스터를 혼내주세요");
            Console.WriteLine("***************1. 수락한다 2. 거절한다***************");
            
            string[] weapon_name = new string[5] { "나무검", "돌검", "구리검", "철검", "은검" };
            string[] armor_name = new string[5] { "나무갑옷", "돌 갑옷", "구리 갑옷", "철 갑옷", "은 갑옷" };
            int[] weapon_stats = new int[5] { 5, 10, 15, 20, 25 };
            int[] armor_stats = new int[5] { 5, 10, 15, 20, 25 };
            
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int message);
                if (message == 1)
                {
                    Console.WriteLine("네 저 랜덤용사가 몬스터를 무찌르겠습니다!");
                    Console.ReadLine();

                    Console.WriteLine("(랜덤)보상을 받았습니다.");
                    Random random1 = new Random();
                    int take = random1.Next(0, 4 + 1);
                    Console.WriteLine("{0}을 받았습니다", weapon_name[take]);
                    Console.WriteLine("공격력이 {0} 만큼 올랐습니다.", weapon_stats[take]);
                    player.attack = player.attack + weapon_stats[take];
                    break;

                }
                else if (message == 2)
                {
                    Console.WriteLine("싫은데요");
                    Console.ReadLine();

                    Console.WriteLine("보상을 받지 못했습니다.");
                    Console.WriteLine("스태미너가 {0}만큼 내려갔습니다.", 5);
                    player.stamina = player.stamina - 5;
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력 하셨습니다.");
                    Console.WriteLine("다시 입력해 주세요");
                }
            }
         
            Console.ReadLine();
            ms.meet_monster(player.HP, player.stamina, player.attack, player.defence); // 몬스터 만나는 함수
           

            //Console.Write("")

        }
    }
}
