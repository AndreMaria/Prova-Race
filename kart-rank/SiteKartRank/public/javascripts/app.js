var app = angular.module('kartRank', ['serverkartRank', 'ngRoute']);

app.config(['$routeProvider',function ($routeProvider) {
    debugger;
    $routeProvider
        .when('/', { templateUrl: '/public/partials/race/resultRace.html', controller: 'kartRankCtrl' })
        .when('/records', { templateUrl: '/public/partials/race/Records.html', controller: 'kartRankCtrl' })
        .otherwise({ redirectTo: '/' });
}]);