﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenAuth.Repository.Core;

namespace OpenAuth.Repository.Domain
{
    /// <summary>
	/// 系统日志
	/// </summary>
      [Table("SysLog")]
    public partial class SysLog : Entity
    {
        public SysLog()
        {
          this.Content= string.Empty;
          this.TypeName= string.Empty;
          this.TypeId= string.Empty;
          this.Href= string.Empty;
          this.CreateTime= DateTime.Now;
          this.CreateId= string.Empty;
          this.CreateName= string.Empty;
          this.Ip= string.Empty;
          this.Result= 0;
        }

        /// <summary>
	    /// 日志内容
	    /// </summary>
         [Description("日志内容")]
        public string Content { get; set; }
        /// <summary>
	    /// 分类名称
	    /// </summary>
         [Description("分类名称")]
        public string TypeName { get; set; }
        /// <summary>
	    /// 分类ID
	    /// </summary>
         [Description("分类ID")]
        public string TypeId { get; set; }
        /// <summary>
	    /// 操作所属模块地址
	    /// </summary>
         [Description("操作所属模块地址")]
        public string Href { get; set; }
        /// <summary>
	    /// 记录时间
	    /// </summary>
         [Description("记录时间")]
        public System.DateTime CreateTime { get; set; }
        /// <summary>
	    /// 操作人ID
	    /// </summary>
         [Description("操作人ID")]
        public string CreateId { get; set; }
        /// <summary>
	    /// 操作人
	    /// </summary>
         [Description("操作人")]
        public string CreateName { get; set; }
        /// <summary>
	    /// 操作机器的IP地址
	    /// </summary>
         [Description("操作机器的IP地址")]
        public string Ip { get; set; }
        /// <summary>
	    /// 操作的结果：0：成功；1：失败；
	    /// </summary>
         [Description("操作的结果：0：成功；1：失败；")]
        public int Result { get; set; }

    }
}