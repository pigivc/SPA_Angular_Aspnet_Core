app.controller("editMovieController", function ($scope, $location, ShareData, SPACRUDService) {
    getMovie();

    function getMovie() {        
        var promiseGetMovie = SPACRUDService.getMovie(ShareData.value);

        promiseGetMovie.then(function (pl)
        {
            $scope.Movie = pl.data;
        },
              function (errorPl) {
                  $scope.error = 'failure loading Student', errorPl;
              });
    }

    $scope.save = function () {
        var Movie = {
            Title: $scope.Movie.title,
            Gener: $scope.Movie.gener,
            ReleaseDate: $scope.Movie.releaseDate,
            Thumbnail: $scope.Movie.thumbnail,
            Description: $scope.Movie.description,
        }; 

        var promisePutMovie = SPACRUDService.EditMovie($scope.Movie.id, Movie);
        promisePutMovie.then(function (pl)
        {
            $location.path("/showmovies");
        },
              function (errorPl) {
                  $scope.error = 'failure loading Movie', errorPl;
              });
    };

});