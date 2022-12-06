<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 06/12/2022
  Time: 10:38 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Create Customer</title>
</head>
<body>
<form action="/customer?action=insert" method="post">
<div class="mb-3 row">
    Customer Type Name
    <select name="customer_type_id">
        <option>1</option>
        <option>2</option>
        <option>3</option>
        <option>4</option>
        <option>5</option>
    </select>
</div>
<div class="mb-3 row">
    <label for="staticName" class="col-sm-2 col-form-label">Name</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticName" name= "name">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticDate" class="col-sm-2 col-form-label">Date Of Birth</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticDate" name= "date_of_birth">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticGender" class="col-sm-2 col-form-label">Gender</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticGender" name= "gender">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticIdCard" class="col-sm-2 col-form-label">ID Card</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticIdCard" name= "id_card">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticPhoneNumber" class="col-sm-2 col-form-label">Phone Number</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticPhoneNumber" name= "phone_number">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticEmail" class="col-sm-2 col-form-label">Email</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticEmail" name= "email">
    </div>
</div>
<div class="mb-3 row">
    <label for="staticAddress" class="col-sm-2 col-form-label">Address</label>
    <div class="col-sm-10">
        <input type="text" readonly class="form-control-plaintext" id="staticAddress" name= "address">
    </div>
</div>
    <button type="submit">Save</button>
</form>
</body>
</html>
