namespace LoopOutputString
{

    internal class Program
    {
        // 2024.08.05
        // 문제 - 문자열 str과 정수 n이 주어집니다.
        //        str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/181950
        static void Main(string[] args)
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);

            for (int i = 0; i < a; i++)
            {
                Console.Write(s1);
            }
        }
    }
}
