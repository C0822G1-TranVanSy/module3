<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 01/12/2022
  Time: 11:12 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Create</title>
</head>
<body>
<form method="post">
    <table>
        <tr>
            <td>Nhập name:</td>
            <td><label>
                <input type="text" name="name">
            </label></td>
        </tr>
        <tr>
            <td>Nhập giá:</td>
            <td><label>
                <input type="text" name="price">
            </label></td>
        </tr>
        <tr>
            <td>Nhập mô tả:</td>
            <td><label>
                <input type="text" name="description">
            </label></td>
        </tr>
        <tr>
            <td>Nhập hãng sản xuất:</td>
            <td><label>
                <input type="text" name="brand">
            </label></td>
        </tr>
        <tr>
            <td><button type="submit">Save</button></td>
            <td><a href="/product">Back to customer list</a></td>
        </tr>

    </table>
</form>

</body>
</html>
