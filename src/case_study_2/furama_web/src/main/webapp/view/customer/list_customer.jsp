<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 06/12/2022
  Time: 12:00 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Customer List</title>
    <link rel="stylesheet" href="../../bootstrap-5.1.3-dist/css/bootstrap.css">
</head>
<body>
<script src="../../bootstrap-5.1.3-dist/js/bootstrap.js"></script>
<%@include file="../include/header.jsp"%>
<h2 class="d-flex justify-content-center text-danger">Customer List</h2>
<table class="table table-striped">
    <tr>
        <th>STT</th>
        <th>Customer Type ID</th>
        <th>Customer Name</th>
        <th>Date Of Birth</th>
        <th>Gender</th>
        <th>ID Card</th>
        <th>Phone Number</th>
        <th>Email</th>
        <th>Address</th>
    </tr>
    <c:forEach var="customer" items="${customerList}" varStatus="status">
        <tr>
            <td>${status.count}</td>
            <td>${customer.customerType.name}</td>
            <td>${customer.name}</td>
            <td>${customer.dateOfBirth}</td>
            <c:if test="${customer.gender}">
                <td>Nam</td>
            </c:if>
            <c:if test="${!customer.gender}">
                <td>Nữ</td>
            </c:if>
            <td>${customer.idCard}</td>
            <td>${customer.phoneNumber}</td>
            <td>${customer.email}</td>
            <td>${customer.address}</td>
        </tr>
    </c:forEach>

</table>
<%@include file="../include/footer.jsp"%>

</body>
</html>
