(function() {
    $(function() {

        var _questionService = abp.services.app.question;
        var _$modal = $('#QuestionCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
            rules: {
                Password: "required",
                ConfirmPassword: {
                    equalTo: "#Password"
                }
            }
        });

        $('#RefreshButton').click(function () {
            refreshQuestionList();
        });

        $('.archive-question').click(function () {
            var questionId = $(this).attr("data-question-id");
            var questionTitle = $(this).attr('data-question-title');

            archiveQuestion(questionId, questionTitle);
        });

        $('.edit-question').click(function (e) {
            var questionId = $(this).attr("data-question-id");
            
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Question/EditQuestionModal?questionId=' + questionId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#QuestionEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        /*_$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var question = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);
            _questionService.create(question).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });*/
        
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshQuestionList() {
            location.reload(true); //reload page to see new user!
        }

        function archiveQuestion(questionId, questionTitle) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'KS'), questionTitle),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _questionService.delete({
                            id: questionId
                        }).done(function () {
                            refreshQuestionList();
                        });
                    }
                }
            );
        }
    });
})();