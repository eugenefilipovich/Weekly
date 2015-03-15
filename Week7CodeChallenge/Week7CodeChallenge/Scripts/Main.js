$(document).ready(function () {
    $('body').on('click', '.ajax-link', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {
            $('.content').html(data);
        });
    });

    $('body').on('submit', '.ajax-form', function (event) {
        event.preventDefault();
        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            $('.content').html(data);
        });
    });
});