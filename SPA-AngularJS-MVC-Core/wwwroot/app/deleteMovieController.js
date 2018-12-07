app.controller("deleteMovieController", function ($scope, $location, ShareData, SPACRUDService) {

    getMovie();
    function getMovie() {

        var promiseGetMovie = SPACRUDService.getMovie(ShareData.value);


        promiseGetMovie.then(function (pl) {
            $scope.Movie = pl.data;
        },
            function (errorPl) {
                $scope.error = 'failure loading Movie', errorPl;
            });
    }

    $scope.delete = function () {
        var promiseDeleteMovie = SPACRUDService.deleteMovie(ShareData.value);

        promiseDeleteMovie.then(function (pl) {
            $location.path("/showmovies");
        },
            function (errorPl) {
                $scope.error = 'failure deleting Movie', errorPl;
            });
    };

});