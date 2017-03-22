angular.module('serverkartRank', ['ngResource']).factory(
    'factorykartRank',
    function ($http) {
        return {
            GetRecords: function (params, callback) {
                $http.get('http://localhost:1341/api/Race/GetRecords', params).then(function (resultsets) {
                    callback(resultsets);
                }, function (err) {
                    console.log(err);
                })
            },
            GetRankPosition: function (params, callback) {
                $http.get('http://localhost:1341/api/Race/GetRankPosition', params).then(function (resultsets) {
                    callback(resultsets);
                }, function (err) {
                    console.log(err);
                })
            },
            ResultRace: function (params, callback) {
                $http.get('http://localhost:1341/api/Race/ResultRace', params).then(function (resultsets) {
                    callback(resultsets);
                },function (err) {
                    console.log(err);
                })
            },
            GetRecordByPilotId: function (data, callback) {

                var config = {
                    params: data,
                    headers: { 'Accept': 'application/json' }
                };

                $http.get('http://localhost:1341/api/Race/GetRecordByPilotId/', config).then(function (resultsets) {
                    callback(resultsets);
                }, function (err) {
                    console.log(err);
                })
            },
            GetResultAfterWinner: function (data, callback) {

                var config = {
                    params: data,
                    headers: { 'Accept': 'application/json' }
                };

                $http.get('http://localhost:1341/api/Race/GetResultAfterWinnerByPilotId/', config).then(function (resultsets) {
                    callback(resultsets);
                }, function (err) {
                    console.log(err);
                })
            }
        };
    });
