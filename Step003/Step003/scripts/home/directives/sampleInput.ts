module home {
    var appModule = angular.module("app");
    interface ISampleInputScope extends ng.IScope {
        data: SampleInput;
    }

    appModule.directive("sampleInput", function () {
        return {

            templateUrl: "scripts/home/directives/sampleInput.html",
            controller: ["$scope","$http", Controller]
        };

        function Controller(scope: ISampleInputScope, $http: ng.IHttpService) {
            scope.data = new SampleInput();
            debugger;

            var result = $http.post("api/customer/add", { id: uuid.v4(), name: 'mitsos' });
            var result = $http.post("api/customer/add", { id: uuid.v4(), name: 'mitsos2' });


            var result = $http.post("api/customer/find", {});

        }
    });
    
}