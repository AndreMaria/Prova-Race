
app.controller('kartRankCtrl', ['$scope', '$location', 'factorykartRank', function ($scope, $location, factorykartRank) {

    $('#myModalLap').on('shown.bs.modal', function () {
        $('#myInput').focus()
    });

    $('#myModalAverage').on('shown.bs.modal', function () {
        $('#myInput').focus()
    });

    $('#myModalAfterWinner').on('shown.bs.modal', function () {
        $('#myInput').focus()
    });

    var item = function () {
        this.ArrivalPosition = null;
        this.PilotId = null;
        this.PilotName = null;
        this.LapsCompleted = null;
        this.TotalRunTime = null;
    }
    var bestLap = function () {
        this.AverageSpeed = null;
        this.BestLap = null;
        this.ListSpeed = null;
        this.PilotId = null;
        this.PilotName = null;
        this.TimeMax = null;
        this.TimeMim = null;
        this.TotalTime = null;
        this.Turns = [];
    }

    var afterWinner = function () {
        this.PilotId = null;
        this.PilotName = null;
        this.TotalTime = null;
        this.TimeAfterWinner = null;
    }

    var turn = function () {
        this.value = null;
    }

    $scope.ResultRace = function () {
        factorykartRank.ResultRace(null,function (resultsets) {
            console.log(resultsets);
            if (resultsets.data[0]) {
                var length = resultsets.data.length;
                var array = resultsets.data;
                var arrayRace = [];

                for (var i = 0; i < length; i++) {
                    var race = new item();

                    race.ArrivalPosition = array[i].ArrivalPosition;
                    race.PilotId = array[i].PilotId;
                    race.PilotName = array[i].PilotName;
                    race.LapsCompleted = array[i].LapsCompleted;
                    race.TotalRunTime = array[i].TotalRunTime;

                    arrayRace.push(race);
                }

                $scope.arrayRace = arrayRace;
            }
        });

        $scope.BestLap = function (event, element) {

            params = { pilotId: event.toElement.id };

            factorykartRank.GetRecordByPilotId(params, function (resultsets) {
                console.log(resultsets);
                if (resultsets.data) {
                    var array = resultsets.data;

                    var _bestLap = new bestLap();

                    _bestLap.AverageSpeed = array.AverageSpeed;
                    _bestLap.BestLap = array.BestLap;
                    _bestLap.ListSpeed = array.ListSpeed;
                    _bestLap.PilotId = array.PilotId;
                    _bestLap.PilotName = array.PilotName;
                    _bestLap.TimeMax = array.TimeMax;
                    _bestLap.TimeMim = array.TimeMim;
                    _bestLap.TotalTime = array.TotalTime;
                    _bestLap.Turns = array.Turns;

                    $scope.result = _bestLap;

                }
            });

            $('.js-show-lap').trigger("click");
        }

        $scope.AverageSpeed = function (event, element) {
            params = { pilotId: event.toElement.id };

            factorykartRank.GetRecordByPilotId(params, function (resultsets) {
                console.log(resultsets);
                if (resultsets.data) {
                    var array = resultsets.data;

                    var _bestLap = new bestLap();

                    _bestLap.AverageSpeed = array.AverageSpeed;
                    _bestLap.BestLap = array.BestLap;
                    _bestLap.ListSpeed = array.ListSpeed;
                    _bestLap.PilotId = array.PilotId;
                    _bestLap.PilotName = array.PilotName;
                    _bestLap.TimeMax = array.TimeMax;
                    _bestLap.TimeMim = array.TimeMim;
                    _bestLap.TotalTime = array.TotalTime;
                    _bestLap.Turns = array.Turns;

                    $scope.result = _bestLap;

                }
            });

            $('.js-show-average').trigger("click");
        }

        $scope.ResultAfterWinner = function (event, element) {
            params = { pilotId: event.toElement.id };

            factorykartRank.GetResultAfterWinner(params, function (resultsets) {
                console.log(resultsets);

                if (resultsets.data) {
                    var array = resultsets.data;

                    var _afterWinner = new afterWinner();

                    _afterWinner.PilotId = array.PilotId;
                    _afterWinner.PilotName = array.PilotName;
                    _afterWinner.TotalTime = array.TotalTime;
                    _afterWinner.TimeAfterWinner = array.TimeAfterWinner;

                    $scope.result = _afterWinner;

                }
            });

            $('.js-show-winner').trigger("click");
        }
    }

    $scope.GetRecords = function (event, element) {
        factorykartRank.GetRecords(null,function (resultsets) {
            console.log(resultsets);
            var arrayRace = [];

            if (resultsets.data) {
                
                var array = resultsets.data;
                for (var i = 0 ; i < array.length; i++)
                {
                    var _bestLap = new bestLap();
                    _bestLap.AverageSpeed = array[i].AverageSpeed;
                    _bestLap.BestLap = array[i].BestLap;
                    _bestLap.ListSpeed = array[i].ListSpeed;
                    _bestLap.PilotId = array[i].PilotId;
                    _bestLap.PilotName = array[i].PilotName;
                    _bestLap.TimeMax = array[i].TimeMax;
                    _bestLap.TimeMim = array[i].TimeMim;
                    _bestLap.TotalTime = array[i].TotalTime;
                    _bestLap.Turns = array[i].Turns;
                    arrayRace.push(_bestLap);
                }

            }
            $scope.result = arrayRace;
        });
    }

}]);