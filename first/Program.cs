
using System; // system에서 땡겨오고 있다. -> 속성에서 암시적
 using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int word;
            //string wword = Console.ReadLine();
            //word = Convert.ToInt32(wword); // Toint32 - 4바이트짜리, Toint64 - 8바이트짜리
            //Console.WriteLine(word);

            string stringBinary = Convert.ToString(10,8); // 10을 이진수 형태로 string으로 저장
            Console.WriteLine(stringBinary);

            int intBinary = Convert.ToInt32("1111",8); // 0111를 이진수형태로 int형으로 저장
            // Int32 = int와 같다. (4바이트)
            // Int64 = 8바이트
            Console.WriteLine(intBinary);

            int value = 0;
            value = -8;
            value = +value;
            Console.WriteLine(value);

            //삼항 연산자
            int PLUS_FIVE = 5;
            string compareTen = (PLUS_FIVE > 10) ? "{0}은 10보다 크다" : "{0}은 10 보다 크지 않다.";
            Console.WriteLine(compareTen,PLUS_FIVE);

            //변환 연산자
            //() 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
            const int PI_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.141592;
            Console.WriteLine("{0}, {1}",PI_INT, PI_FLOAT);

            Console.WriteLine("string " + "plus " + "string");
            /*
            리터널 : 데이터 그 자체 변수에저장하는 변하지 않는 데이터
            값타입 참조타입 나뉨 / 값타입은 무거운연산
            리터널은 값타입으로 연산 -> 메모리에 공간을 만들고 그 안에서 연산함
            대입한 순간 메모리는 소멸하므로 0이된다.
            */
            int number = 0;
            number = number++;
            Console.WriteLine(number);

            /*
             * 관계형 연산자
             * 관계형 연산자(Relational operator) 또는 비교 연산자(Comparative oparator)는 두 항이 큰지, 작은지
             * 또는 같은지 등을 비교하는데 사용한다. 관계형 연산자의 결과값은 논리 데이터 형식인 참또는 거짓으로 출력
             * ex) <, <=, >, >=, ==, !=
             */
            bool isBigger = false;
            isBigger = (5 < 10) || (5 == 10);
            Console.WriteLine(isBigger);

            int a = 10;
            int b = 0;
            b = a & 0b0010; // 비트 연산으로 계산 1010 & 0010 = 0010
            Console.WriteLine("a가 0010 상태를 가지고 있나요? -> {0}", b);

            b = 0;
            b = a << 1; // 1010(10) -> 0001 0100(20)
            Console.WriteLine(b);
            b = 0;
            b = a >> 1; // 1010(10) -> 0101(5)
            Console.WriteLine(b);

            /*
             * 논리 연산자
             * 논리 연산자(Logical operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을
             * 수행한다. 연산의 결과값은 참또는 거짓의 BOOL 형식으로 반환되어 Boolean 연산자라고도 한다.
             * ex) &&, ||, !
             */

            /*
             * 비트 연산자
             * 비트 연산자(Bit operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용된다.
             * ex) &, |, ^, ~
             */

            /*
             * 
             * 시프트 연산자
             * 시프트 연산자(Shift operator)는 정수 데이터가 담겨있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한
             * 비트만큼 이동시킨다.  ex)  << , >> 
             * */

            /*
             * 
             * 조건 연산자
             * 조건 연산자(Conditional operator)는 조건에 따라서 참일 때와 거짓일 때의 결과를 다르게 반환하며,
             * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자 이다. if~else문의 축약형
             * 
             */

            /*
             * sizeof 연산자
             * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
             * sizeof는 운영체제와 cpu 아키텍쳐의 종류에따라 결과값이 다르게 나올 수 있다.
             * */
            
            int t = 1;
            t = sizeof(int);
            Console.WriteLine(sizeof(Int64));
            /*
             * 연산자 우선순위
             * 연산자 여러 개를 함께 사용할 때는 연산자 우선순위(Precedence)에 따라 계산된다.
             * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습하는게 좋다.
             */


            //Console.Write("주어 = ");
            //string subject = Console.ReadLine();
            //Console.Write("동사 = ");
            //string verb = Console.ReadLine();
            //Console.Write("목적어 = ");
            //string obj = Console.ReadLine();
            //Console.WriteLine("{0} {1} a {2}", subject, verb, obj);

            //Console.Write("나이 = ");
            //string age = Console.ReadLine();
            //int.TryParse(age,out number);
            //Console.WriteLine("십년후에는 = {0}이 됩니다.", number+10);

            //int first_num = default;
            //int second_num = default;
            //Console.Write("첫 번째 변 = ");
            //string fir = Console.ReadLine();
            //int.TryParse(fir,out first_num);
            //Console.Write("두 번째 변 = ");
            //string sec = Console.ReadLine();
            //int.TryParse(sec, out second_num);

            //Console.Write("빗변 길이 =  {0}", Math.Sqrt(first_num *first_num +second_num *second_num));
            

            // { 사용자의 입력을 받는 입력부 / dy.Kive / 2022.12.19 -> 이런식으로 주석달자!
            //Console.Write("상자의 길이 : ");
            //string length = Console.ReadLine();
            //int length_n = default;
            //int.TryParse(length, out length_n);

            //Console.Write("상자의 너비 : ");
            //int wide_n = default;
            //string wide = Console.ReadLine();
            //int.TryParse(wide, out wide_n);

            //Console.Write("상자의 높이 : ");
            //int height_n = default;
            //string height = Console.ReadLine();
            //int.TryParse(height, out height_n);
            //// } 

            //Console.WriteLine("상자의 부피 : {0}",length_n*wide_n*height_n);
            //Console.WriteLine("상자의 표면적 : {0}", (length_n *wide_n)*2+(wide_n*height_n)*2+(height_n*length_n)*2) ;

            //Console.Write("평 : ");
            //string pyung = Console.ReadLine();
            //int pyung_n = default;
            //int.TryParse(pyung, out pyung_n);
            //Console.WriteLine("평방미터 : {0}",pyung_n*3.3058);

            //Console.Write("시 : ");
            //string hour = Console.ReadLine();
            //int hour_n = default;
            //int.TryParse(hour, out hour_n);

            //Console.Write("분 : ");
            //string minute=Console.ReadLine();
            //int minute_n = default;
            //int.TryParse (minute, out minute_n);
            //Console.Write("초 : ");

            //string second=Console.ReadLine();
            //int second_n = default;
            //int.TryParse (second, out second_n);
            //Console.WriteLine("전체 초 : {0}",hour_n*3600+minute_n*60+second_n);




            //Console.Write("퀴즈\t#1\t 성적 : ");
            //string quiz1 = Console.ReadLine();
            //int quiz1_n = default;
            //int.TryParse(quiz1, out quiz1_n);

            //Console.Write("퀴즈\t#2\t 성적 : ");
            //string quiz2 = Console.ReadLine();
            //int quiz2_n = default;
            //int.TryParse(quiz2, out quiz2_n);

            //Console.Write("퀴즈\t#3\t 성적 : ");
            //string quiz3 = Console.ReadLine();
            //int quiz3_n = default;
            //int.TryParse(quiz3, out quiz3_n);

            //Console.Write("중간고사#4\t 성적 : ");
            //string midterm = Console.ReadLine();
            //int midterm_n = default;
            //int.TryParse(midterm, out midterm_n);

            //Console.Write("기말고사#5\t 성적 : ");
            //string lastterm = Console.ReadLine();
            //int lastterm_n = default;
            //int.TryParse(lastterm, out lastterm_n);
            //Console.WriteLine("=============================");
            //Console.WriteLine("성적 총합 : {0}", quiz1_n+quiz2_n+quiz3_n+midterm_n+lastterm_n);
            //Console.WriteLine("=============================");

            
            

        } // Main()

    } // class program
} // namespace first

