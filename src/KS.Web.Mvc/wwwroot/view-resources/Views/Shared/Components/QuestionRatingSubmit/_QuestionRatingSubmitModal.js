(function ($) {
    var _questionRatingService = abp.services.app.questionRating;

    //var _$form = $('form[name=QuestionRatingSubmitForm]');
    var _$form = $('#QuestionRatingSubmitForm');

    function submitQuestionRating () {
        
        var questionRating = _$form.serializeFormToObject();
       
        if (!_$form.valid()) {
            return;
        }

        _questionRatingService.create(questionRating)
            .done(function (result) {
                location.reload();
            }).fail(function(error) {

            });
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function(e) {
        e.preventDefault();
        submitQuestionRating();
    });

    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            submitQuestionRating();
        }
    });

    $.AdminBSB.input.activate(_$form);

    $('#QuestionRatingSubmitForm').on('shown.bs.modal', function () {
        _$form.find('select:first').focus();
    });
})(jQuery);