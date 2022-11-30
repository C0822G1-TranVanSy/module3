import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(name = "CalculatorServlet", urlPatterns = {"/calculator"})
public class CalculatorServlet extends HttpServlet {
    Calculator calculator = new Calculator();

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        float firstOperand = Float.parseFloat(request.getParameter("firstOperand"));
        float secondOperand = Float.parseFloat(request.getParameter("secondOperand"));
        String opera = request.getParameter("opera");
        double result = 0;
        try {
            result = calculator.calculate(opera, firstOperand, secondOperand);
        } catch (ArithmeticException e) {
            request.setAttribute("result", e.getMessage());
            request.getRequestDispatcher("display.jsp").forward(request, response);
            return;
        }
        switch (opera) {
            case "Addition":
                opera = "+";
                break;
            case "Subtraction":
                opera = "-";
                break;
            case "Multiplication":
                opera = "*";
                break;
            case "Division":
                opera = "/";
                break;
        }
        request.setAttribute("result", firstOperand + " " + opera + " " + secondOperand + " " + "= " + result);
        request.setAttribute("firstOperand", firstOperand);
        request.setAttribute("secondOperand", secondOperand);
        request.setAttribute("opera", opera);
        request.getRequestDispatcher("display.jsp").forward(request, response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

    }
}
