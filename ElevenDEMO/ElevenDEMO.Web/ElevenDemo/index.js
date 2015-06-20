(function () {
    'use strict';

    var appRoute = angular.module('app', [
        'ngRoute',
        'modelMobule'//register new module
    ]);
    

    appRoute.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/model', { templateUrl: 'model.html', controller: 'modelMobule.myController' }).
            when('/otherModel', { templateUrl: 'otherModel.html', controller: 'otherModelModule.mycontroller' }).
            otherwise({ redirectTo: '/model' });
    }]);

})();

//1. ����ģ��,�ͼ���ģ��  angular.module('',[]);
//2. ����controller  angular.module('').controller('controllerName',['$scope',...,function($scope,...){}]);
//3. ģ��ҳ����·�ɱ�  routeProviter ��  angular.config(['$routeProviter',function($routeProviter){}]);