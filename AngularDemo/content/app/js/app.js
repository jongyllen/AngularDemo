var partialsDir = 'Content/app/views/';
var roydApp = angular.module('demoApp', ['demoApp.filters'])
        .config(function ($routeProvider, $locationProvider) {
            //routes
            $routeProvider
                .when('/', { controller: HomeCtrl, templateUrl: partialsDir + 'default.html' })
                .when('/person/edit/:id', { controller: PersonEditCtrl, templateUrl: partialsDir + 'edit.html' })
                .when('/person/new', { controller: PersonNewCtrl, templateUrl: partialsDir + 'create.html' })
                .when('/person/:id', { controller: PersonCtrl, templateUrl: partialsDir + 'show.html' })
                .otherwise({ redirectTo: '/' });
        });