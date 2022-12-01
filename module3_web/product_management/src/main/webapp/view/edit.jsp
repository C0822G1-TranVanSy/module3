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

    <table>
        <tr><input type="hidden" name="id" value="${product.id}" ></tr>
        <tr>
            <td>Nhập name:</td>
            <td><input type="text" name="name" value="${product.name}" ></td>
        </tr>
        <tr>
            <td>Nhập giá:</td>
            <td><input type="text" name="price" value="${product.price}"></td>
        </tr>
        <tr>
            <td>Nhập mô tả:</td>
            <td><input type="text" name="description" value="${product.description}"></td>
        </tr>
        <tr>
            <td>Nhập hãng sản xuất:</td>
            <td><input type="text" name="brand" value="${product.brand}"></td>
        </tr>
        <tr><td><button type="submit">Save</button></td></tr>
    </table>

</form>
<a href="/product">Back to List</a>
</body>
</html>
