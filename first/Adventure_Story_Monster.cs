using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace first
{
    internal class Adventure_Story_Monster
    {
    }
    class Player // 플레이어 정보를 담은 클래스 이름,레벨 등등
    {
        public string name = "키베이루";
        public int level = 1;
        public int hp = 100;
        public int damage = 10;
        public int defence = 1;
        public int experience = 0;
        public int experience_limit = 100;
        public string []inventory = new string[5]; // 인벤토리의 크기는 5

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Level { get { return this.level;} private set { this.level = value; } }
        public int HP { get { return this.hp;} private set { this.hp= value; } }
        public int Damage { get { return this.damage; } private set { this.damage= value; } }
        public int Defence { get { return this.defence; } private set { this.defence= value; } }
        public int Experience { get { return this.experience; } private set { this.experience= value; } }
        public int Experience_limit { get { return this.experience_limit; } private set { this.experience_limit = value;} }
        public void LevelUP() { // 몬스터를 사냥하다가 경험치를 다채웠을떄 레벨업 함수
            this.experience_limit = this.experience_limit + this.level * 20; // 레벨업을 하면 그 다음 레벨에 필요한 경험치한계가 올라간다.
            this.level = this.level + 1; // 레벨업하면 레벨 추가
            this.damage = this.damage + 2; // 레벨업하면 데미지 추가
            this.defence = this.defence + 1; // 레벨업 하면 방어추가
            this.hp= this.hp + 20;
            this.experience = 0;
            Console.WriteLine("*********레벨업!**********");
            Console.WriteLine("현재 레벨 : {0}", this.Level);
            Console.WriteLine("현재 공격력 : {0}, 현재 방어력 : {1}", this.damage, this.defence);
            Console.WriteLine("현재 체력 {0}", this.hp);
            Console.WriteLine();

        }
        public void Dead() // 죽었을때, 경험치가 감소한다.
        {
            if(this.experience > this.experience - this.level * 10)
            {
                this.experience = this.experience - this.level * 10;
            }
            Console.WriteLine("{0}만큼의 경험치가 감소하였습니다.", this.level*10);
            Console.WriteLine("현재 경험치 : {0}",this.experience);
        }
    }
    class Monster // 몬스터의 정보를 담은 클래스 이름, 체력, 데미지, 방어, 레벨, 드랍아이템
    {
        public string name;
        public int hp;
        public int damage;
        public int defence;
        public int level;
        public string []dropitem = new string[2];

        public string Name { get { return this.name; } private set { this.name = value; } }
        public int Level { get { return this.level; } private set { this.level = value; } }
        public int HP { get { return this.hp; } private set { this.hp = value; } }
        public int Damage { get { return this.damage; } private set { this.damage = value; } }
        public int Defence { get { return this.defence; } private set { this.defence = value; } }
        public string[] Dropitem { get { return this.dropitem;}private set { this.dropitem = value; } }
    }
    class GreenSlime : Monster // 몬스터의 하위 클래스( 초록슬라임)
    {
        public GreenSlime()
        {
            this.name = "초록 슬라임";
            this.level = 1;
            this.hp = 50;
            this.damage = 5;
            this.defence = 1;
            this.dropitem[0] = "물컹물컹한 액체";
            this.dropitem[1] = "수액";
        }
    }
    class BlueSlime : Monster // 몬스터의 하위 클래스(파랑슬라임)
    {
        public BlueSlime()
        {
            
            this.name = "파랑 슬라임";
            this.level = 2;
            this.hp = 70;
            this.damage = 5;
            this.defence = 1;
            this.dropitem[0] = "물컹물컹한 액체";
            this.dropitem[1] = "수액";


        }

    }
    
    class Wolf : Monster// 몬스터의 하위 클래스(늑대)
    {
        public Wolf()
        {
            this.name = "하얀 늑대";
            this.level = 5;
            this.hp = 200;
            this.damage = 10;
            this.defence = 2;
            this.dropitem[0] = "하얀늑대의 이빨";
            this.dropitem[1] = "하얀늑대의 가죽";


        }
    }
    class Dragon : Monster// 몬스터의 하위 클래스(드래곤)
    {
        public Dragon()
        {
            this.name = "붉은 용";
            this.level = 20;
            this.hp = 1000;
            this.damage = 100;
            this.defence = 20;
            this.dropitem[0] = "붉은 용의 이빨";
            this.dropitem[1] = "붉은 용의 가죽";


        }
    }
}
