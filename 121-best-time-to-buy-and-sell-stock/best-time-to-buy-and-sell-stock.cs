public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int sell = 0;
        for(int i = 0; i < prices.Length ; i++)
        {
            if(buy > prices[i])
            {
                buy = prices[i];
            }
            sell = Math.Max(sell, prices[i] - buy);
        }
        return sell;
    }
}