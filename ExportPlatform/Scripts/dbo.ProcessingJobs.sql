CREATE TABLE [dbo].[ProcessingJobs] (
    [IdJob]                      INT           IDENTITY (1, 1) NOT NULL,
    [JobName]                    VARCHAR (20)  NOT NULL,
    [JobDescription]             VARCHAR (200) NULL,
    [JobOperationMode]           INT           NOT NULL,
	[JobProcessingType]          INT           NOT NULL,
    [IsJobActiveFlag]            BIT           NOT NULL,
    [ProcedureName]              VARCHAR (200) NULL,
    [BackupFolderPath]           VARCHAR (150) NULL,
    [InputFileFolderPath]        VARCHAR (150) NULL,
    [InputFileName]              VARCHAR (50)  NULL,
    [InputFileExtension]         VARCHAR (5)   NULL,
    [InputFileSeparatorChar]     CHAR (1)      NULL,
	[InputFileLayout]			 XML	       NULL,
    [OutputFileFolderPath]       VARCHAR (150) NOT NULL,
    [OutputFileName]             VARCHAR (50)  NOT NULL,
    [OutputFileExtension]        VARCHAR (5)   NULL,
    [OutputFileSeparatorChar]    CHAR (1)      NULL,
    [OutputFileLayout]			 XML		   NULL,
	[FileReferenceDateTimeFlag]  BIT           NOT NULL,
    [FileProcessingDateTimeFlag] BIT           NOT NULL
    PRIMARY KEY CLUSTERED ([IdJob] ASC)
);

