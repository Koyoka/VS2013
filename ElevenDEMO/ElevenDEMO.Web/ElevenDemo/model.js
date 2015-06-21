(function () {
    var appModel = angular.module('modelMobule', [
       
    ]);

    var MyControllerId = "modelMobule.myController";
   
    appModel.controller(MyControllerId, ['$scope', 'myService', 'facetorytest', function ($scope, myService, facetorytest) {
        //alert(22)
        var vm = this;
        vm.Eleven = "@vm.Eleven";
        $scope.Name = "@$scope.Name";
        $scope.Model = "@$scope.Model";
        $scope.Vendors = [
            { Vendor: "v1", Code: "c2" },
            { Vendor: "v2", Code: "c1" }
        ];
        $scope.orderProp1 = "Code";
       
       
        $scope.event_click = function () {
            //myService.func1();
            //myService.func2("hahahaha");
            
            abp.services.app.bizBaseData.getVendors({
                //params
            }).done(function (data, p) {
                window.alert(data);
            });
        };
    }]);

})();