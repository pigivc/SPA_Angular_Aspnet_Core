/// <binding AfterBuild='build-all' />  

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    rename = require("gulp-rename");

var root_path = {
    webroot: "./wwwroot/"
};

//library source  
root_path.nmSrc = "./node_modules/";

//library destination  
root_path.package_lib = root_path.webroot + "lib/";

gulp.task('copy-lib-js', function () {

    gulp.src('./node_modules/core-js/**/*.js')
        .pipe(gulp.dest(root_path.package_lib + 'core-js'));
    gulp.src('./node_modules/angular/**/*.js')
        .pipe(gulp.dest(root_path.package_lib + 'angular'));
    gulp.src('./node_modules/angular-route/**/*.js')
        .pipe(gulp.dest(root_path.package_lib + 'angular/router'));
    gulp.src('./node_modules/angular-ui-router/**/*.js')
        .pipe(gulp.dest(root_path.package_lib + 'angular/ui-router'));

});


gulp.task("copy-all", ["copy-lib-js"]);
//Copy End  

gulp.task('min-js', function () {
    gulp.src(['./clientapp/**/*.js'])
        .pipe(uglify())
        .pipe(gulp.dest(root_path.webroot + 'app'))
});

gulp.task('copy-html', function () {
    gulp.src('clientapp/**/*.html')
        .pipe(gulp.dest(root_path.webroot + 'app'));
});

gulp.task("build-all", ["min-js", "copy-html"]);
//Build End  