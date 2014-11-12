'use strict';
var app = angular.module('doma', ['ui.router', 'angular-loading-bar', 'navigation', 'restangular', 'house']);


app.config(function ($stateProvider, $urlRouterProvider, $tooltipProvider) {

    $stateProvider.state('home', {url: '/'});

    $urlRouterProvider.otherwise('/');
    
    $tooltipProvider.setTriggers({
        'mouseenter': 'mouseleave',
        'click': 'mouseleave',
        'focus': 'blur'
    });
});

app.run(function ($rootScope, $state, authSvc, Restangular, APIAddress) {
    $rootScope.$state = $state;
    
    Restangular.setDefaultHeaders({'Content-Type': 'application/json'});
    Restangular.setBaseUrl(APIAddress);
    Restangular.setRestangularFields({ id: "Id" });
});

app.constant('APIAddress', 'http://localhost:20818/');