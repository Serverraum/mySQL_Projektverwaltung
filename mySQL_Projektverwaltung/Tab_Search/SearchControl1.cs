using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace mySQL_Projektverwaltung.Tab_Search
{
    public partial class SearchControl1 : UserControl
    {
        public SearchControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                dataGridView1.DataSource = null;
                string sql = "SELECT * FROM proj WHERE desc_short LIKE '%" + textBox1.Text + "%' OR desc_long LIKE '%" + textBox1.Text + "%'";
                DbConnParam.DbConn.Instance.DbAddCmd(sql);
                DataTable dt = DbConnParam.DbConn.Instance.DbGetDataTable();

                // Konvertiere das Datum in der ersten Spalte in das ShortDateString-Format
                foreach (DataRow row in dt.Rows)
                {
                    // Annahme: Das Datum liegt in der ersten Spalte (Index 0)
                    string desc_long = row[8].ToString(); // Hole das Datum als String aus der DataRow
                    row[8] = RichTextStripper.StripRichTextFormat(desc_long);

                    // Annahme: Das Datum liegt in der ersten Spalte (Index 0)
                    string dateString = row[1].ToString(); // Hole das Datum als String aus der DataRow

                    // Parsen des Datums in das DateTime-Objekt
                    DateTime date;
                    if (DateTime.TryParseExact(dateString, "s", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        // Konvertiere das Datum in das ShortDateString-Format
                        string shortDateString = date.ToShortDateString();

                        // Setze das konvertierte Datum zurück in die erste Spalte der DataRow
                        row[1] = shortDateString;
                    }
                    else if (DateTime.TryParseExact(dateString, "dd.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out date))
                    {
                        // Konvertiere das Datum in das ShortDateString-Format
                        string shortDateString = date.ToShortDateString();

                        // Setze das konvertierte Datum zurück in die erste Spalte der DataRow
                        row[1] = shortDateString;
                    }
                    else
                    {
                        MessageBox.Show("Date wrong: '" + row[1].ToString() + "' not in Format of dd.mm.yy");

                        // Handle den Fall, wenn das Parsen fehlschlägt
                        // Zum Beispiel: Fehlerbehandlung oder anderes Verhalten
                    }
                }


                dataGridView1.DataSource = dt;
                //dataGridView1.Columns[1].HeaderText = "Datum";
                //dataGridView1.Columns[2].HeaderText = "Beschreibung";
                //dataGridView1.Columns[3].HeaderText = "Zeit";
                dataGridView1.Columns[0].Visible = false; //projID
                dataGridView1.Columns[2].Visible = false; //LSID
                dataGridView1.Columns[3].Visible = false; //AGID
                dataGridView1.Columns[9].Visible = false; //completed
                dataGridView1.Columns[10].Visible = false; //folder
                dataGridView1.Columns[11].Visible = false; //datechanged
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long projID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            TabControl parentTabControl = this.Parent.Parent as TabControl;
            parentTabControl.SelectedTab = parentTabControl.TabPages["Projekt"];
            foreach (var item in Application.OpenForms)
            {
                Main main = item as Main;
                if (main != null)
                {
                    main.LoadProject(projID);
                }
            }
        }

        
        
        
    }
    /// <summary>
    /// Rich Text Stripper
    /// </summary>
    /// <remarks>
    /// Translated from Python located at:
    /// http://stackoverflow.com/a/188877/448
    /// </remarks>
    public static class RichTextStripper
    {
        private class StackEntry
        {
            public int NumberOfCharactersToSkip { get; set; }
            public bool Ignorable { get; set; }

            public StackEntry(int numberOfCharactersToSkip, bool ignorable)
            {
                NumberOfCharactersToSkip = numberOfCharactersToSkip;
                Ignorable = ignorable;
            }
        }

        private static readonly Regex _rtfRegex = new Regex(@"\\([a-z]{1,32})(-?\d{1,10})?[ ]?|\\'([0-9a-f]{2})|\\([^a-z])|([{}])|[\r\n]+|(.)", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        private static readonly List<string> destinations = new List<string>
    {
        "aftncn","aftnsep","aftnsepc","annotation","atnauthor","atndate","atnicn","atnid",
        "atnparent","atnref","atntime","atrfend","atrfstart","author","background",
        "bkmkend","bkmkstart","blipuid","buptim","category","colorschememapping",
        "colortbl","comment","company","creatim","datafield","datastore","defchp","defpap",
        "do","doccomm","docvar","dptxbxtext","ebcend","ebcstart","factoidname","falt",
        "fchars","ffdeftext","ffentrymcr","ffexitmcr","ffformat","ffhelptext","ffl",
        "ffname","ffstattext","field","file","filetbl","fldinst","fldrslt","fldtype",
        "fname","fontemb","fontfile","fonttbl","footer","footerf","footerl","footerr",
        "footnote","formfield","ftncn","ftnsep","ftnsepc","g","generator","gridtbl",
        "header","headerf","headerl","headerr","hl","hlfr","hlinkbase","hlloc","hlsrc",
        "hsv","htmltag","info","keycode","keywords","latentstyles","lchars","levelnumbers",
        "leveltext","lfolevel","linkval","list","listlevel","listname","listoverride",
        "listoverridetable","listpicture","liststylename","listtable","listtext",
        "lsdlockedexcept","macc","maccPr","mailmerge","maln","malnScr","manager","margPr",
        "mbar","mbarPr","mbaseJc","mbegChr","mborderBox","mborderBoxPr","mbox","mboxPr",
        "mchr","mcount","mctrlPr","md","mdeg","mdegHide","mden","mdiff","mdPr","me",
        "mendChr","meqArr","meqArrPr","mf","mfName","mfPr","mfunc","mfuncPr","mgroupChr",
        "mgroupChrPr","mgrow","mhideBot","mhideLeft","mhideRight","mhideTop","mhtmltag",
        "mlim","mlimloc","mlimlow","mlimlowPr","mlimupp","mlimuppPr","mm","mmaddfieldname",
        "mmath","mmathPict","mmathPr","mmaxdist","mmc","mmcJc","mmconnectstr",
        "mmconnectstrdata","mmcPr","mmcs","mmdatasource","mmheadersource","mmmailsubject",
        "mmodso","mmodsofilter","mmodsofldmpdata","mmodsomappedname","mmodsoname",
        "mmodsorecipdata","mmodsosort","mmodsosrc","mmodsotable","mmodsoudl",
        "mmodsoudldata","mmodsouniquetag","mmPr","mmquery","mmr","mnary","mnaryPr",
        "mnoBreak","mnum","mobjDist","moMath","moMathPara","moMathParaPr","mopEmu",
        "mphant","mphantPr","mplcHide","mpos","mr","mrad","mradPr","mrPr","msepChr",
        "mshow","mshp","msPre","msPrePr","msSub","msSubPr","msSubSup","msSubSupPr","msSup",
        "msSupPr","mstrikeBLTR","mstrikeH","mstrikeTLBR","mstrikeV","msub","msubHide",
        "msup","msupHide","mtransp","mtype","mvertJc","mvfmf","mvfml","mvtof","mvtol",
        "mzeroAsc","mzeroDesc","mzeroWid","nesttableprops","nextfile","nonesttables",
        "objalias","objclass","objdata","object","objname","objsect","objtime","oldcprops",
        "oldpprops","oldsprops","oldtprops","oleclsid","operator","panose","password",
        "passwordhash","pgp","pgptbl","picprop","pict","pn","pnseclvl","pntext","pntxta",
        "pntxtb","printim","private","propname","protend","protstart","protusertbl","pxe",
        "result","revtbl","revtim","rsidtbl","rxe","shp","shpgrp","shpinst",
        "shppict","shprslt","shptxt","sn","sp","staticval","stylesheet","subject","sv",
        "svb","tc","template","themedata","title","txe","ud","upr","userprops",
        "wgrffmtfilter","windowcaption","writereservation","writereservhash","xe","xform",
        "xmlattrname","xmlattrvalue","xmlclose","xmlname","xmlnstbl",
        "xmlopen"
    };

        private static readonly Dictionary<string, string> specialCharacters = new Dictionary<string, string>
    {
        { "par", "\n" },
        { "sect", "\n\n" },
        { "page", "\n\n" },
        { "line", "\n" },
        { "tab", "\t" },
        { "emdash", "\u2014" },
        { "endash", "\u2013" },
        { "emspace", "\u2003" },
        { "enspace", "\u2002" },
        { "qmspace", "\u2005" },
        { "bullet", "\u2022" },
        { "lquote", "\u2018" },
        { "rquote", "\u2019" },
        { "ldblquote", "\u201C" },
        { "rdblquote", "\u201D" },
    };
        /// <summary>
        /// Strip RTF Tags from RTF Text
        /// </summary>
        /// <param name="inputRtf">RTF formatted text</param>
        /// <returns>Plain text from RTF</returns>
        public static string StripRichTextFormat(string inputRtf)
        {
            if (inputRtf == null)
            {
                return null;
            }

            string returnString;

            var stack = new Stack<StackEntry>();
            bool ignorable = false;              // Whether this group (and all inside it) are "ignorable".
            int ucskip = 1;                      // Number of ASCII characters to skip after a unicode character.
            int curskip = 0;                     // Number of ASCII characters left to skip
            var outList = new List<string>();    // Output buffer.

            MatchCollection matches = _rtfRegex.Matches(inputRtf);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string word = match.Groups[1].Value;
                    string arg = match.Groups[2].Value;
                    string hex = match.Groups[3].Value;
                    string character = match.Groups[4].Value;
                    string brace = match.Groups[5].Value;
                    string tchar = match.Groups[6].Value;

                    if (!String.IsNullOrEmpty(brace))
                    {
                        curskip = 0;
                        if (brace == "{")
                        {
                            // Push state
                            stack.Push(new StackEntry(ucskip, ignorable));
                        }
                        else if (brace == "}")
                        {
                            // Pop state
                            StackEntry entry = stack.Pop();
                            ucskip = entry.NumberOfCharactersToSkip;
                            ignorable = entry.Ignorable;
                        }
                    }
                    else if (!String.IsNullOrEmpty(character)) // \x (not a letter)
                    {
                        curskip = 0;
                        if (character == "~")
                        {
                            if (!ignorable)
                            {
                                outList.Add("\xA0");
                            }
                        }
                        else if ("{}\\".Contains(character))
                        {
                            if (!ignorable)
                            {
                                outList.Add(character);
                            }
                        }
                        else if (character == "*")
                        {
                            ignorable = true;
                        }
                    }
                    else if (!String.IsNullOrEmpty(word)) // \foo
                    {
                        curskip = 0;
                        if (destinations.Contains(word))
                        {
                            ignorable = true;
                        }
                        else if (ignorable)
                        {
                        }
                        else if (specialCharacters.ContainsKey(word))
                        {
                            outList.Add(specialCharacters[word]);
                        }
                        else if (word == "uc")
                        {
                            ucskip = Int32.Parse(arg);
                        }
                        else if (word == "u")
                        {
                            int c = Int32.Parse(arg);
                            if (c < 0)
                            {
                                c += 0x10000;
                            }
                            //Ein gültiger UTF32-Wert ist zwischen 0x000000 und 0x10ffff (einschließlich) und sollte keine Ersatzcodepunktwerte (0x00d800 ~ 0x00dfff)
                            if (c >= 0x000000 && c <= 0x10ffff && (c < 0x00d800 || c > 0x00dfff))
                                outList.Add(Char.ConvertFromUtf32(c));
                            else outList.Add("?");
                            curskip = ucskip;
                        }
                    }
                    else if (!String.IsNullOrEmpty(hex)) // \'xx
                    {
                        if (curskip > 0)
                        {
                            curskip -= 1;
                        }
                        else if (!ignorable)
                        {
                            int c = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                            outList.Add(Char.ConvertFromUtf32(c));
                        }
                    }
                    else if (!String.IsNullOrEmpty(tchar))
                    {
                        if (curskip > 0)
                        {
                            curskip -= 1;
                        }
                        else if (!ignorable)
                        {
                            outList.Add(tchar);
                        }
                    }
                }
            }
            else
            {
                // Didn't match the regex
                returnString = inputRtf;
            }

            returnString = String.Join(String.Empty, outList.ToArray());

            return returnString;
        }
    }
}
