var url = $("#abouttabs button:first").data("url");
$.get(url, function (data) {
    $("#aboutcontent").html(data);
});

$("#abouttabs").on("click", ".about", function () {
    var url = $(this).data("url");
    $(".about").removeClass("active");
    $(this).addClass("active");

    $.get(url, function (data) {
        $("#aboutcontent").html(data);
    });
});