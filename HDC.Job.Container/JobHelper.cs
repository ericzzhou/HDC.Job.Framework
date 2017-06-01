#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 11:32:10
* 文 件 名：JobHelper
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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HDC.Job.Container
{
    public class JobHelper
    {
        private static IJob instance;
        private static JobSettingEntity _JobSetting;

        public static JobSettingEntity JobSetting
        {
            get { return JobHelper._JobSetting; }
            set { JobHelper._JobSetting = value; }
        }

        static JobHelper()
        {
            //loading setting entity
            try
            {
                string settingString = LoadSettingConfig();
                _JobSetting = Deserialize<JobSettingEntity>(settingString);
            }
            catch (Exception ex)
            {
                LoggerFactory.Error(ex.Message, ex);
                _JobSetting = new JobSettingEntity();
            }
        }

        private static string LoadSettingConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string appStartupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            xmlDoc.Load(appStartupPath + @"settings.config");//获取配置文件存放的位置

            return xmlDoc.InnerXml;
        }
        private JobHelper() { }

        public static string GetJobName()
        {
            return _JobSetting.ServiceName;
        }

        public static string GetJobDescription()
        {
            return _JobSetting.Description;
        }

        public static string GetJobDisplayName()
        {
            return _JobSetting.DisplayName;
        }

        public static IJob GetJobInstance()
        {
            if (instance == null)
            {
                string instanceNamespace = _JobSetting.InstanceNamespace;
                instance = (IJob)Activator.CreateInstance(Type.GetType(instanceNamespace, false, true)); ;
            }
            return instance;
        }

        public static JobContext GetJobContext()
        {
            JobContext context = new JobContext();
            //context.Properties = new System.Collections.Generic.Dictionary<string,string>();
            if (_JobSetting != null && _JobSetting.Contexts != null && _JobSetting.Contexts.Count > 0)
            {
                foreach (var item in _JobSetting.Contexts)
                {
                    context.Properties.Add(item.Name, item.Value);
                }
            }
            return context;
        }

        /// <summary>
        /// string 序列化为 对象 T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        private static T Deserialize<T>(string str)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(str))
            {
                T t = (T)xmlSer.Deserialize(reader);
                return t;
            }
        }
    }
}
