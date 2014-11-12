var gulp = require('gulp'),
    gulpLoadPlugins = require('gulp-load-plugins'),
    plugins = gulpLoadPlugins(),
    minimist = require('minimist');

var knownArgs = {
    string: 'env',
    default: { env: 'production' }
};
var args = minimist(process.argv.slice(2), knownArgs);
args.env = args.env.toLowerCase();

gulp.task('default', function () {
    gulp.src('app/**/*.*')
        .pipe(gulp.dest('build'));
});