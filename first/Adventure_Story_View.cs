using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first
{
    class View
    {
        public virtual void StartView()// 시작 뷰
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t    ■\t\t ■■■■\t■        ■\t■■■■■■\t■\t■\t■■■■\t■■■■■");
            Console.WriteLine("\t  ■  ■\t ■\t ■ \t ■      ■\t     ■\t\t■\t■\t■\t■\t■");
            Console.WriteLine("\t ■    ■\t ■\t  ■\t  ■    ■\t     ■\t\t■\t■\t■■■■\t■");
            Console.WriteLine("\t■■■■■\t ■\t  ■\t   ■  ■\t     ■\t\t■\t■\t■  ■\t\t■■■■■");
            Console.WriteLine("\t■      ■\t ■\t ■\t    ■■\t     ■\t\t■\t■\t■    ■\t■");
            Console.WriteLine("\t■      ■\t ■■■■\t     ■\t\t     ■\t\t■■■■■\t■      ■\t■■■■■");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t\t\t\t\tPress Any Button");
            Console.ReadLine();
            Console.Clear();
        }// 시작 뷰
        public void LoginView() // 로그인 뷰
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Player player = new Player();
                Console.Write("\t\t\t\t\t이름을 입력해주세요 : ");
                player.Name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t{0}가 맞습니까? ", player.Name);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\tYES = 1\t NO = 2 ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t");
                int.TryParse(Console.ReadLine(), out int name_check);
                Console.Clear();
                if (name_check == 1)
                {
                    LoadingView();
                    break;
                }
            }
            
        }// 로그인 뷰
        public async void LoadingView()
        {
            
           
            Console.WriteLine("□□□□□□");
            Thread.Sleep(2000);
            Console.Clear();
     
            Console.WriteLine("■□□□□□");
            Thread.Sleep(2000);
            Console.Clear();

        
            Console.WriteLine("■■□□□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("■■■□□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("■■■■□□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("■■■■■□");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("■■■■■■");
            Thread.Sleep(2000);
            Console.Clear();


        }

    }// class View
    class Map : View // Map표시
    {
        public override void StartView()
        {

        }
    }
    internal class Adventure_Story_View
    {
        static void Main(String [] args)
        {
            View view = new View();
            view.StartView();
            view.LoginView();
        }
        
    }
}
