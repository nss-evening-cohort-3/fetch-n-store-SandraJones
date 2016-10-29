app.controller("FetchCtrl", function ($scope, $http) {

   
    $scope.address = "";
    $scope.status = "";
    $scope.httpMethod = document.getElementById("getButton");
    $scope.elapsed;

    $scope.URLmethod = function () {
        var begin = Date.now();
        console.log("fetchcontroller is here");
        console.log($scope.address);
        $http.get($scope.address)
            .then(function success(response) {
                var end = Date.now();              
                $scope.status = response.status;          
                $scope.elapsed = end - begin;
            }, function error(response) {
                $scope.title = "Oops... something went wrong";
                $scope.working = false;
                
            });        
    };
});