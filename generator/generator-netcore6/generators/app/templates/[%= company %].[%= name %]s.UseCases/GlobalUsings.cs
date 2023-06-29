// <summary>
// <copyright file="GlobalUsings.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

global using AutoMapper;
global using [%= company %].[%= name %]s.DTOs;
global using [%= company %].[%= name %]s.DTOs.Create[%= name %];
global using [%= company %].[%= name %]s.DTOs.Update[%= name %];
global using [%= company %].[%= name %]s.Entities.Exceptions;
global using [%= company %].[%= name %]s.Entities.Interfaces;
global using [%= company %].[%= name %]s.Entities.Poco;
global using [%= company %].[%= name %]s.UseCases.Common.Ports;
global using FluentValidation;
global using MediatR;
global using Microsoft.Extensions.Caching.Distributed;
global using Newtonsoft.Json;