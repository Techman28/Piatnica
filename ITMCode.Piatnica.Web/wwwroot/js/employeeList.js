$(document).ready(function () {



    var dataSet2 = [["1", "Jan", "Kowalski", "45", "C + B", "2013-08-05 10:03:11"],
    ["2", "Jan", "Nowak", "36", "C + B", "2015-08-05 10:47:20"],
    ["3", "Maighdiln", "Bembridge", "28", "C+A", "2012-03-11 10:40:39"],
    ["4", "Piotr", "Potowski", "21", "B+C", "2019-03-11 10:40:39"],
    ["5", "Kamil", "Grabas", "33", "B+C+A1", "2012-01-14 18:51:39"],
    ["6", "Mateusz", "Pyk", "27", "B+C", "2016-03-11 10:40:39"],
    ["7", "Michał", "Mazuch", "22", "A+B+C", "2018-01-14 18:51:39"],
    ["8", "Matuesz ", "Kosmyk", "25", "B+C", "2017-01-14 18:51:39"],
    ["9", "Will", "Smith", "49", "B+C", "2011-09-28 18:17:30"],
    ["10", "Adam", "Adamczyk", "31", "B+C", "2019-08-02 10:24:22"],
    ["11", "Jan", "Czajka", "27", "B+C", "2019-08-03 10:01:20"],
    ["12", "Mikołaj", "Kasprzyk", "29", "B+C", "2015-10-06 18:04:59"],
    ["13", "Aleksander", "Majewski", "35", "B+C", "2015-05-18 22:10:26"],
    ["14", "Kacper", "Wojciechowski", "31", "B+C", "2013-09-13 07:47:18"],
    ["15", "Adam", "Kowalczyk", "42", "B+C", "2014-01-14 18:51:39"],
    ["16", "Robert", "Kubica", "30", "B+C", "2016-01-14 18:51:39"],
    ["17", "Jakub ", "Karpiński", "38", "B+C", "2010-01-14 18:51:39"],
    ["18", "Franciszek", "Kania", "45", "B+C", "2008-01-14 18:51:39"],
    ["19", "Krystian", "Dąbrowski", "43", "B+C", "2011-01-14 18:51:39"],
    ["20", "Filip ", "Zieliński", "31", "B+C", "2012-01-14 18:51:39"],
    ["21", "Jan", "Matusiak", "43", "B+C", "2007-01-14 18:51:39"],
    ["22", "Filip ", "Kamiński", "38", "B+C", "2014-03-11 10:40:39"],
    ["23", "Adam", "Lewicki", "33", "B+C", "2015-01-14 18:51:39"],
    ["24", "Jakub", "Nowak", "32", "B+C", "2014-01-14 18:51:39"],
    ["25", "Jakub", "Stefański", "28", "B+C", "2017-09-28 18:17:30"],
    ["26", "Stanisław", "Mazurek", "22", "B+C", "2019-01-14 18:51:39"],
    ["27", "Szymon", "Lewicki", "25", "B+C", "2018-03-11 10:40:39"],
    ["28", "Adam", "Zieliński", "37", "B+C", "2016-01-14 18:51:39"],
    ["29", "Dominik", "Matusiak", "32", "B+C", "2017-01-14 18:51:39"],
    ["30", "Dominik", "Olszewski", "29", "B+C", "2018-09-28 18:17:30"]



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
                "title": "Imię"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Nazwisko"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Wiek"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Prawo jazdy"
            },
            {
                "orderable": false,
                "searchable": true,
                "title": "Data zatrudnienia"
            },

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



