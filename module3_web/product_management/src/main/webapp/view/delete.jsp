<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 01/12/2022
  Time: 5:03 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Delete</title>
</head>
<body>
<form action="/product?action=delete&id=${product.id}" method="post">
    <h3>Are you sure?</h3>
    <table>
        <tr>
            <td>Name:</td>
            <td>${requestScope["product"].getName()}</td>
        </tr>
        <tr>
            <td>Price:</td>
            <td>${requestScope["product"].getPrice()}</td>
        </tr>
        <tr>
            <td>Description:</td>
            <td>${requestScope["product"].getDescription()}</td>
        </tr>
        <tr>
            <td>Brand:</td>
            <td>${requestScope["product"].getBrand()}</td>
        </tr>
        <tr>
            <td><input type="submit" value="Delete product"></td>
            <td><a href="/product">Back to customer list</a></td>
        </tr>
    </table>
</form>
</body>
</html>

