public class Calculator {
    public double calculate(String opera, float num1, float num2) {
        double result = 0;
        switch (opera) {
            case "Addition":
                result = num1 + num2;
                break;
            case "Subtraction":
                result = num1 - num2;
                break;
            case "Multiplication":
                result = num1 * num2;
                break;
            case "Division":
                if (num2 == 0) {
                    throw new ArithmeticException("Lỗi chia cho 0");
                }
                result = num1 / num2;
                break;
        }
        return result;
    }
}
