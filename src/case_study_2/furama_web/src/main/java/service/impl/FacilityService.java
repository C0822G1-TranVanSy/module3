package service.impl;

import model.Customer;
import model.Facility;
import repository.IFacilityRepository;
import repository.impl.FacilityRepository;
import service.IFacilityService;

import java.util.List;

public class FacilityService implements IFacilityService {
    IFacilityRepository facilityRepository = new FacilityRepository();
    @Override
    public List<Facility> displayListFacility() {
        return facilityRepository.displayListFacility();
    }

    @Override
    public boolean insertFacility(Facility facility) {
        return facilityRepository.insertFacility(facility);
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
