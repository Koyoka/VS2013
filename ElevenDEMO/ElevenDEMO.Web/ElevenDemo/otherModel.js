(function () {
    var appModul = angular.module('app');//angular.module('otherModelModule', []);

    var controllerId = "otherModelModule.mycontroller";
    appModul.controller(controllerId, ['$scope','$http', function ($scope,$http) {
        $http.get('vendor.json').success(function (data) {
            $scope.VenderService = data;
        });
    }]);


})();