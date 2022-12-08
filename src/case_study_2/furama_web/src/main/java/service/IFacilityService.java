package service;

import model.Customer;
import model.Facility;

import java.util.List;

public interface IFacilityService {

    List<Facility> displayListFacility();

    boolean insertFacility(Facility facility);

    Facility findFacilityById(int id);

    boolean editFacility(Facility facility);

    boolean deleteFacility(int id);

    List<Customer> findFacility(String customerName,String customerPhoneNumber, String customerAddress);
}
