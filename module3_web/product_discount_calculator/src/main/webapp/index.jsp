<%--
  Created by IntelliJ IDEA.
  User: OS
  Date: 29/11/2022
  Time: 11:23 SA
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
  <head>
    <title>$Title$</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  </head>
  <body>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
  <form action="${pageContext.request.contextPath}/Product" method="post">
    <table>
      <tr>
        <td>Product Description</td>
        <td>
          <label>
            <input type="text" name="ProductDescription" class="form-control" placeholder="Nhập mô tả">
          </label>
        </td>
      </tr>
      <tr>
        <td>List Price</td>
        <td>
          <label>
            <input type="text" name="listPrice" class="form-control" placeholder="Nhập giá">
          </label>
        </td>
      </tr>
      <tr>
        <td>Discount Percent</td>
        <td>
          <label>
            <input type="text" name="discountPercent" class="form-control" placeholder="Nhập tỷ lệ chiết khấu">
          </label>
        </td>
      </tr>
      <tr>
        <td colspan="2">
          <button type="submit" class="btn btn-outline-danger">Send</button>
        </td>
      </tr>
    </table>
  </form>
  </body>
</html>
