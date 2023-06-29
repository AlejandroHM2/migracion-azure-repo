// <summary>
// <copyright file="GlobalUsings.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

global using [%= company %].[%= name %]s.Backgrounds;
global using [%= company %].[%= name %]s.DTOs.Config;
global using [%= company %].[%= name %]s.DTOs.Create[%= name %];
global using [%= company %].[%= name %]s.DTOs.Update[%= name %];
global using [%= company %].[%= name %]s.DTOs;
global using [%= company %].[%= name %]s.IoC;
global using [%= company %].[%= name %]s.Presenters;
global using [%= company %].[%= name %]s.UseCases.Create[%= name %];
global using [%= company %].[%= name %]s.UseCases.Delete[%= name %];
global using [%= company %].[%= name %]s.UseCases.GetAll[%= name %]s;
global using [%= company %].[%= name %]s.UseCases.GetById[%= name %];
global using [%= company %].[%= name %]s.UseCases.Update[%= name %];
global using [%= company %].[%= name %]s.WebExceptionsPresenter;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using Serilog;
global using Serilog.Events;
global using Steeltoe.Extensions.Configuration.Placeholder;