#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 11:32:49
* 文 件 名：JobInstall
* 版本：V1.0.0
* 描述说明：
*
* 更改历史==============================================
* 修改者：           时间：               
* 修改说明：
*
* *******************************************************/
#endregion
using System;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.ServiceProcess;

namespace HDC.Job.Container
{
    [RunInstaller(true)]
    public class JobInstall : Installer
    {
        private ServiceInstaller installer;
        private ServiceProcessInstaller proInstaller;

        public JobInstall()
        {
            installer = new ServiceInstaller();
            proInstaller = new ServiceProcessInstaller();
            proInstaller.Account = ServiceAccount.LocalSystem;

            installer.StartType = ServiceStartMode.Automatic;
            installer.ServiceName = JobHelper.GetJobName();
            installer.DisplayName = JobHelper.GetJobDisplayName();
            installer.Description = JobHelper.GetJobDescription();

            Installers.Add(installer);
            Installers.Add(proInstaller);
        }
    }
}
