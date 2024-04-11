using System;
using System.Data;
using System.IO;
using System.Linq;

public class PTOHistory
{
    public DataTable RetrievePTOHistory(string filePath)
    {
        DataTable dataTable = new DataTable();
        string[] csvLines = File.ReadAllLines(filePath);

        if (csvLines.Length > 0)
        {
            // Use the first line to add columns to DataTable
            string[] columnNames = csvLines[0].Split(',');
            foreach (string columnName in columnNames)
            {
                dataTable.Columns.Add(columnName);
            }

            // Add rows to DataTable
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                dataTable.Rows.Add(rowData);
            }
        }

        return dataTable;
    }

    public string ConstructFilter(string employeeId, string department)
    {
        string empIdFilter = string.Empty;
        string departmentFilter = string.Empty;

        if (!string.IsNullOrEmpty(employeeId) && int.TryParse(employeeId, out _))
        {
            empIdFilter = $"[Employee ID] = {employeeId}";
        }

        if (department != "All")
        {
            departmentFilter = $"[Department] = '{department}'";
        }

        return (!string.IsNullOrEmpty(empIdFilter) && !string.IsNullOrEmpty(departmentFilter)) ? $"{empIdFilter} AND {departmentFilter}" :
               !string.IsNullOrEmpty(empIdFilter) ? empIdFilter :
               !string.IsNullOrEmpty(departmentFilter) ? departmentFilter : string.Empty;
    }
}
public partial class ViewPTOHistoryForm : Form
{
    private readonly PTOHistory ptoHistory = new PTOHistory();

    public ViewPTOHistoryForm()
    {
        InitializeComponent();

        string filePath = @"C:\Users\lastg\OneDrive\Desktop\Concordia\Winter 2024\BTM495\Project Data\PTO_Request_Data.csv";
        ViewPTOHistoryDataGrid.DataSource = ptoHistory.RetrievePTOHistory(filePath);

        string[] departments = { "All", "Sales", "Human Resources", "Customer Service", "Finance", "Operations", "Marketing", "Research and Development", "Technology" };
        cmbDepartment.Items.AddRange(departments);
        cmbDepartment.SelectedIndex = 0; // Select "All" by default to show all records initially
    }

    private void EmpIDFilterbtn_Click(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        string employeeId = EmpIDtxt.Text.Trim();
        string selectedDepartment = cmbDepartment.SelectedItem.ToString();

        string filter = ptoHistory.ConstructFilter(employeeId, selectedDepartment);
        (ViewPTOHistoryDataGrid.DataSource as DataTable).DefaultView.RowFilter = filter;
    }
}

