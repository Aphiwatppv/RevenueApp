using DailyRecordRevenueApp.MethodDesign;
using DataAccess.Services;
using DataAccess.Models;
using DataAccess.SqlAccess;
using Timer = System.Windows.Forms.Timer;
namespace DailyRecordRevenueApp
{
    public partial class Main : Form
    {
        IInternalService _InternalService;

        IEnumerable<DetailTypes> _detailTypes;

        int _Id = 0;

        private Timer timer;

        ExpenseIncomeRecordAdd _expenseIncomeRecordAdd;
        // Drag panel
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Main()
        {
            InitializeComponent();
            InitailSetuptimmer();

            this.panelTop.MouseDown += new MouseEventHandler(Panel_MouseDown);
            this.panelTop.MouseMove += new MouseEventHandler(Panel_MouseMove);
            this.panelTop.MouseUp += new MouseEventHandler(Panel_MouseUp);
        }

        private void InitailSetuptimmer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Interval set to 1 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            labeldatetime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void Main_Load(object sender, EventArgs e)
        {

            DesigndgvMethod.Modernize(dataGridViewRecord);
            _InternalService = new InternalService(new SqlAccessInternal("Data Source=APHIWAT;Initial Catalog=RevenueDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=false"));
            var result = await _InternalService.GetRecordsAsync();
            dataGridViewRecord.DataSource = result;
            _detailTypes = new List<DetailTypes>();
            _detailTypes = await _InternalService.GetAllDetailTypesAsync();
            var detailtypeDetail = from detail in _detailTypes.Select(x => x.Detail)
                                   select detail;
            comboBoxDetail.DataSource = detailtypeDetail.ToList();

            var IncomeExpense = new List<string> { "Income", "Expense" };
            comboBoxIncomeExpense.DataSource = IncomeExpense;
          
            InitialSetUp();
            await GetTaskAsync();
        }


        private void InitialSetUp()
        {
            textBoxAccount.Enabled = false;
            textBoxAccount.Text = "Aphiwat";

            textBoxDetailRecordId.Enabled = false;
            textBoxTypeRecord.Enabled = false;
        }
        private async void buttonAddDetail_Click(object sender, EventArgs e)
        {
            var detailTypes = new DetailTypes
            {
                Detail = txtdetail.Text,
                Type = txtTypes.Text,
                DetailId = 0

            };

            await _InternalService.SaveDetailTypesAsync(detailTypes);

            _detailTypes = new List<DetailTypes>();
            _detailTypes = await _InternalService.GetAllDetailTypesAsync();
            var detailtypeDetail = from detail in _detailTypes.Select(x => x.Detail)
                                   select detail;
            comboBoxDetail.DataSource = detailtypeDetail.ToList();
            ClearDetail();



        }

        private void comboBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = from detail in _detailTypes
                     where detail.Detail == comboBoxDetail.Text
                     select detail.DetailId;


            var TypeDetail = from detail in _detailTypes
                             where detail.Detail == comboBoxDetail.Text
                             select detail.Type;


            var resultId = Id.ToList();
            textBoxDetailRecordId.Text = resultId[0].ToString();
            textBoxTypeRecord.Text = TypeDetail.ToList()[0];

        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var record = new ExpenseIncomeRecordAdd
            {
                DetailId = int.Parse(textBoxDetailRecordId.Text),
                IsIncomeOrExpense = comboBoxIncomeExpense.Text,
                Value = decimal.Parse(textBoxValue.Text)
            };
            await _InternalService.SaveRecordAsync(record);

            var result = await _InternalService.GetRecordsAsync();
            dataGridViewRecord.DataSource = result;
            ClearDetail();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void dataGridViewRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRecord.Rows[e.RowIndex];
                _Id = int.Parse(row.Cells[0].Value.ToString());
                textBoxAccount.Text = row.Cells[1].Value.ToString();
                textBoxDetailRecordId.Text = row.Cells[4].Value.ToString();
                textBoxValue.Text = row.Cells[6].Value.ToString();
                LoadVariabe();
            }
            else
            {
                ClearDetail();
            }
        }

        private void LoadVariabe()
        {
            _expenseIncomeRecordAdd = new ExpenseIncomeRecordAdd
            {
                DetailId = int.Parse(textBoxDetailRecordId.Text),
                IsIncomeOrExpense = comboBoxIncomeExpense.Text,
                Value = decimal.Parse(textBoxValue.Text),
            };
        }

        private void ClearDetail()
        {
            textBoxAccount.Text = "Aphiwat";
            textBoxValue.Text = string.Empty;

            txtdetail.Clear();
            txtTypes.Clear();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadVariabe();
            await _InternalService.UpdateRecordAsync(_Id, _expenseIncomeRecordAdd);

            var result = await _InternalService.GetRecordsAsync();
            dataGridViewRecord.DataSource = result;
            ClearDetail();
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            if(_Id != 0)
            {
                await _InternalService.DeleteRecordAsync(_Id);
                var result = await _InternalService.GetRecordsAsync();
                dataGridViewRecord.DataSource = result;
                ClearDetail();
            }
          
        }

        private async Task GetTaskAsync()
        {
            try
            {
                // Using null-coalescing assignment to ensure initialization of strings
                string currentDay = string.Empty;
                string currentExpense = string.Empty;
                string year = string.Empty;
                string month = string.Empty;
                string currentMonthExpense = string.Empty;

                // Retrieving expenses asynchronously
                var currentDayExpense = await _InternalService.CurrentDayExpenseAsync();
                var monthTotalExpense = await _InternalService.CurrentMonthExpenseAsync();

                // Safely handling null results
                if (currentDayExpense != null)
                {
                    currentDay = currentDayExpense.ExpenseDate.ToShortDateString();
                    currentExpense = currentDayExpense.TotalExpense.ToString(); 

                   
                    if (monthTotalExpense != null)
                    {
                        year = monthTotalExpense.ExpenseYear.ToString();
                        month = monthTotalExpense.ExpenseMonth.ToString();
                        currentMonthExpense = monthTotalExpense.TotalExpense.ToString();
                    }
                }

                if(decimal.Parse(currentExpense) >= 300)
                {
                    DialyCurrentDaytxt.ForeColor = Color.Red;
                    DialyCurrentDaytxt.Text = $"Current Day: {currentDay} | Dialy Expense: {currentExpense} Baht (Max = 300 Baht/Day)";
                }
                else
                {
                    DialyCurrentDaytxt.ForeColor = Color.LightGreen;
                    DialyCurrentDaytxt.Text = $"Current Day: {currentDay} | Dialy Expense: {currentExpense} Baht (Max = 300 Baht/Day)";
                }
            

                if (!string.IsNullOrEmpty(currentMonthExpense))
                {
                    if(decimal.Parse(currentMonthExpense) >= 9000)
                    {
                        MonthlyCurrenttxt.ForeColor = Color.Red;
                        MonthlyCurrenttxt.Text = $" | Monthly Expense: {currentMonthExpense} Baht (Max = 9000 Baht/Month)" ;
                    }
                    else
                    {
                        MonthlyCurrenttxt.ForeColor = Color.LightGreen;
                        MonthlyCurrenttxt.Text = $" | Monthly Expense: {currentMonthExpense} Baht (Max = 9000 Baht/Month)";
                    }
            
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred while retrieving expense data. Please try again.");
            }
        }

    }
}
