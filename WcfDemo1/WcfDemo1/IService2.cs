﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService2”。
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        void DoWork();

        [OperationContract] //表示声明的是一个服务的操作契约
        double Add(double x, double y);

        [OperationContract]
        double Subtract(double x, double y);
    }

    

}
