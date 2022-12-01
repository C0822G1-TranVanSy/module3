<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 01/12/2022
  Time: 9:16 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>View</title>
</head>
<body>
<h1>Customer details</h1>
<p>
    <a href="/product">Back to customer list</a>
</p>
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
</table>
</body>
</html>
