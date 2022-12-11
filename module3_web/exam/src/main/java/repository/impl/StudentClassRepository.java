package repository.impl;

import model.StudentClass;
import repository.BaseRepository;
import repository.IStudentClassRepository;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class StudentClassRepository implements IStudentClassRepository {
    BaseRepository baseRepository = new BaseRepository();
    private final String SELECT_ALL = "select * from class";

    @Override
    public List<StudentClass> selectAllClass() {
        List<StudentClass> studentClassList =new ArrayList<>();
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement ps = connection.prepareStatement(SELECT_ALL);
            ResultSet rs = ps.executeQuery();
            while (rs.next()){
                int id = rs.getInt("id");
                String className = rs.getString("class_name");
                studentClassList.add(new StudentClass(id,className));
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return studentClassList;
    }
}
