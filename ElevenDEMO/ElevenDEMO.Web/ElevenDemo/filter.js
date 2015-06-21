(function () {
    var filterModule = angular.module('filterModule', []);
    filterModule
    .filter('filter1', function () {
        return function (input1) {
            return input1 + "-filter-output";
        }
    })
    .filter('filter2', function () {
        return function (input1) {
            return input1.Code + "##" + input1.Vendor;
        }
    });

})();