#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 11:44:44
* 文 件 名：JobSettingEntity
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HDC.Job.Container.Entities
{
    [Serializable]
    [XmlRoot("jobSetting")]
    public class JobSettingEntity
    {
        [XmlElement("serviceName")]
        public string ServiceName { get; set; }

        [XmlElement("displayName")]
        public string DisplayName { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("instanceNamespace")]
        public string InstanceNamespace { get; set; }

        [XmlElement("triggers")]
        public List<Trigger> Triggers { get; set; }

        [XmlElement("context")]
        public List<Context> Contexts { get; set; }
    }

    [Serializable]
    public class Context
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }
    }

    public class Trigger
    {
        /// <summary>
        /// 触发器类型 D(每天) W(每周) M(每月) O(一次)
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 时间间隔
        /// </summary>
        [XmlAttribute("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// 明确（type=W 有效）
        /// </summary>
        [XmlAttribute("specific")]
        public int Specific { get; set; }

        /// <summary>
        /// 月范围，以逗号“,”分隔
        /// </summary>
        [XmlAttribute("m_scope")]
        public string M_scope { get; set; }

        /// <summary>
        /// 天范围，以逗号“,”分隔
        /// </summary>
        [XmlAttribute("d_scope")]
        public string D_scope { get; set; }
    }


}
