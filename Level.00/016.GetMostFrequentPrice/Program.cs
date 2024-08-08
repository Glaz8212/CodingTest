namespace _016.GetMostFrequentPrice
{
    internal class Program
    {
        // 2024.08.08
        // 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다.
        // 정수 배열 array가 매개변수로 주어질 때, 최빈값을 return 하도록 solution 함수를 완성해보세요.
        // 최빈값이 여러 개면 -1을 return 합니다.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120812
        public class Solution
        {
            public int solution(int[] array)
            {
                int[] array2 = new int[1001];

                // 빈도 계산
                for (int i = 0; i < array.Length; i++)
                {
                    int value = array[i];
                    array2[value]++;
                }

                int answer = 0;
                int max = 0;
                bool existSameNumber = false;

                // 최빈값 찾기 및 중복 확인
                for (int i = 0; i <= 1000; i++)
                {
                    if (array2[i] > max)
                    {
                        max = array2[i];
                        answer = i;
                        existSameNumber = false; // 새로운 최빈값이 발견되었으므로 중복 플래그를 초기화
                    }
                    else if (array2[i] == max)
                    {
                        existSameNumber = true; // 동일한 값 존재
                    }
                }

                // 최빈값이 두 개 이상인 경우 -1 반환
                if (existSameNumber)
                {
                    return -1;
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
