
using System; // system에서 땡겨오고 있다. -> 속성에서 암시적
using System.ComponentModel.DataAnnotations;

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

            string stringBinary = Convert.ToString(10,2); // 10을 이진수 형태로 string으로 저장
            Console.WriteLine(stringBinary);

            int intBinary = Convert.ToInt32("0111",2); // 0111를 이진수형태로 int형으로 저장
            Console.WriteLine(intBinary);

            int value = 0;
            value = -8;
            value = +value;
            Console.WriteLine(value);
            

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
 *과제------------------
 *memory safety하다란?
 *콜드스토리지 : 하드디스크날라감
 */