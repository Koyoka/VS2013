(function () {
    'use strict';
    var app = angular.module('app', []);

    var MyControllerId = "MyController";
    var MyControllerHttpId = "MyControllerHttpId";
    
    //构造控制器
    //var MyControllerController = function ($scope) {};
    //
    //MyControllerController.$inject = ['$scope'];// 声明注入 解决js压缩问题 数组表示注入的服务模块
    
    //构造控制器 js数组方式 解决注入变量名 压缩问题
    //var MyControllerController = ['$scope', function ($scope) {}];

    //app.controller(MyControllerId, MyControllerController) {//一般构造控制器方法
    app.controller(MyControllerId, function ($scope) {//一般构造控制器方法
        var vm = this;
        vm.Eleven = "@vm.Eleven";
        $scope.Name = "@$scope.Name";
        $scope.Model = "@$scope.Model";
        $scope.Vendors = [
            { Vendor: "v1", Code: "c2" },
            { Vendor: "v2", Code: "c1" }
        ];
        $scope.orderProp1 = "Code";
    });

    app.controller(MyControllerHttpId, ['$scope', '$http', function ($scope, $http) {
        $http.get('vendor.json').success(function (data) {
            $scope.VenderService = data;
        });
    }])

 
})();