ALTER TABLE [QuestionRatings] ADD [Reason] nvarchar(max) NULL;

GO

CREATE INDEX [IX_QuestionViewCounts_CreatorUserId] ON [QuestionViewCounts] ([CreatorUserId]);

GO

CREATE INDEX [IX_Questionses_CreatorUserId] ON [Questionses] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionRatings_CreatorUserId] ON [QuestionRatings] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionCategories_CreatorUserId] ON [QuestionCategories] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionAnswers_CreatorUserId] ON [QuestionAnswers] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionAnswerRatings_CreatorUserId] ON [QuestionAnswerRatings] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionAnswerComments_CreatorUserId] ON [QuestionAnswerComments] ([CreatorUserId]);

GO

ALTER TABLE [QuestionAnswerComments] ADD CONSTRAINT [FK_QuestionAnswerComments_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [QuestionAnswerRatings] ADD CONSTRAINT [FK_QuestionAnswerRatings_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [QuestionAnswers] ADD CONSTRAINT [FK_QuestionAnswers_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [QuestionCategories] ADD CONSTRAINT [FK_QuestionCategories_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [QuestionRatings] ADD CONSTRAINT [FK_QuestionRatings_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Questionses] ADD CONSTRAINT [FK_Questionses_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [QuestionViewCounts] ADD CONSTRAINT [FK_QuestionViewCounts_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180708161823_Reason_Added_On_Reating', N'2.1.0-rtm-30799');

GO

ALTER TABLE [Questionses] ADD [RatingValue] float NOT NULL DEFAULT 0E0;

GO

ALTER TABLE [QuestionAnswers] ADD [RatingValue] float NOT NULL DEFAULT 0E0;

GO

ALTER TABLE [QuestionAnswerRatings] ADD [Reason] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180709031033_RatingValue_Added_On_Question_And_QuestionAnswer_Models', N'2.1.0-rtm-30799');

GO

