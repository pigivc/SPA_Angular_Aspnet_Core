app.controller('showMoviesController',['$scope', '$controller','$location','$route','SPACRUDService','ShareData', function ($scope, $controller,$location,$route ,SPACRUDService, ShareData) {

    var base = $controller('commonController', { $scope: $scope });

    loadAllStudentsRecords();

    function loadAllStudentsRecords()
    {
        var promiseGetMovie = SPACRUDService.getMovies();
        
        promiseGetMovie.then(function (pl) { 
                $scope.Movies = pl.data 
                },
              function (errorPl) {
                  $scope.error =  errorPl;
              });
    }
    
    //To Edit Movie Information
    $scope.editMovie = function (movieID) {
        ShareData.value = movieID;
        $location.path("/editmovie");
    }

    //To Delete a Movie
    $scope.deleteMovie = function (movieID) {
        ShareData.value = movieID;
        $location.path("/deletemovie");
    }
}]);