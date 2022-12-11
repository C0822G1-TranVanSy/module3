package service;

import model.Student;

import java.util.List;
import java.util.Map;

public interface IStudentService {

    List<Student> selectAllStudent();

    Map<String,String> insertStudent(Student student);

    Map<String,String> updateStudent(Student student);

    boolean deleteStudent(int id);

    List<Student> findStudent(String name, boolean gender, String className);
}
