var questionRatingSubmitComponent;

(function () {
    //$('.question-rating-submit-component')
    //    .click(function (e) {           
    //        e.preventDefault();
    //        $.ajax({
    //            url: abp.appPath + 'Question/QuestionRatingSubmitModal',
    //            type: 'POST',
    //            contentType: 'application/html',
    //            success: function (content) {
    //                $('#QuestionRatingSubmitModal div.modal-content').html(content);
    //            },
    //            error: function (e) { }
    //        });
    //    });

    questionRatingSubmitComponent = function (id) {

        var data = { QuestionId: id };
        $.ajax({
            url: abp.appPath + 'Question/QuestionRatingSubmitModal',
            type: 'POST',
            //contentType: 'application/html',
            data: data,
            success: function (content) {
                $('#QuestionRatingSubmitModal div.modal-content').html(content);
            },
            error: function (e) { }
        });
    }
})();