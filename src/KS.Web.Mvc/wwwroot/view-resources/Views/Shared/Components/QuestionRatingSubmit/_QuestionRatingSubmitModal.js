(function ($) {
    var _questionService = abp.services.app.question;

    var _$form = $('form[name=QuestionRatingSubmitForm]');

    function switchToSelectedTenant () {

        //var tenancyName = _$form.find('input[name=TenancyName]').val();

        if (!_$form.valid()) {
            return;
        }

        _questionService.submitQuestionRating({
            tenancyName: tenancyName
        }).done(function (result) {
        });
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function(e) {
        e.preventDefault();
        switchToSelectedTenant();
    });

    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            switchToSelectedTenant();
        }
    });

    $.AdminBSB.input.activate(_$form);

    $('#QuestionRatingSubmitForm').on('shown.bs.modal', function () {
        _$form.find('select:first').focus();
    });
})(jQuery);