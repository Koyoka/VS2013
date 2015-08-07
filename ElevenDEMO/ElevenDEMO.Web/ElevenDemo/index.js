(function () {
    'use strict';

    var appRoute = angular.module('app', [
        'ngRoute',
        'modelMobule',//register new module,
        'filterModule',
         'serviceModule'
    ]);
    

    appRoute.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/model', { templateUrl: 'model.html', controller: 'modelMobule.myController as vm' }).
            when('/otherModel', { templateUrl: 'otherModel.html', controller: 'otherModelModule.mycontroller as vm' }).
            when('/otherModel/:Id', { templateUrl: 'otherModel.html', controller: 'otherModelModule.mycontroller' }).
            when('/otherModel/:Id/:cc', { templateUrl: 'otherModel.html', controller: 'otherModelModule.mycontroller' }).
            when('/forms', { templateUrl: 'forms.html', controller: 'app.fromsController as vm' }).
            when('/BMD', { templateUrl: 'bootstrap-material-design.html', controller: 'app.bmd as vm' }).
            when('/ASYNC', { templateUrl: 'asyncView/asyncView.html', controller: 'app.asyncView as vm' }).
            otherwise({ redirectTo: '/model/' });
        $.material.init();
    }]);

})();

//1. ����ģ��,�ͼ���ģ��  angular.module('',[]);
//2. ����controller  angular.module('').controller('controllerName',['$scope',...,function($scope,...){}]);
//3. ģ��ҳ����·�ɱ�  routeProviter ��  angular.config(['$routeProviter',function($routeProviter){}]);