$(document).ready(() => {


    //Id'si verified olan tablo başlangıçta gizlenecek.
    $("#verified").css('display', 'none')

    //Elimizde bir JWT olduğunda aşağıdaki işlem devreye alınacak
    //$("#verified").css('display','table')

    GetEmployees();
})

//function GetEmployees() {
//    $.ajax({
//        url: 'https://localhost:7220/api/employee',
//        type: 'Get',
//        success: function (data) {
//            console.log(data)
//            $("#verified").css('display', 'table')
//            $("#unauthorized").css('display', 'none')
//        },
//        error: function (err) {
//            console.log(err)
//        }
//    })
//}

function GetEmployees() {

    //localstorage
    const token = localStorage.getItem("token");
    $.ajax({
        url: 'https://localhost:7220/api/employee',
        type: 'Get',
        headers: {
            "content-type": "application/json",
            "Authorization": "Bearer " + token
        },

        success: function (data) {
            console.log(data)
            $("#verified").css('display', 'table')
            $("#unauthorized").css('display', 'none')
            GetEmployeeTable(data);
        },
        error: function (err) {
            console.log(err)
        }
    })
}

//login tıklandığında bir ajax fonksiyonu bilgileri api'a gönderecek.
$("#login").on('click', () => {

    var username = $("#username").val();
    var password = $("#password").val();

    const loginDTO = {
        "Firstname": username,
        "Lastname":password
    }

    $.ajax({
        url: "https://localhost:7220/api/auth",
        type: 'Post',
        data: loginDTO,
        success: function (token) {
            $("#token").html(token)

            //localstorage: browserda saklanacak bilgiler bu alanda tutulması gerekir.
            localStorage.setItem("token", token);
            GetEmployees();
        },
        error: function (err) {
            console.log(err)
        }
    })

});


function GetEmployeeTable(data) {
    data.forEach((val, i) => {
        $("#employeeBody").append(`
    <tr>
        <td>${val.id}</td>
        <td>${val.firstName}</td>
        <td>${val.lastName}</td>
        <td>${val.title}</td>
        <td>${val.titleOfCourtesy}</td>
    </tr>
    `)
    })
}