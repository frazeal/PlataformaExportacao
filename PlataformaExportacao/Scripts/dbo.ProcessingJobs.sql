CREATE TABLE [dbo].[ProcessingJobs] (
    [IdJob]                      INT           NOT NULL IDENTITY,
    [JobName]                    VARCHAR (20)  NOT NULL,
    [JobDescription]             VARCHAR (200) NULL,
    [OperationMode]              INT           NOT NULL,
    [InputFolderPath]            VARCHAR (150)  NULL,
    [InputFileName]              VARCHAR (50)  NULL,
	[InputFileExtension]         VARCHAR (5)  NULL,
	[InputFileSeparatorChar]	 CHAR	 (1)   NULL,
    [ProcedureName]              VARCHAR (200) NULL,
	[BackupFolderPath]			 VARCHAR (150) NULL,
    [OutputFolderPath]           VARCHAR (150) NOT NULL,
    [OutputFileName]             VARCHAR (50)  NOT NULL,
    [OutputFileExtension]        VARCHAR (5)   NULL,
	[OutputFileSeparatorChar]    CHAR (1)      NULL,
    [IsJobActiveFlag]            BIT           NOT NULL,
    [FileExportDateTimeFlag]     BIT           NOT NULL,
    [FileProcessingDateTimeFlag] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([IdJob] ASC)
);

