// <summary>
// <copyright file="GlobalUsings.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

global using AutoMapper;
global using [%= company %].[%= name %]s.DTOs;
global using [%= company %].[%= name %]s.DTOs.Config;
global using [%= company %].[%= name %]s.DTOs.Create[%= name %];
global using [%= company %].[%= name %]s.DTOs.Update[%= name %];
global using [%= company %].[%= name %]s.Entities.Enum;
global using [%= company %].[%= name %]s.Entities.Interfaces;
global using [%= company %].[%= name %]s.Entities.Poco;
global using [%= company %].[%= name %]s.Repositories.DataContext;
global using [%= company %].[%= name %]s.Repositories.Repositories;
global using [%= company %].[%= name %]s.UseCases.Common.Mappings;
global using [%= company %].[%= name %]s.UseCases.Common.Ports;
global using [%= company %].[%= name %]s.UseCases.Create[%= name %];
global using [%= company %].[%= name %]s.UseCases.Delete[%= name %];
global using [%= company %].[%= name %]s.UseCases.GetAll[%= name %]s;
global using [%= company %].[%= name %]s.UseCases.GetById[%= name %];
global using [%= company %].[%= name %]s.UseCases.Update[%= name %];
global using Dapper.FastCrud;
global using Microsoft.Extensions.Caching.Distributed;
global using Microsoft.Extensions.Options;
global using Moq;
global using NUnit.Framework;
global using System.Data.SQLite;
