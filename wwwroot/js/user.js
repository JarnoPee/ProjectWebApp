var dataTable;

$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/User/GetAll"
        },
        "columns": [
            { "data": "naam", "width": "10%" },
            { "data": "voornaam", "width": "10%" },
            { "data": "email", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "land", "width": "15%" },
            { "data": "rol", "width": "15%" }
            //{
            //    "data": {
            //        id: "id", lockoutEnd: "lockoutEnd"
            //    },
            //    "render": function (data) {
            //        var today = new Date().getTime();
            //        var lockout = new Date(data.lockoutEnd).getTime();
            //        if (lockout > today) {
            //            //user is currently locked
            //            return `
            //                <div class="text-center">
            //                    <a onclick=LockUnlock('${data.id}') class="btn btn-danger text-white" style="cursor:pointer; width:100px;">
            //                        <i class="fas fa-lock-open"></i>  Unlock
            //                    </a>
            //                </div>
            //               `;
            //        }
            //        else {
            //            return `
            //                <div class="text-center">
            //                    <a onclick=LockUnlock('${data.id}') class="btn btn-success text-white" style="cursor:pointer; width:100px;">
            //                        <i class="fas fa-lock"></i>  Lock
            //                    </a>
            //                </div>
            //               `;
            //        }
                    
            //    }, "width": "20%"
            //}
        ]
    });
}

//function LockUnlock(id) {
    
//            $.ajax({
//                type: "POST",
//                url: '/Admin/User/LockUnlock',
//                data: JSON.stringify(id),
//                contentType: "application/json",
//                success: function (data) {
//                    if (data.success) {
//                        toastr.success(data.message);
//                        dataTable.ajax.reload();
//                    }
//                    else {
//                        toastr.error(data.message);
//                    }
//                }
//            });   
//}