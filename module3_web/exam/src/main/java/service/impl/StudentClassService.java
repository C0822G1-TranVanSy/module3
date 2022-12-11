package service.impl;

import model.StudentClass;
import repository.IStudentClassRepository;
import repository.impl.StudentClassRepository;
import service.IStudentClassService;

import java.util.List;

public class StudentClassService implements IStudentClassService {
    IStudentClassRepository studentClassRepository = new StudentClassRepository();
    @Override
    public List<StudentClass> selectAllClass() {
        return studentClassRepository.selectAllClass();
    }
}
