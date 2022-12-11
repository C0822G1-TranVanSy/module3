package repository.impl;

import model.Student;
import model.StudentClass;
import repository.BaseRepository;
import repository.IStudentRepository;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

public class StudentRepository implements IStudentRepository {
    BaseRepository baseRepository = new BaseRepository();
    private final String SELECT_ALL = "select s.*,c.class_name from student s join class c on s.class_id = c.id;";
    private final String INSERT = "insert into student (name,gender,date_of_birth,score,class_id) values(?,?,?,?,?)";
    private final String UPDATE = "update student set name = ?, gender = ?, date_of_birth = ?, score = ?, class_id = ? where id = ?";
    private final String DELETE = "delete from student where id = ?";

    @Override
    public List<Student> selectAllStudent() {
        List<Student> studentList = new ArrayList<>();
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement ps = connection.prepareStatement(SELECT_ALL);
            ResultSet rs = ps.executeQuery();
            while (rs.next()){
                int id = rs.getInt("id");
                String name = rs.getString("name");
                boolean gender = rs.getBoolean("gender");
                String dateOfBirth = rs.getString("date_of_birth");
                double score = rs.getDouble("score");
                int classId = rs.getInt("class_id");
                String className = rs.getString("class_name");
                studentList.add(new Student(id,name,gender,dateOfBirth,score,new StudentClass(classId,className)));
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return studentList;
    }

    @Override
    public boolean insertStudent(Student student) {
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement ps = connection.prepareStatement(INSERT);
            ps.setString(1,student.getName());
            ps.setBoolean(2,student.isGender());
            ps.setString(3,student.getDateOfBirth());
            ps.setDouble(4,student.getScore());
            ps.setInt(5,student.getStudentClass().getId());
            return ps.executeUpdate() > 0;
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean updateStudent(Student student) {
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement ps = connection.prepareStatement(UPDATE);
            ps.setString(1, student.getName());
            ps.setBoolean(2, student.isGender());
            ps.setString(3, student.getDateOfBirth());
            ps.setDouble(4, student.getScore());
            ps.setInt(5, student.getStudentClass().getId());
            ps.setInt(6, student.getId());
            return ps.executeUpdate() > 0;
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean deleteStudent(int id) {
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement ps = connection.prepareStatement(DELETE);
            ps.setInt(1,id);
            return ps.executeUpdate() > 0;
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return false;
    }

    @Override
    public List<Student> findStudent(String name, boolean gender, String className) {
        return null;
    }
}
