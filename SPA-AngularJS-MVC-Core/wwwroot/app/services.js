 
app.service("SPACRUDService", function ($http) {

    //Read all Movies
    this.getMovies = function () {
      
        return $http.get("/api/MovieApi");
    };

    //Fundction to Read Movie by Movie ID
    this.getMovie = function (id) {
        return $http.get("/api/MovieApi/" + id);
    };

    //Function to create new Movie
    this.addMovie = function (Movie) {
        var request = $http({
            method: "post",
            url: "/api/MovieApi",
            dataType: 'json',
            data: Movie,
        });
        return request;
    };

    //Edit Movie By ID 
    this.EditMovie = function (id, Movie) {
        var request = $http({
            method: "put",
            url: "/api/MovieApi/" + id,
            dataType: 'json',
            data: Movie
        });
        return request;
    };

    //Delete Movie By Movie ID
    this.deleteMovie = function (id) {
        var request = $http({
            method: "delete",
            url: "/api/MovieApi/" + id
        });
        return request;
    };
});








