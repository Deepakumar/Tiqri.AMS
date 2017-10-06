angular.module('amc').factory('employeeData', function ($http, $log, $q) {
    return {
        getAllEmployees: function () {
            var deferred = $q.defer();
            $http({ method: 'GET', url: 'api/employee' })
            .success(function (data, status, headers, config) {
                $log.info(data, status, headers, config);
                deferred.resolve(data);
            })
            .error(function (data, status, headers, config) {
                $log.warn(data, status, headers, config);
                deferred.reject(status);
            })
            return deferred.promise;
        },
        getCurrentUser: function () {
            var deferred = $q.defer();
            $http({ method: 'GET', url: 'api/currentUser' })
            .success(function (data, status, headers, config) {
                $log.info(data, status, headers, config);
                deferred.resolve(data);
            })
            .error(function (data, status, headers, config) {
                $log.warn(data, status, headers, config);
                deferred.reject(status);
            })
            return deferred.promise;
        }
    };
});