app.controller('addMovieController', function ($scope, SPACRUDService) {
    $scope.StudentID = 0;
     
    $scope.save = function () {
        var Movie = {
            Title: $scope.Title,
            Gener: $scope.Gener,
            ReleaseDate: $scope.ReleaseDate,
            Thumbnail: $scope.Thumbnail,
            Description: $scope.Description
        };

        var promisePost = SPACRUDService.addMovie(Movie);

        promisePost.then(function (pl) {
            alert("Movie Saved Successfully.");
        },
              function (errorPl) {
                  $scope.error = 'failure saving Movie', errorPl;
                    alert("Operation failed.");
              });

    };

});