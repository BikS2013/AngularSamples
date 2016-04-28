module home {

    var appModule = angular.module("app");
    interface ILengthLabelScope extends ng.IScope {
        localData: SampleInput;
        getLength: () => number;
    }
    appModule.directive("lengthLabel", function () {
        return {
            replace: true,
            scope: {
                localData: "="
            },
            templateUrl: "scripts/home/directives/lengthLabel.html",
            controller: ["$scope", Controller]
        };

        function Controller(scope: ILengthLabelScope) {

            scope.getLength = () => {
                if (!(scope.localData && scope.localData.text) ) {
                    return 0; 
                }
                return scope.localData.text.length;
            }
        }
    });

}