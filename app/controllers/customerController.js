//option 1
app.controller('CustomersController', function($scope){
            $scope.sortBy = 'name';
            $scope.reverse = 'false';
            $scope.customers = [{joined: '2000-12-02', name:'John', city:'Chandler', orderTotal: 9.9956},
                                {joined: '1965-01-25', name:'Zed', city:'LasVegas', orderTotal:44.99},
                                {joined: '1995-03-28', name:'Dave', city:'Seattle', orderTotal:101.50},
                                {joined: '1994-07-25', name:'Shad', city:'Lucknow', orderTotal: 50.00}]; //customers property
            $scope.doSort = function(propName){
                $scope.sortBy = propName;
                $scope.reverse = !$scope.reverse;
            };
        });
