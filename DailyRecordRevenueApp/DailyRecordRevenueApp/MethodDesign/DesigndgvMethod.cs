using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRecordRevenueApp.MethodDesign
{
    public  static class DesigndgvMethod
    {


        public static void DesignMethod(DataGridView dgv)
        {
            // Set the font and text color
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);  // Modern, clean font
            dgv.DefaultCellStyle.ForeColor = Color.Black;         // Text color

            // Set row styles
            dgv.RowTemplate.Height = 35;                           // Row height
            dgv.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light gray row background
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220); // Alternating row color

            // Set header styles
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(72, 144, 168); // Modern teal for header background
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                // White header text
            dgv.EnableHeadersVisualStyles = false;  // Ensures custom header styles are applied

            // Set gridline style
            dgv.GridColor = Color.Gray;  // Modern gray gridlines

            // Optional: remove gridlines between rows for a cleaner look
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Optional: additional visual enhancements
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Highlight entire row when selected
            dgv.MultiSelect = false;                                     // Single row selection
            dgv.ReadOnly = true;                                         // Prevents editing (optional)
        }

        public static void ApplyModernTone(DataGridView dgv)
        {
            // General grid settings
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Columns adjust to fit
            dgv.RowHeadersVisible = false;  // Hides row headers for a cleaner look
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // No header borders

            // Font and text styling
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Clean, modern font
            dgv.DefaultCellStyle.ForeColor = Color.Black;         // Text color
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light gray background

            // Header styling
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Bold header font
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(72, 144, 168); // Modern teal background
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // White text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centered header text
            dgv.EnableHeadersVisualStyles = false;  // Custom styling enabled

            // Grid line settings
            dgv.GridColor = Color.FromArgb(200, 200, 200);  // Light gray grid lines
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Horizontal grid lines only

            // Row styling
            dgv.RowTemplate.Height = 30;  // Uniform row height
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220); // Alternating row background
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Select entire row
            dgv.MultiSelect = false;  // Single-row selection
            dgv.ReadOnly = true;  // Prevents direct editing

            // Optional: adding row hover effect
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;  // Change color on hover
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ? Color.FromArgb(240, 240, 240) : Color.FromArgb(220, 220, 220); // Restore color on leave
            };
        }

        public static void Modernize(DataGridView dgv)
        {
            // Set general DataGridView settings
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Columns adjust to the width of the grid
            dgv.RowHeadersVisible = false;  // Hide row headers for a cleaner look
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;  // No borders on column headers

            // Font and styling for cells and headers
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);  // Modern and readable font
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray;  // Dark text color for contrast
            dgv.DefaultCellStyle.BackColor = Color.White;  // White background for cell content
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text alignment

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);  // Bolder font for headers
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;  // Pastel blue for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // White text for contrast with pastel headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text alignment for headers

            // Grid lines and cell borders for a cleaner appearance
            dgv.GridColor = Color.LightGray;  // Light gray for subtle grid lines
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;  // Horizontal lines only

            // Set alternating row styles for better readability
            dgv.RowTemplate.Height = 28;  // Consistent row height
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255);  // Light pastel blue for alternating rows

            // Set selection and read-only mode for a clean look
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Highlight the entire row
            dgv.MultiSelect = false;  // Allow only single-row selection
            dgv.ReadOnly = true;  // Make the DataGridView read-only to avoid accidental edits

            // Hover effects for modern interactivity
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 255);  // Light pastel blue on hover
                }
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ?
                        Color.White : Color.FromArgb(235, 245, 255);  // Restore alternating row color
                }
            };
        }


        public static void ApplyModernStyle(DataGridView dgv)
        {
            // General settings for a modern look
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Columns adjust to container width
            dgv.RowHeadersVisible = false;  // Hide row headers for a cleaner look
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;  // No header borders
            dgv.EnableHeadersVisualStyles = false;  // Apply custom styles to headers

            // Font and text alignment for cells
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);  // Modern font
            dgv.DefaultCellStyle.ForeColor = Color.White;  // White text for visibility
            dgv.DefaultCellStyle.BackColor = Color.Black;  // Black background for contrast
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text

            // Styling for column headers
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);  // Bold font for emphasis
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;  // Dark tone for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // White text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text

            // Styling for grid lines and cell borders
            dgv.GridColor = Color.Gray;  // Gray grid lines for subtle separation
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;  // Horizontal cell borders

            // Row height and styling with alternating colors
            dgv.RowTemplate.Height = 28;  // Standard row height for consistency
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;  // Light color for alternating rows

            // Hover effect for rows
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;  // Light gray on hover
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ? Color.Black : Color.White;  // Restore original color
            };

            // Selection mode and other settings
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Select entire row
            dgv.MultiSelect = false;  // Restrict to single-row selection
            dgv.ReadOnly = true;  // Prevent editing in the DataGridView
        }

        public static void ApplyStyle(DataGridView dgv)
        {
            // General appearance
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.GridColor = Color.LightGray;  // Subtle grid lines
            dgv.BorderStyle = BorderStyle.None;  // No outer border for a cleaner look

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Auto-fill columns for a clean appearance
            dgv.RowHeadersVisible = false;  // Hide row headers for a streamlined look
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;  // Simple border for column headers
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;  // Uniform border style

            // Column headers
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;  // Modern shade of blue
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // White text for high contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);  // Slightly larger font
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text for uniformity

            // Row style
            dgv.RowsDefaultCellStyle.BackColor = Color.White;  // Light background
            dgv.RowsDefaultCellStyle.ForeColor = Color.Black;  // Black text for visibility
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);  // Modern font size
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;  // Align left for readability

            // Alternating row style
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);  // Light gray for alternating rows

            // Selection style
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;  // Subtle blue for selection
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;  // Black text for contrast

            // Additional configurations
            dgv.EnableHeadersVisualStyles = false;  // Ensures custom styling
      
            dgv.ReadOnly = true;  // Prevent accidental edits
            dgv.MultiSelect = false;  // Avoid multiple row selections
        }
        public static void ApplyPastelTheme(DataGridView dgv)
        {
            // General settings for a pastel theme
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Columns fit to the container
            dgv.RowHeadersVisible = false;  // Hides row headers for a cleaner appearance
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // No header borders

            // Font and styling for rows
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);  // Modern, clean font
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray;  // Dark text for readability
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);  // Light gray background

            // Styling for headers with pastel colors
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);  // Bold font for headers
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);  // Pastel pink for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;  // Dark text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text
            dgv.EnableHeadersVisualStyles = false;  // Custom styling enabled

            // Grid line settings with pastel tones
            dgv.GridColor = Color.LightGray;  // Subtle gray grid lines for a soft appearance
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Horizontal grid lines only

            // Row styling and selection
            dgv.RowTemplate.Height = 28;  // Standard row height for consistency
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189, 252, 201);  // Pastel mint for alternating rows
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Select entire row
            dgv.MultiSelect = false;  // Single-row selection
            dgv.ReadOnly = true;  // Prevents editing for a cleaner look

            // Optional: Row hover effect with pastel color
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250);  // Pastel lavender on hover
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ? Color.FromArgb(245, 245, 245) : Color.FromArgb(189, 252, 201);  // Restore original color
            };
        }

        public static void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Styling for a more modern look
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.Gainsboro;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Column Header Default Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34); // Dark background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // White text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Modern font for headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Color when a cell is selected
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;





           // dgv.Columns[2].Visible = false;


            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static void ConfigureDgvSummary(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = true;

            // Styling for a lighter, more vibrant look
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray; // Lighter grid lines
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Column Header Default Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue; // Lighter, vibrant background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Modern font for headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Default cell style
            dgv.DefaultCellStyle.BackColor = Color.Azure; // A lighter background for cells
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Dark text for readability
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue; // A vibrant color when a cell is selected
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // Row Headers Visibility
            dgv.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.CellFormatting += Dgv_CellFormatting;
        }

        private static void Dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) 
            {
                var dgv = sender as DataGridView;
                if (dgv is null) return;



                if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() == "Out of Limit")
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 218, 185); // Peach color
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Ensures text is readable
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(173, 216, 230); // LightBlue color
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkSlateGray; // Ensures text is readable
                }

            }
        }


    }
}
