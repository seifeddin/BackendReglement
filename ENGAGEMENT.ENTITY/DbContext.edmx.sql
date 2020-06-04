
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/04/2020 09:52:14
-- Generated from EDMX file: C:\PFE_ACHREF\BackendReglement\ENGAGEMENT.ENTITY\DbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [REG_FSS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Facture_Fournisseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facture] DROP CONSTRAINT [FK_Facture_Fournisseur];
GO
IF OBJECT_ID(N'[dbo].[FK_FoncTechRole_FoncRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FoncTechRole] DROP CONSTRAINT [FK_FoncTechRole_FoncRole];
GO
IF OBJECT_ID(N'[dbo].[FK_FoncTechRole_TechRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FoncTechRole] DROP CONSTRAINT [FK_FoncTechRole_TechRole];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_Banque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_Banque];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_BonAPayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_BonAPayer];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_Caisse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_Caisse];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_Devise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_Devise];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_ModeReglement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_ModeReglement];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_Retenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_Retenu];
GO
IF OBJECT_ID(N'[dbo].[FK_Reglement_SuiviBancaire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reglement] DROP CONSTRAINT [FK_Reglement_SuiviBancaire];
GO
IF OBJECT_ID(N'[dbo].[FK_ReglementFacture_Facture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReglementFacture] DROP CONSTRAINT [FK_ReglementFacture_Facture];
GO
IF OBJECT_ID(N'[dbo].[FK_ReglementFacture_Reglement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReglementFacture] DROP CONSTRAINT [FK_ReglementFacture_Reglement];
GO
IF OBJECT_ID(N'[dbo].[FK_RubriqueRetenu_Annexe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RubriqueRetenu] DROP CONSTRAINT [FK_RubriqueRetenu_Annexe];
GO
IF OBJECT_ID(N'[dbo].[FK_RubriqueRetenu_Retenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RubriqueRetenu] DROP CONSTRAINT [FK_RubriqueRetenu_Retenu];
GO
IF OBJECT_ID(N'[dbo].[FK_RubriqueRetenu_Rubrique]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RubriqueRetenu] DROP CONSTRAINT [FK_RubriqueRetenu_Rubrique];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Utilisateur] DROP CONSTRAINT [FK_Utilisateur_Role];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Annexe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Annexe];
GO
IF OBJECT_ID(N'[dbo].[Banque]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Banque];
GO
IF OBJECT_ID(N'[dbo].[BonAPayer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BonAPayer];
GO
IF OBJECT_ID(N'[dbo].[Caisse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Caisse];
GO
IF OBJECT_ID(N'[dbo].[Devise]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Devise];
GO
IF OBJECT_ID(N'[dbo].[Facture]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facture];
GO
IF OBJECT_ID(N'[dbo].[FoncTechRole]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoncTechRole];
GO
IF OBJECT_ID(N'[dbo].[Fournisseur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fournisseur];
GO
IF OBJECT_ID(N'[dbo].[ModeReglement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeReglement];
GO
IF OBJECT_ID(N'[dbo].[Reglement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reglement];
GO
IF OBJECT_ID(N'[dbo].[ReglementFacture]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReglementFacture];
GO
IF OBJECT_ID(N'[dbo].[Retenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Retenu];
GO
IF OBJECT_ID(N'[dbo].[RoleFonctionnel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleFonctionnel];
GO
IF OBJECT_ID(N'[dbo].[RoleTechnique]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleTechnique];
GO
IF OBJECT_ID(N'[dbo].[Rubrique]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rubrique];
GO
IF OBJECT_ID(N'[dbo].[RubriqueRetenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RubriqueRetenu];
GO
IF OBJECT_ID(N'[dbo].[SuiviBancaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SuiviBancaire];
GO
IF OBJECT_ID(N'[dbo].[Utilisateur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utilisateur];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Annexe'
CREATE TABLE [dbo].[Annexe] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL
);
GO

-- Creating table 'Banque'
CREATE TABLE [dbo].[Banque] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL
);
GO

-- Creating table 'BonAPayer'
CREATE TABLE [dbo].[BonAPayer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MontantRetenu] decimal(18,3)  NULL,
    [MontantTotalEcheance] decimal(18,3)  NULL,
    [NetAPayer] decimal(18,3)  NULL,
    [ValiderPar] varchar(250)  NULL,
    [DateValidation] datetime  NULL,
    [DateSignature] datetime  NULL,
    [EstRegle] bit  NULL
);
GO

-- Creating table 'Caisse'
CREATE TABLE [dbo].[Caisse] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL
);
GO

-- Creating table 'Devise'
CREATE TABLE [dbo].[Devise] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodeDevise] varchar(50)  NOT NULL
);
GO

-- Creating table 'Facture'
CREATE TABLE [dbo].[Facture] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Reference] varchar(50)  NULL,
    [Date] datetime  NULL,
    [Echeance] datetime  NULL,
    [MontantTotale] decimal(18,0)  NULL,
    [MontantDev] decimal(18,0)  NULL,
    [MontantRegle] decimal(18,0)  NULL,
    [MontantReste] decimal(18,0)  NULL,
    [Statut] varchar(50)  NULL,
    [IdFournisseur] int  NOT NULL
);
GO

-- Creating table 'Fournisseur'
CREATE TABLE [dbo].[Fournisseur] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaisonSocial] nvarchar(50)  NULL,
    [Nom] nvarchar(50)  NULL,
    [Prenom] nvarchar(50)  NULL,
    [FraisGeneraux] decimal(18,3)  NULL,
    [Solde] decimal(18,0)  NULL,
    [EstPhysique] bit  NULL,
    [EstMorale] bit  NULL
);
GO

-- Creating table 'ModeReglement'
CREATE TABLE [dbo].[ModeReglement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL
);
GO

-- Creating table 'Reglement'
CREATE TABLE [dbo].[Reglement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Echeance] datetime  NULL,
    [DateValidation] datetime  NULL,
    [ValiderPar] varchar(250)  NULL,
    [DateReglement] varchar(250)  NULL,
    [IdDevise] int  NULL,
    [IdRetenu] int  NULL,
    [IdModeReglement] int  NULL,
    [IdBanque] int  NULL,
    [IdCaisse] int  NULL,
    [IdSuiviBancaire] int  NULL,
    [IdBonAPayer] int  NULL
);
GO

-- Creating table 'ReglementFacture'
CREATE TABLE [dbo].[ReglementFacture] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdFacture] int  NOT NULL,
    [IdReglement] int  NOT NULL,
    [MontantTotale] decimal(18,3)  NULL
);
GO

-- Creating table 'Retenu'
CREATE TABLE [dbo].[Retenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [NumeroCertficat] int  NULL,
    [TypeMontant] varchar(50)  NULL,
    [DateValidation] datetime  NULL,
    [ValiderPar] varchar(50)  NULL
);
GO

-- Creating table 'RoleFonctionnel'
CREATE TABLE [dbo].[RoleFonctionnel] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(250)  NULL
);
GO

-- Creating table 'RoleTechnique'
CREATE TABLE [dbo].[RoleTechnique] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(250)  NULL
);
GO

-- Creating table 'Rubrique'
CREATE TABLE [dbo].[Rubrique] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] varchar(50)  NULL
);
GO

-- Creating table 'RubriqueRetenu'
CREATE TABLE [dbo].[RubriqueRetenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdRubrique] int  NOT NULL,
    [IdRetenu] int  NOT NULL,
    [MontantHt] decimal(18,3)  NULL,
    [Tva] float  NULL,
    [MontantTtc] decimal(18,3)  NULL,
    [IdAnnexe] int  NULL
);
GO

-- Creating table 'SuiviBancaire'
CREATE TABLE [dbo].[SuiviBancaire] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstPreavis] bit  NULL,
    [EstImpayes] bit  NULL,
    [EstRegle] bit  NULL
);
GO

-- Creating table 'Utilisateur'
CREATE TABLE [dbo].[Utilisateur] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdRoleFonctionnel] int  NULL,
    [NomUtilisateur] varchar(250)  NULL,
    [Nom] varchar(50)  NULL,
    [Prenom] varchar(50)  NULL,
    [MotDePasse] varchar(50)  NULL,
    [Email] varchar(50)  NULL,
    [Telephone] varchar(50)  NULL,
    [EstActive] bit  NULL
);
GO

-- Creating table 'FoncTechRole'
CREATE TABLE [dbo].[FoncTechRole] (
    [IdTechRole] int  NOT NULL,
    [IdFoncRole] int  NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Annexe'
ALTER TABLE [dbo].[Annexe]
ADD CONSTRAINT [PK_Annexe]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Banque'
ALTER TABLE [dbo].[Banque]
ADD CONSTRAINT [PK_Banque]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BonAPayer'
ALTER TABLE [dbo].[BonAPayer]
ADD CONSTRAINT [PK_BonAPayer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Caisse'
ALTER TABLE [dbo].[Caisse]
ADD CONSTRAINT [PK_Caisse]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Devise'
ALTER TABLE [dbo].[Devise]
ADD CONSTRAINT [PK_Devise]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Facture'
ALTER TABLE [dbo].[Facture]
ADD CONSTRAINT [PK_Facture]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fournisseur'
ALTER TABLE [dbo].[Fournisseur]
ADD CONSTRAINT [PK_Fournisseur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModeReglement'
ALTER TABLE [dbo].[ModeReglement]
ADD CONSTRAINT [PK_ModeReglement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [PK_Reglement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReglementFacture'
ALTER TABLE [dbo].[ReglementFacture]
ADD CONSTRAINT [PK_ReglementFacture]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Retenu'
ALTER TABLE [dbo].[Retenu]
ADD CONSTRAINT [PK_Retenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleFonctionnel'
ALTER TABLE [dbo].[RoleFonctionnel]
ADD CONSTRAINT [PK_RoleFonctionnel]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleTechnique'
ALTER TABLE [dbo].[RoleTechnique]
ADD CONSTRAINT [PK_RoleTechnique]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rubrique'
ALTER TABLE [dbo].[Rubrique]
ADD CONSTRAINT [PK_Rubrique]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RubriqueRetenu'
ALTER TABLE [dbo].[RubriqueRetenu]
ADD CONSTRAINT [PK_RubriqueRetenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SuiviBancaire'
ALTER TABLE [dbo].[SuiviBancaire]
ADD CONSTRAINT [PK_SuiviBancaire]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Utilisateur'
ALTER TABLE [dbo].[Utilisateur]
ADD CONSTRAINT [PK_Utilisateur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FoncTechRole'
ALTER TABLE [dbo].[FoncTechRole]
ADD CONSTRAINT [PK_FoncTechRole]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdAnnexe] in table 'RubriqueRetenu'
ALTER TABLE [dbo].[RubriqueRetenu]
ADD CONSTRAINT [FK_RubriqueRetenu_Annexe]
    FOREIGN KEY ([IdAnnexe])
    REFERENCES [dbo].[Annexe]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RubriqueRetenu_Annexe'
CREATE INDEX [IX_FK_RubriqueRetenu_Annexe]
ON [dbo].[RubriqueRetenu]
    ([IdAnnexe]);
GO

-- Creating foreign key on [IdBanque] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_Banque]
    FOREIGN KEY ([IdBanque])
    REFERENCES [dbo].[Banque]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_Banque'
CREATE INDEX [IX_FK_Reglement_Banque]
ON [dbo].[Reglement]
    ([IdBanque]);
GO

-- Creating foreign key on [IdBonAPayer] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_BonAPayer]
    FOREIGN KEY ([IdBonAPayer])
    REFERENCES [dbo].[BonAPayer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_BonAPayer'
CREATE INDEX [IX_FK_Reglement_BonAPayer]
ON [dbo].[Reglement]
    ([IdBonAPayer]);
GO

-- Creating foreign key on [IdCaisse] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_Caisse]
    FOREIGN KEY ([IdCaisse])
    REFERENCES [dbo].[Caisse]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_Caisse'
CREATE INDEX [IX_FK_Reglement_Caisse]
ON [dbo].[Reglement]
    ([IdCaisse]);
GO

-- Creating foreign key on [IdDevise] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_Devise]
    FOREIGN KEY ([IdDevise])
    REFERENCES [dbo].[Devise]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_Devise'
CREATE INDEX [IX_FK_Reglement_Devise]
ON [dbo].[Reglement]
    ([IdDevise]);
GO

-- Creating foreign key on [IdFournisseur] in table 'Facture'
ALTER TABLE [dbo].[Facture]
ADD CONSTRAINT [FK_Facture_Fournisseur]
    FOREIGN KEY ([IdFournisseur])
    REFERENCES [dbo].[Fournisseur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Facture_Fournisseur'
CREATE INDEX [IX_FK_Facture_Fournisseur]
ON [dbo].[Facture]
    ([IdFournisseur]);
GO

-- Creating foreign key on [IdFacture] in table 'ReglementFacture'
ALTER TABLE [dbo].[ReglementFacture]
ADD CONSTRAINT [FK_ReglementFacture_Facture]
    FOREIGN KEY ([IdFacture])
    REFERENCES [dbo].[Facture]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReglementFacture_Facture'
CREATE INDEX [IX_FK_ReglementFacture_Facture]
ON [dbo].[ReglementFacture]
    ([IdFacture]);
GO

-- Creating foreign key on [IdModeReglement] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_ModeReglement]
    FOREIGN KEY ([IdModeReglement])
    REFERENCES [dbo].[ModeReglement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_ModeReglement'
CREATE INDEX [IX_FK_Reglement_ModeReglement]
ON [dbo].[Reglement]
    ([IdModeReglement]);
GO

-- Creating foreign key on [IdRetenu] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_Retenu]
    FOREIGN KEY ([IdRetenu])
    REFERENCES [dbo].[Retenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_Retenu'
CREATE INDEX [IX_FK_Reglement_Retenu]
ON [dbo].[Reglement]
    ([IdRetenu]);
GO

-- Creating foreign key on [IdSuiviBancaire] in table 'Reglement'
ALTER TABLE [dbo].[Reglement]
ADD CONSTRAINT [FK_Reglement_SuiviBancaire]
    FOREIGN KEY ([IdSuiviBancaire])
    REFERENCES [dbo].[SuiviBancaire]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reglement_SuiviBancaire'
CREATE INDEX [IX_FK_Reglement_SuiviBancaire]
ON [dbo].[Reglement]
    ([IdSuiviBancaire]);
GO

-- Creating foreign key on [IdReglement] in table 'ReglementFacture'
ALTER TABLE [dbo].[ReglementFacture]
ADD CONSTRAINT [FK_ReglementFacture_Reglement]
    FOREIGN KEY ([IdReglement])
    REFERENCES [dbo].[Reglement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReglementFacture_Reglement'
CREATE INDEX [IX_FK_ReglementFacture_Reglement]
ON [dbo].[ReglementFacture]
    ([IdReglement]);
GO

-- Creating foreign key on [IdRetenu] in table 'RubriqueRetenu'
ALTER TABLE [dbo].[RubriqueRetenu]
ADD CONSTRAINT [FK_RubriqueRetenu_Retenu]
    FOREIGN KEY ([IdRetenu])
    REFERENCES [dbo].[Retenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RubriqueRetenu_Retenu'
CREATE INDEX [IX_FK_RubriqueRetenu_Retenu]
ON [dbo].[RubriqueRetenu]
    ([IdRetenu]);
GO

-- Creating foreign key on [IdRubrique] in table 'RubriqueRetenu'
ALTER TABLE [dbo].[RubriqueRetenu]
ADD CONSTRAINT [FK_RubriqueRetenu_Rubrique]
    FOREIGN KEY ([IdRubrique])
    REFERENCES [dbo].[Rubrique]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RubriqueRetenu_Rubrique'
CREATE INDEX [IX_FK_RubriqueRetenu_Rubrique]
ON [dbo].[RubriqueRetenu]
    ([IdRubrique]);
GO

-- Creating foreign key on [IdRoleFonctionnel] in table 'Utilisateur'
ALTER TABLE [dbo].[Utilisateur]
ADD CONSTRAINT [FK_Utilisateur_Role]
    FOREIGN KEY ([IdRoleFonctionnel])
    REFERENCES [dbo].[RoleFonctionnel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Utilisateur_Role'
CREATE INDEX [IX_FK_Utilisateur_Role]
ON [dbo].[Utilisateur]
    ([IdRoleFonctionnel]);
GO

-- Creating foreign key on [IdFoncRole] in table 'FoncTechRole'
ALTER TABLE [dbo].[FoncTechRole]
ADD CONSTRAINT [FK_FoncTechRole_FoncRole]
    FOREIGN KEY ([IdFoncRole])
    REFERENCES [dbo].[RoleFonctionnel]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoncTechRole_FoncRole'
CREATE INDEX [IX_FK_FoncTechRole_FoncRole]
ON [dbo].[FoncTechRole]
    ([IdFoncRole]);
GO

-- Creating foreign key on [IdTechRole] in table 'FoncTechRole'
ALTER TABLE [dbo].[FoncTechRole]
ADD CONSTRAINT [FK_FoncTechRole_TechRole]
    FOREIGN KEY ([IdTechRole])
    REFERENCES [dbo].[RoleTechnique]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoncTechRole_TechRole'
CREATE INDEX [IX_FK_FoncTechRole_TechRole]
ON [dbo].[FoncTechRole]
    ([IdTechRole]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------