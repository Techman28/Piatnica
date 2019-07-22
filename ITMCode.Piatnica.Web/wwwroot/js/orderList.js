$(document).ready(function () {

     

    var dataSet2 = [["1", "Fresh world", "Jan Kowalski", "Żywność", "Karton", "2019-08-05 10:03:11", "Chaem Luang", "2019-08-05 15:00:21", "Gulou", "Raškovice", "4350.32 zł", ""],
        ["2", "Fresh", "Jan Nowak", "Żywność", "Karton", "2019-08-05 10:47:20", "Waco", "2019-08-05 15:00:50", "Bronisze", "Kraków", "4220.22 zł", ""],
        ["3", "Weber LLC", "Maighdiln Bembridge","Coffee - Dark Roast", "Mecamylamine Hydrochloride", "2019-03-11 10:40:39", "El Valle del Espíritu Santo", "2019-01-14 18:51:39", "Huangxikou", "Jiangqiao", "3139.34 zł", ""],
        ["4", "Okuneva LLC","Benjy Shuttle", "Pasta - Spaghetti, Dry", "CARE ONE", "2019-03-11 10:40:39", "San Gregorio", "2019-03-14 10:40:39", "Leśnica", "Baimajing", "3160.62 zł", ""],
        ["5", "Murphy-Kub", "Derwin Girdwood", "Chicken - Wieners", "AMBROSIA TRIFIDA POLLEN", "2019-01-14 18:51:39", "Birmingham", "2019-02-11 10:40:39", "Chuguyevka", "Kopychyntsi", "4846.75 zł", ""],
        ["6", "Graham and Sons", "Roddy Wykes", "Tart - Pecan Butter Squares", "Omeprazole", "2019-03-11 10:40:39", "Igbo-Ukwu", "2019-01-14 18:51:39", "Dióni", "Huesca", "2455.49 zł", ""],
        ["7", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["8", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł",""],
        ["9", "Baumbach-Sipes", "Emmye Brecknock", "Żywność", "Folia", "2018-09-28 18:17:30", "Aurora", "2018-08-16 13:32:33", "Gulou", "Bontang", "2400.43 zł", ""],
        ["10", "Metz", "Lyle Livoir", "Ginsing - Fresh", "Karton", "2019-08-02 10:24:22", "Semënovskoye", "2018-09-28 18:17:30", "Aurora", "Raškovice", "5600.32 zł", ""],
        ["11", "Goyette Inc", "Connie Cheeld", "Broccoli - Fresh", "Paleta", "2019-08-03 10:01:20", "Maltahöhe", "2018-08-16 13:32:33", "Waco", "Aurora", "4050.23 zł", ""],
        ["12", "Fresh world", "Gaspard Derycot", "Chocolate - Milk", "Worek", "2018-10-06 18:04:59", "Warszawa", "2018-09-13 07:47:18", "Ciechanów", "Kraków", "3300.53 zł", ""],
        ["13", "Harris LLC", "Robinet Wetherick", "Pasta - Canellon", "Karton", "2019-05-18 22:10:26", "Stockholm", "2018-07-17 10:35:31", "Gulou", "Vohipaho", "7400.33 zł", ""],
        ["14", "Brown Inc", "Barnie Major", "Bread - Pita, Mini", "Karton", "2018-09-13 07:47:18", "Kabarnet", "2018-10-06 18:04:59", "Olympia", "Raškovice", "5300.87 zł", ""],
        ["15", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["16", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł", ""],
        ["17", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["18", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł", ""],
        ["19", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["20", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł", ""],
        ["21", "Murphy-Kub", "Derwin Girdwood", "Chicken - Wieners", "AMBROSIA TRIFIDA POLLEN", "2019-01-14 18:51:39", "Birmingham", "2019-02-11 10:40:39", "Chuguyevka", "Kopychyntsi", "4846.75 zł", ""],
        ["22", "Graham and Sons", "Roddy Wykes", "Tart - Pecan Butter Squares", "Omeprazole", "2019-03-11 10:40:39", "Igbo-Ukwu", "2019-01-14 18:51:39", "Dióni", "Huesca", "2455.49 zł", ""],
        ["23", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["24", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł", ""],
        ["25", "Baumbach-Sipes", "Emmye Brecknock", "Żywność", "Folia", "2018-09-28 18:17:30", "Aurora", "2018-08-16 13:32:33", "Gulou", "Bontang", "2400.43 zł", ""],
        ["26", "Murphy-Kub", "Derwin Girdwood", "Chicken - Wieners", "AMBROSIA TRIFIDA POLLEN", "2019-01-14 18:51:39", "Birmingham", "2019-02-11 10:40:39", "Chuguyevka", "Kopychyntsi", "4846.75 zł", ""],
        ["27", "Graham and Sons", "Roddy Wykes", "Tart - Pecan Butter Squares", "Omeprazole", "2019-03-11 10:40:39", "Igbo-Ukwu", "2019-01-14 18:51:39", "Dióni", "Huesca", "2455.49 zł", ""],
        ["28", "Dach", "Hackett and Trantow", "Alvy oldey,Sprouts - Bean", "Birch Juniper Rejuvenation", "2019-01-14 18:51:39", "Jingu", "2019-03-11 10:40:39", "Pagaruša", "Yanghong", "4567.22 zł", ""],
        ["29", "Shields", "Christiane Middiff", "Kautzer and DuBuque", "Vaccum Bag 10x13", "2019-01-14 18:51:39", "Carbamazepine", "2019-03-11 10:40:39", "Caherconlish", "Doropeti", "4815.65 zł", ""],
        ["30", "Baumbach-Sipes", "Emmye Brecknock", "Żywność", "Folia", "2018-09-28 18:17:30", "Aurora", "2018-08-16 13:32:33", "Gulou", "Bontang", "2400.43 zł", ""]



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

                "defaultContent": "<a href='/order/DetailOrder' class='btn btn-primary darkblue'>Szczegóły</a>"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Dodaj do zlecenia",
                "data": null,
                "defaultContent": "<a class='btn text-white btn-primary add-to-order darkgreen'>Dodaj do zlecenia</a>"

            }
        ]
    });

    var orderNumber = 1;
    $('#datatables tbody').on('click', '.add-to-order', function () {
        var data = table.row($(this).parents('tr')).data();
        var newOrder = new Object();

        newOrder.id = orderNumber + table.rows[$(this).parents('tr')].cells[0].innerHTML;
        newOrder.contrahent = orderNumber + table.rows[$(this).parents('tr')].cells[1].innerHTML;
        newOrder.merchendise = orderNumber + table.rows[$(this).parents('tr')].cells[2].innerHTML;

        if (sessionStorage.order) {
            order = JSON.parse(sessionStorage.getItem('order'));
        } else {
            order = [];
        }
        order.push(newOrder);
        
        console.log('1' + order);
        orderNumber++;
        sessionStorage.setItem('order', JSON.stringify(order));
        swal({
            title: "Dodano!",
            text: `Zamówienie od kontrahenta ${data[1]} zostało dodane`,
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