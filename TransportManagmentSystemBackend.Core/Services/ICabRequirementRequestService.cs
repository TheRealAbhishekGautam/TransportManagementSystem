﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagmentSystemBackend.Core.Domain.Models;


namespace TransportManagmentSystemBackend.Core.Services
{
    public interface ICabRequirementRequestService
    {
        Task<CabRequirementRequestResponse> Add(CabRequirementRequest request);
        Task<List<CabRequirementRequestResponse>> GetAll();
        Task<CabRequirementRequestResponse> Update(CabRequirementRequest request,int Id);
        Task<CabRequirementRequestResponse> GetCabRequest(int Id);
        Task<bool> DeleteCab(int id);

    }
}
