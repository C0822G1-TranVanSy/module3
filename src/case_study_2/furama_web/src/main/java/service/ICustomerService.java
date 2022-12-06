package service;

import model.Customer;

import java.util.List;

public interface ICustomerService {
    List<Customer> displayListCustomer();

    boolean insertCustomer();
}
