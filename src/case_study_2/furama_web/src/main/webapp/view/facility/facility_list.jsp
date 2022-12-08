<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 08/12/2022
  Time: 12:12 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Facility List</title>
    <link rel="stylesheet" href="../../bootstrap-5.1.3-dist/css/bootstrap.css">
</head>
<body>
<script src="../../bootstrap-5.1.3-dist/js/bootstrap.js"></script>

<%@include file="../include/header.jsp" %>

<button type="button" class="btn btn-warning" data-bs-toggle="modal" data-bs-target="#add">Thêm mới</button>

<!-- Modal add -->
<div class="modal fade" id="add" tabindex="-1" aria-labelledby="addModal" aria-hidden="true">
    <div class="modal-dialog modal-xl">
        <div class="modal-content">
            <form action="/customer?action=add" method="post" class="form-xl">
                <div class="modal-header">
                    <h5 class="modal-title" id="addModal">Chỉnh sửa</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="m-2 row">
                        <label class="col-sm-3 form-label"> Facility Type</label>
                        <div class="col-sm-9">
                        <input hidden type="text" name="facility_type_id" id="facilityTypeIdAdd">
                    <button type="button" onclick="addVilla('${facility.name}','${facility.area}','${facility.cost}',
                            '${facility.maxPeople}','${facility.rentType.getId()}','${facility.facilityType.getId()}',
                            '${facility.standardRoom}','${facility.descriptionOtherConvenience}','${facility.poolArea}',
                            '${facility.numberOfFloors}','${facility.facilityFree}')">Villa</button>
                    <button type="button" onclick="addHouse('${facility.name}','${facility.area}','${facility.cost}',
                            '${facility.maxPeople}','${facility.rentType.getId()}','${facility.facilityType.getId()}',
                            '${facility.standardRoom}','${facility.descriptionOtherConvenience}','${facility.poolArea}',
                            '${facility.numberOfFloors}','${facility.facilityFree}')">House</button>
                    <button type="button" onclick="addRoom('${facility.name}','${facility.area}','${facility.cost}',
                            '${facility.maxPeople}','${facility.rentType.getId()}','${facility.facilityType.getId()}',
                            '${facility.standardRoom}','${facility.descriptionOtherConvenience}','${facility.poolArea}',
                            '${facility.numberOfFloors}','${facility.facilityFree}')">Room</button></div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Facility Name</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="nameAdd" name="name">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Area</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="areaAdd" name="area">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Cost</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="costAdd" name="cost">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Max People</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="maxPeopleAdd" name="max_people">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Rent Type Name</label>
                        <div class="col-sm-9">
                            <select class="form-select" name="rent_type_id" id="rentTypeAdd">
                                <c:forEach var="rt" items="${rentTypeList}">
                                    <option value="${rt.id}">${rt.name}</option>
                                </c:forEach>
                            </select>
                        </div>
                    </div>

                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Standard Room</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="standardRoomAdd" name="standard_room">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Description Other Convenience</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="descriptionAdd" name="description_other_convenience">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Pool Area</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="poolAreaAdd" name="pool_area">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Number of Floors</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="numberOfFloorsAdd" name="number_of_floors">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Facility Free</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="facilityFreeAdd" name="facility_free">
                        </div>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="submit" class="btn btn-primary">Save changes</button>
                </div>
            </form>
        </div>
    </div>
</div>

<h2 class="d-flex justify-content-center text-danger">Facility List</h2>
<h3 class="text-success">${mess}</h3>
<%--Search--%>
<form class="d-flex" action="/facility?action=search" method="post">
    <input class="form-control me-2" type="search" placeholder="Search Name" aria-label="Search" name="name">
    <input class="form-control me-2" type="search" placeholder="Search Phone Number" aria-label="Search"
           name="phone_number">
    <input class="form-control me-2" type="search" placeholder="Search Address" aria-label="Search" name="address">
    <button class="btn btn-outline-success" type="submit">Search</button>
</form>

