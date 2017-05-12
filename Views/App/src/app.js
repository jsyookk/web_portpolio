import angular from 'angular';

import 'angular-animate';
import 'angular-aria';
import 'angular-material';

export dafault angular.module('starter-app', ['ngMaterial'])
    .run(() => {
        console.log('Starting the module');
    });