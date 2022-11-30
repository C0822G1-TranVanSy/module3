<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 30/11/2022
  Time: 1:32 CH
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>$Title$</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"
          integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"
        crossorigin="anonymous"></script>
<body>
<h2 class="text-center">Calculator</h2>
<form action="${pageContext.request.contextPath}/calculator" method="post">
    <table class="table table-striped d-flex justify-content-center">
        <tr>
            <td>First operand:</td>
            <td><label>
                <input class="form form-control" type="text" name="firstOperand" required>
            </label>
            </td>
        </tr>
        <tr>
            <td>Operand:</td>
            <td>
                <label>
                    <select class="form form-control" name="opera">
                        <option value="Addition">Addition</option>
                        <option value="Subtraction">Subtraction</option>
                        <option value="Multiplication">Multiplication</option>
                        <option value="Division">Division</option>
                    </select>
                </label>
            </td>
        </tr>
        <tr>
            <td>Second operand:</td>
            <td><label>
                <input class="form form-control" type="text" name="secondOperand" required>
            </label></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <button type="submit" class="btn btn-outline-danger">Calculate</button>
            </td>
        </tr>
    </table>
</form>
</body>
</html>
