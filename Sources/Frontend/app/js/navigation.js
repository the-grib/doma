'use strict';
var navigation = angular.module('navigation', ['ui.router']);


navigation.service('navSvc', function () {

    var mainMenu = [];
    this.getMainMenu = function () {
        return mainMenu;
    };
    this.addMainMenuItem = function (name, stateName) {
        mainMenu.push({name: name, state: stateName});
    };

    var specialMenu = [];
    this.getSpecialMenu = function () {
        return specialMenu;
    };
    this.addSpecialMenuItem = function (name, stateName) {
        specialMenu.push({name: name, state: stateName});
    };
    this.removeSpecialMenuItem = function (name) {
        for (var i = 0; i < specialMenu.length; i++) {
            if (specialMenu[i].name === name) {
                specialMenu.splice(i, 1);
                break;
            }
        }
    };
});

navigation.controller('navCtrl', ['$scope', 'navSvc', function ($scope, navSvc) {

    $scope.mainMenu = navSvc.getMainMenu();
    $scope.specialMenu = navSvc.getSpecialMenu();

    $scope.isCollapsed = true;
}]);