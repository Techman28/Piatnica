function allStorage() {

    var values = [],
        keys = Object.keys(localStorage),
        i = keys.length;

    while (i--) {
        values.push(JSON.parse(localStorage.getItem(keys[i])));
    }

    return values;
}
var table;
var dataSet2;
function CreateDatatables() {

    dataSet2 = allStorage();
    table = $('#datatables').DataTable({
        data: dataSet2,
        columns: [
            {
                "orderable": false,
                "searchable": false,
                "title": "",
                data : "id"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kontrahent",
                data: "contractor"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Handlowiec",
                data: "trader"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Nazwa towaru",
                data: "commodityName"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Rodzaj opakowania",
                data: "packageType"



            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Miejsce docelowe",
                data: "place"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kwota netto",
                data: "price"

            },

            {
                "orderable": false,
                "searchable": true,
                "title": "Usuń",
                "data": null,

                "defaultContent": "<a class='btn text-white btn-primary darkred delete-from-order'>Usuń</a>"

            }
        ],

        language: {
            processing: "Przetwarzanie...",
            search: "Szukaj:",
            lengthMenu: "Pokaż _MENU_ pozycji",
            info: "Pozycje od _START_ do _END_ z _TOTAL_ łącznie",
            infoEmpty: "Pozycji 0 z 0 dostępnych",
            infoFiltered: "(filtrowanie spośród _MAX_ dostępnych pozycji)",
            infoPostFix: "",
            loadingRecords: "Wczytywanie...",
            zeroRecords: "Nie znaleziono pasujących pozycji",
            emptyTable: "Brak danych",
            paginate: {
                first: "Pierwsza",
                previous: "Poprzednia",
                next: "Następna",
                last: "Ostatnia"
            },
            aria: {
                sortAscending: ": aktywuj, by posortować kolumnę rosnąco",
                sortDescending: ": aktywuj, by posortować kolumnę malejąco"
            }
        }
    });
}
$(document).ready(function () {


    CreateDatatables();

    var summaryTable = $('#summary-table').DataTable({
        data: dataSet2,
        columns: [
            {
                "orderable": false,
                "searchable": false,
                "title": "",
                data: "id"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kontrahent",
                data: "contractor"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Handlowiec",
                data: "trader"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Nazwa towaru",
                data: "commodityName"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Rodzaj opakowania",
                data: "packageType"



            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Miejsce docelowe",
                data: "place"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kwota netto",
                data: "price"

            },

        ],

        language: {
            processing: "Przetwarzanie...",
            search: "Szukaj:",
            lengthMenu: "Pokaż _MENU_ pozycji",
            info: "Pozycje od _START_ do _END_ z _TOTAL_ łącznie",
            infoEmpty: "Pozycji 0 z 0 dostępnych",
            infoFiltered: "(filtrowanie spośród _MAX_ dostępnych pozycji)",
            infoPostFix: "",
            loadingRecords: "Wczytywanie...",
            zeroRecords: "Nie znaleziono pasujących pozycji",
            emptyTable: "Brak danych",
            paginate: {
                first: "Pierwsza",
                previous: "Poprzednia",
                next: "Następna",
                last: "Ostatnia"
            },
            aria: {
                sortAscending: ": aktywuj, by posortować kolumnę rosnąco",
                sortDescending: ": aktywuj, by posortować kolumnę malejąco"
            }
        }


    });

    $('#datatables tbody').on('click', '.delete-from-order', function () {
        swal.fire({
            title: 'Na pewno chcesz usunąć zamówienie?',
            text: ' Nie będziesz mógł powrócić do poprzedniego stanu!',
            type: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Tak, usuń!',
            cancelButtonText: 'Nie usuwaj',
            confirmButtonClass: "btn btn-success",
            cancelButtonClass: "btn btn-danger",
            buttonsStyling: false
        }).then((result) => {
            if (result.value) {
                var data = table.row($(this).parents('tr')).data();
                localStorage.removeItem(data['id']);
                //CreateDatatables();
                table.draw();
                Swal.fire(
                    'Usunięto!',
                    '',
                    'success'
                )
            }
        })

    });




    // Edit record
    table.on('click', '.edit', function () {
        $tr = $(this).closest('tr');
        var data = table.row($tr).data();
        alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
    });

    // Delete a record
    table.on('click', '.remove', function (e) {
        $tr = $(this).closest('tr');
        table.row($tr).remove().draw();
        e.preventDefault();
    });

    //Like record
    table.on('click', '.like', function () {
        alert('You clicked on Like button');
    });

    $('#finish-order').on('click', function () {
        swal({
            title: "Utworzono!",
            text: `Zlecenie zostało utworzone`,
            timer: 3000,
            showConfirmButton: false,
            buttonsStyling: false,
            confirmButtonClass: "btn btn-success",
            type: "success"
        }).then(function () {
            window.location.href = "https://localhost:44350/order/orderList"
        })


    });

});

