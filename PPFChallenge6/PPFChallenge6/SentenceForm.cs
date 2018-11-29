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
    public partial class SentenceForm : Form
    {

        #region Field

        /// <summary>
        /// 選択期限
        /// </summary>
        public DateTime SetPeriod { get; set; }

        /// <summary>
        /// 作成テキスト
        /// </summary>
        public String SetText { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// コンストラクター
        /// </summary>
        public SentenceForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event

        /// <summary>
        ///　設定内容を登録し、フォームを閉じる
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SetButton_Click(object sender, EventArgs e)
        {
            SetPeriod = SetDateTimePicker.Value;
            SetText = SetTextBox.Text;
            Close();
        }

        /// <summary>
        /// 登録ボタンイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SetTextBox.Text.Length > 0)
            {
                SetButton.Enabled = true;
            }
            else
            {
                SetButton.Enabled = false;
            }
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SentenceForm_Load(object sender, EventArgs e)
        {
            SetTextBox.Text = SetText;
        }

        #endregion

    }
}
