var app = angular.module('kartRank');

app.directive('bestLap', function () {
    console.log('Start directive bestlap kartRankCtrl');
    return {
        controller: 'kartRankCtrl',
        restrict: 'E',
        templateUrl: '/public/directives/BestLap.html'
    }
});

app.directive('averageSpeed', function () {
    console.log('Start directive');
    return {
        controller: 'kartRankCtrl',
        restrict: 'E',
        templateUrl: '/public/directives/AverageSpeed.html'
    }
});

app.directive('afterWinner', function () {
    console.log('Start directive');
    return {
        controller: 'kartRankCtrl',
        restrict: 'E',
        templateUrl: '/public/directives/AfterWinner.html'
    }
});


