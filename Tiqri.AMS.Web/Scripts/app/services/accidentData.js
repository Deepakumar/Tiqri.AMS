angular.module('amc').factory('accidentData', function ($http,$log,$q) {
    return {
        getAccidentCategories: function () {
            var deferred = $q.defer();
            $http({ method: 'GET', url: 'api/accidentCategory' })
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
        insertAccident: function (accident) {
            var deferred = $q.defer();
            $http({ method: 'POST', url: 'api/accident', data :accident })
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