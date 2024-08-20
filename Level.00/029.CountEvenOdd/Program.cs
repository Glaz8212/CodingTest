namespace _029.CountEvenOdd
{
    internal class Program
    {
        // 2024.08.20
        // 정수가 담긴 리스트 num_list가 주어질 때,
        // num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120824
        public class Solution
        {
            public int[] solution(int[] num_list)
            {
                int even = 0;
                int odd = 0;
                foreach (int i in num_list)
                {
                    if (i % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                int[] answer = new int[] {even, odd};
                return answer;
            }
        }
    }
}
