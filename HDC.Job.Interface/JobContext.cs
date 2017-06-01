#region 版   权   信   息
/*********************************************************
* Copyright(c) 2014-2015 西安易流物联科技有限公司, All Rights Reserved.
* 开发人员：[周兆坤]
* 创建时间：2014/9/1 11:27:28
* 文 件 名：JobContext
* 版本：V1.0.0
* 描述说明：
*
* 更改历史==============================================
* 修改者：           时间：               
* 修改说明：
*
* *******************************************************/
#endregion
using System.Collections.Generic;

namespace HDC.Job.Interface
{
    public class JobContext
    {
        public JobContext()
        {
            if (this._Properties == null)
            {
                this._Properties = new Dictionary<string, string>();
            }
        }

        private Dictionary<string, string> _Properties;

        public Dictionary<string, string> Properties
        {
            get { return _Properties; }
            set { _Properties = value; }
        }
    }
}
