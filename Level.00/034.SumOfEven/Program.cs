namespace _034.SumOfEven
{
    internal class Program
    {
        // 2024.08.21
        // 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120831
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                if ( n % 2 == 0 )
                {
                    answer = (1 + n / 2) * n / 2;
                }
                if (n % 2 == 1)
                {
                    answer = (1 + (n - 1) / 2) * (n - 1) / 2;
                }
                return answer;
            }
        }
    }
}
