angular.module('amc').controller('HomeCtrl', function ($scope, DTOptionsBuilder, DTColumnBuilder) {
    
    $scope.dtColumns = [
        DTColumnBuilder.newColumn("AccidentRefNo", "Accident RefNo"),
        DTColumnBuilder.newColumn("Reporter", "Reported By"),
        DTColumnBuilder.newColumn("Date", "Date"),
        DTColumnBuilder.newColumn("Location","Location")
    ]

    $scope.dtOptions = DTOptionsBuilder.newOptions().withOption('ajax', {
        url: "api/Accident",
        type:"GET"
    })
    .withPaginationType('full_numbers')
    .withDisplayLength(10)
    .withDOM('itrl');
});