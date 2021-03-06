﻿using System;

namespace HostsManageTool.Winform
{
    /// <summary>
    /// 项已存在
    /// </summary>
    public class ItemAlreadyExitedException : Exception
    {
        public ItemAlreadyExitedException()
            : base("项目已存在")
        {
        }
    }

    /// <summary>
    /// 未找到项
    /// </summary>
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
            : base("项目不存在")
        {

        }
    }

    /// <summary>
    /// 操作失败
    /// </summary>
    public class ItemOperationFaildException : Exception
    {
        public ItemOperationFaildException() : base("操作失败") { }
    }

    /// <summary>
    /// 下载hosts失败
    /// </summary>
    public class HostSourceFalseException : Exception
    {
        public string RequestUrl { get; set; }

        public override string Message { get; }

        public HostSourceFalseException(string url, string msg)
        {
            Message = msg;
            RequestUrl = url;
        }

    }
}
