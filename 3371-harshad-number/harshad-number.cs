public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        string str = x.ToString();
        int sum = str
            .Select(c => c - '0')
            .Sum();
    return x % sum == 0 ? sum : -1;}
}