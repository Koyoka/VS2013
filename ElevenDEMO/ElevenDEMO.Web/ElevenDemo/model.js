(function () {
    var appModel = angular.module('modelMobule', []);

    var MyControllerId = "modelMobule.myController";
    appModel.controller(MyControllerId, ['$scope', function ($scope) {
        var vm = this;
        vm.Eleven = "@vm.Eleven";
        $scope.Name = "@$scope.Name";
        $scope.Model = "@$scope.Model";
        $scope.Vendors = [
            { Vendor: "v1", Code: "c2" },
            { Vendor: "v2", Code: "c1" }
        ];
        $scope.orderProp1 = "Code";
    }]);

})();