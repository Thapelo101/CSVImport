angular.module('LoginApp').service('LoginService', function ($http) {
    this.LoginValidate = function (UserData) {
        var result = $http({
            method: "Post",
            url: --YYYYYYYYYYYYY, //pass UserData Values to class file
            data: save
        });
        return result;
    }
});