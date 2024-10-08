﻿using System.Text;

namespace _037.NumberingEmergency
{
    internal class Program
    {
        // 2024.08.22
        // 외과의사 머쓱이는 응급실에 온 환자의 응급도를 기준으로 진료 순서를 정하려고 합니다.
        // 정수 배열 emergency가 매개변수로 주어질 때
        // 응급도가 높은 순서대로 진료 순서를 정한 배열을 return하도록 solution 함수를 완성해주세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120835
        public class Solution
        {
            public int[] solution(int[] emergency)
            {
                int[] sortedEmergency = (int[])emergency.Clone();
                Array.Sort(sortedEmergency);
                Array.Reverse(sortedEmergency);

                int[] answer = new int[sortedEmergency.Length];

                for (int i = 0; i < emergency.Length; i++)
                {
                    answer[i] = Array.IndexOf(sortedEmergency, emergency[i]) + 1;
                }

                return answer;
            }
        }
    }
}
