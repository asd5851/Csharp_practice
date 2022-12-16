using System;
namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
        }
    }
}
/*
 * ctrl + l => 한줄 지우기
 * ctrl + c => 한줄 복사
 * ctrl + 화살표 => 단어 점프
 * 깃헙 -> 한줄 공백 4칸 이상
 * git clone [paste]
 * git = 로컬과 클라우스 동기화(소스코드 관리를 위해서 사용, 누가 언제 무엇을 수정했는지 파악하기 위해서 사용)
 *  add- 로컬 수장사항을 스테이지 영역에 추가(무엇을 변경할지 선택) // git add .
 *  commit- 스테이지 영역의 내용을 깃에 기록(메모와함께) // git commit -m"메세지"
 *  push- commit한 내용을 원격리포지토리에 덮어씀
 *  stauts- 폴더 안에 뭐가 있니
 *  .- 모든 파일을 가르킴
 * 메세지를 사용하는 규칙 - 컨벤션
 *  코드에 적용되는 규칙은 코딩컨벤션
 *  커밋 메세지 컨벤션
 *  
 * 과제-----------------------------
 * 1) 깃을 왜 쓰는지?
 * 2) 코드 스테이지 영역이란?
 * 3) add, commit, push 명령어는 각각 무엇을 하는 것인지?
 * 4) 코딩컨벤션
 *    -헝가리안
 *    -파스칼
 *    -스네이크
 *    -기타 등등
 * 5) 커밋 메세지 컨벤션
 *  <type>[optional scope]: <description>
 *  git commit -m "[이름] feat(New project) Create new project"
 *  [이름] feat(New project) Create new project
 * 6) 플로우차트 어떻게 그리는가
 *  터미널(시작과 종료), 프로세스(하나의 단계 처리), 
 */