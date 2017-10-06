describe("A suite", function () {
    it("contains spec with an expectation", function () {
        expect(true).toBe(true);
    });
});

describe('AccidentCtrl', function () {
    beforeEach(angular.mock.module('amc'));
    var $controller

    beforeEach(inject(function (_$controller_) {
        $controller = _$controller_;
    }));

    describe('$scope', function () {
        it('adds one', function () {
            var $scope = {};
            var controller = $controller('AccidentCtrl', { $scope: $scope });
            $scope.add();
            expect($scope.count).toEqual(1);
        })
    })
});





