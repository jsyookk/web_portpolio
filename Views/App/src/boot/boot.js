import angular from 'angular';
import App from 'src/app';

angular
    .element(document)
    .ready(function () {
        angular
            .module('starter-app-bootstrap', [])
            .run(() => {
                console.log('Running the app');
            });

        let body = document.getElementsByTagName("body")[0];
        angular.bootstrap(body, ['starter-app-bootstrap']);



    });