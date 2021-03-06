﻿angular.module('amc').controller('AccidentCtrl', function ($scope, $state, $stateParams, accidentData, employeeData) {
    debugger;
    $scope.accident = {
        categoryId: 0,
        titleId: 0,
        firstName: "",
        lastName: "",
        date: moment(new Date()).format("MM/DD/YYYY"),
        time: moment(new Date()).format("hh:mm A"),
        locationTypeId: "1",
        history:"",
        victims : []
    };
    $scope.victim = {
        id:'',
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
        },
        detailRequiredMsg: false
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
    $scope.addVictium = function (vicitumDetailForm,victim) {
        var employee, victimTypeName;
        if (victim.victimTypeId == 1) {
            victimTypeName = "Employee";
            $scope.victiumRequired = false;
        }
        if (victim.victimTypeId == 2) {
            victimTypeName = "Short term contractor";
        }
        if (victim.victimTypeId == 3) {
            victimTypeName = "Member of Public";
        }
        debugger;
        if (victim.victimTypeId == 1) {
            var employee = _.findWhere($scope.employees, { ID: victim.employeeId.ID });
            $scope.accident.victims.push({
                id:timestamp = new Date().getUTCMilliseconds(),
                typeId: victim.victimTypeId,
                employeeId: victim.employeeId.ID,
                firstName: employee.FirstName,
                lastName: employee.LastName,
                victimTypeName: victimTypeName
            });
            clearVitiumDetails();
            $('#victiumModel').modal('hide');
        }
        else {
            if (!vicitumDetailForm.$valid) {
                $scope.victiumRequired = vicitumDetailForm.$valid === false;
            }
            else {
                $scope.accident.victims.push({
                    id:timestamp = new Date().getUTCMilliseconds(),
                    typeId: victim.victimTypeId,
                    employeeId: victim.employeeId.ID,
                    firstName: victim.firstName,
                    lastName: victim.lastName,
                    victimTypeName: victimTypeName
                });
                clearVitiumDetails();
                $('#victiumModel').modal('hide');
            }
        }      
    }
    $scope.submitVictimForm = function (isValid, victim) {
        if (isValid) {
            $scope.addVictium(victim);
        }
    }
    $scope.insert = function (accidentHistoryForm) {
        if (accidentHistoryForm.$valid) {
            console.log($scope.accident);
            console.log(JSON.stringify($scope.accident));
            var incAccResult = accidentData.insertAccident($scope.accident);
            incAccResult.then(function (accRes) {
                debugger;
                $scope.regRefNo = accRes.Message;
                $state.go('home');
            },
        function (response) {

        });
        }
    }

    $scope.detailToHistory = function (accidentDetailForm) {
        if (accidentDetailForm.$valid) {
            $scope.validations.detailRequiredMsg = false;
            $state.go('accident.history')
        }
        else {
            $scope.validations.detailRequiredMsg = true;
        }
    }

    $scope.deleteVictim = function (vic) {
        debugger;
        $scope.accident.victims = _.reject($scope.accident.victims, function (ele) { return ele.id == vic.id });
    }

    function clearVitiumDetails(){
        $scope.victim = {
            victimTypeId: "1",
            victimTypeName:"",
            employeeId: 0,
            firstName: "",
            lastName: ""
        };
    }
});