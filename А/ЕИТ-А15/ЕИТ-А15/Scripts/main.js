$(document).ready(function () {
    $("#filter").on('input', function () {
        var param = $("#filter").val();
        var count = $("#prikazT tr").length;
        console.log(param);
        for (var i = 1; i < count; i++) {
            if ($("#reg" + i).text().indexOf(param) >= 0) {
                $("#prikazT tr").eq(i).show();
            } else {
                $("#prikazT tr").eq(i).hide();
            }
        }
    });
});