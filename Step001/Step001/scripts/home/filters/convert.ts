module home {
    var appModule = angular.module("app");
    appModule.filter("convert", function () {
        return function (text: string) {
            if (text == null) return null;
            return text.toUpperCase();
        }
    });

}