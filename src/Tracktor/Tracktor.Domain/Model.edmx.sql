
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2016 14:42:32
-- Generated from EDMX file: C:\Users\herc\Source\Repos\oobl-seminar\src\Tracktor\Tracktor.Domain\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [tracktordb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InfoComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents_Comment] DROP CONSTRAINT [FK_InfoComment];
GO
IF OBJECT_ID(N'[dbo].[FK_InfoCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents_Info] DROP CONSTRAINT [FK_InfoCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_VotedPositive_Reputation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VotedPositive] DROP CONSTRAINT [FK_VotedPositive_Reputation];
GO
IF OBJECT_ID(N'[dbo].[FK_VotedPositive_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VotedPositive] DROP CONSTRAINT [FK_VotedPositive_User];
GO
IF OBJECT_ID(N'[dbo].[FK_VotedNegative_Reputation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VotedNegative] DROP CONSTRAINT [FK_VotedNegative_Reputation];
GO
IF OBJECT_ID(N'[dbo].[FK_VotedNegative_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VotedNegative] DROP CONSTRAINT [FK_VotedNegative_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ContentUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_ContentUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ContentReputation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents] DROP CONSTRAINT [FK_ContentReputation];
GO
IF OBJECT_ID(N'[dbo].[FK_Info_inherits_Content]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents_Info] DROP CONSTRAINT [FK_Info_inherits_Content];
GO
IF OBJECT_ID(N'[dbo].[FK_Comment_inherits_Content]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contents_Comment] DROP CONSTRAINT [FK_Comment_inherits_Content];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Reputations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reputations];
GO
IF OBJECT_ID(N'[dbo].[Contents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contents];
GO
IF OBJECT_ID(N'[dbo].[Contents_Info]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contents_Info];
GO
IF OBJECT_ID(N'[dbo].[Contents_Comment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contents_Comment];
GO
IF OBJECT_ID(N'[dbo].[VotedPositive]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VotedPositive];
GO
IF OBJECT_ID(N'[dbo].[VotedNegative]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VotedNegative];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [isAdmin] bit  NOT NULL,
    [fullName] nvarchar(max)  NOT NULL,
    [isPremium] bit  NOT NULL,
    [enabled] bit  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int  NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Reputations'
CREATE TABLE [dbo].[Reputations] (
    [id] int  NOT NULL
);
GO

-- Creating table 'Contents'
CREATE TABLE [dbo].[Contents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [startTime] datetime  NOT NULL,
    [User_Id] int  NOT NULL,
    [Reputation_id] int  NOT NULL
);
GO

-- Creating table 'Contents_Info'
CREATE TABLE [dbo].[Contents_Info] (
    [location] geography  NOT NULL,
    [range] float  NOT NULL,
    [endTime] datetime  NOT NULL,
    [Id] int  NOT NULL,
    [Category_Id] int  NOT NULL
);
GO

-- Creating table 'Contents_Comment'
CREATE TABLE [dbo].[Contents_Comment] (
    [Id] int  NOT NULL,
    [Info_Id] int  NOT NULL
);
GO

-- Creating table 'VotedPositive'
CREATE TABLE [dbo].[VotedPositive] (
    [Reputations_id] int  NOT NULL,
    [VotedPositive_Id] int  NOT NULL
);
GO

-- Creating table 'VotedNegative'
CREATE TABLE [dbo].[VotedNegative] (
    [Reputations1_id] int  NOT NULL,
    [VotedNegative_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Reputations'
ALTER TABLE [dbo].[Reputations]
ADD CONSTRAINT [PK_Reputations]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [PK_Contents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contents_Info'
ALTER TABLE [dbo].[Contents_Info]
ADD CONSTRAINT [PK_Contents_Info]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contents_Comment'
ALTER TABLE [dbo].[Contents_Comment]
ADD CONSTRAINT [PK_Contents_Comment]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Reputations_id], [VotedPositive_Id] in table 'VotedPositive'
ALTER TABLE [dbo].[VotedPositive]
ADD CONSTRAINT [PK_VotedPositive]
    PRIMARY KEY CLUSTERED ([Reputations_id], [VotedPositive_Id] ASC);
GO

-- Creating primary key on [Reputations1_id], [VotedNegative_Id] in table 'VotedNegative'
ALTER TABLE [dbo].[VotedNegative]
ADD CONSTRAINT [PK_VotedNegative]
    PRIMARY KEY CLUSTERED ([Reputations1_id], [VotedNegative_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Info_Id] in table 'Contents_Comment'
ALTER TABLE [dbo].[Contents_Comment]
ADD CONSTRAINT [FK_InfoComment]
    FOREIGN KEY ([Info_Id])
    REFERENCES [dbo].[Contents_Info]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InfoComment'
CREATE INDEX [IX_FK_InfoComment]
ON [dbo].[Contents_Comment]
    ([Info_Id]);
GO

-- Creating foreign key on [Category_Id] in table 'Contents_Info'
ALTER TABLE [dbo].[Contents_Info]
ADD CONSTRAINT [FK_InfoCategory]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InfoCategory'
CREATE INDEX [IX_FK_InfoCategory]
ON [dbo].[Contents_Info]
    ([Category_Id]);
GO

-- Creating foreign key on [Reputations_id] in table 'VotedPositive'
ALTER TABLE [dbo].[VotedPositive]
ADD CONSTRAINT [FK_VotedPositive_Reputation]
    FOREIGN KEY ([Reputations_id])
    REFERENCES [dbo].[Reputations]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [VotedPositive_Id] in table 'VotedPositive'
ALTER TABLE [dbo].[VotedPositive]
ADD CONSTRAINT [FK_VotedPositive_User]
    FOREIGN KEY ([VotedPositive_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VotedPositive_User'
CREATE INDEX [IX_FK_VotedPositive_User]
ON [dbo].[VotedPositive]
    ([VotedPositive_Id]);
GO

-- Creating foreign key on [Reputations1_id] in table 'VotedNegative'
ALTER TABLE [dbo].[VotedNegative]
ADD CONSTRAINT [FK_VotedNegative_Reputation]
    FOREIGN KEY ([Reputations1_id])
    REFERENCES [dbo].[Reputations]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [VotedNegative_Id] in table 'VotedNegative'
ALTER TABLE [dbo].[VotedNegative]
ADD CONSTRAINT [FK_VotedNegative_User]
    FOREIGN KEY ([VotedNegative_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VotedNegative_User'
CREATE INDEX [IX_FK_VotedNegative_User]
ON [dbo].[VotedNegative]
    ([VotedNegative_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_ContentUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContentUser'
CREATE INDEX [IX_FK_ContentUser]
ON [dbo].[Contents]
    ([User_Id]);
GO

-- Creating foreign key on [Reputation_id] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [FK_ContentReputation]
    FOREIGN KEY ([Reputation_id])
    REFERENCES [dbo].[Reputations]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContentReputation'
CREATE INDEX [IX_FK_ContentReputation]
ON [dbo].[Contents]
    ([Reputation_id]);
GO

-- Creating foreign key on [Id] in table 'Contents_Info'
ALTER TABLE [dbo].[Contents_Info]
ADD CONSTRAINT [FK_Info_inherits_Content]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Contents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Contents_Comment'
ALTER TABLE [dbo].[Contents_Comment]
ADD CONSTRAINT [FK_Comment_inherits_Content]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Contents]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------