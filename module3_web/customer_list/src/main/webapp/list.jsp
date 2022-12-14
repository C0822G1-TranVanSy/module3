<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 30/11/2022
  Time: 10:56 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>

<html>
<head>
    <title>Title</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
<h1 style="text-align: center">Danh sách khách hàng</h1>
    <table class="table table-striped d-flex justify-content-center">
    <tr>
        <th>STT</th>
        <th>Tên</th>
        <th>Ngày sinh</th>
        <th>Địa chỉ</th>
        <th>Ảnh</th>
    </tr>
    <c:forEach var="customer" items="${customerList}" varStatus="status">
     <tr>
         <td>${status.count}</td>
         <td><c:out value="${customer.name}"/></td>
         <td><c:out value="${customer.dateOfBirth}"/></td>
         <td><c:out value="${customer.address}"/></td>
         <td><img src="${customer.picture}" alt="ảnh lỗi" style="width: 50px;height: 50px"></td>
     </tr>
    </c:forEach>
</table>
</body>
</html>
