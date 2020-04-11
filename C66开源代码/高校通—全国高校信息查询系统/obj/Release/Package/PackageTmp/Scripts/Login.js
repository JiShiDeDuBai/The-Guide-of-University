$(document).ready(function () {
    $("#log").click(function () {
        $.ajax({
            async: true,
            cache: false,
            timeout: 60 * 60 * 1000,    
            data: { "userName": $("#userName").val(), "passWord": $("#passWord").val() },  //这就是把要传的数据以json格式打包起来
            type: "post",
            datatype: "JSON",
            url: "/Login/CheckLogin",            
            success: function (result) {
                if (result == "登陆成功") { 
                    window.location.href = '../Home/MainPage';
                }
                else {
                    alert(result);
                    alert("用户名或密码错误,请重新输入");
                }                
            },
            error: function (result) {
                alert("用户名或密码错误，请重新输入");
            },           
        })
    });
})


$(document).ready(function () {
    $("#register").click(function () {
        window.location.href = '../Login/Register';
    });
})