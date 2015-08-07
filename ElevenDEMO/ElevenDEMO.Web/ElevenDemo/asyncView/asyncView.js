(function () {
    var controllerId = "app.asyncView";
    angular.module('app').controller(controllerId, ['$scope','$q', function ($scope,$q) {
        var vm = this;
        vm.name = "";

        $scope.$watch('vm.name', function (n, o) {
            //window.alert(n+" " +o);
        });

        var asyncGreet = function (name) {
            var deferred = $q.defer();

            setTimeout(function () {
                deferred.notify('About to greet ' + name + '.');

                if (name == 'eleven') {
                    deferred.resolve('Hello, ' + name + '!');
                } else {
                    deferred.reject('No ' + name + ' !');
                }
            }, 2000);

            return deferred.promise;
        };

        //var promise = asyncGreet(vm.name);
        //promise.then(function (greeting) {
        //    alert('Success: ' + greeting);
        //}, function (reason) {
        //    alert('Failed: ' + reason);
        //}, function (update) {
        //    alert('Notify: ' + update);
        //});


        vm.Model = {name:'eleven'};

    }]);
})();