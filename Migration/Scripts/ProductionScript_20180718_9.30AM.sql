CREATE TABLE [QuestionAnswerViewCounts] (
    [Id] int NOT NULL IDENTITY,
    [CreationTime] datetime2 NOT NULL,
    [CreatorUserId] bigint NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierUserId] bigint NULL,
    [DeleterUserId] bigint NULL,
    [DeletionTime] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    [QuestionAnswerId] int NOT NULL,
    [Count] bigint NOT NULL,
    CONSTRAINT [PK_QuestionAnswerViewCounts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionAnswerViewCounts_AbpUsers_CreatorUserId] FOREIGN KEY ([CreatorUserId]) REFERENCES [AbpUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_QuestionAnswerViewCounts_QuestionAnswers_QuestionAnswerId] FOREIGN KEY ([QuestionAnswerId]) REFERENCES [QuestionAnswers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_QuestionAnswerViewCounts_CreatorUserId] ON [QuestionAnswerViewCounts] ([CreatorUserId]);

GO

CREATE INDEX [IX_QuestionAnswerViewCounts_QuestionAnswerId] ON [QuestionAnswerViewCounts] ([QuestionAnswerId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180710184545_QuestionAnswerViewCount_Model_Added', N'2.1.0-rtm-30799');

GO

