DROP TABLE [QuestionsAnswerComments];

GO

DROP TABLE [QuestionsAnswers];

GO

ALTER TABLE [Questionses] ADD [QuestionViewCount] bigint NOT NULL DEFAULT CAST(0 AS bigint);

GO

CREATE TABLE [QuestionAnswers] (
    [Id] int NOT NULL IDENTITY,
    [CreationTime] datetime2 NOT NULL,
    [CreatorUserId] bigint NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierUserId] bigint NULL,
    [DeleterUserId] bigint NULL,
    [DeletionTime] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    [QuestionId] int NOT NULL,
    [AnswerText] nvarchar(max) NULL,
    [IsCorrect] bit NOT NULL,
    [Rating] int NULL,
    CONSTRAINT [PK_QuestionAnswers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionAnswers_Questionses_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [Questionses] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [QuestionRatings] (
    [Id] int NOT NULL IDENTITY,
    [CreationTime] datetime2 NOT NULL,
    [CreatorUserId] bigint NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierUserId] bigint NULL,
    [DeleterUserId] bigint NULL,
    [DeletionTime] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    [QuestionId] int NOT NULL,
    [Rating] int NOT NULL,
    CONSTRAINT [PK_QuestionRatings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionRatings_Questionses_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [Questionses] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [QuestionAnswerComments] (
    [Id] int NOT NULL IDENTITY,
    [CreationTime] datetime2 NOT NULL,
    [CreatorUserId] bigint NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierUserId] bigint NULL,
    [DeleterUserId] bigint NULL,
    [DeletionTime] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    [QuestionAnswerId] int NOT NULL,
    [Comment] nvarchar(max) NULL,
    CONSTRAINT [PK_QuestionAnswerComments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionAnswerComments_QuestionAnswers_QuestionAnswerId] FOREIGN KEY ([QuestionAnswerId]) REFERENCES [QuestionAnswers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [QuestionAnswerRatings] (
    [Id] int NOT NULL IDENTITY,
    [CreationTime] datetime2 NOT NULL,
    [CreatorUserId] bigint NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierUserId] bigint NULL,
    [DeleterUserId] bigint NULL,
    [DeletionTime] datetime2 NULL,
    [IsDeleted] bit NOT NULL,
    [QuestionAnswerId] int NOT NULL,
    [Rating] int NOT NULL,
    CONSTRAINT [PK_QuestionAnswerRatings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuestionAnswerRatings_QuestionAnswers_QuestionAnswerId] FOREIGN KEY ([QuestionAnswerId]) REFERENCES [QuestionAnswers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_QuestionAnswerComments_QuestionAnswerId] ON [QuestionAnswerComments] ([QuestionAnswerId]);

GO

CREATE INDEX [IX_QuestionAnswerRatings_QuestionAnswerId] ON [QuestionAnswerRatings] ([QuestionAnswerId]);

GO

CREATE INDEX [IX_QuestionAnswers_QuestionId] ON [QuestionAnswers] ([QuestionId]);

GO

CREATE INDEX [IX_QuestionRatings_QuestionId] ON [QuestionRatings] ([QuestionId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180705000022_RatingModels_Added_And_Modified', N'2.1.0-rtm-30799');

GO

