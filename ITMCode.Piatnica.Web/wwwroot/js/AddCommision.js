$(document).ready(function () {



    var dataSet2 = [["1", "Fresh world", "Jan Kowalski", "Żywność", "Karton", "Raškovice", "4350.32 zł", "",""],
    ["2", "Fresh", "Jan Nowak", "Żywność", "Karton","Kraków", "4220.22 zł", ""],
        ["3", "Weber LLC", "Maighdiln Bembridge", "Coffee - Dark Roast", "Mecamylamine Hydrochloride", "Jiangqiao", "3139.34 zł", "", ""],
        ["4", "Okuneva LLC", "Benjy Shuttle", "Pasta - Spaghetti, Dry", "CARE ONE", "Baimajing", "3160.62 zł", "", ""],
        ["5", "Murphy-Kub", "Derwin Girdwood", "Chicken - Wieners", "AMBROSIA TRIFIDA POLLEN", "Kopychyntsi", "4846.75 zł", "", ""],
   

    ];

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
                "title": "Dodaj",
                "data": null,
                "defaultContent": "<button class='btn btn-primary add-to-order btn darkgreen'>Dodaj</button>"

            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Usuń",
                "data": null,
                "defaultContent": "<button class='btn btn-primary delete-from-order btn darkred'>Usuń</button>"
            }
        ]
    });


    $('#add-to-order').on('click', function () {
        var data = table.row($(this).parents('tr')).data();
        swal({
            title: "Dodano!",
            text: `Zamówienie od kontrahenta zostało dodane`,
            buttonsStyling: false,
            confirmButtonClass: "btn btn-success",
            type: "success"
        }).catch(swal.noop)
    });

    $('#datatables tbody').on('click', '.delete-from-order', function () {
        var data = table.row($(this).parents('tr')).data();
        swal({
            title: "Usunięto!",
            text: `Usunięto Zamówienie od kontrahenta ${data[1]}`,
            buttonsStyling: false,
            confirmButtonClass: "btn btn-success",
            type: "success"
        }).catch(swal.noop)
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

