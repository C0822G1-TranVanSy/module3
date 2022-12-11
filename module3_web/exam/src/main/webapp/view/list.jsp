<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 10/12/2022
  Time: 4:31 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Danh sách</title>
    <link rel="stylesheet" href="../bootstrap-5.1.3-dist/css/bootstrap.css">
</head>
<body>
<script src="../bootstrap-5.1.3-dist/js/bootstrap.js"></script>
<%@include file="../include/header.jsp" %>

<%------------------------ADD-----------------------------%>
<button type="button" class="btn btn-warning" data-bs-toggle="modal" data-bs-target="#openAddModal">Thêm mới</button>
<!-- Modal add -->
<div class="modal fade" id="openAddModal" tabindex="-1" aria-labelledby="addModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-xl">
        <div class="modal-content">
            <form action="/student?action=add" method="post" class="form-xl">
                <div class="modal-header">
                    <h5 class="modal-title" id="addModalLabel">Thêm mới</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Student Name</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" pattern="([A-Z])([\D]+)" name="name" required>
                            <c:if test="${!errorMap.isEmpty}">
                                <span class="text-danger" id="errorName">${errorMap.get("errorName")}</span>
                            </c:if>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Gender</label>
                        <div class="col-sm-9">
                            <input type="radio" id="genderAdd1" name="gender" value="true" checked>Nam
                            <input type="radio" id="genderAdd2" name="gender" value="false">Nữ
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Date Of Birth</label>
                        <div class="col-sm-9">
                            <input type="date" class="form-control" name="date_of_birth" required>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Score</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" pattern="^((\d+(\.\d*)?)|(\.\d+))$" name="score" required>
                            <c:if test="${!errorMap.isEmpty}">
                                <span class="text-danger" id="errorScore">${errorMap.get("errorScore")}</span>
                            </c:if>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label class="col-sm-3 col-form-label">Class Name</label>
                        <div class="col-sm-9">
                            <select class="form-select" name="class_id">
                                <c:forEach var="cl" items="${studentClassList}">
                                    <option value="${cl.getId()}">${cl.getClassName()}</option>
                                </c:forEach>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" onclick="display()">Close
                    </button>
                    <button type="submit" class="btn btn-primary">Save changes</button>
                </div>
            </form>
        </div>
    </div>
</div>

<%------------------------DisplayList----------------------%>
<h2 class="d-flex justify-content-center text-danger">Student List</h2>
<h3 class="text-success" id="mess">${mess}</h3>
<table id="tableStudent" class="table table-striped">
    <thead>
    <tr>
        <th class="col">STT</th>
        <th class="col">Name</th>
        <th class="col">Gender</th>
        <th class="col">Date Of Birth</th>
        <th class="col">Score</th>
        <th class="col">Class Name</th>
        <th class="col">Edit</th>
        <th class="col">Delete</th>
    </tr>
    </thead>
    <tbody>
    <c:forEach var="student" items="${studentList}" varStatus="status">
        <tr>
            <td>${status.count}</td>
            <td>${student.name}</td>
            <c:if test="${student.gender}">
                <td>Nam</td>
            </c:if>
            <c:if test="${!student.gender}">
                <td>Nữ</td>
            </c:if>
            <td>${student.dateOfBirth}</td>
            <td>${student.score}</td>
            <td>${student.studentClass.className}</td>
            <td>
                <button onclick="infoEdit('${student.getId()}','${student.getName()}','${student.isGender()}','${student.getDateOfBirth()}',
                        '${student.getScore()}','${student.getStudentClass().getId()}')"
                        type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#openEditModal">
                    Edit
                </button>
            </td>
            <td>
                <button onclick="infoDelete('${student.getId()}','${student.getName()}')" type="button"
                        class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#openDeleteModal">
                    Delete
                </button>
            </td>
        </tr>
    </c:forEach>
    </tbody>
</table>

