using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPFChallenge6
{
    public partial class MaineForm : Form
    {

        #region Field

        /// <summary>
        /// やることデータリスト
        /// </summary>
        List<ToDoListClass> ToDoListes = new List<ToDoListClass>();

        /// <summary>
        /// CSVファイルパス
        /// </summary>
        const string Path = @"C:..\..\Resources\ToDoData.csv";

        /// <summary>
        /// リストカウント
        /// </summary>
        private int ListCount;

        /// <summary>
        /// 選択行番号
        /// </summary>
        private int SelectIndex = -1;

        #endregion

        #region Constructor

        /// <summary>
        /// コンストラクター
        /// </summary>
        public MaineForm()
        {
            InitializeComponent();
            ToDoData();
        }

        #endregion

        #region Event

        /// <summary>
        /// 褒めるフォーム表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PraiseButton_Click(object sender, EventArgs e)
        {
            if (SelectIndex != -1)
            {
                RowDelete();
                PraiseForm praise = new PraiseForm();
                praise.Show();
            }
            else
            {
                MessageBox.Show("選択してください。");
            }
        }

        /// <summary>
        /// お叱りフォーム表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PunishmentButton_Click(object sender, EventArgs e)
        {
            if (SelectIndex != -1)
            {
                RowDelete();
                PunishmentForm punishment = new PunishmentForm();
                punishment.Show();
            }
            else
            {
                MessageBox.Show("選択してください。");
            }
        }

        /// <summary>
        /// やること追加フォーム表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            SentenceForm sentence = new SentenceForm();
            sentence.FormClosed += new FormClosedEventHandler(Sentence_FormClosed);
            sentence.Show();
        }

        /// <summary>
        /// やることフォームが閉じたイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Sentence_FormClosed(object sender, EventArgs e)
        {
            SentenceForm sentence = (SentenceForm)sender;
            SetPeriod = sentence.SetPeriod.ToShortDateString();
            TimeSpan span = new DateTime(sentence.SetPeriod.Year, sentence.SetPeriod.Month, sentence.SetPeriod.Day) -
                            new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            SetLeftDays = span.Days.ToString();
            SetText = sentence.SetText;
            SetDataGridView(SetPeriod, SetLeftDays, SetText);
            ToDoDataGridView.Refresh();
        }

        /// <summary>
        /// やること編集フォーム表示
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectIndex != -1)
            {
                SentenceForm sentence = new SentenceForm();
                sentence.FormClosed += new FormClosedEventHandler(Sentence_FormClosed);
                sentence.SetText = ToDoDataGridView.Rows[SelectIndex].Cells[3].Value.ToString();
                RowDelete();
                sentence.Show();
                ToDoDataGridView.Refresh();
            }
            else if (SelectIndex != -1)
            {
                MessageBox.Show("選択してください。");
            }
            else
            {
                MessageBox.Show("複数編集はできません。");
            }
        }

        /// <summary>
        /// アプリ終了
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// データを挿入
        /// </summary>
        /// <param name="period">期限</param>
        /// <param name="remaining">残り日数</param>
        /// <param name="text">やること</param>
        public void SetDataGridView(string period, string remaining, String text)
        {
            ToDoDataGridView.Rows.Add(false, period, remaining, text);
        }

        /// <summary>
        ///ファイルからデータを読み込みインスタンスに
        /// </summary>
        private void ToDoData()
        {
            StreamReader sr = new StreamReader(Path, Encoding.GetEncoding("UTF-8"));
            string stResult = string.Empty;
            while (sr.Peek() >= 0)
            {
                string stBuffer = sr.ReadLine();
                stResult += stBuffer + Environment.NewLine;
            }
            sr.Close();
            string[] del = { "\r\n" };
            // 段らく区切りで分割して配列に格納する
            string[] ListData = stResult.Split(del, StringSplitOptions.None);
            ListCount = ListData.Length;
            string toDoConfiguration;
            string[] eachToDo;
            for (int i = 0; i < ListCount - 1; i++)
            {
                toDoConfiguration = ListData[i];
                eachToDo = toDoConfiguration.Split(',');
                ToDoListes.Add(new ToDoListClass(eachToDo[0], eachToDo[1], eachToDo[2]));
            }
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Maine_Load(object sender, EventArgs e)
        {
            if (ToDoListes.Count > 0)
            {
                for (int i = 0; i < ToDoListes.Count; i++)
                {
                    SetDataGridView(ToDoListes[i].Period, ToDoListes[i].LeftDays, ToDoListes[i].Text);
                }
            }
        }

        /// <summary>
        /// データをCSVファイルに保存
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Path, false, Encoding.UTF8);
                for (int row = 0; row < ToDoDataGridView.RowCount; row++)
                {
                    for (int colum = 1; colum < ToDoDataGridView.ColumnCount; colum++)
                    {
                        string field = ToDoDataGridView.Rows[row].Cells[colum].Value.ToString();
                        writer.Write(field);
                        if (ToDoDataGridView.ColumnCount - 1 > colum)
                        {
                            writer.Write(',');
                        }
                        else if (ToDoDataGridView.ColumnCount - 1 == colum)
                        {
                            writer.Write("\r\n");
                        }
                    }
                }
                writer.Close();
            }
            catch
            {
                MessageBox.Show("保存に失敗しました。");
            }
        }

        /// <summary>
        /// データの削除
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RowDelete();
        }

        /// <summary>
        /// セルの値変更イベント
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ToDoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 選択列の場合
                if (e.ColumnIndex == 0)
                {
                    // 今回チェック設定した
                    if ((bool)ToDoDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                    {
                        // 他にチェックされている項目がある場合はそのチェックを解除
                        for (int rowIndex = 0; rowIndex < ToDoDataGridView.Rows.Count; rowIndex++)
                        {
                            if ((rowIndex != e.RowIndex) && ((bool)ToDoDataGridView[0, rowIndex].Value == true))
                            {
                                // チェックを解除
                                ToDoDataGridView[0, rowIndex].Value = false;
                                // ReadOnlyを解除
                                ToDoDataGridView[0, rowIndex].ReadOnly = false;
                            }
                        }
                        // 今回チェックした場所をReadOnlyに設定
                        ToDoDataGridView[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                        SelectIndex = e.RowIndex;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// セル値変更イベントにコミット
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ToDoDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            ToDoDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion

        #region Property

        /// <summary>
        /// 選択期限
        /// </summary>
        public string SetPeriod { get; set; }

        /// <summary>
        /// 作成テキスト
        /// </summary>
        public String SetText { get; set; }


        /// <summary>
        /// 作成テキスト
        /// </summary>
        public String SetLeftDays { get; set; }

        /// <summary>
        /// 編集テキスト
        /// </summary>
        public string EditText { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// 行削除関数
        /// </summary>
        public void RowDelete()
        {
            if (SelectIndex != -1)
            {
                ToDoDataGridView.Rows.RemoveAt(SelectIndex);
            }
            SelectIndex = -1;
        }

        #endregion

    }
}
