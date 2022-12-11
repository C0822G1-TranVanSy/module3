package repository;

import model.Student;

import java.util.List;
import java.util.Map;

public interface IStudentRepository {
    List<Student> selectAllStudent();

    boolean insertStudent(Student student);

    boolean updateStudent(Student student);

    boolean deleteStudent(int id);

    List<Student> findStudent(String name, boolean gender, String className);
}
