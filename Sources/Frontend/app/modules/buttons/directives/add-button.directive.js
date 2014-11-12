(function() {
    angular.module("buttons").directive("addButton", addButtonDirective);

    function addButtonDirective() {
        return {
            restrict: "E",

            replace: true,
            templateUrl: "modules/buttons/directives/templates/add-button.html"
        };
    }
})();