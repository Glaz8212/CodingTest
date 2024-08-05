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

            char[] ss = s.ToCharArray();

            for (int i = 0; i < ss.Length; i++)
            {
                if (char.IsUpper(ss[i]))
                {
                    ss[i] = char.ToLower(ss[i]);
                }
                else
                {
                    ss[i] = char.ToUpper(ss[i]);
                }
            }

            string str = new string(ss);
            Console.WriteLine(str);
        }
    }
}
