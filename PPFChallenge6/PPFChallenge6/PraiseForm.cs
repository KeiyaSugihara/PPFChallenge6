using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPFChallenge6
{
    public partial class PraiseForm : Form
    {

        #region Constructor

        /// <summary>
        /// コンストラクター
        /// </summary>
        public PraiseForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event

        /// <summary>
        /// フォームを閉じる
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CommentLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
