#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 11:30:47
* 文 件 名：JobService
* 版本：V1.0.0
* 描述说明：
*
* 更改历史==============================================
* 修改者：           时间：               
* 修改说明：
*
* *******************************************************/
#endregion
using E6GPS.Logger;
using HDC.Job.Container.Entities;
using HDC.Job.Interface;
using System;
using System.ServiceProcess;

namespace HDC.Job.Container
{
    public class JobService : ServiceBase
    {
        private readonly IJob job;
        private JobSettingEntity jobSetting;

        public JobService()
        {
            job = JobHelper.GetJobInstance();
            InitService();

        }

        private void InitService()
        {
            jobSetting = JobHelper.JobSetting;
            this.ServiceName = JobHelper.GetJobName();
            this.CanStop = true;
            this.CanShutdown = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                LoggerFactory.Info("JobServer.OnStart()");
                job.Start(JobHelper.GetJobContext());
            }
            catch (Exception ex)
            {
                LoggerFactory.Error(ex.Message, ex);
            }
        }

        protected override void OnStop()
        {
            LoggerFactory.Info("JobServer.Stop()");
            job.Stop(JobHelper.GetJobContext());
           
        }

        protected override void OnPause()
        {
            LoggerFactory.Info("JobServer.Pause()");
            job.Pause(JobHelper.GetJobContext());
           
        }
        protected override void OnContinue()
        {
            LoggerFactory.Info("JobServer.Continue()");
            job.Continue(JobHelper.GetJobContext());
            
        }
    }
}
