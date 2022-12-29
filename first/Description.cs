using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Description
    { 
        public static void inventory_check(Player player, Monster monster) // 몬스터를 잡았을때 아이템을 얻는 함수
        {
            Console.WriteLine();
            Random random = new Random();
            int drop_num = random.Next(0, 1 + 1); // 드랍 아이템은 랜덤으로 한다.
            
            bool item_flag = true; // 아이템이 가득찼을때 false로 바뀐다.
            for (int i = 0; i < 5; i++)
            {
                if (player.inventory[i] == null)
                {
                    Console.WriteLine("{0}을 얻었습니다.", monster.dropitem[drop_num]);
                    player.inventory[i] = monster.dropitem[drop_num];
                    item_flag = true;
                    break;
                }
                else
                {
                    item_flag = false;
                }
            }
            if (item_flag == false)
            {
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }
        }
        public static void inventory_view(Player player) // 플레이어의 인벤토리를 보여주는 함수
        {
            Console.WriteLine("==========인벤토리==========");
            Console.WriteLine();

            for (int i = 0; i< 5; i++){ // 플레이어의 인벤토리를 0부터 돌면서 보여준다.
                Console.WriteLine("{0}", player.inventory[i]);
            }
            Console.WriteLine("==========인벤토리==========");
            Console.WriteLine();


        }
        // 몬스터와의 전투가 끝난 후에 경험치를 획득하거나 레벨업을 하는 함수
        public static void battle_After(Player player, Monster monster, Player player_init, Monster moster_init)
        {
            // 전투가 끝나고 플레이어의 체력이 남았을때
            if (player.hp > 0)
            {
                monster.hp = moster_init.hp; // 몬스터의 체력 초기화
                player.experience += monster.level * 20; // 플레이어의 경험치 증가.
                Console.WriteLine("승리하셨습니다.");
                inventory_check(player, monster); // 인벤토리를 체크한다.
                Console.WriteLine("{0}의 경험치를 획득 했습니다", monster.level * 20);
                Console.WriteLine();

                // 플레이어의 경험치가 한계를 넘었을 경우 레벨업
                if (player.experience >= player.experience_limit)
                {
                    HP_Reset(player, player_init); // 레벨업을 했을 경우 체력이 찬다.
                    player.LevelUP(); // 플레이어 레벨업 함수를 불러온다.
                    player_init.hp = player.hp; // 플레이어의 
                }
                else
                {
                    Console.WriteLine("현재 경험치 : {0}", player.experience);
                    Console.WriteLine("남은 경험치 : {0}", player.experience_limit - player.experience);
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("YOU DIED");
                Console.WriteLine();

                player.Dead();
            }
        }
        //플레이어의 체력을 리셋하는 함수
        public static void HP_Reset(Player player, Player player_init)
        {
            player.hp = player_init.hp;
        }

        // 플레이어와 몬스터가 전투하는 함수
        public static void battle(Player player, Monster monster, Player player_init, Monster moster_init)
        {
            inventory_view(player); // 인벤토리를 보여준다.
            // loop : 플레이어와 몬스터 둘중하나가 죽을때까지 루프를 돌린다.
            while(player.hp >= 0 && monster.hp >= 0)
            {
                Console.WriteLine("플레이어의 공격!");
                Console.WriteLine("[{0}]가 [{1}]를 {2}의 공격력으로 공격했다"
                    , player.name, monster.name, player.damage);
                player.hp = player.hp + player.defence - monster.damage;
                Console.WriteLine("플레이어의 남은 생명력 : {0}", player.hp);
                Console.WriteLine();
                Console.WriteLine("몬스터의 공격!");
                Console.WriteLine("[{0}]가 [{1}]를 {2}의 공격력으로 공격했다"
                    , monster.name, player.name, monster.damage);
                monster.hp = monster.hp + monster.defence - player.damage;
                Console.WriteLine("몬스터의 남은 생명력 : {0}", monster.hp);
                Console.WriteLine();
                Console.ReadLine();

            }
            battle_After(player, monster, player_init, moster_init); // 전투가 끝나면
            // 보상페이지


        }
        // 메인
        public static void Main(string[] args)
        {
            Player player = new Player();
            Player player_init = new Player();
            BlueSlime bs = new BlueSlime();
            BlueSlime bs_init= new BlueSlime();
            Wolf wolf = new Wolf();
            Wolf wolf_init = new Wolf();

            battle(player, bs, player_init, bs_init);
            Console.ReadLine();
            battle(player, bs, player_init, bs_init);            
            Console.ReadLine();
            battle(player, bs, player_init, bs_init);
            Console.ReadLine();
            battle(player, wolf, player_init, wolf_init);
            Console.ReadLine();
            Console.WriteLine(player.hp);
            Console.WriteLine(bs.hp);
        }

    }
    
   
}
