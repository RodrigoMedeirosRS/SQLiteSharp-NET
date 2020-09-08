﻿namespace System.Data.SQLite.Tools
{
	[Flags]
	public enum SQLiteOpenFlags
	{
		ReadOnly = 1, ReadWrite = 2, Create = 4,
		NoMutex = 0x8000, FullMutex = 0x10000,
		SharedCache = 0x20000, PrivateCache = 0x40000,
		ProtectionComplete = 0x00100000,
		ProtectionCompleteUnlessOpen = 0x00200000,
		ProtectionCompleteUntilFirstUserAuthentication = 0x00300000,
		ProtectionNone = 0x00400000
	}

	[Flags]
	public enum CreateFlags
	{
		/// <summary>
		/// Use the default creation options
		/// </summary>
		None = 0x000,
		/// <summary>
		/// Create a primary key index for a property called 'Id' (case-insensitive).
		/// This avoids the need for the [PrimaryKey] attribute.
		/// </summary>
		ImplicitPK = 0x001,
		/// <summary>
		/// Create indices for properties ending in 'Id' (case-insensitive).
		/// </summary>
		ImplicitIndex = 0x002,
		/// <summary>
		/// Create a primary key for a property called 'Id' and
		/// create an indices for properties ending in 'Id' (case-insensitive).
		/// </summary>
		AllImplicit = 0x003,
		/// <summary>
		/// Force the primary key property to be auto incrementing.
		/// This avoids the need for the [AutoIncrement] attribute.
		/// The primary key property on the class should have type int or long.
		/// </summary>
		AutoIncPK = 0x004,
		/// <summary>
		/// Create virtual table using FTS3
		/// </summary>
		FullTextSearch3 = 0x100,
		/// <summary>
		/// Create virtual table using FTS4
		/// </summary>
		FullTextSearch4 = 0x200
	}

	public enum NotifyTableChangedAction
	{
		Insert,
		Update,
		Delete,
	}

	public enum CreateTableResult
	{
		Created,
		Migrated,
	}

	public enum Result : int
	{
		OK = 0,
		Error = 1,
		Internal = 2,
		Perm = 3,
		Abort = 4,
		Busy = 5,
		Locked = 6,
		NoMem = 7,
		ReadOnly = 8,
		Interrupt = 9,
		IOError = 10,
		Corrupt = 11,
		NotFound = 12,
		Full = 13,
		CannotOpen = 14,
		LockErr = 15,
		Empty = 16,
		SchemaChngd = 17,
		TooBig = 18,
		Constraint = 19,
		Mismatch = 20,
		Misuse = 21,
		NotImplementedLFS = 22,
		AccessDenied = 23,
		Format = 24,
		Range = 25,
		NonDBFile = 26,
		Notice = 27,
		Warning = 28,
		Row = 100,
		Done = 101
	}

	public enum ExtendedResult : int
	{
		IOErrorRead = (Result.IOError | (1 << 8)),
		IOErrorShortRead = (Result.IOError | (2 << 8)),
		IOErrorWrite = (Result.IOError | (3 << 8)),
		IOErrorFsync = (Result.IOError | (4 << 8)),
		IOErrorDirFSync = (Result.IOError | (5 << 8)),
		IOErrorTruncate = (Result.IOError | (6 << 8)),
		IOErrorFStat = (Result.IOError | (7 << 8)),
		IOErrorUnlock = (Result.IOError | (8 << 8)),
		IOErrorRdlock = (Result.IOError | (9 << 8)),
		IOErrorDelete = (Result.IOError | (10 << 8)),
		IOErrorBlocked = (Result.IOError | (11 << 8)),
		IOErrorNoMem = (Result.IOError | (12 << 8)),
		IOErrorAccess = (Result.IOError | (13 << 8)),
		IOErrorCheckReservedLock = (Result.IOError | (14 << 8)),
		IOErrorLock = (Result.IOError | (15 << 8)),
		IOErrorClose = (Result.IOError | (16 << 8)),
		IOErrorDirClose = (Result.IOError | (17 << 8)),
		IOErrorSHMOpen = (Result.IOError | (18 << 8)),
		IOErrorSHMSize = (Result.IOError | (19 << 8)),
		IOErrorSHMLock = (Result.IOError | (20 << 8)),
		IOErrorSHMMap = (Result.IOError | (21 << 8)),
		IOErrorSeek = (Result.IOError | (22 << 8)),
		IOErrorDeleteNoEnt = (Result.IOError | (23 << 8)),
		IOErrorMMap = (Result.IOError | (24 << 8)),
		LockedSharedcache = (Result.Locked | (1 << 8)),
		BusyRecovery = (Result.Busy | (1 << 8)),
		CannottOpenNoTempDir = (Result.CannotOpen | (1 << 8)),
		CannotOpenIsDir = (Result.CannotOpen | (2 << 8)),
		CannotOpenFullPath = (Result.CannotOpen | (3 << 8)),
		CorruptVTab = (Result.Corrupt | (1 << 8)),
		ReadonlyRecovery = (Result.ReadOnly | (1 << 8)),
		ReadonlyCannotLock = (Result.ReadOnly | (2 << 8)),
		ReadonlyRollback = (Result.ReadOnly | (3 << 8)),
		AbortRollback = (Result.Abort | (2 << 8)),
		ConstraintCheck = (Result.Constraint | (1 << 8)),
		ConstraintCommitHook = (Result.Constraint | (2 << 8)),
		ConstraintForeignKey = (Result.Constraint | (3 << 8)),
		ConstraintFunction = (Result.Constraint | (4 << 8)),
		ConstraintNotNull = (Result.Constraint | (5 << 8)),
		ConstraintPrimaryKey = (Result.Constraint | (6 << 8)),
		ConstraintTrigger = (Result.Constraint | (7 << 8)),
		ConstraintUnique = (Result.Constraint | (8 << 8)),
		ConstraintVTab = (Result.Constraint | (9 << 8)),
		NoticeRecoverWAL = (Result.Notice | (1 << 8)),
		NoticeRecoverRollback = (Result.Notice | (2 << 8))
	}

	public enum ConfigOption : int
	{
		SingleThread = 1,
		MultiThread = 2,
		Serialized = 3
	}

}
