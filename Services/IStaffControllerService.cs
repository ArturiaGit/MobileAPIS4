﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobileAPIS4.DtoParameter;
using MobileAPIS4.Entities;

namespace MobileAPIS4.Services;

public interface IStaffControllerService
{
    //根据parameter.Telephone和parameter.Password获取人员信息
    public Task<Staff> GetStaffAsync(StaffControllerParameter parameter);

    //根据RoleId获取对应的Role信息
    public Task<Role> GetRoleAsync(int roleId);

    //获取所有空闲的车队负责人
    public Task<IEnumerable<Staff>> GetFreeVehicleTeamAdministrator();
}