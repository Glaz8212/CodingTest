namespace _019.DevidePizza2
{
    internal class Program
    {
        // 2024.08.09
        // 머쓱이네 피자가게는 피자를 여섯 조각으로 잘라 줍니다.
        // 피자를 나눠먹을 사람의 수 n이 매개변수로 주어질 때,
        // n명이 주문한 피자를 남기지 않고 모두 같은 수의 피자 조각을 먹어야 한다면
        // 최소 몇 판을 시켜야 하는지를 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120815
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= 100; i++)
            {
                // (피자 수 * 6 = 조각수) 를 6으로 나눈 나머지가 0일 때,
                if (i * 6 % n == 0)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
        }
    }
}