<table class="table table-striped table-hover" id="tableStudent">
    <thead>
    <tr>
        <th scope="col">STT</th>
        <th scope="col">Facility Name</th>
        <th scope="col">Area</th>
        <th scope="col">Cost</th>
        <th scope="col">Max People</th>
        <th scope="col">Rent Type Name</th>
        <th scope="col">Facility Type Name</th>
        <th scope="col">Standard Room</th>
        <th scope="col">Description Other Convenience</th>
        <th scope="col">Pool Area</th>
        <th scope="col">Number Of Floors</th>
        <th scope="col">Facility free</th>
        <th scope="col">Edit</th>
        <th scope="col">Delete</th>
    </tr>
    </thead>
    <tbody>
    <c:forEach var="facility" items="${facilityList}" varStatus="status">
        <tr>
            <td>${status.count}</td>
            <td>${facility.name}</td>
            <td>${facility.area}</td>
            <td>${facility.cost}</td>
            <td>${facility.maxPeople}</td>
            <td>${facility.rentType.name}</td>
            <td>${facility.facilityType.name}</td>
            <td>${facility.standardRoom}</td>
            <td>${facility.descriptionOtherConvenience}</td>
            <td>${facility.poolArea}</td>
            <td>${facility.numberOfFloors}</td>
            <td>${facility.facilityFree}</td>
            <td>
                <button onclick="infoEdit('${facility.getId()}','${facility.name}','${facility.area}','${facility.cost}',
                        '${facility.maxPeople}','${facility.rentType.getId()}','${facility.facilityType.getId()}',
                        '${facility.standardRoom}','${facility.descriptionOtherConvenience}','${facility.poolArea}','${facility.numberOfFloors}','${facility.facilityFree}')"
                        type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#edit">
                    Edit
                </button>
            </td>
            <td>
                <button onclick="infoDelete('${facility.getId()}','${facility.getName()}')" type="button"
                        class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#exampleModal">
                    Delete
                </button>
            </td>
        </tr>
    </c:forEach>
    </tbody>
</table>

<%@include file="../include/footer.jsp" %>

<%-- modal delete--%>
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Delete Customer</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <form action="${pageContext.request.contextPath}/customer?action=delete" method="post">
                <div class="modal-body">
                    <label for="deleteId"></label><input type="text" hidden id="deleteId" name="id">
                    Bạn có muốn xóa khách hàng <span id="deleteName" style="color: brown; font-weight: bold"></span>
                    không ?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                    <button type="submit" class="btn btn-primary">Confirm</button>
                </div>
            </form>
        </div>
    </div>
</div>

<!-- Modal edit -->
<div class="modal fade" id="edit" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
    <div class="modal-dialog modal-xl">
        <div class="modal-content">
            <form action="/customer?action=edit" method="post" class="form-xl">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel1">Chỉnh sửa</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <input name="id" hidden id="idEdit" type="text">
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Rent Type Name</label>
                        <div class="col-sm-9">
                            <select class="form-select" name="facility_type_id" id="rentTypeIdEdit">
                                <c:forEach var="ft" items="${rentTypeList}">
                                    <option value="${ft.id}">${ft.name}</option>
                                </c:forEach>
                            </select>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Facility Type Name</label>
                        <div class="col-sm-9">
                            <select class="form-select" name="facility_type_id" id="facilityTypeIdEdit">
                                <c:forEach var="ft" items="${facilityTypeList}">
                                    <option value="${ft.id}">${ft.name}</option>
                                </c:forEach>
                            </select>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="nameEdit" class="col-sm-3 col-form-label">Name</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="nameEdit" name="name">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="dateEdit" class="col-sm-3 col-form-label">Date Of Birth</label>
                        <div class="col-sm-9">
                            <input type="date" class="form-control" id="dateEdit" name="date_of_birth">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <div class="col-sm-3">Gender</div>
                        <div class="col-sm-9">
                            <label><input type="radio" name="gender" value="true" id="male">Nam</label>
                            <label><input type="radio" name="gender" value="false" id="female">Nữ</label>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="idCardEdit" class="col-sm-3 col-form-label">ID Card</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="idCardEdit" name="id_card">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="phoneNumberEdit" class="col-sm-3 col-form-label">Phone Number</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="phoneNumberEdit" name="phone_number">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="emailEdit" class="col-sm-3 col-form-label">Email</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="emailEdit" name="email">
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="addressEdit" class="col-sm-3 col-form-label">Address</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="addressEdit" name="address">
                        </div>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="submit" class="btn btn-primary">Save changes</button>
                </div>
            </form>
        </div>
    </div>
