$(document).ready(function () {

     


    var dataSet = [
        {  "1", "Aliquam", "2093", "448065", "24" },
        {  "2",  "sit",  "6751",  "335185" ,"20"},
        {  "3",  "nunc",  "9350",  "352941", "20"},

    ];

    var table = $('#datatables').DataTable({
        data: dataSet,
    columns: [
        {
            "orderable": false,
            "searchable": false,
            "title": ""
        },
        {
            "orderable": false,
            "searchable": true,
            "title": "Marka"
        },
        {
            "orderable": false,
            "searchable": true,
            "title": "Nr Rejestracyjny"
        },
        {
            "orderable": false,
            "searchable": true,
            "title": "Przebieg"
        },
        {
            "orderable": false,
            "searchable": true,
            "title": "Ładowność"
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