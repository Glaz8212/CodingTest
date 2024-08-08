namespace _017.HateEven
{
    internal class Program
    {
        // 2024.08.08
        // 정수 n이 매개변수로 주어질 때,
        // n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120813
        public class Solution
        {
            public int[] solution(int n)
            {
                // 배열 생성
                int i;
                if (n % 2 == 0)
                {
                    i = n / 2;
                }
                else
                {
                    i = n / 2 + 1;
                }

                int[] answer = new int[i];

                // answer[j]에  홀수 대입
                for (int j = 0; j < i; j++)
                {
                    answer[j] = j * 2 + 1;
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
