var amc = angular.module('amc', ['ngResource', 'ui.router', 'LocalStorageModule']);

angular.module('amc').config(['$stateProvider','$urlRouterProvider', configRoutes]);

function configRoutes($stateProvider, $urlRouterProvider) {

    $stateProvider.state('home', {
        url: '/',
        templateUrl: '/templates/home.html',
        controller: 'HomeCtrl',
        controllerAs: 'vm'
    });
    $stateProvider.state('accident', {
        url: '/accident',
        abstract:true,
        templateUrl: '/templates/accident.html',
        controller: 'AccidentCtrl',
        controllerAs: 'vm'
    });
    $stateProvider.state('accident.category', {
        url: '/category',
        templateUrl: '/templates/accident_category.html'
    });
    $stateProvider.state('accident.reporter', {
        url: '/reporter',
        templateUrl: '/templates/accident_reporter.html'
    });
    $stateProvider.state('accident.detail', {
        url: '/detail',
        templateUrl: '/templates/accident_detail.html'
    });
    $stateProvider.state('accident.history', {
        url: '/history',
        templateUrl: '/templates/accident_history.html'
    });

    $urlRouterProvider.otherwise('/');
}

angular.module('amc').run(['$state', function ($route) {

}]);

angular.module('amc').config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});