(function ($) {
    var _questionAnswerRatingService = abp.services.app.questionAnswerRating;

    //var _$form = $('form[name=QuestionRatingSubmitForm]');
    var _$form = $('#QuestionAnswerRatingSubmitForm');

    function submitQuestionAnswerRating () {
        
        var questionAnserRating = _$form.serializeFormToObject();
       
        if (!_$form.valid()) {
            return;
        }

        _questionAnswerRatingService.create(questionAnserRating)
            .done(function (result) {
                location.reload();
            }).fail(function(error) {

            });
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function(e) {
        e.preventDefault();
        submitQuestionAnswerRating();
    });

    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            submitQuestionAnswerRating();
        }
    });

    $.AdminBSB.input.activate(_$form);

    $('#QuestionRatingSubmitForm').on('shown.bs.modal', function () {
        _$form.find('select:first').focus();
    });
})(jQuery);