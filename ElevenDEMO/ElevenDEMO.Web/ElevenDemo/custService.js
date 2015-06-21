(function () {
    
    var myServiceModule = angular.module('serviceModule', []);
    
    myServiceModule.factory('facetorytest', ['$window',         //factory方式
        function () {
            return {
                CC: function () {
                    alert('elelelelelel');
                }
            };
        }
    ]);

    myServiceModule.factory('myService',function(){
        var _func1 = function () {
            alert('this is func1 from service!')
        }
        var _func2 = function (name) {
            alert(name + " from service func2!");
        }
        return {
            func1: _func1,
            func2: _func2
        };
       
    });

})();