(function() {
    angular.module("buttons").directive("editButton", editButtonDirective);

    function editButtonDirective() {
        return {
            restrict: "E",

            replace: true,
            templateUrl: "modules/buttons/directives/templates/edit-button.html"
        };
    }
})();