/*연산자
 * 데이터로 연산 작업을 수행할 떄는 연산자(Operator)를 사용한다. 연산자는 기능에 따라 대입, 산술
 * , 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며 형태에 따라 항 1개로 연산을 하는 단항 연산자
 * 와 항 2개로 연산을 하는 이항 연산자, 항 3개로 연산을 하는 삼항 연산자로 나뉜다.
 * 
 * 단항연산자
 * 단항 연산자는 연산자와 피연산자 하나로 식을 처리한다. ex) [연산자] [피연산자]
 * + 연산자 : 특정 정수형 변수 값을 그대로 출력한다.
 * - 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력한다. 음수 값이 들어 있다면 양수로 변환해서 반환한다.
 * 
 * 이항연산자
 * 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다. ex) [피연산자1] [연산자] [피연산자2]
 * 
 * 삼항연산자
 * 삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1개씩 총 2개의 항으로 식을 처리한다.
 * ex) (식) ? 피연산자1 : 피연산자2
 * 
 * 식과 문
 * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expression) 또는 표현식이라고 한다. 표현식을 사용하여
 * 명령 하나를 진행하는 구문을 문(Statement) 또는 문장이라고 한다.
 * 
 * 변환 연산자
 * () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
 * 
 * 산술 연산자 add, subtract, multiply, divide, modules +, -, *, /, %
 * 수학적 연산을 하는 데 사용한다. 정수형식과 실수형식의 산술 연산에서 사용한다.
 * 
 * 문자열 연결 연산자
 * 산술 연산자 중 하나인 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 수행한다.
 * + 연산자 : 두 항이 숫자일 때는 산술(+) 연산 가능, 문자열일때는 문자 연결가능
 * 
 * 할당 연산자
 * 할당 연산자(Assignment operator)는 변수에 데이터를 대입하는 데, 사용한다. 할당 연산자를 대입 연산자 라고한다.
 * C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 데이터를 왼쪽 변수에 할당하라고 지시하는 것.
 * ex) =, +=, -=, *=, /=, %=
 * 
 * 증감 연산자(Increment/ Decrement operator)
 * 변수 값을 1 증가시키거나 1 감소시키는 연산자이다. 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐에따라
 * 연산 처리 우선순위가 결정된다.
 * ++(증가 연산자) : 변수 값에 1을 더한다.
 * --(감소 연산자) : 변수 값에 1을 뺀다.
 * 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
 * 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수행
 * 후위(Postfix) 증감 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에 변수값 증감
 * 
 * 연산자 오버로딩 -> 잘안씀, 가독성 구림
 * 
 *과제------------------
 *memory safety하다란?
 *콜드스토리지 : 하드디스크날라감
 */