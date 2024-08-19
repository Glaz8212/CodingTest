namespace _023.GetSale
{
    internal class Program
    {
        // 2024.08.19
        // 머쓱이네 옷가게는 10만 원 이상 사면 5%, 30만 원 이상 사면 10%, 50만 원 이상 사면 20%를 할인해줍니다.
        // 구매한 옷의 가격 price가 주어질 때, 지불해야 할 금액을 return 하도록 solution 함수를 완성해보세요.
        // https://school.programmers.co.kr/learn/courses/30/lessons/120818
        public int solution(int price)
        {
            double saledPrice;
            if ( 100000 <= price && price <= 299999)
            {
                saledPrice = price * 0.95 ;
            }
            else if (300000 <= price && price <= 499999)
            {
                saledPrice = price * 0.9 ;
            }
            else if (500000 <= price )
            {
                saledPrice = price * 0.8;
            }
            else
            {
                saledPrice = price;
            }

            return (int)saledPrice;
        }
    }
}
