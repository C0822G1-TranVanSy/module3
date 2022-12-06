package service.impl;

import model.CustomerType;
import repository.ICustomerTypeRepository;
import repository.impl.CustomerTypeRepository;

import java.util.List;

public class CustomerTypeService implements ICustomerTypeRepository {
    ICustomerTypeRepository customerTypeRepository = new CustomerTypeRepository();

    @Override
    public List<CustomerType> findAllCustomerType() {
        return customerTypeRepository.findAllCustomerType();
    }
}
