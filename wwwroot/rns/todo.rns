$(document).ready(function () {
    $('#add-btn').click(function () {
        var name = $('#new-todo-name').val();
        $.post('/ToDo/Create', { Name: name, IsComplete: false }, function () {
            location.reload();
        });
    });

    $('.delete-btn').click(function () {
        var id = $(this).closest('li').data('id');
        $.post('/ToDo/Delete', { id: id }, function () {
            location.reload();
        });
    });

    $('input[type="checkbox"]').change(function () {
        var id = $(this).closest('li').data('id');
        var isComplete = $(this).is(':checked');
        var name = $(this).siblings('span').text();
        $.post('/ToDo/Update', { Id: id, Name: name, IsComplete: isComplete }, function () {
            location.reload();
        });
    });
});