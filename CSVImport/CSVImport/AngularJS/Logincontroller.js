LoginApp.controller('LoginController', ['$scope', ' MyService ', function ($scope, MyService) {
    $scope.submit = function () {
        var UserData = {
            Username: $scope.Username,
            Password: $scope.Password,
        }
        Myservice.LoginValidate(UserData).then(function (pl) {
            //result data
            alert(pl.data);
        });
    }
}])