package controller;

import model.Facility;
import model.FacilityType;
import model.RentType;
import service.IFacilityService;
import service.IFacilityTypeService;
import service.IRentTypeService;
import service.impl.FacilityService;
import service.impl.FacilityTypeService;
import service.impl.RentTypeService;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(name = "FacilityServlet",urlPatterns = "/facility")
public class FacilityServlet extends HttpServlet {
    IFacilityService facilityService = new FacilityService();
    IFacilityTypeService facilityTypeService = new FacilityTypeService();
    IRentTypeService rentTypeService = new RentTypeService();
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String action = request.getParameter("action");
        if(action == null){
            action = "";
        }
        switch (action){
            case "add":
                addFacility(request,response);
                break;
        }
    }

    private void addFacility(HttpServletRequest request, HttpServletResponse response) {
        String name = request.getParameter("name");
        int area = Integer.parseInt(request.getParameter("area"));
        double cost = Double.parseDouble(request.getParameter("cost"));
        int maxPeople = Integer.parseInt(request.getParameter("max_people"));
        int rentTypeId = Integer.parseInt(request.getParameter("rent_type_id"));
        int facilityTypeId = Integer.parseInt(request.getParameter("facility_type_id"));
        String standardRoom = request.getParameter("standard_room");
        String descriptionOtherConvenience = request.getParameter("description_other_convenience");
        double poolArea = Double.parseDouble(request.getParameter("pool_area"));
        int numberOfFloors = Integer.parseInt(request.getParameter("number_of_floors"));
        String facility_free = request.getParameter("facility_free");
        Facility facility = new Facility(name,area,cost,maxPeople,new RentType(rentTypeId),new FacilityType(facilityTypeId),standardRoom,
                descriptionOtherConvenience,poolArea,numberOfFloors,facility_free);
        facilityService.insertFacility(facility);
        showListFacility(request,response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String action = request.getParameter("action");
        if(action == null){
            action = "";
        }
        switch (action){
            default:
                showListFacility(request,response);

        }
    }

    private void showListFacility(HttpServletRequest request, HttpServletResponse response) {
        request.setAttribute("facilityList",facilityService.displayListFacility());
        request.setAttribute("facilityTypeList",facilityTypeService.findAllFacilityType());
        request.setAttribute("rentTypeList",rentTypeService.findAllRentType());
        try {
            request.getRequestDispatcher("view/facility/facility_list.jsp").forward(request,response);
        } catch (ServletException | IOException e) {
            e.printStackTrace();
        }
    }


}
