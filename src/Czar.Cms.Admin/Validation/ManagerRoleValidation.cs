﻿using Czar.Cms.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Czar.Cms.Admin.Validation
{
    public class ManagerRoleValidation : AbstractValidator<ManagerRole>
    {
        public ManagerRoleValidation()
        {
            RuleFor(x => x.RoleName).Length(1, 64).WithMessage("角色名称不能为空并且长度不能超过64个字符");
            RuleFor(x => x.RoleType).InclusiveBetween(1,2).WithMessage("角色类型格式不正确") ;
            RuleFor(x => x.IsSystem).NotNull().WithMessage("是否系统默认必须选择") ;
            RuleFor(x => x.Remark).Length(0, 128).WithMessage("备注信息的长度必须符合规则");
        }
    }
}