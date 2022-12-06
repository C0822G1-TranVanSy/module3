package repository.impl;

import model.Customer;
import model.CustomerType;
import repository.BaseRepository;
import repository.ICustomerRepository;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class CustomerRepository implements ICustomerRepository {
    BaseRepository baseRepository = new BaseRepository();
    private final String SELECT_ALL_CUSTOMERS = "select c.*,ct.name as customer_type_name from customer c join customer_type ct on c.customer_type_id = ct.id";
    private final String INSERT_CUSTOMER = "insert into customer (customer_type_id,name,date_of_birth,gender,id_card,phone_number,email,address) values (?,?,?,?,?,?,?,?)";

    @Override
    public List<Customer> displayListCustomer() {
        List<Customer> customerList = new ArrayList<>();
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement preparedStatement = connection.prepareStatement(SELECT_ALL_CUSTOMERS);
            ResultSet rs = preparedStatement.executeQuery();
            while (rs.next()){
                int id = rs.getInt("id");
                int customerTypeId = rs.getInt("customer_type_id");
                String customerTypeName = rs.getString("customer_type_name");
                String name = rs.getString("name");
                String dateOfBirth = rs.getString("date_of_birth");
                boolean gender = rs.getBoolean("gender");
                String idCard = rs.getString("id_card");
                String phoneNumber = rs.getString("phone_number");
                String email = rs.getString("email");
                String address = rs.getString("address");
                CustomerType customerType = new CustomerType(customerTypeId,customerTypeName);
                customerList.add(new Customer(id,customerType,name,dateOfBirth,gender,idCard,phoneNumber,email,address));
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return customerList;
    }

    @Override
    public boolean insertCustomer() {
        Connection connection = baseRepository.getConnection();
        try {
            PreparedStatement preparedStatement = connection.prepareStatement(INSERT_CUSTOMER);
            preparedStatement.setString(1,"customer_type_id");
            preparedStatement.setString(2,"name");
            preparedStatement.setString(3,"date_of_birth");
            preparedStatement.setString(4,"gender");
            preparedStatement.setString(5,"id_card");
            preparedStatement.setString(6,"phone_number");
            preparedStatement.setString(7,"email");
            preparedStatement.setString(8,"address");
            return preparedStatement.executeUpdate() > 0;
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }

        return false;
    }
}
