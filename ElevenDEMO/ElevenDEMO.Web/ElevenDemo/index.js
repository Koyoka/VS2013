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

//1. 定义模块,和加载模块  angular.module('',[]);
//2. 定义controller  angular.module('').controller('controllerName',['$scope',...,function($scope,...){}]);
//3. 模板页配置路由表  routeProviter ，  angular.config(['$routeProviter',function($routeProviter){}]);