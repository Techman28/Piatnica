$(document).ready(function () {


    var tabledata = [
        { id: 1, name: "Oli Bob", progress: 12, gender: "male", rating: 1, col: "red" },
        { id: 2, name: "Mary May", progress: 1, gender: "female", rating: 2, col: "blue" },
        { id: 3, name: "Christine Lobowski", progress: 42, gender: "female", rating: 0, col: "green" },
        { id: 4, name: "Brendon Philips", progress: 100, gender: "male", rating: 1, col: "orange" },
        { id: 5, name: "Margret Marmajuke", progress: 16, gender: "female", rating: 5, col: "yellow" },
    ];


    var table = new Tabulator("#example-table", {
        data: tabledata,           //load row data from array
        layout: "fitColumns",      //fit columns to width of table
        responsiveLayout: "hide",  //hide columns that dont fit on the table
        tooltips: true,            //show tool tips on cells
        addRowPos: "top",          //when adding a new row, add it to the top of the table
        history: true,             //allow undo and redo actions on the table
        pagination: "local",       //paginate the data
        paginationSize: 7,         //allow 7 rows per page of data
        movableColumns: true,      //allow column order to be changed
        resizableRows: true,       //allow row order to be changed
        initialSort: [             //set the initial sort order of the data
            { column: "name", dir: "asc" },
        ],
        columns: [                 //define the table columns
            { title: "Dane kontrahenta", field: "name", editor: "input", headerFilter: "input" },
            { title: "Nazwa kontrahenta", field: "name", editor: "input", headerFilter: "input" },

            //{ title: "Task Progress", field: "progress", align: "left", formatter: "progress", editor: true, headerFilter: "input" },
            { title: "Gender", field: "gender", width: 95, editor: "select", editorParams: { values: ["male", "female"] }, headerFilter: "input"},
            { title: "Rating", field: "rating", formatter: "star", align: "center", width: 100, editor: true, headerFilter: "input"},
            { title: "Color", field: "col", width: 130, editor: "input", headerFilter: "input" },
            { title: "Date Of Birth", field: "dob", width: 130, sorter: "date", align: "center", headerFilter: "input" },
            { title: "Driver", field: "car", width: 90, align: "center", formatter: "tickCross", sorter: "boolean", editor: true, headerFilter: "input"},
            { title: "Data", field: "car", width: 90, align: "center", sorter: "boolean", editor: false, headerFilter: "input"},
        ],
    });

});