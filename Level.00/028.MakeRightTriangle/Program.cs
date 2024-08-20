namespace _028.MakeRightTriangle
{
    internal class Program
    {
        // 2024.08.20
        // "*"의 높이와 너비를 1이라고 했을 때, "*"을 이용해 직각 이등변 삼각형을 그리려고합니다.
        // 정수 n 이 주어지면 높이와 너비가 n 인 직각 이등변 삼각형을 출력하도록 코드를 작성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120823
        public static void Main()
        {
            string str = Console.ReadLine();
            int.TryParse(str, out int n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
