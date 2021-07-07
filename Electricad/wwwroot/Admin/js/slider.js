﻿var dataTable;

$(document).ready(function () {
   cargarDatatable();
});
 
function cargarDatatable() {
   
    dataTable = $("#tblSliders").DataTable({
        "ajax": {
            "url": "Offers/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "descount", "width": "6%" },
            { "data": "desc", "width": "25%" },
            {
                "data": "offer_file",
                "render": function (image) {
                    return `<img src="../${image}" width="200">`
                }
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href='/Offers/Edit/${data}' class='btn btn-info text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-edit'></i> Edit
                            </a>
                            &nbsp;
                            <a onclick=Delete("/Offers/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-trash-alt'></i> Delete
                            </a>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No records"
        },
        "width": "100%"
    });
}


function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "This register cannot be retrieved!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes, delete!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    }); 
} 

function myFunction() {
    document.getElementById("myFile").required = true;
    document.getElementById("demo").innerHTML = "The required property was set. A file in the file upload field must now be filled out before submitting the form.";
}