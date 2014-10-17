'use strict';

// Demonstrate how to register services
// In this case it is a simple value service.
angular.module('app.services', ['ngResource'])
    .service('queueService', [
        '$resource', function ($resource) {
            return $resource('/hashtagInfo/:sourceHashtag', {}, {
                query: { method: 'GET', params: { sourceHashtag: '@sourceHashtag' }, isArray: true }
            });
        }]);