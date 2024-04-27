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
            try
            {
                // Design configurations
                DesigndgvMethod.Modernize(dataGridViewRecord);
                DesigndgvMethod.ConfigureDgvSummary(dgvSummary);

                // Initialize services and set data sources
                _InternalService = new InternalService(new SqlAccessInternal("Data Source=APHIWAT;Initial Catalog=RevenueDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=false"));

                // Load records asynchronously and bind to DataGridView
                var records = await _InternalService.GetRecordsAsync();
                dataGridViewRecord.DataSource = records;

                // Load detail types and set combo box data source
                await LoadDetailTypes();

                // Set up income/expense combo box
                var incomeExpense = new List<string> { "Income", "Expense" };
                comboBoxIncomeExpense.DataSource = incomeExpense;

                // Initial setup for UI components
                InitialSetUp();

                await GetTaskAsync(); // Perform additional asynchronous tasks
            }
            catch (Exception ex)
            {
                // Handle exceptions and provide feedback
                MessageBox.Show($"Error during initialization: {ex.Message}");
            }
        }

        private async Task LoadDetailTypes()
        {
            _detailTypes = await _InternalService.GetAllDetailTypesAsync(); // Get all detail types
            comboBoxDetail.DataSource = _detailTypes.Select(x => x.Detail).ToList(); // Set data source for combo box
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
            try
            {
                var detailType = new DetailTypes
                {
                    Detail = txtdetail.Text,
                    Type = txtTypes.Text,
                    DetailId = 0
                };

                await _InternalService.SaveDetailTypesAsync(detailType); // Save new detail type

                await LoadDetailTypes(); // Refresh detail types
                ClearDetail(); // Clear the input fields
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding detail type: {ex.Message}");
            }

        }

        private void comboBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDetail.SelectedItem == null) return;

            var selectedDetail = _detailTypes.FirstOrDefault(detail => detail.Detail == comboBoxDetail.Text);

            if (selectedDetail != null)
            {
                textBoxDetailRecordId.Text = selectedDetail.DetailId.ToString();
                textBoxTypeRecord.Text = selectedDetail.Type;
            }

        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var record = new ExpenseIncomeRecordAdd
                {
                    DetailId = int.Parse(textBoxDetailRecordId.Text),
                    IsIncomeOrExpense = comboBoxIncomeExpense.Text,
                    Value = decimal.Parse(textBoxValue.Text)
                };

                await _InternalService.SaveRecordAsync(record); // Save the new record

                var updatedRecords = await _InternalService.GetRecordsAsync(); // Get updated records
                dataGridViewRecord.DataSource = updatedRecords; // Update DataGridView
                ClearDetail(); // Clear the fields
                await GetTaskAsync(); // Perform additional async tasks
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
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
                LoadVariables();
            }
            else
            {
                ClearDetail();
            }
        }

        private void LoadVariables()
        {
            {
                _expenseIncomeRecordAdd = new ExpenseIncomeRecordAdd
                {
                    DetailId = int.Parse(textBoxDetailRecordId.Text),
                    IsIncomeOrExpense = comboBoxIncomeExpense.Text,
                    Value = decimal.Parse(textBoxValue.Text),
                };
            }
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
            LoadVariables();

            await _InternalService.UpdateRecordAsync(_Id, _expenseIncomeRecordAdd);

            var result = await _InternalService.GetRecordsAsync(); // Get the latest records
            dataGridViewRecord.DataSource = result; // Update DataGridView
            ClearDetail(); // Clear UI components
            await GetTaskAsync(); // Execute additional async tasks
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_Id != 0) // Ensure valid ID
            {
                await _InternalService.DeleteRecordAsync(_Id);

                var result = await _InternalService.GetRecordsAsync(); // Get updated records
                dataGridViewRecord.DataSource = result; // Update DataGridView
                ClearDetail(); // Clear UI components
                await GetTaskAsync(); // Execute additional async tasks
            }
            else
            {
                // Handle invalid ID scenario
                MessageBox.Show("Invalid record ID. Cannot remove.");
            }

        }

        private async Task GetTaskAsync()
        {
            try
            {
                // Using null-coalescing assignment to ensure initialization of strings
                await GetSummaryAsync();
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

                if (decimal.Parse(currentExpense) >= 300)
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
                    if (decimal.Parse(currentMonthExpense) >= 9000)
                    {
                        MonthlyCurrenttxt.ForeColor = Color.Red;
                        MonthlyCurrenttxt.Text = $" | Monthly Expense: {currentMonthExpense} Baht (Max = 9000 Baht/Month)";
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


        private async Task GetSummaryAsync()
        {
            try
            {
                // Fetch data asynchronously
                var result = await _InternalService.DailyExpenseSummariesAsync(300);

                if (result == null || !result.Any())
                {
                    // If no data, clear data source and set status
                    dgvSummary.DataSource = null;
                    statusLabel.Text = "No data available.";
                    return;
                }

                // Convert to lists to avoid deferred execution
                var withinLimit = result.Where(c => c.ExpenseStatus == "Within Limit").ToList();
                var outOfLimit = result.Where(c => c.ExpenseStatus == "Out of Limit").ToList();

                // Bind data to DataGridView
                dgvSummary.DataSource = result;

                // Set status label with counts
                statusLabel.Text = $"Within Limit: {withinLimit.Count} Times | Out of Limit: {outOfLimit.Count} Times";
            }
            catch (Exception ex)
            {
                // Handle exceptions
                statusLabel.Text = $"Error fetching summary: {ex.Message}";
                // Optionally, log the error for further analysis
            }
        }

    }
}