</div>

<script>
    function addVilla(facility_type_id,name, area, cost, max_people, rent_type_id, standard_room, description_other_convenience,pool_area,number_of_floors,facility_free) {
        document.getElementById("facilityTypeIdAdd").value = 1;
        document.getElementById("nameAdd").value = name;
        document.getElementById("areaAdd").value = area;
        document.getElementById("costAdd").value = cost;
        document.getElementById("maxPeopleAdd").value = max_people;
        document.getElementById("rentTypeIdAdd").value = rent_type_id;
        document.getElementById("standardRoomAdd").value = standard_room;
        document.getElementById("descriptionAdd").value = description_other_convenience;
        document.getElementById("poolAreaAdd").value = pool_area;
        document.getElementById("numberOfFloorAdd").value = number_of_floors;
        let facilityFree = document.getElementById("facilityFreeAdd").value = facility_free;
        facility_free.style.display = 'none';
    }

    function addHouse(facility_type_id,name, area, cost, max_people, rent_type_id, standard_room, description_other_convenience,pool_area,number_of_floors,facility_free) {
        document.getElementById("facilityTypeIdAdd").value = 2;
        document.getElementById("nameAdd").value = name;
        document.getElementById("areaAdd").value = area;
        document.getElementById("costAdd").value = cost;
        document.getElementById("maxPeopleAdd").value = max_people;
        document.getElementById("rentTypeIdAdd").value = rent_type_id;
        document.getElementById("standardRoomAdd").value = standard_room;
        document.getElementById("descriptionAdd").value = description_other_convenience;
        let poolArea = document.getElementById("poolAreaAdd").value = pool_area;
        poolArea.style.display= 'none';
        document.getElementById("numberOfFloorAdd").value = number_of_floors;
        let facilityFree = document.getElementById("facilityFreeAdd").value = facility_free;
        facilityFree.style.display = 'none';
    }

    function addRoom(facility_type_id,name, area, cost, max_people, rent_type_id, standard_room, description_other_convenience,pool_area,number_of_floors,facility_free) {
        document.getElementById("facilityTypeIdAdd").value = 3;
        document.getElementById("nameAdd").value = name;
        document.getElementById("areaAdd").value = area;
        document.getElementById("costAdd").value = cost;
        document.getElementById("maxPeopleAdd").value = max_people;
        document.getElementById("rentTypeIdAdd").value = rent_type_id;
        document.getElementById("standardRoomAdd").display = "none";
        document.getElementById("descriptionAdd").display = "none";
        document.getElementById("poolAreaAdd").display = "none";
        document.getElementById("numberOfFloorAdd").display = "none";
        document.getElementById("facilityFreeAdd").value= facility_free;
    }

    function infoDelete(id, name) {
        document.getElementById("deleteId").value = id;
        document.getElementById("deleteName").innerText = name;
    }

    function infoEdit(id, customerTypeId, name, date_of_birth, id_card, phone_number, email, address, gender) {
        document.getElementById("idEdit").value = id;
        document.getElementById("customerTypeIdEdit").value = customerTypeId;
        document.getElementById("nameEdit").value = name;
        document.getElementById("dateEdit").value = date_of_birth;
        document.getElementById("idCardEdit").value = id_card;
        document.getElementById("phoneNumberEdit").value = phone_number;
        document.getElementById("emailEdit").value = email;
        document.getElementById("addressEdit").value = address;
        if (gender === "true") {
            document.getElementById("male").checked = true;
            document.getElementById("female").checked = false;
        } else {
            document.getElementById("male").checked = false;
            document.getElementById("female").checked = true;
        }
    }
</script>
<script src="../../jquery/jquery-3.5.1.min.js"></script>
<script src="../../datatables/js/jquery.dataTables.min.js"></script>
<script src="../../datatables/js/dataTables.bootstrap5.min.js"></script>
<script>
    $(document).ready(function () {
        $('#tableStudent').dataTable({
            "dom": 'lrtip',
            "lengthChange": false,
            "pageLength": 5
        });
    });
</script>
</body>
</html>
