app.controller("FetchCtrl", function ($scope, $http) {

   
    $scope.address = "";
    $scope.status = "";
    $scope.httpMethod = "";
    $scope.responseTime = "";

    $scope.URLmethod = function () {

        console.log("fetchcontroller is here");
        console.log($scope.address);
        $http.get($scope.address)
            .then(function success(response) {
                console.log(response);
                $scope.status = response.status;
            }, function error(response) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
            });
    };
});

