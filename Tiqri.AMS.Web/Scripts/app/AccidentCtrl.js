angular.module('amc').controller('AccidentCtrl', function ($scope, $state, $stateParams, accidentData, employeeData) {
    debugger;
    $scope.accident = {
        categoryId: 0,
        titleId: 0,
        firstName: "",
        lastName: "",
        date: "",
        time: "",
        locationTypeId: 0,
        history:"",
        victims : []
    };
    $scope.victim = {
        victimTypeId: "1",
        victimTypeName:"",
        employeeId: 0,
        firstName: "",
        lastName: ""
    };
    $scope.validations = {
        firstName: {
            required :true
        },
        lastName: {
            required:true
        }
    };
    $scope.temVicType = "";
   
    $scope.showInvPersonDetails = false;
    var resultCat = accidentData.getAccidentCategories();
    resultCat.then(
            function (categories) {
                $scope.accidentCategories = categories
            },
            function (response) {

            }
        );
    var resultEmp = employeeData.getAllEmployees();
    resultEmp.then(function (employees) {
        $scope.employees = employees;
    },
    function (response) {

    });
    var resultCurrEmp = employeeData.getCurrentUser();
    resultCurrEmp.then(function (user) {
        debugger;
        $scope.currentUser = user;
    },
    function (response) {

    });


    $scope.selectCategory = function (cat) {
        $scope.accident.categoryId = cat.ID;
        $state.go('accident.reporter');
    }
    $scope.invPerStype = function (typeid) {
        if (typeid != 1) {
            $scope.showInvPersonDetails = true;
            $scope.validations.firstName.required = true;
            $scope.validations.firstName.required = false;
        }
        else {
            $scope.showInvPersonDetails = false;
            $scope.validations.firstName.required = true;
            $scope.validations.firstName.required = false;
        }
    }
    $scope.addVictium = function (victim) {

        var employee, victimTypeName;
        if (victim.victimTypeId == 1) {
            victimTypeName = "Employee";
        }
        if (victim.victimTypeId == 2) {
            victimTypeName = "Short term contractor";
        }
        if (victim.victimTypeId == 3) {
            victimTypeName = "Member of Public";
        }
        if (victim.victimTypeId == 1) {
            var employee = _.findWhere($scope.employees, { ID: victim.employeeId.ID });
            $scope.accident.victims.push({
                typeId: victim.victimTypeId,
                employeeId: victim.employeeId.ID,
                firstName: employee.FirstName,
                lastName: employee.LastName,
                victimTypeName: victimTypeName
            });
        }
        else {
            $scope.accident.victims.push({
                typeId: victim.victimTypeId,
                employeeId: victim.employeeId.ID,
                firstName: victim.firstName,
                lastName: victim.lastName,
                victimTypeName: victimTypeName
            });
        }
        
    }
    $scope.submitVictimForm = function (isValid, victim) {
        if (isValid) {
            $scope.addVictium(victim);
        }
    }
    $scope.insert = function () {
        console.log($scope.accident);
        console.log(JSON.stringify($scope.accident));
        var incAccResult = accidentData.insertAccident($scope.accident);
        incAccResult.then(function (accRes) {
            debugger;
            $scope.regRefNo = accRes.Message;
            $state.go('accident.registread');
        },
    function (response) {

    });
    }
});