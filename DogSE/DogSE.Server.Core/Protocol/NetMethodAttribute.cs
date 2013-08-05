﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogSE.Server.Core.Protocol
{
    /// <summary>
    /// 网络回调方法的参数
    /// </summary>
    public class NetMethodAttribute:Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opcode"></param>
        /// <param name="type">消息的处理方法</param>
        public NetMethodAttribute(ushort opcode, NetMethodType type)
        {
            OpCode = opcode;
            MethodType = type;
        }

        /// <summary>
        /// 消息码
        /// </summary>
        public ushort OpCode { get; private set; }

        /// <summary>
        /// 方法类型
        /// </summary>
        public NetMethodType MethodType { get; private set; }

    }

    /// <summary>
    /// 网络方法的生成类型
    /// </summary>
    public enum NetMethodType
    {
        /// <summary>
        /// 方法里一共2个参数
        /// 第二个参数为使用的是数据流，需要自己来解析数据流内容
        /// </summary>
        PacketReader  = 0,

        /// <summary>
        /// 方法里一共2个参数
        /// 第二个参数为已经定义过解析协议的数据包流对象
        /// </summary>
        ProtocolStruct = 1,

        /// <summary>
        /// 简单方法，由系统自动帮忙负责解析协议
        /// </summary>
        SimpleMethod = 2,
    }
}
