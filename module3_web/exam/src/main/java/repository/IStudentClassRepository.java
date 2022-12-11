package repository;

import model.StudentClass;

import java.util.List;

public interface IStudentClassRepository {
    List<StudentClass> selectAllClass();
}
