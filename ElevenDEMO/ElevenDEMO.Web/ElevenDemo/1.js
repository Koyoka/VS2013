(function () {
    'use strict';
    var app = angular.module('app', []);

    var MyControllerId = "MyController";
    var MyControllerHttpId = "MyControllerHttpId";
    
    //���������
    //var MyControllerController = function ($scope) {};
    //
    //MyControllerController.$inject = ['$scope'];// ����ע�� ���jsѹ������ �����ʾע��ķ���ģ��
    
    //��������� js���鷽ʽ ���ע������� ѹ������
    //var MyControllerController = ['$scope', function ($scope) {}];

    //app.controller(MyControllerId, MyControllerController) {//һ�㹹�����������
    app.controller(MyControllerId, function ($scope) {//һ�㹹�����������
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