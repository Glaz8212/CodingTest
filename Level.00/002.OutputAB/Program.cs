namespace OutputAB
{
    internal class Program
    {
        // 2024.08.05
        // 문제 - 정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/181951
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // 주어진 두 정수를 한 글자씩 분리
            string[] inputs = input.Split();

            //분리 후 배열 첫 번째와 두 번째에 담아서 a, b에 저장
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