<%------------------------Edit----------------------%>
<!-- Modal edit -->
<div class="modal fade" id="openEditModal" tabindex="-1" aria-labelledby="editModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-xl">
        <div class="modal-content">
            <form action="/student?action=edit" method="post" class="form-xl">
                <div class="modal-header">
                    <h5 class="modal-title" id="editModalLabel">Chỉnh sửa</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <label for="idEdit"></label><input type="text" pattern="([A-Z])([\D]+)" name="id" hidden id="idEdit" >
                    <div class="m-2 row">
                        <label for="nameEdit" class="col-sm-3 col-form-label">Name</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" id="nameEdit" name="name" required>
                            <c:if test="${!errorMap.isEmpty}">
                                <span class="text-danger" id="errorNameEdit">${errorMap.get("errorNameEdit")}</span>
                            </c:if>
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
                        <label for="dateEdit" class="col-sm-3 col-form-label">Date Of Birth</label>
                        <div class="col-sm-9">
                            <input type="date" class="form-control" id="dateEdit" name="date_of_birth" required>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="scoreEdit" class="col-sm-3 col-form-label">Score</label>
                        <div class="col-sm-9">
                            <input type="text" class="form-control" pattern="^((\d+(\.\d*)?)|(\.\d+))$" id="scoreEdit" name="score" required>
                            <c:if test="${!errorMap.isEmpty}">
                                <span class="text-danger" id="errorScoreEdit">${errorMap.get("errorScoreEdit")}</span>
                            </c:if>
                        </div>
                    </div>
                    <div class="m-2 row">
                        <label for="classIdEdit" class="col-sm-3 col-form-label">Class Name</label>
                        <div class="col-sm-9">
                            <select class="form-select" name="class_id" id="classIdEdit">
                                <c:forEach var="sc" items="${studentClassList}">
                                    <option value="${sc.getId()}">${sc.getClassName()}</option>
                                </c:forEach>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" onclick="display()" class="btn btn-secondary" data-bs-dismiss="modal">Close
                    </button>
                    <button type="submit" class="btn btn-primary">Save changes</button>
                </div>
            </form>
        </div>
    </div>
</div>

<%------------------------Delete----------------------%>
<!-- Modal Delete -->
<div class="modal fade" id="openDeleteModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Delete</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <form action="/student?action=delete" method="post">
                <div class="modal-body">
                    <label for="deleteId"></label><input type="text" hidden id="deleteId" name="id">
                    Bạn có muốn xóa khách hàng <span id="deleteName" style="color: #a52a2a; font-weight: bold"></span>
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


<input type="hidden" id="addModal" value="${isModalAdd}">
<input type="hidden" id="editModal" value="${isModalEdit}">
<%@include file="../include/footer.jsp" %>

<script>
    function infoEdit(id, name,gender, date_of_birth, score, class_id ) {
        document.getElementById("idEdit").value = id;
        document.getElementById("nameEdit").value = name;
        if (gender === "true") {
            document.getElementById("male").checked = true;
            document.getElementById("female").checked = false;
        } else {
            document.getElementById("male").checked = false;
            document.getElementById("female").checked = true;
        }
        document.getElementById("dateEdit").value = date_of_birth;
        document.getElementById("scoreEdit").value = score;
        document.getElementById("classIdEdit").value = class_id;

    }

    function infoDelete(id, name) {
        document.getElementById("deleteId").value = id;
        document.getElementById("deleteName").innerText = name;
    }
</script>
<script src="../jquery/jquery-3.5.1.min.js"></script>
<script src="../datatables/js/jquery.dataTables.min.js"></script>
<script src="../datatables/js/dataTables.bootstrap5.min.js"></script>
<script>
    $(document).ready(function () {
        $('#tableStudent').dataTable({
            "dom": 'lrtip',
            "lengthChange": false,
            "pageLength": 5,
        });
    });
</script>
<script>
    function display() {
        document.getElementById("errorName").style.display = "none";
        document.getElementById("errorScore").style.display = "none";
        document.getElementById("errorNameEdit").style.display = "none";
        document.getElementById("errorScoreEdit").style.display = "none";
    }
</script>
<script>
    if ($("#addModal").val() == "true") {
        $(document).ready(function () {
            $("#openAddModal").modal('show');
        });
    }
    if ($("#editModal").val() == "true") {
        $(document).ready(function () {
            $("#openEditModal").modal('show');
        });
    }

    setTimeout(function () {
        close(document.getElementById("mess").style.display = "none")
    }, 5000);
</script>
</body>
</html>
