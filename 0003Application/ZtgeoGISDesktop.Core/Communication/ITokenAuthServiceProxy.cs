﻿using Abp.Application.Services.Dto;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ztgeo.Gis.Runtime.Authorization;
using Ztgeo.Gis.Runtime.Authorization.Permissions;

namespace ZtgeoGISDesktop.Core.Communication
{
    public interface ITokenAuthServiceProxy : ISingletonDependency
    {
        AuthenticateResultModel Authenticate(AuthenticateModel authenticateModel);
        Task<AuthenticateResultModel> AuthenticateAsync(AuthenticateModel authenticateModel);

        IListResult<FlatPermissionWithLevelDto> GetAllPressions();

        Task<IListResult<FlatPermissionWithLevelDto>> GetAllPressionsAsync();
    }
}
