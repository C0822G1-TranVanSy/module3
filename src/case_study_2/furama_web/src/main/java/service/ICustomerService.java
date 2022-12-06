package service;

import model.Customer;

import java.util.List;

public interface ICustomerService {
    List<Customer> displayListCustomer();

    boolean insertCustomer(Customer customer);

    Customer findCustomerById(int id);

    boolean editCustomer(Customer customer);

    boolean deleteCustomer(int id);
}
