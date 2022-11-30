import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@WebServlet(name = "CustomerServlet",urlPatterns = {"/customer"})
public class CustomerServlet extends HttpServlet {
    private static final List<Customer> customerList = new ArrayList<>();
    static {
        customerList.add(new Customer("Mai Văn Hoàn",new Date("1983/08/20"),"Hà Nội", "picture\\1.jpg"));
        customerList.add(new Customer("Nguyễn Văn Nam",new Date("1983/08/20"),"Bắc Giang", "picture\\2.jpg"));
        customerList.add(new Customer("Nguyễn Thái Hòa",new Date("1983/08/20"),"Nam Định", "picture\\3.jpg"));
        customerList.add(new Customer("Trần Đăng Khoa",new Date("1983/08/20"),"Hà Tây", "picture\\4.jpg"));
        customerList.add(new Customer("Nguyễn Đình Thi",new Date("1983/08/20"),"Hà Nội", "picture\\5.jpg"));
    }
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setAttribute("customerList",customerList);
        request.getRequestDispatcher("list.jsp").forward(request,response);
    }
}
