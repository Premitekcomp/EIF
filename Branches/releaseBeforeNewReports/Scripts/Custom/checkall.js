$(function () {

    $("#checkAll").change(function () {
        $("input[name='checkonce']").prop('checked', $(this).prop("checked"));
    });

    $("input[name='checkonce']").click(function () {
        
        if ($("input[name='checkonce']").length == $("input[name='checkonce']:checked").length) {
            $("#checkAll").prop('checked', true);
        }
        else {
            $("#checkAll").prop('checked', false);
        }
    })



});
