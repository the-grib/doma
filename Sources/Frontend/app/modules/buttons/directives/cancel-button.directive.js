(function() {
    angular.module("buttons").directive("cancelButton", cancelButtonDirective);

    function cancelButtonDirective() {
        return {
            restrict: "E",

            replace: true,
            templateUrl: "modules/buttons/directives/templates/cancel-button.html"
        };
    }
})();