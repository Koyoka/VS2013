(function () {
    var appModul = angular.module('app');//angular.module('otherModelModule', []);

    var controllerId = "otherModelModule.mycontroller";
    //$routeParams
    appModul.controller(controllerId, ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams) {
        $http.get('vendor.json').success(function (data) {
            //alert(data)
            var p = $routeParams;
            if (p.Id && p.cc) {
                window.alert(p.Id + " " + p.cc);
            } else if (p.Id) {
                window.alert(p.Id);
            } 
            
            $scope.VenderService = data;
        });
        $scope.event_click = function () {
            alert("cccc");
        }
        $scope.setImage = function (imageUrl) {
            alert(imageUrl);
        };
    }]);


})();