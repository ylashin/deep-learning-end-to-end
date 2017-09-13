var dogsVsCatsApp = angular.module('dogsVsCatsApp', []);

dogsVsCatsApp.controller('DogsVsCatsController', function DogsVsCatsController($scope, $http, uploadService, $interval) {
    
    $scope.$watch('file', function (newfile, oldfile) {
        if (angular.equals(newfile, oldfile)) {
            return;
        }

        $scope.uploadFile();

    });

    $interval(function () { activate(); }, 5000);
    activate();

    function activate()
    {
        $http.get("/api/app").then(function (result) {
            $scope.predictions = result.data;
        });
    }

    $scope.uploadFile = function ()
    {        
        if (!$scope.file || !$scope.file.size)
            return;
        document.body.style.cursor = "wait";
        uploadService.upload($scope.file).then(function (res) {
            activate();
            $scope.file = null;
            document.body.style.cursor = "default";
        }, function (error) {
            alert("Error uploading file!");
            console.error(error);
            document.body.style.cursor = "default";
            });
    }

});


dogsVsCatsApp.service("uploadService", function ($http, $q) {

    return ({
        upload: upload
    });

    function upload(file) {        
        var upl = $http({
            method: 'POST',
            url: '/api/app', // /api/upload
            headers: {
                'Content-Type': 'multipart/form-data'
            },
            data: {
                upload: file
            },
            transformRequest: function (data, headersGetter) {
                var formData = new FormData();
                angular.forEach(data, function (value, key) {
                    formData.append(key, value);
                });

                var headers = headersGetter();
                delete headers['Content-Type'];

                return formData;
            }
        });
        return upl.then(handleSuccess, handleError);

    } // End upload function



    function handleError(response, data) {
        if (!angular.isObject(response.data) || !response.data.message) {
            return ($q.reject("An unknown error occurred."));
        }

        return ($q.reject(response.data.message));
    }

    function handleSuccess(response) {
        return (response);
    }

});

dogsVsCatsApp.directive("fileinput", [function () {
    return {
        scope: {
            fileinput: "=",
            filepreview: "="
        },
        link: function (scope, element, attributes) {
            element.bind("change", function (changeEvent) {
                scope.fileinput = changeEvent.target.files[0];
                var reader = new FileReader();
                reader.onload = function (loadEvent) {
                    scope.$apply(function () {
                        scope.filepreview = loadEvent.target.result;
                    });
                }
                reader.readAsDataURL(scope.fileinput);
            });
        }
    }
}]);