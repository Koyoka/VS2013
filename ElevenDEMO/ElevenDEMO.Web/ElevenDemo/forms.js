(function () {
    var controllerId = "app.fromsController";

    angular.module('app').controller(controllerId, ['$scope', function ($scope) {
        var vm = this;

        //window.alert(controllerId);

        vm.aa = "eleven";
        
        vm.orders = [];
        vm.orders.push(
            {
                id: 1,
                name:'eleven'
            });
        vm.orders.push(
            {
                id: 2,
                name: 'koyoka'
            });
        
        vm.click = function () {
            //$scope.myForm.submit();
            window.alert($scope.myForm.$valid);
        };

    }]);

})();