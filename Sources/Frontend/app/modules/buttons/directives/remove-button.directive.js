(function() {
    angular.module("buttons").directive("removeButton", removeButtonDirective);

    function removeButtonDirective() {
        return {
            restrict: "E",

            replace: true,
            templateUrl: "modules/buttons/directives/templates/remove-button.html"
        };
    }
})();