package service.impl;

import model.Customer;
import repository.ICustomerRepository;
import repository.impl.CustomerRepository;
import service.ICustomerService;

import java.util.List;

public class CustomerService implements ICustomerService {
    ICustomerRepository customerRepository = new CustomerRepository();

    @Override
    public List<Customer> displayListCustomer() {
        return customerRepository.displayListCustomer();
    }

    @Override
    public boolean insertCustomer(Customer customer) {
        return customerRepository.insertCustomer(customer);
    }

    @Override
    public Customer findCustomerById(int id) {
        return customerRepository.findCustomerById(id);
    }

    @Override
    public boolean editCustomer(Customer customer) {
        return customerRepository.editCustomer(customer);
    }

    @Override
    public boolean deleteCustomer(int id) {
        return customerRepository.deleteCustomer(id);
    }
}
