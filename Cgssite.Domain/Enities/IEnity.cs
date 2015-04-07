using System;

namespace Cgssite.Domain.Enities
{
    ///<summary>
    ///实现该接口的实体类
    ///</summary>
    interface IEnity
    {
        /// <summary>
        /// 实体类唯一标识
        /// </summary>
        Guid Id { get; }
    }
}
