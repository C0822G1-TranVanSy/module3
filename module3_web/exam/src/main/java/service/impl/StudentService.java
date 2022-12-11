package service.impl;

import common.Regex;
import model.Student;
import repository.IStudentRepository;
import repository.impl.StudentRepository;
import service.IStudentService;

import java.sql.Connection;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class StudentService implements IStudentService {
    IStudentRepository studentRepository = new StudentRepository();
    Regex regex = new Regex();
    @Override
    public List<Student> selectAllStudent() {
        return studentRepository.selectAllStudent();
    }

    @Override
    public Map<String, String> insertStudent(Student student) {
        Map<String,String> errorMap = new HashMap<>();
        if(!regex.checkName(student.getName())) {
            errorMap.put("errorName", "Nhập không đúng định dạng chữ!!!");
        }else if(!regex.checkScore(String.valueOf(student.getScore())) || student.getScore()<0 || student.getScore()>10) {
            errorMap.put("errorScore", "Điểm số từ 0-10!!!");
        }else {
            studentRepository.insertStudent(student);
        }
        return errorMap;
    }

    @Override
    public Map<String, String> updateStudent(Student student) {
        Map<String,String> errorMap = new HashMap<>();
        if(!regex.checkName(student.getName())) {
            errorMap.put("errorNameEdit", "Nhập không đúng định dạng chữ!!!");
        }else if(!regex.checkScore(String.valueOf(student.getScore())) || student.getScore()<0 || student.getScore()>10) {
            errorMap.put("errorScoreEdit", "Điểm số từ 0-10!!!");
        }else {
            studentRepository.updateStudent(student);
        }
        return errorMap;
    }

    @Override
    public boolean deleteStudent(int id) {
        return studentRepository.deleteStudent(id);
    }

    @Override
    public List<Student> findStudent(String name, boolean gender, String className) {
        return null;
    }
}
