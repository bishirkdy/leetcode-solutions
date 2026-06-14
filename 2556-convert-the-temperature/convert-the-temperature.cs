public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double cei = celsius + 273.15;
        double far = celsius * 1.80 + 32.00;
        return new double[] {cei , far};
    }
}