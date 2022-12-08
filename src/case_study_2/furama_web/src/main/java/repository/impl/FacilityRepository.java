package repository.impl;

import model.Customer;
import model.Facility;
import model.FacilityType;
import model.RentType;
import repository.BaseRepository;
import repository.IFacilityRepository;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class FacilityRepository implements IFacilityRepository {
    BaseRepository baseRepository = new BaseRepository();
    private final String SELECT_ALL_FACILITY = "select f.*,ft.name as facility_type_name,rt.name as rent_type_name from facility f join facility_type ft on f.facility_type_id = ft.id join rent_type rt on f.rent_type_id = rt.id ";
    private final String SELECT_FACILITY = "select c.*,ct.name as customer_type_name from customer c join customer_type ct on c.customer_type_id = ct.id where c.id=?";
    private final String FIND_FACILITY_BY_ = "select c.*,ct.name as customer_type_name from customer c join customer_type ct on c.customer_type_id = ct.id where c.name like ? and c.phone_number like ? and c.address like ?";
    private final String INSERT_FACILITY = "insert into facility (name,area,cost,max_people,rent_type_id,facility_type_id,standard_room,description_other_convenience,pool_area,number_of_floors,facility_free) values (?,?,?,?,?,?,?,?,?,?,?)";
    private final String EDIT_FACILITY = "update customer set customer_type_id = ?,name=?,date_of_birth=?,gender=?,id_card=?,phone_number=?,email=?,address=? where id = ?;";
    private final String DELETE_FACILITY = "delete from customer where id = ?;";
    private final String SQL_SAFE_UPDATES = "set sql_safe_updates = 0;";
    private final String FOREIGN_KEY_CHECKS = "set foreign_key_checks = 0;";


    @Override
    public List<Facility> displayListFacility() {
        Connection connection = baseRepository.getConnection();
        List<Facility> facilityList = new ArrayList<>();
        try {
            PreparedStatement ps = connection.prepareStatement(SELECT_ALL_FACILITY);
            ResultSet rs = ps.executeQuery();
            while (rs.next()){
                int id = rs.getInt("id");
                String name = rs.getString("name");
                int area = rs.getInt("area");
                double cost = rs.getInt("cost");
                int maxPeople = rs.getInt("max_people");
                int rentTypeId = rs.getInt("rent_type_id");
                String rentTypeName = rs.getString("rent_type_name");
                int facilityTypeId = rs.getInt("facility_type_id");
                String facilityTypeName = rs.getString("facility_type_name");
                String standardRoom = rs.getString("standard_room");
                String descriptionOtherConvenience = rs.getString("description_other_convenience");
                double poolArea = rs.getDouble("pool_area");
                int numberOfFloors = rs.getInt("number_of_floors");
                String facilityFree = rs.getString("facility_free");
                FacilityType facilityType = new FacilityType(facilityTypeId,facilityTypeName);
                RentType rentType = new RentType(rentTypeId,rentTypeName);
                facilityList.add(new Facility(id,name,area,cost,maxPeople,rentType,facilityType,standardRoom,descriptionOtherConvenience,poolArea,numberOfFloors,facilityFree) );
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return facilityList;
    }

    @Override
    public boolean insertFacility(Facility facility) {
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement preparedStatement = connection.prepareStatement(INSERT_FACILITY);
            preparedStatement.setString(1,facility.getName());
            preparedStatement.setInt(2,facility.getArea());
            preparedStatement.setDouble(3,facility.getCost());
            preparedStatement.setInt(4,facility.getMaxPeople());
            preparedStatement.setInt(5,facility.getRentType().getId());
            preparedStatement.setInt(6,facility.getFacilityType().getId());
            preparedStatement.setString(7,facility.getStandardRoom());
            preparedStatement.setString(8,facility.getDescriptionOtherConvenience());
            preparedStatement.setDouble(9,facility.getPoolArea());
            preparedStatement.setInt(10,facility.getNumberOfFloors());
            preparedStatement.setString(11,facility.getFacilityFree());
            return preparedStatement.executeUpdate() > 0;
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return false;
    }

    @Override
    public Facility findFacilityById(int id) {
        return null;
    }

    @Override
    public boolean editFacility(Facility facility) {
        return false;
    }

    @Override
    public boolean deleteFacility(int id) {
        return false;
    }

    @Override
    public List<Customer> findFacility(String customerName, String customerPhoneNumber, String customerAddress) {
        return null;
    }
}
