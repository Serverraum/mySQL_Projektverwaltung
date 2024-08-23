using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
//using QuestPDF.Drawing;
using QuestPDF.Fluent;
//using QuestPDF.Previewer;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using System.Xml.Linq;
//using System.Runtime.CompilerServices;
//using static QuestPDF.Helpers.Colors
using HTMLQuestPDF.Extensions;
using RtfPipe;
using System.Text;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ZstdSharp.Unsafe;
using static mySQL_Projektverwaltung.Project_PrintControl;

namespace mySQL_Projektverwaltung
{


    public partial class Project_PrintControl : UserControl
    {
        public Project_PrintControl()
        {
            InitializeComponent();
            //main.CreateDocument(projID);

            //.GeneratePdf("hello.pdf"); 
        }
        int projID = 0;
        public void button1_Click(object sender, EventArgs e)
        {


            OnCreateDocument(projID);


        }
        public event EventHandler<ProjIdEventArgs> CreateDocumentProj;

        private void OnCreateDocument(int projID)
        {
            CreateDocumentProj?.Invoke(this, new ProjIdEventArgs(projID));
        }






        public void ReLoad_Project_PrintControl(int projId)
        {
            projID = projId;
        }
    }
    public class ProjIdEventArgs : EventArgs
    {
        public int projID { get; }

        public ProjIdEventArgs(int ProjID)
        {
            projID = ProjID;
        }
    }

