﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1848:Use the LoggerMessage delegates", Justification = "Pending migration to LoggerMessage.", Scope = "member", Target = "~T:GtMotive.Estimate.Microservice.Infrastructure.Logging.LoggerAdapter`1")]
[assembly: SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "Pending migration to LoggerMessage.", Scope = "member", Target = "~T:GtMotive.Estimate.Microservice.Infrastructure.Logging.LoggerAdapter`1")]
[assembly: SuppressMessage("Style", "IDE0240:Quitar directiva redundante que admite un valor NULL", Justification = "<pendiente>", Scope = "namespace", Target = "~N:GtMotive.Estimate.Microservice.Infrastructure.Migrations")]
[assembly: SuppressMessage("Design", "CA1062:Validar argumentos de métodos públicos", Justification = "<pendiente>", Scope = "member", Target = "~M:GtMotive.Estimate.Microservice.Infrastructure.Migrations.InitialCreate.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)")]
[assembly: SuppressMessage("Design", "CA1062:Validar argumentos de métodos públicos", Justification = "<pendiente>", Scope = "member", Target = "~M:GtMotive.Estimate.Microservice.Infrastructure.Migrations.InitialCreate.Down(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)")]
