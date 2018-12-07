var app = angular.module("ApplicationModule", ["ngRoute"]);

app.factory("ShareData", function () {
    return { value: 0 }
});

//Showing Routing
app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    debugger;
    $routeProvider.when('/showmovies',
                        {
                            templateUrl: 'Movie/AllMovies',
                            controller: 'showMoviesController'
                        });
    $routeProvider.when('/addmovie',
                        {
                            templateUrl: 'Movie/AddMovie',
                            controller: 'addMovieController'
                        });
    $routeProvider.when("/editmovie",
                        {
                            templateUrl: 'Movie/EditMovie',
                            controller: 'editMovieController'
                        });
    $routeProvider.when('/deletemovie',
                        {
                            templateUrl: 'Movie/DeleteMovie',
                            controller: 'deleteMovieController'
                        });
    $routeProvider.otherwise(
                        {
                            redirectTo: '/'
                        });
    
    $locationProvider.html5Mode(true).hashPrefix('!')
}]);