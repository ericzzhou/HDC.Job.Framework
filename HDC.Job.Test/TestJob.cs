#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 13:46:40
* 文 件 名：TestJob
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
using HDC.Job.Interface;
using System.Threading;

namespace HDC.Job.Test
{
    public class TestJob : IJob
    {
        System.Timers.Timer _timer;

        public void Start(JobContext context)
        {
            _timer = new System.Timers.Timer(5000);
            _timer.Enabled = true;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }

        void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LoggerFactory.Info("测试程序 Run");
        }


        public void Stop(JobContext context)
        {
            LoggerFactory.Info("测试程序 Stop");
            _timer.Stop();
        }

        public void Continue(JobContext context)
        {
            LoggerFactory.Info("测试程序 Continue");
        }

        public void Pause(JobContext context)
        {
            LoggerFactory.Info("测试程序 Pause");
        }
    }
}
