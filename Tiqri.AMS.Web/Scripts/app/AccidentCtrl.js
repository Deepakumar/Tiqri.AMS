angular.module('amc').controller('AccidentCtrl', function ($scope,$state, $stateParams, accidentData) {
    var accident = {
        categoryId: 0,
        titleId: 0,
        firstName: "",
        invPerStype:1
    };
    $scope.showInvPersonDetails = false;
    var result = accidentData.getAccidentCategories();
    result.then(
            function (categories) {
                $scope.accidentCategories = categories
            },
            function (response) {

            }
        );
    $scope.selectCategory = function (cat) {
        debugger;
        accident.categoryId = cat.ID;
        $state.go('accident.reporter');
    }
    $scope.invPerStype = function (typeid) {
        if (typeid != 1) {
            $scope.showInvPersonDetails = true;
        }
        else {
            $scope.showInvPersonDetails = false;
        }
    }
});