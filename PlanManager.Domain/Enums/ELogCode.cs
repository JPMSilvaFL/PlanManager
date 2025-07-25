﻿namespace PlanManager.Domain.Enums;

public enum ELogCode {
	// Success
	CreatePerson = 1,
	CreateUser = 2,
	CreateAccess = 3,
	CreateCustomer = 4,
	CreatePurpose = 5,
	CreateRole = 6,
	CreateEmployee = 7,
	CreateSchedule = 8,
	CreateSecretary = 9,
	SearchAvailable = 10,
	Login = 11,

	// Errors
	DuplicatePersonKeys = 1001,
	AvailableError = 1002,
	ErrorGettingPurpose = 1003,
	InvalidUserError = 1004,
	ScheduledError = 1005,
	ScheduledNullError = 1006,
	SecretaryNullError = 1007
}