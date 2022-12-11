<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 10/12/2022
  Time: 2:51 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Home</title>
    <link rel="stylesheet" href="../bootstrap-5.1.3-dist/css/bootstrap.css">
</head>
<body>
<script src="../bootstrap-5.1.3-dist/js/bootstrap.js"></script>
<%@include file="../include/header.jsp"%>
<div class="row">
    <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3 ">
        <ul class="list-group vh-100 overflow-scroll" style="border: 1px solid #7952b3;">
            <li class="list-group-item ">An active item</li>
            <li class="list-group-item ">A second item</li>
            <li class="list-group-item ">A third item</li>
            <li class="list-group-item ">An active item</li>
        </ul>
    </div>
    <div class="col-xs-12 col-sm-6 col-md-8 col-lg-9">
        <div class="row m-2">
            <img src="../picture/soiden.jpg" height="600" width="750" alt="ảnh lỗi"/>
        </div>
    </div>
</div>
<%@include file="../include/footer.jsp"%>
</body>
</html>