    public partial class Main : Form
    {
        private void Project_PrintControl1_CreateDocumentProj(object sender, ProjIdEventArgs e)
        {
            projID = e.projID;
            //Get ProjTime
            string sql = "SELECT * FROM projTime WHERE projID = @projID";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
            DataTable dthour = DbConnParam.DbConn.Instance.DbGetDataTable();

            //Get Proj
            sql = "SELECT * FROM proj WHERE projID = @projID";
            DbConnParam.DbConn.Instance.DbAddCmd(sql);
            DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
            DataTable dtproj = DbConnParam.DbConn.Instance.DbGetDataTable();
            DataRow drproj;
            string ls;
            string ag;
            string datestr;

            string html = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n</head>\r\n<body>\r\n    <div class=\"reader-container container container_center\">\r\n        <div class=\"article-image\">\r\n            <a href=\"https://www.pexels.com/ru-ru/photo/7961265/\">\r\n                <img src=\"https://images.pexels.com/photos/7961265/pexels-photo-7961265.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1\" />\r\n            </a>\r\n        </div>\r\n        <p>Lorem</p>\r\n        <h1>h1</h1>\r\n        <h2><s>h2</s></h2>\r\n        <h3>h3</h3>\r\n        <h4>h4</h4>\r\n        <h5>h5</h5>\r\n        <br />\r\n        <br />\r\n        <h6>h6</h6>\r\n        <p>\r\n            <s>Lorem &nbsp;&nbsp;ipsum</s> dolor <br />\r\n            sit, <b>amet</b> consectetur <strike>adipisicing</strike> elit. Illo\r\n            aperiam perferendis soluta nam <small>ducimus</small> ipsa <br />\r\n            alias animi asperiores quisquam aut ex minus, cum\r\n            <u>possimus</u> accusamus corporis\r\n            <a href=\"https://www.google.com/\">Test link</a> consequatur\r\n            <i>ipsam</i> praesentium.\r\n        </p>\r\n        <table class=\"tg\">\r\n            <thead>\r\n                <tr>\r\n                    <td class=\"tg-0lax\" rowspan=\"3\">1</td>\r\n                    <td class=\"tg-0lax\">2</td>\r\n                    <td class=\"tg-0lax\">3</td>\r\n                    <td class=\"tg-0lax\">4</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"tg-0lax\" rowspan=\"2\">5</td>\r\n                    <td class=\"tg-0lax\" colspan=\"2\">6</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"tg-0lax\">7</td>\r\n                    <td class=\"tg-0lax\">8</td>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n        <br />\r\n        <table>\r\n            <tr>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Email Address</th>\r\n            </tr>\r\n            <tr>\r\n                <td>Hillary</td>\r\n                <td>Nyakundi</td>\r\n                <td>tables@mail.com</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Lary</td>\r\n                <td>Mak</td>\r\n                <td>developer@mail.com</td>\r\n            </tr>\r\n        </table>\r\n\r\n        <ul>\r\n            <li>\r\n                <p>\r\n                    <s>Lorem &nbsp;&nbsp;ipsum</s> dolor <br />\r\n                    sit, <b>amet</b> consectetur <strike>adipisicing</strike> elit. Illo\r\n                    aperiam perferendis soluta nam <small>ducimus</small> ipsa <br />\r\n                    alias animi asperiores quisquam aut ex minus, cum\r\n                    <u>possimus</u> accusamus corporis\r\n                    <a href=\"https://www.google.com/\">Test link</a> consequatur\r\n                    <i>ipsam</i> praesentium.\r\n                </p>\r\n            </li>\r\n            lorem\r\n            <li>\r\n                Lorem ipsum dolor sit amet consectetur adipisicing elit. Ullam\r\n                voluptates dignissimos, praesentium non necessitatibus reiciendis\r\n                nihil repudiandae quibusdam deleniti, placeat accusantium impedit\r\n                aperiam laborum. Cupiditate sed repellendus eos quam harum.\r\n                <ol>\r\n                    <li>Option 1</li>\r\n                    <li>Option 2</li>\r\n                </ol>\r\n            </li>\r\n        </ul>\r\n\r\n        <p>\r\n            Лорем ипсум долор сит амет, хинц феугаит албуциус не пер, вис еу темпор\r\n            номинати маиестатис. Еу ерос оптион яуи. Ерат миним ехерци хас еа, нец\r\n            легимус детерруиссет ат. Еирмод тхеопхрастус те хис, еи яуо видит аугуе,\r\n            дицтас цонсецтетуер при ад. Бруте сенсибус вис ат, нам путант форенсибус\r\n            ид, мел еа порро толлит перфецто. Яуот цлита ут нец. Ан иус алиа\r\n            цонсецтетуер, те хис тале неморе. Цу сусципит апеириан торяуатос цум.\r\n            Яуи ут адхуц аппареат цомпрехенсам, граецис еррорибус еи вел.\r\n        </p>\r\n\r\n        <p>—————————————————————</p>\r\n        <br />\r\n        <p>● Lorem ipsum dolor sit amet</p>\r\n        <p>● Lorem ipsum dolor sit amet</p>\r\n        <p>Lorem ipsum dolor sit amet. 😊</p>\r\n    </div>\r\n</body>\r\n</html>";
            string html2 = "<!DOCTYPE html>\r\n<html lang=\"de\">\r\n  <head>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Titel der Seite | Name der Website</title>\r\n  </head>\r\n  <body>\r\n    <!-- Sichtbarer Dokumentinhalt im body -->\r\n    <p>Sehen Sie sich den Quellcode dieser Seite an.\r\n      <kbd>(Kontextmenu: Seitenquelltext anzeigen)</kbd></p>\r\n  </body>\r\n</html>"; // "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n</head>\r\n<body>\r\n    <div class=\"reader-container container container_center\\\">\\r\\n        <div class=\\\"article-image\\\">\\r\\n            <a href=\\\"https://www.pexels.com/ru-ru/photo/7961265/\\\">\\r\\n                <img src=\\\"https://images.pexels.com/photos/7961265/pexels-photo-7961265.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1\\\" />\\r\\n            </a>\\r\\n        </div>\\r\\n        <p>Lorem</p>\\r\\n        <h1>h1</h1>\\r\\n        <h2><s>h2</s></h2>\\r\\n        <h3>h3</h3>\\r\\n        <h4>h4</h4>\\r\\n        <h5>h5</h5>\\r\\n        <br />\\r\\n        <br />\\r\\n        <h6>h6</h6>\\r\\n        <p>\\r\\n            <s>Lorem &nbsp;&nbsp;ipsum</s> dolor <br />\\r\\n            sit, <b>amet</b> consectetur <strike>adipisicing</strike> elit. Illo\\r\\n            aperiam perferendis soluta nam <small>ducimus</small> ipsa <br />\\r\\n            alias animi asperiores quisquam aut ex minus, cum\\r\\n            <u>possimus</u> accusamus corporis\\r\\n            <a href=\\\"https://www.google.com/\\\">Test link</a> consequatur\\r\\n            <i>ipsam</i> praesentium.\\r\\n        </p>\\r\\n        <table class=\\\"tg\\\">\\r\\n            <thead>\\r\\n                <tr>\\r\\n                    <td class=\\\"tg-0lax\\\" rowspan=\\\"3\\\">1</td>\\r\\n                    <td class=\\\"tg-0lax\\\">2</td>\\r\\n                    <td class=\\\"tg-0lax\\\">3</td>\\r\\n                    <td class=\\\"tg-0lax\\\">4</td>\\r\\n                </tr>\\r\\n                <tr>\\r\\n                    <td class=\\\"tg-0lax\\\" rowspan=\\\"2\\\">5</td>\\r\\n                    <td class=\\\"tg-0lax\\\" colspan=\\\"2\\\">6</td>\\r\\n                </tr>\\r\\n                <tr>\\r\\n                    <td class=\\\"tg-0lax\\\">7</td>\\r\\n                    <td class=\\\"tg-0lax\\\">8</td>\\r\\n                </tr>\\r\\n            </thead>\\r\\n        </table>\\r\\n        <br />\\r\\n        <table>\\r\\n            <tr>\\r\\n                <th>First Name</th>\\r\\n                <th>Last Name</th>\\r\\n                <th>Email Address</th>\\r\\n            </tr>\\r\\n            <tr>\\r\\n                <td>Hillary</td>\\r\\n                <td>Nyakundi</td>\\r\\n                <td>tables@mail.com</td>\\r\\n            </tr>\\r\\n            <tr>\\r\\n                <td>Lary</td>\\r\\n                <td>Mak</td>\\r\\n                <td>developer@mail.com</td>\\r\\n            </tr>\\r\\n        </table>\\r\\n\\r\\n        <ul>\\r\\n            <li>\\r\\n                <p>\\r\\n                    <s>Lorem &nbsp;&nbsp;ipsum</s> dolor <br />\\r\\n                    sit, <b>amet</b> consectetur <strike>adipisicing</strike> elit. Illo\\r\\n                    aperiam perferendis soluta nam <small>ducimus</small> ipsa <br />\\r\\n                    alias animi asperiores quisquam aut ex minus, cum\\r\\n                    <u>possimus</u> accusamus corporis\\r\\n                    <a href=\\\"https://www.google.com/\\\">Test link</a> consequatur\\r\\n                    <i>ipsam</i> praesentium.\\r\\n                </p>\\r\\n            </li>\\r\\n            lorem\\r\\n            <li>\\r\\n                Lorem ipsum dolor sit amet consectetur adipisicing elit. Ullam\\r\\n                voluptates dignissimos, praesentium non necessitatibus reiciendis\\r\\n                nihil repudiandae quibusdam deleniti, placeat accusantium impedit\\r\\n                aperiam laborum. Cupiditate sed repellendus eos quam harum.\\r\\n                <ol>\\r\\n                    <li>Option 1</li>\\r\\n                    <li>Option 2</li>\\r\\n                </ol>\\r\\n            </li>\\r\\n        </ul> <p>\r\n  \r\n<p>—————————————————————</p>\r\n        <br />\r\n    <p>Lorem ipsum dolor sit amet. 😊</p> </div>\r\n</body>\r\n</html>";


#if NETCORE
            // Add a reference to the NuGet package System.Text.Encoding.CodePages for .Net core only
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#elif NET
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif




            try
            {
                drproj = dtproj.Rows[0];


                //Get LS
                sql = "SELECT ls FROM ls WHERE LSID = @LSID";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@LSID", drproj["lsid"]);
                ls = DbConnParam.DbConn.Instance.DbScalar().ToString();
                //Get AG
                sql = "SELECT ag FROM ag WHERE AGID = @AGID";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DbConnParam.DbConn.Instance.CmdAddParam("@AGID", drproj["agid"]);
                ag = DbConnParam.DbConn.Instance.DbScalar().ToString();

                DateTime date;
                DateTime.TryParse(drproj["date"].ToString(), out date);
                datestr = date.ToShortDateString();

            }
            catch (IndexOutOfRangeException)
            {
                drproj = dtproj.NewRow();
                drproj.BeginEdit();
                ls = "";
                ag = "";
                datestr = "";
            }

            QuestPDF.Fluent.Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.DefaultTextStyle(x => x.FontSize(12));


                    page.Header()
                        .Column(row =>
                        {
                            row.Item().ShowOnce().Table(x =>
                            {
                                x.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(44, Unit.Millimetre);//1750, Unit.Mil);//44, Unit.Millimetre);
                                    columns.RelativeColumn();
                                });
                                x.Cell()./*Border(1, Unit.Mil).*/PaddingRight(1, Unit.Millimetre).MaxHeight(20, Unit.Millimetre).Image(Properties.Resources.Logo_fGn).FitHeight();//GetLogo("LMU_Logo_RGB_FlaechigGruen.png"));//Placeholders.Image(300, 200));
                                //x.Cell()./*Border(1, Unit.Mil).PaddingRight(2, Unit.Millimetre).*/MaxHeight(20, Unit.Millimetre).Image(Placeholders.Image(574, 242));
                                x.Cell().Background(QuestPDF.Infrastructure.Color.FromHex("F5F5F5")).Border(1, Unit.Mil).PaddingLeft(5, Unit.Millimetre).AlignMiddle().Text("Ludwig-Maximilians-Universität\r\nElektroniklabor").LineHeight(2).FontColor(QuestPDF.Infrastructure.Color.FromHex("626468")).AlignLeft();//Colors.Grey.Darken2).AlignLeft();

                            });
                            //row.Item().ShowOnce().Text("Hello PDF!")
                            //.SemiBold().FontSize(36).FontColor(Colors.LightGreen.Medium);

                        });



                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)

                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(drproj["desc_short"].ToString()).AlignCenter().Underline().Overline().FontSize(14);
                            x.Spacing(5, Unit.Millimetre);
                            x.Item().Table(x =>
                                {
                                    //x.Header();
                                    x.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(1);
                                        columns.RelativeColumn(1);
                                        columns.RelativeColumn(2);
                                    });
                                    x.Cell().Text("Lehrstuhl: ");
                                    x.Cell().Text(ls);
                                    //x.Cell().RowSpan(5).Text(drproj["desc_long"].ToString()); //String-Only
                                    //x.Cell().RowSpan(5).HTML(handler => { handler.SetHtml(Rtf.ToHtml(drproj["desc_long"].ToString())); });// HTML-Inline


                                    /*********************************************/
                                    /* --- --- --- ADD SOME PICTURES --- --- --- */
                                    /*********************************************/
                                    ///Check here for Error.
                                    ///
                                    /// Falls die Bilder größer als der vorhandene Platz sind, stürzt das Programm ab.
                                    ///
                                    ///
                                    string sql = "SELECT * FROM pictures WHERE projID=@projID ";
                                    DbConnParam.DbConn.Instance.DbAddCmd(sql);
                                    DbConnParam.DbConn.Instance.CmdAddParam("@projID", projID);
                                    DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();
                                    int index = 0;
                                    List<byte[]> Pictures = new List<byte[]>();
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        //Stream str = (Stream)dr[2];
                                        Pictures.Insert(index, (byte[])dr[2]);
                                        index++;
                                    }

                                    if (index == 1)
                                    {
                                        x.Cell().RowSpan(6).Image(QuestPDF.Infrastructure.Image.FromBinaryData(Pictures[0])).FitArea();
                                    }
                                    else if (index > 1)
                                    {

                                        x.Cell().RowSpan(6).Table(x =>
                                        {
                                            x.ColumnsDefinition(col =>
                                            {
                                                col.RelativeColumn();
                                                col.RelativeColumn();
                                                if (index > 4) { col.RelativeColumn(); }
                                            });
                                            int i = 0;
                                            foreach (byte[] b in Pictures)
                                            {
                                                i++;
                                                //x.Cell().Image(QuestPDF.Infrastructure.Image.FromBinaryData(b)).FitArea();
                                                if (i < 10) { x.Cell().Image(b).FitArea().WithCompressionQuality(ImageCompressionQuality.Medium); }
                                            }

                                        });

                                    }
                                    /************************************************/
                                    /* --- --- - End ADD SOME PICTURES_V1 - --- --- */
                                    /************************************************/

                                    x.Cell().Text("Arbeitsgruppe: ");
                                    x.Cell().Text(ag);
                                    x.Cell().Text("Name: ");
                                    x.Cell().Text(drproj["name"].ToString());
                                    x.Cell().Text("Telefon: ");
                                    x.Cell().Text(drproj["tel"].ToString());
                                    x.Cell().Text("eMail: ");
                                    x.Cell().Text(drproj["email"].ToString());
                                    x.Cell().Text("Datum: ");
                                    x.Cell().Text(datestr);


                                });

                            
                            x.Item().EnsureSpace(600).Text("Beschreibung").AlignCenter().Underline().Overline().FontSize(14);
                            x.Item().HTML(handler => { try { handler.SetHtml(Rtf.ToHtml(drproj["desc_long"].ToString())); } catch (Exception e) { MessageBox.Show(e.Message); } });
                            x.Spacing(5, Unit.Millimetre);
                            x.Item().Table(x => //Add ProjTime to PDF 
                            {
                                x.ColumnsDefinition(columns =>
                                {

                                    columns.ConstantColumn(30, Unit.Millimetre);
                                    columns.RelativeColumn(8);
                                    columns.ConstantColumn(15, Unit.Millimetre);
                                });
                                x.Header(x =>
                                {
                                    x.Cell().BorderBottom(1).AlignBottom().Text("Datum").AlignCenter();
                                    x.Cell().BorderBottom(1).BorderVertical(1).AlignBottom().Text("Beschreibung").AlignCenter();
                                    x.Cell().BorderBottom(1).Text("Zeit\r\nin h").AlignCenter();
                                });

                                if (dthour.Rows.Count < 1) //If projtime empty
                                {
                                    x.Cell().Text("_").FontColor(Colors.Transparent);
                                    x.Cell().BorderVertical(1).Text("");
                                    x.Cell().Text("T").FontColor(Colors.Transparent);
                                }
                                else
                                {
                                    int sumTime = 0;
                                    foreach (DataRow row in dthour.Rows)
                                    {
                                        //Prepare Date to be showed in Short Form
                                        DateTime date;
                                        DateTime.TryParse(row["date"].ToString(), out date);
                                        //Summ Time
                                        Int32.TryParse(row["time_h"].ToString(), out int j);
                                        sumTime = sumTime + j;

                                        //Add DataRow to PDF
                                        x.Cell().Text(date.ToShortDateString()).AlignLeft();
                                        x.Cell().BorderVertical(1).Text(row["description"].ToString()).ClampLines(1).AlignCenter();
                                        x.Cell().Text(row["time_h"].ToString()).AlignRight();
                                    }
                                    x.Cell().Text("_").FontColor(Colors.Transparent);
                                    x.Cell().Text("Summe :").AlignRight();
                                    x.Cell().Text(sumTime.ToString()).AlignRight();
                                    //x.Item().HTML(handler =>
                                    //{
                                    //    handler.SetHtml(html);
                                    //});

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

            }).GeneratePdfAndShow();//.ShowInPreviewer();//
            /**/
        }



        public byte[] GetLogo(string file)
        {
            //Get Logo from Ressources
            Bitmap bm = Properties.Resources.pen3;
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(file))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                // TODO: use the buffer that was read
                return buffer;
            }
        }
    }
}

