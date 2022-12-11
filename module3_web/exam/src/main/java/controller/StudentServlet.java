package controller;

import model.Student;
import model.StudentClass;
import service.IStudentClassService;
import service.IStudentService;
import service.impl.StudentClassService;
import service.impl.StudentService;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.Map;

@WebServlet(name = "StudentServlet", urlPatterns = "/student")
public class StudentServlet extends HttpServlet {
    IStudentService studentService = new StudentService();
    IStudentClassService studentClassService = new StudentClassService();

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setCharacterEncoding("UTF-8");
        response.setContentType("text/html;charset=UTF-8");
        String action = request.getParameter("action");
        if (action == null) {
            action = "";
        }
        switch (action) {
            case "add":
                addStudent(request, response);
                break;
            case "edit":
                editStudent(request, response);
                break;
            case "delete":
                removeStudent(request, response);
                break;
        }
    }

    private void removeStudent(HttpServletRequest request, HttpServletResponse response) {
        int id = Integer.parseInt(request.getParameter("id"));
        String mess = "Xóa không thành công";
        boolean check = studentService.deleteStudent(id);
        if(check){
            mess = "Xóa thành công";
        }

        displayList(request, response);
    }

    private void editStudent(HttpServletRequest request, HttpServletResponse response) {
        int id = Integer.parseInt(request.getParameter("id"));
        String name = request.getParameter("name");
        boolean gender = Boolean.parseBoolean(request.getParameter("gender"));
        String dateOfBirth = request.getParameter("date_of_birth");
        double score = Double.parseDouble(request.getParameter("score"));
        int classId = Integer.parseInt(request.getParameter("class_id"));
        Student student = new Student(id, name, gender, dateOfBirth, score, new StudentClass(classId));
        Map<String, String> errorMap = studentService.updateStudent(student);
        String mess = "Cập nhật thành công";
        if (!errorMap.isEmpty()) {
            mess = "Cập nhật không thành công";
            request.setAttribute("errorMap", errorMap);
            request.setAttribute("isModalEdit", true);
        }
        request.setAttribute("mess", mess);
        displayList(request, response);
    }

    private void addStudent(HttpServletRequest request, HttpServletResponse response) {
        String name = request.getParameter("name");
        boolean gender = Boolean.parseBoolean(request.getParameter("gender"));
        String dateOfBirth = request.getParameter("date_of_birth");
        double score = Double.parseDouble(request.getParameter("score"));
        int classId = Integer.parseInt(request.getParameter("class_id"));
        Student student = new Student(name, gender, dateOfBirth, score, new StudentClass(classId));
        Map<String, String> errorMap = studentService.insertStudent(student);
        String mess = "Thêm mới thành công";
        if (!errorMap.isEmpty()) {
            mess = "Thêm mới không thành công";
            request.setAttribute("errorMap", errorMap);
            request.setAttribute("isModalAdd", true);
        }
        request.setAttribute("mess", mess);
        displayList(request, response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        request.setCharacterEncoding("UTF-8");
        response.setContentType("text/html;charset=UTF-8");
        String action = request.getParameter("action");
        if (action == null) {
            action = "";
        }
        switch (action) {

            default:
                displayList(request, response);
        }
    }

    private void displayList(HttpServletRequest request, HttpServletResponse response) {
        request.setAttribute("studentList", studentService.selectAllStudent());
        request.setAttribute("studentClassList", studentClassService.selectAllClass());
        try {
            request.getRequestDispatcher("view/list.jsp").forward(request, response);
        } catch (ServletException | IOException e) {
            e.printStackTrace();
        }
    }
}
