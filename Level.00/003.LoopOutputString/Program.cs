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

            // 주어진 문자열과 정수를 분리 후 배열에 넣는다.
            input = Console.ReadLine().Split(' ');

            
            // 문자열을 s1에 저장
            String s1 = input[0];
            
            // 정수를 정수로 변환 후 a에 저장
            int a = Int32.Parse(input[1]);

            for (int i = 0; i < a; i++)
            {
                Console.Write(s1);
            }
        }
    }
}
