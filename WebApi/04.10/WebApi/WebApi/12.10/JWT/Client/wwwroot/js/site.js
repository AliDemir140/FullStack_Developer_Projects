$(document).ready(() => {


    //Id'si verified olan tablo başlangıçta gizlenecek.
    $("#verified").css('display', 'none')

    //Elimizde bir JWT olduğunda aşağıdaki işlem devreye alınacak
    //$("#verified").css('display','table')

    GetEmployees();
})

function GetEmployees() {
    $.ajax({
        url: 'https://localhost:7220/api/employee',
        type: 'Get',
        success: function (data) {
            console.log(data)
            $("#verified").css('display', 'table')
            $("#unauthorized").css('display', 'none')
        },
        error: function (err) {
            console.log(err)
        }
    })
}