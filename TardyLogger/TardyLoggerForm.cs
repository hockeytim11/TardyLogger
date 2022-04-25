﻿using CsvHelper;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace HallPass
{
    public partial class TardyLoggerForm : Form
    {

        // Define request parameters.
        String spreadsheetId = ConfigurationManager.AppSettings["sheet"];
        String tab = ConfigurationManager.AppSettings["tab"];
        DataTable studentsData = new DataTable();
        SheetsService service;
        Font font;
        Font font2;
        PrinterSettings printSettings;
        public TardyLoggerForm()
        {
            InitializeComponent();
        }
        private void HallPassForm_Load(object sender, EventArgs e)
        {

            font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            font2 = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            studentsData.Columns.Add("studentNumber", typeof(string));
            studentsData.Columns.Add("lastName", typeof(string));
            studentsData.Columns.Add("firstName", typeof(string));
            studentsData.Columns.Add("grade", typeof(string));
            studentsData.Columns.Add("homeroomTeacher", typeof(string));

            using (var reader = new StreamReader("students.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                foreach (Student student in csv.GetRecords<Student>())
                {
                    studentsData.Rows.Add(student.toRow());
                    if (!gradeSelect.Items.Contains(student.grade))
                    {
                        gradeSelect.Items.Add(student.grade);
                    }
                    if (!homeroom.Items.Contains(student.homeroomTeacher))
                    {
                        homeroom.Items.Add(student.homeroomTeacher);
                    }
                }
            }
            studentsSearch.DataSource = studentsData;

            UserCredential credential;

            // The file token.json stores the user's access and refresh tokens, and is created
            // automatically when the authorization flow completes for the first time.
            string credPath = "token.json";
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromFile("credentials.json").Secrets,
                new string[]{"https://www.googleapis.com/auth/spreadsheets" },
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;
            Console.WriteLine("Credential file saved to: " + credPath);
            // Create Google Sheets API service.
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Hall Pass",
            });

        }

        String content = "";
        String content2 = "";
        private void PrintButton_Click(object sender, EventArgs e)
        {


            var type = morningRadio.Checked ? "Morning Tardy" : "Passing Period Tardy";
            var time = DateTime.Now;
            printLog.Items.Clear();

            foreach (DataGridViewRow student in studentsSearch.SelectedRows) {
                string id = (string)student.Cells[0].Value;
                string name = (string)student.Cells[2].Value + " " + (string)student.Cells[1].Value;
                string grade = (string)student.Cells[3].Value;
                string homeroom = (string)student.Cells[4].Value;

                content = $@"
STUDENT:
{name}
";
                content2 = $@"
DATE/TIME:
{time.ToString("MMMM d, yyyy\nhh:mm tt")}

PASS TYPE:
{type}
";

                printLog.Items.Add($"STUDENT: {name} ID: {id} TIME: {time}");
                PrintDocument doc = new PrintDocument();
                doc.DocumentName = $"Tardy Pass for {name}";

                if (printSettings == null) {
                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)
                        printSettings = printDialog.PrinterSettings;
                }

                if (printSettings!=null) {
                    doc.QueryPageSettings += Doc_QueryPageSettings;
                    doc.PrinterSettings = printSettings;
                    doc.PrintPage += new PrintPageEventHandler(passPrint);
                    doc.Print();
                
                    var range = new ValueRange()
                    {
                        Values = new List<IList<object>> { new List<object> {
                        time.ToString(), type, id, name, grade, homeroom
                    } } };
                    var append = service.Spreadsheets.Values.Append(range, spreadsheetId, tab+"!A:A");
                    append.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                    var resp = append.Execute();
                }
            }
        }

        private void Doc_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Margins.Top = 0;
            e.PageSettings.Margins.Bottom = 0;
            e.PageSettings.Margins.Left = 0;
            e.PageSettings.Margins.Right = 0;
        }

        private void updateFilter() {
            string queries = "";
            if (!String.IsNullOrEmpty(studentId.Text)) {
                queries = $"studentNumber LIKE '%{studentId.Text}'";
            } else {
                if (!String.IsNullOrEmpty(nameSearch.Text))
                {
                    string[] parts = nameSearch.Text.Split(',');
                    string lastQuery = parts[0];
                    string firstQuery = parts.Length > 1 ? parts[1] : "";
                    queries += $"(firstName LIKE '%{firstQuery}%' AND lastName LIKE '%{lastQuery}%')";
                }
                if (gradeSelect.SelectedItem != null && gradeSelect.SelectedItem != "-ALL-")
                {
                    if (queries.Length > 0) queries += " AND ";
                    queries += $"grade = '{gradeSelect.SelectedItem}'";
                }
                if (homeroom.SelectedItem != null && homeroom.SelectedItem != "-ALL-")
                {
                    if (queries.Length > 0) queries += " AND ";
                    queries += $"homeroomTeacher = '{homeroom.SelectedItem}'";
                }
            }
            studentsData.DefaultView.RowFilter = queries;
        }

        private void studentId_TextChanged(object sender, EventArgs e)
        {
            updateFilter();
        }

        private void nameSearch_TextChanged(object sender, EventArgs e)
        {
            updateFilter(); 
        }

        private void gradeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFilter();
        }

        private void homeroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFilter();
        }

        private void passPrint(object sender, PrintPageEventArgs ev)
        {
            var fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;

            ev.Graphics.DrawImage(Image.FromFile("HEADER.png"), new Rectangle(new Point(0,0), new Size(280,140)));
            ev.Graphics.DrawString(content, font, Brushes.Black, new Point(140, 150), fmt);
            ev.Graphics.DrawString(content2, font2, Brushes.Black, new Point(140, 230), fmt);
            ev.Graphics.DrawImage(Image.FromFile("FOOTER.png"), new Rectangle(new Point(0, 390), new Size(280, 140)));
        }

        private void labelPreview_Click(object sender, EventArgs e)
        {

        }

    }
}