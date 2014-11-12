(function() {
    angular.module("buttons").directive("applyButton", applyButtonDirective);

    function applyButtonDirective() {
        return {
            restrict: "E",

            replace: true,
            templateUrl: "modules/buttons/directives/templates/apply-button.html"
        };
    }
})();