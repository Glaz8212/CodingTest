﻿using System.Text;

namespace _041.RockPaperScissors
{
    internal class Program
    {
        // 2024.08.23
        // 가위는 2 바위는 0 보는 5로 표현합니다.
        // 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때,
        // rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록
        // solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120839
        public class Solution
        {
            public string solution(string rsp)
            {
                char[] chars = rsp.ToCharArray();
                StringBuilder answer = new StringBuilder();

                foreach (char c in chars)
                {
                    switch (c)
                    {
                        case '2':
                            answer.Append('0');
                            break;
                        case '0':
                            answer.Append("5");
                            break;
                        case '5':
                            answer.Append("2");
                            break;
                    }
                }

                return answer.ToString();
            }
        }
    }
}
