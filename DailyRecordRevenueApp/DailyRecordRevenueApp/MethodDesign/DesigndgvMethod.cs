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
            // General settings for a modern look
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Columns fit to the container
            dgv.RowHeadersVisible = false;  // Hides row headers for a cleaner appearance
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;  // No header borders

            // Font and styling for rows with centered text
            dgv.DefaultCellStyle.Font = new Font("Roboto", 9);  // Clean, modern font
            dgv.DefaultCellStyle.ForeColor = Color.DarkSlateGray;  // Dark text for a modern tone
            dgv.DefaultCellStyle.BackColor = Color.White;  // White background for cells
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text

            // Styling for headers
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);  // Bold, modern font
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;  // Teal background for headers
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  // White text for contrast
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  // Centered text
            dgv.EnableHeadersVisualStyles = false;  // Ensure custom styles are applied

            // Styling for grid lines and cell borders
            dgv.GridColor = Color.Gray;  // Subtle gray grid lines for a modern look
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;  // Horizontal lines only

            // Row styling and selection with different tone
            dgv.RowTemplate.Height = 28;  // Standard row height for consistency
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 255);  // Light pastel blue for alternating rows
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Highlight entire row
            dgv.MultiSelect = false;  // Restrict to single-row selection
            dgv.ReadOnly = true;  // Make the DataGridView read-only to avoid editing

            // Hover effect for rows
            dgv.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(210, 210, 255);  // Light pastel blue on hover
            };

            dgv.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = (e.RowIndex % 2 == 0) ? Color.White : Color.FromArgb(240, 240, 255);  // Restore original color
            };
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
    }
}
