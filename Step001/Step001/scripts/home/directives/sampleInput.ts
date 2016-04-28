module home {
    var appModule = angular.module("app");
    interface ISampleInputScope extends ng.IScope {
        data: SampleInput;
    }

    appModule.directive("sampleInput", function () {
        return {

            templateUrl: "scripts/home/directives/sampleInput.html",
            controller: ["$scope", Controller]
        };

        function Controller(scope: ISampleInputScope) {
            scope.data =  new SampleInput();
        }
    });
    
}