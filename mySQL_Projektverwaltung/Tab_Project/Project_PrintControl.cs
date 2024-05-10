using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Runtime.CompilerServices;


namespace mySQL_Projektverwaltung
{


    public partial class Project_PrintControl : UserControl
    {
        public Main main;
        public Project_PrintControl(Main main2)
        {
            main = main2; //sets Parent
            InitializeComponent();



            main.CreateDocument();


            //.GeneratePdf("hello.pdf"); 
        }
        int projID = 0;
        public void button1_Click(object sender, EventArgs e)
        {
        }






        public void ReLoad_Project_PrintControl(int projId)
        {
            projID = projId;
        }
    }
    
    public partial class Main
    {
        public void CreateDocument()
        {
            DataTable MakeNamesTable()
            {
                // Create a new DataTable titled 'Names.'
                DataTable namesTable = new DataTable("Names");

                // Add three column objects to the table.
                DataColumn idColumn = new DataColumn();
                idColumn.DataType = System.Type.GetType("System.Int32");
                idColumn.ColumnName = "id";
                idColumn.AutoIncrement = true;
                namesTable.Columns.Add(idColumn);

                DataColumn fNameColumn = new DataColumn();
                fNameColumn.DataType = System.Type.GetType("System.String");
                fNameColumn.ColumnName = "Fname";
                fNameColumn.DefaultValue = "Fname";
                namesTable.Columns.Add(fNameColumn);

                DataColumn lNameColumn = new DataColumn();
                lNameColumn.DataType = System.Type.GetType("System.String");
                lNameColumn.ColumnName = "LName";
                namesTable.Columns.Add(lNameColumn);

                // Create an array for DataColumn objects.
                DataColumn[] keys = new DataColumn[1];
                keys[0] = idColumn;
                namesTable.PrimaryKey = keys;

                // Return the new DataTable.
                return namesTable;
            }
            bool test = true;
            DataTable dt = MakeNamesTable(); ;
            int i = 0;
            while (i < 10)
            {
                DataRow dr = dt.NewRow();
                dr["fName"] = Placeholders.Label();
                dr["lName"] = Placeholders.Name();
                dt.Rows.Add(dr);
                i++;
            }

            string a = "a1";
            string b = "b1";
            string c = "c1";



            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Column(row =>
                        {
                            row.Item().ShowOnce().Text("Hello PDF!")
                            .SemiBold().FontSize(36).FontColor(Colors.LightGreen.Medium);
                            row.Item().SkipOnce().Text("Hallo")
                            .SemiBold().FontSize(36).FontColor(Colors.LightGreen.Medium).AlignCenter();
                        });



                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)

                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(Placeholders.LoremIpsum());
                            x.Item().ShowIf(test).Image(Placeholders.Image(200, 50));
                            x.Item().Text(Placeholders.Label()).AlignCenter().Underline().Overline();
                            x.Spacing(5, Unit.Millimetre);
                            x.Item().Table(x =>
                            {
                                x.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn();
                                }
                                );

                                foreach (DataRow row in dt.Rows)
                                {
                                    x.Cell().ShowOnce().Text(a);
                                    x.Cell().ShowOnce().Text(b);
                                    x.Cell().ShowOnce().Text(c);
                                    x.Cell().Text("3");
                                    x.Cell().BorderVertical(1).Text(row["lname"].ToString()).ClampLines(1);
                                    x.Cell().Text(Placeholders.Integer());
                                }
                            });
                            x.Item().Text("Tester").AlignCenter();
                        });



                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            }).ShowInPreviewer();//.GeneratePdfAndShow();//
            /**/
        }
    }
}
