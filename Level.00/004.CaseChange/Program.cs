namespace CaseChange
{
    internal class Program
    {
        // 2024.08.05
        // 문제 - 영어 알파벳으로 이루어진 문자열 str이 주어집니다.
        //        각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/181949
        static void Main(string[] args)
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            // 입력받은 영어 문자열을 ss의 char형 배열에 저장
            char[] ss = s.ToCharArray();

            for (int i = 0; i < ss.Length; i++)
            {
                // 문자열 내의 대문자의 경우
                if (char.IsUpper(ss[i]))
                {  
                    // 소문자로 변환
                    ss[i] = char.ToLower(ss[i]);
                }
                // 소문자의 경우
                else
                {   // 대문자로 변환
                    ss[i] = char.ToUpper(ss[i]);
                }
            }

            string str = new string(ss);
            Console.WriteLine(str);
        }
    }
}
