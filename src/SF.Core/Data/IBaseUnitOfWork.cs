﻿/*******************************************************************************
* 命名空间: SF.Core.Data
*
* 功 能： N/A
* 类 名： IBaseUnitOfWork
*
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2016/11/11 14:56:44 疯狂蚂蚁 初版
*
* Copyright (c) 2016 SF 版权所有
* Description: SF快速开发平台
* Website：http://www.mayisite.com
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using SF.Core.Abstraction.UoW;
using SF.Core.Data.WorkArea;
using SF.Core.EFCore.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SF.Core.Data
{
    public interface IBaseUnitOfWork : IEFCoreUnitOfWork
    {
        #region Work Areas

        IBaseWorkArea BaseWorkArea { get; }

        #endregion
    }
}
