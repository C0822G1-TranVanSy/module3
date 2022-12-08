package repository;

import model.Customer;
import model.Facility;

import java.util.List;

public interface IFacilityRepository {

    List<Facility> displayListFacility();

    boolean insertFacility(Facility facility);

    Facility findFacilityById(int id);

    boolean editFacility(Facility facility);

    boolean deleteFacility(int id);

    List<Customer> findFacility(String customerName,String customerPhoneNumber, String customerAddress);
}
