$(document).ready(function () {
    $('#add-to-order').on('click', function () {
        //var contractor = $('#contractor-info').
        var contractor_name = $('#contractor-name').html()
        var contractor_adress = $('#contractor-adress').html()
        swal({
            title: "Dodano!",
            text: `Zamówienie od kontrahenta ${contractor_name} ${contractor_adress} zostało dodane`,
            timer: 3000,
            showConfirmButton: false,
            buttonsStyling: false,
            confirmButtonClass: "btn btn-success",
            type: "success"
        }).then(function () {
            window.location.href ="https://localhost:44350/order/orderList"
        })


    });

})