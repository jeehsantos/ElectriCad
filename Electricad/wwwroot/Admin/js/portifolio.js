var dataTable;

$(document).ready(function () {
   loadDatatable();

});
 
function loadDatatable() {
   
    dataTable = $("#tblPortfolio").DataTable({
        "ajax": {
            "url": "Portfolio/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "desc", "width": "10%" },
            {
                "data": "port_file",
                "render": function (image) {
                    return `<img class="zoom" src="../${image}" width="200">`
                }
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<a onclick=Delete("/Portfolio/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
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
                    toastr.options.timeOut = 1700;
                    toastr.options.progressBar = true;
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
