$(document).ready(function () {

     

        var dataSet2 = [["1", "Fresh world", "Jan Kowalski", "Żywność", "Karton", "2019-08-05 10:00", "Warszawa", "2019-08-057 15:00", "Bronisze", "Kraków", "4000 zł", ""]];

    var table = $('#datatables').DataTable({
        data: dataSet2,
        columns: [
            {
                "orderable": false,
                "searchable": false,
                "title": ""
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kontrahent"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Handlowiec"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Nazwa towaru"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Rodzaj opakowania"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Data rozładunku"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Lokalizacja rozładunku"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Data załadunku"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Miejsce załadunku"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Miejsce docelowe"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Kwota netto"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Szczegóły", 
                "data": null,
                "defaultContent": "<a href='/order/DetailOrder' class='btn btn-primary'>Szczegóły</a>"
            }
        ]
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
});