﻿app.controller("FetchCtrl", function ($scope, $http) {

   
    $scope.url = function () {

        console.log("fetchcontroller is here");

        $http.get("/api/Response")
            .success(function (data, status, headers, config) {
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
    };


    //example of AJAX GET call:
    //$("button").click(function () {
    //    $.get("demo_test.asp", function (data, status) {
    //        alert("Data: " + data + "\nStatus: " + status);
    //    });
    //});



});