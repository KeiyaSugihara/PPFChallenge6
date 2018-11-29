using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFChallenge6
{
    class ToDoListClass
    {
        #region Field

        /// <summary>
        /// 期限
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 残り日数
        /// </summary>
        public string LeftDays { get; set; }

        /// <summary>
        /// やること
        /// </summary>
        public string Text { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// コンストラクター
        /// </summary>
        /// <param name="period">期限</param>
        /// <param name="leftDays">残り日数</param>
        /// <param name="text">やること</param>
        public ToDoListClass(string period, string leftDays, string text)
        {
            Period = period;
            LeftDays = leftDays;
            Text = text;
        }

        #endregion
    }
}
