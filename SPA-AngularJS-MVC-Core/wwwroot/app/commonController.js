app.controller('commonController', ['$scope','$route',function ($scope,$route ) {
var self = this;
//self.reload = function(){
    //$route.reload();
//}
$scope.reload = function(){
    $route.reload();
}
}]);