function GetBrunchSectionDDL() {
    $.ajax({
        url: url + "Account/GetBrunchSectionDDL",
        type: 'post',
        cache: false,
        async: true,
        data: { id: $("#UserName").val() },
        success: function (result) {
            $('#DDL').html(result);
        }
    });
}