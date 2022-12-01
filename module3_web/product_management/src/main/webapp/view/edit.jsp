<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 01/12/2022
  Time: 1:33 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Edit</title>
</head>
<body>
<form method="post">
    <input type="hidden" name="id" value="${product.id}" >
    Nhập name: <input type="text" name="name" value="${product.name}" ><br>
    Nhập giá: <input type="text" name="price" value="${product.price}"><br>
    Nhập mô tả: <input type="text" name="description" value="${product.description}"><br>
    Nhập hãng sản xuất: <input type="text" name="brand" value="${product.brand}"><br>
    <button type="submit">Save</button>
</form>
<a href="/product">Back to List</a>
</body>
</html>
