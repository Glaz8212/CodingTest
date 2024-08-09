namespace _020.DevidePizza3
{
    internal class Program
    {
        // 2024.08.09
        // 머쓱이네 피자가게는 피자를 두 조각에서 열 조각까지 원하는 조각 수로 잘라줍니다.
        // 피자 조각 수 slice와 피자를 먹는 사람의 수 n이 매개변수로 주어질 때,
        // n명의 사람이 최소 한 조각 이상 피자를 먹으려면 최소 몇 판의 피자를 시켜야 하는지
        // 를 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120816
        public int solution(int slice, int n)
        {
            int answer = 0;
            // 피자의 수가 제한사항기준으로 최대 50판이기 때문에,
            for (int i = 1; i <= 50; i++)
            {
                // 조각수 * 판수가 사람수보다 많으면 종료
                if (slice * i >= n)
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
