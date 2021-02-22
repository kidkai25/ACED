var myApp = angular.module("myApp", []);


myApp.controller('myController',['$scope', '$log', 'notify', function($scope, $log, notify){
    
    $scope.callNotify = function(msg){
        notify(msg);
    }
        
}]);

myApp.directive('myDirective', function(){    
    return {        
        template: '<h1>myDirective</h1>'        
    }
})


myApp.factory('notify', ['$window', function(win){
    let msgs = [];
    return function(msg){
        msgs.push(msg);
        
        if(msgs.length === 3)
        {
            win.alert(msgs.join('\n'));
            msgs=[];
        }
    }
}]);

