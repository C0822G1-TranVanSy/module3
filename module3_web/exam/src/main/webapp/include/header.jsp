<%@ page contentType="text/html;charset=UTF-8" language="java" %>

<div class="m-2">
    <div class="d-flex justify-content-between text-center">
        <span><img src="../picture/CodeGym-3-02-copy.jpg" height="80" width="400" alt="logo lỗi"/></span>
        <span class="d-flex align-items-center text-danger">Trần Văn Sỹ</span>
    </div>
</div>

<nav class="navbar navbar-expand-lg navbar-light " style="background: #046056">
    <div class="container-fluid">
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02"
                aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="home.jsp">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="/student">Student</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" href="/teacher">Teacher</a>
                </li>

            </ul>
            <form class="d-flex">
                <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                <button class="btn btn-outline-warning" type="submit">Search</button>
            </form>
        </div>
    </div>
</nav>