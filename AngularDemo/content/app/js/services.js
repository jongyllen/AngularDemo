angular.module('demoApp.services', [])
  .factory('People', ['$http', function ($http) {
      return {
          get: function (callback) {
              $http.get('/data/people').success(function (data) {
                  callback(data);
              });
          }
      };
  }]);