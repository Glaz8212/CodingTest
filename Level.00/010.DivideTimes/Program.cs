﻿namespace _010.DivideTimes
{
    internal class Program
    {
        // 2024.08.07
        // 정수 num1과 num2가 매개변수로 주어질 때,
        // num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120806
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 * 1000 / num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
        }
    }

}
