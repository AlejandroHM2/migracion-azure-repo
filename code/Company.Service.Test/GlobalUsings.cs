// <summary>
// <copyright file="GlobalUsings.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

global using AutoMapper;
global using Company.Service.DTOs;
global using Company.Service.DTOs.Config;
global using Company.Service.DTOs.CreateUser;
global using Company.Service.DTOs.UpdateUser;
global using Company.Service.Entities.Enum;
global using Company.Service.Entities.Interfaces;
global using Company.Service.Entities.Poco;
global using Company.Service.Repositories.DataContext;
global using Company.Service.Repositories.Repositories;
global using Company.Service.UseCases.Common.Mappings;
global using Company.Service.UseCases.Common.Ports;
global using Company.Service.UseCases.CreateUser;
global using Company.Service.UseCases.DeleteUser;
global using Company.Service.UseCases.GetAllUsers;
global using Company.Service.UseCases.GetByIdUser;
global using Company.Service.UseCases.UpdateUser;
global using Dapper.FastCrud;
global using Microsoft.Extensions.Caching.Distributed;
global using Microsoft.Extensions.Options;
global using Moq;
global using NUnit.Framework;
global using System.Data.SQLite;
