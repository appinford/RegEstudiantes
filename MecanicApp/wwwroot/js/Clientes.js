/// <reference path="../scripts/angular.js" />

angular.module('Clientes', []);

angular.module('Clientes').controller('ClienteCtrl', ['$scope', '$http', function ($scope, $http) {

    $scope.Cliente = {
        Id: 0,
        Nombres: "",
        Apellidos: "",
        Cedula: "",
        Direccion: "",
        Sector: "",
        Ciudad: "",
        Vehiculos: []
    }

    const urlParams = new URLSearchParams(window.location.search);
    const myParam = urlParams.get('Id');

    if (myParam) {

        let id = parseInt(myParam);

        $http.get(`/api/Clientes/GetCliente?Id=${id}`).then(response => {
            var clientes = response.data;
            console.log(clientes);

            $scope.Cliente.Id = clientes.id;
            $scope.Cliente.Nombres = clientes.nombres;
            $scope.Cliente.Apellidos = clientes.apellidos;
            $scope.Cliente.Cedula = clientes.cedula;
            $scope.Cliente.Direccion = clientes.direccion;
            $scope.Cliente.Sector = clientes.sector;
            $scope.Cliente.Ciudad = clientes.ciudad;

            if (clientes.vehiculos) {
                clientes.vehiculos.forEach(item => {
                    $scope.Cliente.Vehiculos.push({
                        Id: item.id,
                        FechaIngreso : item.fechaIngreso,
                        Marca: item.marca,
                        AnoFab: item.anoFab,
                        Color: item.color,
                        TipoTransmision: item.tipoTransmision,
                        LugarFabricacion: item.lugarFab,
                        DescProblema: item.descProblema,
                        ClienteId: item.clienteId
                    })
                })
            }
        })
    }

    $scope.AgregarVehiculo = function () {
        $scope.Cliente.Vehiculos.push({});
    }


    $scope.GuardarCambios = function () {

        //$scope.Cliente.Marca = parseInt($scope.Cliente.Marca);
        //$scope.Cliente.Color = parseInt($scope.Cliente.Color);
        //$scope.Cliente.Tipos = parseInt($scope.Cliente.Tipos);
        //$scope.Cliente.Lugares = parseInt($scope.Cliente.Lugares);

        $http.post(`/api/Clientes/Guardar`, $scope.Cliente).then(response => {
            var clientes = response.data;

            if (clientes.id > 0) {
                alert('El registro fue guardado satisfactoriamente');
                window.location.replace('/Clientes/Lista');
            }
            else {
                alert('Hubo un error al procesar la solicitud');
            }

        })
    }


    $http.get(`/api/Clientes/GetMarcas`).then(response => {
        var data = response.data;
        $scope.Marcas = data
    })

    $http.get(`/api/Clientes/GetColores`).then(response => {
        var data = response.data;
        $scope.Colores = data
    })

    $http.get(`/api/Clientes/GetTipos`).then(response => {
        var data = response.data;
        $scope.Tipos = data
    })

    $http.get(`/api/Clientes/GetLugares`).then(response => {
        var data = response.data;
        $scope.Lugares = data
    })

}])