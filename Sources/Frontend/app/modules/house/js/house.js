'use strict';
var house = angular.module("house", ["restangular", "buttons"]);


house.config(function ($stateProvider) {

    $stateProvider.state('posts', {
        abstract: true,
        url: '/posts',
        template: '<div ui-view></div>'
    });

    $stateProvider.state('posts.list', {
        url: '',
        controller: 'postsCtrl',
        templateUrl: 'modules/house/html/states/posts.list.html'
    });

    $stateProvider.state('posts.item', {
        url: '/{id:[0-9a-fA-F-]+}',
        controller: 'postCtrl',
        templateUrl: 'modules/house/html/states/posts.item.html'
    });
});

house.run(function ($rootScope, $state, navSvc) {
    navSvc.addMainMenuItem('My house', 'posts.list');
});