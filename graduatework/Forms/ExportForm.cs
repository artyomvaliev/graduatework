using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Threading;

namespace graduatework.Forms
{

    public partial class ExportForm : Form
    {
        private Excel.Application excelapp; // Программа Excel
        private Excel.Range excelcells; // Диапазон ячеек или ячейка

        public ExportForm()
        {
            InitializeComponent();
        }
        
        private void rjButton1_Click(object sender, EventArgs e)
        {            
            string pathEx = Path.GetFullPath("Расчетный файл.xls");
            string FNDogMain = SelectBanking.nameDogovor + "_" + SelectBanking.dateDogovor;
            //    +=[]:;«,./?'пробел' /\:*? «<>|
            string FNDog1 = FNDogMain.Replace("+", "");
            string FNDog2 = FNDog1.Replace("+", "");
            string FNDog3 = FNDog2.Replace("=", "");
            string FNDog4 = FNDog3.Replace("[", "");
            string FNDog5 = FNDog4.Replace("]", "");
            string FNDog6 = FNDog5.Replace(":", "");
            string FNDog7 = FNDog6.Replace(";", "");
            string FNDog10 = FNDog7.Replace("«", "");
            string FNDog11 = FNDog10.Replace(",", "");
            string FNDog12 = FNDog11.Replace(".", "");
            string FNDog13 = FNDog12.Replace(" ", "");
            string FNDog14 = FNDog13.Replace("/", "");
            string FNDog15 = FNDog14.Replace("*", "");
            string FNDog16 = FNDog15.Replace("?", "");
            string FNDog17 = FNDog16.Replace("<", "");
            string FNDog18 = FNDog17.Replace(">", "");
            string FNDog = FNDog18.Replace("|", "");

            string FNDogDir = FNDog.Substring(0, FNDog.Length - 5);
            string path = Path.GetFullPath("Отчеты\\");

            if (!string.IsNullOrWhiteSpace(FNDogDir))
            { Directory.CreateDirectory(Path.Combine(path, FNDogDir));

            }

            string DogovorDirectory = path + FNDogDir + "\\";
            string Otchet = "Отчет";
            if (!string.IsNullOrWhiteSpace(Otchet))
            {
                Directory.CreateDirectory(Path.Combine(DogovorDirectory, Otchet));
            }

            string DogovorDirectoryOtchetExcel = DogovorDirectory + Otchet+ "\\Расчетный файл.xls";
            if (!string.IsNullOrWhiteSpace(DogovorDirectoryOtchetExcel))
            {
                File.Copy(pathEx, DogovorDirectoryOtchetExcel, true);
            }
            // Запустим Excel
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            //Откроем Книгу
            Excel.Workbook workbook = excelapp.Workbooks.Open(DogovorDirectoryOtchetExcel);
            //ОПИСАНИЕ ФОРМУЛЯР

            Worksheet ObjWorkSheet = (Worksheet)excelapp.Worksheets[1];
            ObjWorkSheet.Select(Type.Missing);
            //documents
            if (SelectBanking.EGRN[1] == "2")
            {
                excelcells = ObjWorkSheet.get_Range("R3", "R3");
                excelcells.Value2 = "есть";
            }
            else
            {
                excelcells = ObjWorkSheet.get_Range("R3", "R3");
                excelcells.Value2 = "не предоставлено";
            }
            if (SelectBanking.TehPasport[1] == "2")
            {
                excelcells = ObjWorkSheet.get_Range("R5", "R5");
                excelcells.Value2 = "есть";
            }
            else
            {
                excelcells = ObjWorkSheet.get_Range("R5", "R5");
                excelcells.Value2 = "не предоставлено";
            }
            if (SelectBanking.Pasport[1] == "2")
            {
                excelcells = ObjWorkSheet.get_Range("R6", "R6");
                excelcells.Value2 = "есть";
            }
            else
            {
                excelcells = ObjWorkSheet.get_Range("R6", "R6");
                excelcells.Value2 = "не предоставлено";
            }
            //Идентификация и характеристика местоположения объекта оценки
            excelcells = ObjWorkSheet.get_Range("H3", "H3");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[1];
            excelcells = ObjWorkSheet.get_Range("H5", "H5");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[2];
            excelcells = ObjWorkSheet.get_Range("H6", "H6");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[3];
            excelcells = ObjWorkSheet.get_Range("H7", "H7");
            excelcells.Value2 = SelectBanking.LokalRasp[1];
            excelcells = ObjWorkSheet.get_Range("H8", "H8");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[4];
            excelcells = ObjWorkSheet.get_Range("H9", "H9");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[9];
            excelcells = ObjWorkSheet.get_Range("H10", "H10");
            excelcells.Value2 = SelectBanking.PreoblZastr[1];
            excelcells = ObjWorkSheet.get_Range("H11", "H11");
            excelcells.Value2 = SelectBanking.TranspDostup[1];
            excelcells = ObjWorkSheet.get_Range("H12", "H12");
            excelcells.Value2 = SelectBanking.ObespObshTrans[1];
            excelcells = ObjWorkSheet.get_Range("H13", "H13");
            excelcells.Value2 = SelectBanking.IIXMO[6];
            excelcells = ObjWorkSheet.get_Range("H14", "H14");
            excelcells.Value2 = SelectBanking.ObespObjSocInf[1];
            excelcells = ObjWorkSheet.get_Range("H15", "H15");
            excelcells.Value2 = SelectBanking.EcoObstRaionl[1];
            excelcells = ObjWorkSheet.get_Range("H16", "H16");
            excelcells.Value2 = SelectBanking.IIXMO[9];

            //Общая характеристика здания
            excelcells = ObjWorkSheet.get_Range("H20", "H20");
            excelcells.Value2 = SelectBanking.TipDomaMatSten[1];
            excelcells = ObjWorkSheet.get_Range("H21", "H21");
            excelcells.Value2 = SelectBanking.OXZ[2];
            excelcells = ObjWorkSheet.get_Range("H22", "H22");
            excelcells.Value2 = SelectBanking.MaterialPerekr[1];
            excelcells = ObjWorkSheet.get_Range("H23", "H23");
            excelcells.Value2 = SelectBanking.OXZ[4];
            excelcells = ObjWorkSheet.get_Range("H24", "H24");
            excelcells.Value2 = SelectBanking.OXZ[5];
            excelcells = ObjWorkSheet.get_Range("H26", "H26");
            excelcells.Value2 = SelectBanking.SostDoma[1];
            excelcells = ObjWorkSheet.get_Range("H29", "H29");
            excelcells.Value2 = SelectBanking.SostVneshOtd[1];
            excelcells = ObjWorkSheet.get_Range("H31", "H31");
            excelcells.Value2 = SelectBanking.Domofon[1];
            excelcells = ObjWorkSheet.get_Range("H32", "H32");
            excelcells.Value2 = SelectBanking.Parkovka[1];
            excelcells = ObjWorkSheet.get_Range("H33", "H33");
            excelcells.Value2 = SelectBanking.OgorojdTerr[1];
            excelcells = ObjWorkSheet.get_Range("H34", "H34");
            excelcells.Value2 = SelectBanking.Privlekatelnost[1];
            excelcells = ObjWorkSheet.get_Range("H35", "H35");
            excelcells.Value2 = SelectBanking.SostPodjezd[1];
            excelcells = ObjWorkSheet.get_Range("E36", "E36");
            excelcells.Value2 = SelectBanking.DetPlosh[1];
            excelcells = ObjWorkSheet.get_Range("M36", "M36");
            excelcells.Value2 = SelectBanking.ZelNasajd[1];
            excelcells = ObjWorkSheet.get_Range("H37", "H37");
            excelcells.Value2 = SelectBanking.OXZ[18];

            //Характеристика объекта оценки
            excelcells = ObjWorkSheet.get_Range("H41", "H41");
            excelcells.Value2 = SelectBanking.TipPomesh[1];
            excelcells = ObjWorkSheet.get_Range("H42", "H42");
            excelcells.Value2 = SelectBanking.Naznachenie[1];
            excelcells = ObjWorkSheet.get_Range("H43", "H43");
            excelcells.Value2 = SelectBanking.TekushIsp[1];
            excelcells = ObjWorkSheet.get_Range("H44", "H44");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[4];

            excelcells = ObjWorkSheet.get_Range("H46", "H46");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[7];
            excelcells = ObjWorkSheet.get_Range("H48", "H48");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[5];
            excelcells = ObjWorkSheet.get_Range("H49", "H49");
            excelcells.Value2 = SelectBanking.ObjectOtsenki[6];

            excelcells = ObjWorkSheet.get_Range("I50", "I50");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[6];
            excelcells = ObjWorkSheet.get_Range("K50", "K50");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[7];
            excelcells = ObjWorkSheet.get_Range("M50", "M50");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[8];
            excelcells = ObjWorkSheet.get_Range("O50", "O50");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[9];

            excelcells = ObjWorkSheet.get_Range("H52", "H52");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[10];
            excelcells = ObjWorkSheet.get_Range("H53", "H53");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[11];
            excelcells = ObjWorkSheet.get_Range("H54", "H54");
            excelcells.Value2 = SelectBanking.TipSanuzlov[1];
            excelcells = ObjWorkSheet.get_Range("H55", "H55");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[13];
            excelcells = ObjWorkSheet.get_Range("H56", "H56");
            excelcells.Value2 = SelectBanking.HarkaObjectaOtsenki[19];
            excelcells = ObjWorkSheet.get_Range("H57", "H57");
            excelcells.Value2 = SelectBanking.HarkaBalkon[1];
            excelcells = ObjWorkSheet.get_Range("L57", "L57");
            excelcells.Value2 = SelectBanking.Steklo[1];
            excelcells = ObjWorkSheet.get_Range("H58", "H58");
            excelcells.Value2 = SelectBanking.VidIzOkon[1];
            excelcells = ObjWorkSheet.get_Range("H59", "H59");
            excelcells.Value2 = SelectBanking.DannieOPereplan[1];
            excelcells = ObjWorkSheet.get_Range("H60", "H60");
            excelcells.Value2 = SelectBanking.TipOtdelki[1];

            //Инженерное обеспечение
            excelcells = ObjWorkSheet.get_Range("D64", "D64");
            if (SelectBanking.InjenernoeObesp[1] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[1] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D65", "D65");
            if (SelectBanking.InjenernoeObesp[2] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[2] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D66", "D66");
            if (SelectBanking.InjenernoeObesp[3] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[3] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D67", "D67");
            if (SelectBanking.InjenernoeObesp[4] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[4] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D68", "D68");
            if (SelectBanking.InjenernoeObesp[5] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[5] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D69", "D69");
            if (SelectBanking.InjenernoeObesp[6] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[6] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D70", "D70");
            if (SelectBanking.InjenernoeObesp[7] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[7] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D71", "D71");
            if (SelectBanking.InjenernoeObesp[8] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[8] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D72", "D72");
            if (SelectBanking.InjenernoeObesp[9] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[9] == "0")
            { excelcells.Value2 = "нет"; }
            excelcells = ObjWorkSheet.get_Range("D73", "D73");
            if (SelectBanking.InjenernoeObesp[10] == "1")
            { excelcells.Value2 = "да"; }
            else if (SelectBanking.InjenernoeObesp[10] == "0")
            { excelcells.Value2 = "нет"; }

            //Отделка
            excelcells = ObjWorkSheet.get_Range("H64", "H64");
            excelcells.Value2 = SelectBanking.VhodDver[1];
            excelcells = ObjWorkSheet.get_Range("H65", "H65");
            excelcells.Value2 = SelectBanking.MejkomnataDver[1];
            //Комнаты
            excelcells = ObjWorkSheet.get_Range("H67", "H67");
            excelcells.Value2 = SelectBanking.KomnatiSteni[1];
            excelcells = ObjWorkSheet.get_Range("H69", "H69");
            excelcells.Value2 = SelectBanking.KomnatiPoli[1];
            excelcells = ObjWorkSheet.get_Range("H71", "H71");
            excelcells.Value2 = SelectBanking.KomnatiPotolok[1];
            excelcells = ObjWorkSheet.get_Range("H73", "H73");
            excelcells.Value2 = SelectBanking.KomnatiOkna[1];
            //Кухня
            excelcells = ObjWorkSheet.get_Range("J67", "J67");
            excelcells.Value2 = SelectBanking.KuhnyaSteni[1];
            excelcells = ObjWorkSheet.get_Range("J69", "J69");
            excelcells.Value2 = SelectBanking.KuhnyaPoli[1];
            excelcells = ObjWorkSheet.get_Range("J71", "J71");
            excelcells.Value2 = SelectBanking.KuhnyaPotolok[1];
            excelcells = ObjWorkSheet.get_Range("J73", "J73");
            excelcells.Value2 = SelectBanking.KuhnyaOkna[1];
            //Санузлы
            excelcells = ObjWorkSheet.get_Range("L67", "L67");
            excelcells.Value2 = SelectBanking.SanuzliSteni[1];
            excelcells = ObjWorkSheet.get_Range("L69", "L69");
            excelcells.Value2 = SelectBanking.SanuzliPoli[1];
            excelcells = ObjWorkSheet.get_Range("L71", "L71");
            excelcells.Value2 = SelectBanking.SanuzliPotolok[1];
            excelcells = ObjWorkSheet.get_Range("L73", "L73");
            excelcells.Value2 = SelectBanking.SanuzliOkna[1];
            //Иные
            excelcells = ObjWorkSheet.get_Range("N67", "N67");
            excelcells.Value2 = SelectBanking.InieSteni[1];
            excelcells = ObjWorkSheet.get_Range("N69", "N69");
            excelcells.Value2 = SelectBanking.IniePoli[1];
            excelcells = ObjWorkSheet.get_Range("N71", "N71");
            excelcells.Value2 = SelectBanking.IniePotolok[1];
            excelcells = ObjWorkSheet.get_Range("N73", "N73");
            excelcells.Value2 = SelectBanking.InieOkna[1];
            //Экспертная оценка технического состояния
            excelcells = ObjWorkSheet.get_Range("H79", "H79");
            excelcells.Value2 = SelectBanking.ES1[1];
            excelcells = ObjWorkSheet.get_Range("L79", "L79");
            excelcells.Value2 = SelectBanking.ES1[2];

            excelcells = ObjWorkSheet.get_Range("H80", "H80");
            excelcells.Value2 = SelectBanking.ES2[1];
            excelcells = ObjWorkSheet.get_Range("L80", "L80");
            excelcells.Value2 = SelectBanking.ES2[2];

            excelcells = ObjWorkSheet.get_Range("H81", "H81");
            excelcells.Value2 = SelectBanking.ES3[1];
            excelcells = ObjWorkSheet.get_Range("L81", "L81");
            excelcells.Value2 = SelectBanking.ES4[2];

            excelcells = ObjWorkSheet.get_Range("H82", "H82");
            excelcells.Value2 = SelectBanking.ES4[1];
            excelcells = ObjWorkSheet.get_Range("L82", "L82");
            excelcells.Value2 = SelectBanking.ES4[2];

            excelcells = ObjWorkSheet.get_Range("H83", "H83");
            excelcells.Value2 = SelectBanking.ES5[1];
            excelcells = ObjWorkSheet.get_Range("L83", "L83");
            excelcells.Value2 = SelectBanking.ES5[2];

            excelcells = ObjWorkSheet.get_Range("H84", "H84");
            excelcells.Value2 = SelectBanking.ES6[1];
            excelcells = ObjWorkSheet.get_Range("L84", "L84");
            excelcells.Value2 = SelectBanking.ES6[2];

            excelcells = ObjWorkSheet.get_Range("H85", "H85");
            excelcells.Value2 = SelectBanking.ES7[1];
            excelcells = ObjWorkSheet.get_Range("L85", "L85");
            excelcells.Value2 = SelectBanking.ES7[2];

            excelcells = ObjWorkSheet.get_Range("H86", "H86");
            excelcells.Value2 = SelectBanking.ES8[1];
            excelcells = ObjWorkSheet.get_Range("L86", "L86");
            excelcells.Value2 = SelectBanking.ES8[2];

            excelcells = ObjWorkSheet.get_Range("H87", "H87");
            excelcells.Value2 = SelectBanking.ES9[1];
            excelcells = ObjWorkSheet.get_Range("L87", "L87");
            excelcells.Value2 = SelectBanking.ES9[2];

            excelcells = ObjWorkSheet.get_Range("H88", "H88");
            excelcells.Value2 = SelectBanking.ES10[1];
            excelcells = ObjWorkSheet.get_Range("L88", "L88");
            excelcells.Value2 = SelectBanking.ES10[2];

            excelcells = ObjWorkSheet.get_Range("H89", "H89");
            excelcells.Value2 = SelectBanking.ES11[1];
            excelcells = ObjWorkSheet.get_Range("L89", "L89");
            excelcells.Value2 = SelectBanking.ES11[2];

            excelcells = ObjWorkSheet.get_Range("H90", "H90");
            excelcells.Value2 = SelectBanking.ES12[1];
            excelcells = ObjWorkSheet.get_Range("L90", "L90");
            excelcells.Value2 = SelectBanking.ES12[2];

            excelcells = ObjWorkSheet.get_Range("H91", "H91");
            excelcells.Value2 = SelectBanking.ES13[1];
            excelcells = ObjWorkSheet.get_Range("L91", "L91");
            excelcells.Value2 = SelectBanking.ES13[2];

            excelcells = ObjWorkSheet.get_Range("H92", "H92");
            excelcells.Value2 = SelectBanking.ES14[1];
            excelcells = ObjWorkSheet.get_Range("L92", "L92");
            excelcells.Value2 = SelectBanking.ES14[2];

            excelcells = ObjWorkSheet.get_Range("H93", "H93");
            excelcells.Value2 = SelectBanking.ES15[1];
            excelcells = ObjWorkSheet.get_Range("L93", "L93");
            excelcells.Value2 = SelectBanking.ES15[2];

            excelcells = ObjWorkSheet.get_Range("H95", "H95");
            excelcells.Value2 = SelectBanking.ES16[1];
            excelcells = ObjWorkSheet.get_Range("L95", "L95");
            excelcells.Value2 = SelectBanking.ES16[2];

            excelcells = ObjWorkSheet.get_Range("H96", "H96");
            excelcells.Value2 = SelectBanking.EOTS[17];


            //Расчет износа
            ObjWorkSheet = (Worksheet)excelapp.Worksheets[2];
            ObjWorkSheet.Select(Type.Missing);

            excelcells = ObjWorkSheet.get_Range("B13", "B13");
            excelcells.Value2 = SelectBanking.NSSPDR[2];
            excelcells = ObjWorkSheet.get_Range("B14", "B14");
            excelcells.Value2 = SelectBanking.SOFSS[1];
            excelcells = ObjWorkSheet.get_Range("B15", "B15");
            excelcells.Value2 = SelectBanking.OXZ[6];

            excelcells = ObjWorkSheet.get_Range("B20", "B20");
            excelcells.Value2 = Convert.ToDouble(SelectBanking.Method[3]) / 100;
            excelcells = ObjWorkSheet.get_Range("B21", "B21");
            excelcells.Value2 = SelectBanking.PrinMethod[1];
            excelcells = ObjWorkSheet.get_Range("B22", "B22");
            excelcells.Value2 = Convert.ToDouble(SelectBanking.Method[4]) / 100;

            //Задание на оценку

            ObjWorkSheet = (Worksheet)excelapp.Worksheets[3];
            ObjWorkSheet.Select();

            ObjWorkSheet.Cells[1, 5].Value2 = textBox1.Text;
            ObjWorkSheet.Cells[2, 5].Value2 = textBox2.Text;
            ObjWorkSheet.Cells[3, 5].Value2 = textBox3.Text;

            ObjWorkSheet.Cells[14, 3].Value2 = SelectBanking.OtsenkePold[1];
            ObjWorkSheet.Cells[16, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.EGRN[2]);
            ObjWorkSheet.Cells[17, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.TehPasport[2]);
            ObjWorkSheet.Cells[18, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Pasport[2]);
            //excelcells = ObjWorkSheet.get_Range("С14", "С14");
            //excelcells.Value2 = SelectBanking.OtsenkePold[1];
            ObjWorkSheet.Cells[37, 3].Value2 = SelectBanking.TIPNOO[1];
            //excelcells = ObjWorkSheet.get_Range("С37", "С37");
            //excelcells.Value2 = SelectBanking.TIPNOO[1];
            ObjWorkSheet.Cells[38, 3].Value2 = SelectBanking.NalichObr[1];
            //excelcells = ObjWorkSheet.get_Range("С38", "С38");
            //excelcells.Value2 = SelectBanking.NalichObr[1];
            ObjWorkSheet.Cells[39, 3].Value2 = SelectBanking.HarkaObr[1];
            //excelcells = ObjWorkSheet.get_Range("С39", "С39");
            //excelcells.Value2 = SelectBanking.HarkaObr[1];
            ObjWorkSheet.Cells[40, 3].Value2 = SelectBanking.ZadanieNaOtcenku[5];
            //excelcells = ObjWorkSheet.get_Range("С40", "С40");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[5];
            ObjWorkSheet.Cells[41, 3].Value2 = SelectBanking.PhysUrLitso[1];
            //excelcells = ObjWorkSheet.get_Range("С41", "С41");
            //excelcells.Value2 = SelectBanking.PhysUrLitso[1];
            if (SelectBanking.ZadanieNaOtcenku[5] == "5")
            {
                //1
                ObjWorkSheet.Cells[53, 3].Value2 = SelectBanking.Provoobledatel1[1] + " " + SelectBanking.Provoobledatel1[2] + " " + SelectBanking.Provoobledatel1[3];
                ObjWorkSheet.Cells[54, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]) + ", " + SelectBanking.Provoobledatel1[4];
                ObjWorkSheet.Cells[56, 3].Value2 = SelectBanking.Provoobledatel1[6];


                //2
                ObjWorkSheet.Cells[61, 3].Value2 = SelectBanking.Provoobledatel2[1] + " " + SelectBanking.Provoobledatel2[2] + " " + SelectBanking.Provoobledatel2[3];
                ObjWorkSheet.Cells[62, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel2[5]);
                ObjWorkSheet.Cells[63, 3].Value2 = SelectBanking.Provoobledatel2[4];
                ObjWorkSheet.Cells[64, 3].Value2 = SelectBanking.Provoobledatel2[6];

                //3
                ObjWorkSheet.Cells[65, 3].Value2 = SelectBanking.Provoobledatel3[1] + " " + SelectBanking.Provoobledatel3[2] + " " + SelectBanking.Provoobledatel3[3];
                ObjWorkSheet.Cells[66, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel3[5]);
                ObjWorkSheet.Cells[67, 3].Value2 = SelectBanking.Provoobledatel3[4];
                ObjWorkSheet.Cells[68, 3].Value2 = SelectBanking.Provoobledatel3[6];

                //4
                ObjWorkSheet.Cells[69, 3].Value2 = SelectBanking.Provoobledatel4[1] + " " + SelectBanking.Provoobledatel4[2] + " " + SelectBanking.Provoobledatel4[3];
                ObjWorkSheet.Cells[70, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel4[5]);
                ObjWorkSheet.Cells[71, 3].Value2 = SelectBanking.Provoobledatel4[4];
                ObjWorkSheet.Cells[72, 3].Value2 = SelectBanking.Provoobledatel4[6];

                //5
                ObjWorkSheet.Cells[73, 3].Value2 = SelectBanking.Provoobledatel5[1] + " " + SelectBanking.Provoobledatel5[2] + " " + SelectBanking.Provoobledatel5[3];
                ObjWorkSheet.Cells[74, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel5[5]);
                ObjWorkSheet.Cells[75, 3].Value2 = SelectBanking.Provoobledatel5[4];
                ObjWorkSheet.Cells[76, 3].Value2 = SelectBanking.Provoobledatel5[6];
            }
            else if (SelectBanking.ZadanieNaOtcenku[5] == "4")
            {
                //1
                ObjWorkSheet.Cells[53, 3].Value2 = SelectBanking.Provoobledatel1[1] + " " + SelectBanking.Provoobledatel1[2] + " " + SelectBanking.Provoobledatel1[3];
                ObjWorkSheet.Cells[54, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]) + ", " + SelectBanking.Provoobledatel1[4];
                ObjWorkSheet.Cells[56, 3].Value2 = SelectBanking.Provoobledatel1[6];


                //2
                ObjWorkSheet.Cells[61, 3].Value2 = SelectBanking.Provoobledatel2[1] + " " + SelectBanking.Provoobledatel2[2] + " " + SelectBanking.Provoobledatel2[3];
                ObjWorkSheet.Cells[62, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel2[5]);
                ObjWorkSheet.Cells[63, 3].Value2 = SelectBanking.Provoobledatel2[4];
                ObjWorkSheet.Cells[64, 3].Value2 = SelectBanking.Provoobledatel2[6];

                //3
                ObjWorkSheet.Cells[65, 3].Value2 = SelectBanking.Provoobledatel3[1] + " " + SelectBanking.Provoobledatel3[2] + " " + SelectBanking.Provoobledatel3[3];
                ObjWorkSheet.Cells[66, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel3[5]);
                ObjWorkSheet.Cells[67, 3].Value2 = SelectBanking.Provoobledatel3[4];
                ObjWorkSheet.Cells[68, 3].Value2 = SelectBanking.Provoobledatel3[6];

                //4
                ObjWorkSheet.Cells[69, 3].Value2 = SelectBanking.Provoobledatel4[1] + " " + SelectBanking.Provoobledatel4[2] + " " + SelectBanking.Provoobledatel4[3];
                ObjWorkSheet.Cells[70, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel4[5]);
                ObjWorkSheet.Cells[71, 3].Value2 = SelectBanking.Provoobledatel4[4];
                ObjWorkSheet.Cells[72, 3].Value2 = SelectBanking.Provoobledatel4[6];

                //5
                ObjWorkSheet.Cells[73, 3].Value2 = "";
                ObjWorkSheet.Cells[74, 3].Value2 = "";
                ObjWorkSheet.Cells[75, 3].Value2 = "";
                ObjWorkSheet.Cells[76, 3].Value2 = "";
            }
            else if (SelectBanking.ZadanieNaOtcenku[5] == "3")
            {
                //1
                ObjWorkSheet.Cells[53, 3].Value2 = SelectBanking.Provoobledatel1[1] + " " + SelectBanking.Provoobledatel1[2] + " " + SelectBanking.Provoobledatel1[3];
                ObjWorkSheet.Cells[54, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]) + ", " + SelectBanking.Provoobledatel1[4];
                ObjWorkSheet.Cells[56, 3].Value2 = SelectBanking.Provoobledatel1[6];


                //2
                ObjWorkSheet.Cells[61, 3].Value2 = SelectBanking.Provoobledatel2[1] + " " + SelectBanking.Provoobledatel2[2] + " " + SelectBanking.Provoobledatel2[3];
                ObjWorkSheet.Cells[62, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel2[5]);
                ObjWorkSheet.Cells[63, 3].Value2 = SelectBanking.Provoobledatel2[4];
                ObjWorkSheet.Cells[64, 3].Value2 = SelectBanking.Provoobledatel2[6];

                //3
                ObjWorkSheet.Cells[65, 3].Value2 = SelectBanking.Provoobledatel3[1] + " " + SelectBanking.Provoobledatel3[2] + " " + SelectBanking.Provoobledatel3[3];
                ObjWorkSheet.Cells[66, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel3[5]);
                ObjWorkSheet.Cells[67, 3].Value2 = SelectBanking.Provoobledatel3[4];
                ObjWorkSheet.Cells[68, 3].Value2 = SelectBanking.Provoobledatel3[6];

                //4
                ObjWorkSheet.Cells[69, 3].Value2 = "";
                ObjWorkSheet.Cells[70, 3].Value2 = "";
                ObjWorkSheet.Cells[71, 3].Value2 = "";
                ObjWorkSheet.Cells[72, 3].Value2 = "";

                //5
                ObjWorkSheet.Cells[73, 3].Value2 = "";
                ObjWorkSheet.Cells[74, 3].Value2 = "";
                ObjWorkSheet.Cells[75, 3].Value2 = "";
                ObjWorkSheet.Cells[76, 3].Value2 = "";
            }
            else if (SelectBanking.ZadanieNaOtcenku[5] == "2")
            {
                //1
                ObjWorkSheet.Cells[53, 3].Value2 = SelectBanking.Provoobledatel1[1] + " " + SelectBanking.Provoobledatel1[2] + " " + SelectBanking.Provoobledatel1[3];
                ObjWorkSheet.Cells[54, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]) + ", " + SelectBanking.Provoobledatel1[4];
                ObjWorkSheet.Cells[56, 3].Value2 = SelectBanking.Provoobledatel1[6];


                //2
                ObjWorkSheet.Cells[61, 3].Value2 = SelectBanking.Provoobledatel2[1] + " " + SelectBanking.Provoobledatel2[2] + " " + SelectBanking.Provoobledatel2[3];
                ObjWorkSheet.Cells[62, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel2[5]);
                ObjWorkSheet.Cells[63, 3].Value2 = SelectBanking.Provoobledatel2[4];
                ObjWorkSheet.Cells[64, 3].Value2 = SelectBanking.Provoobledatel2[6];

                //3
                ObjWorkSheet.Cells[65, 3].Value2 = "";
                ObjWorkSheet.Cells[66, 3].Value2 = "";
                ObjWorkSheet.Cells[67, 3].Value2 = "";
                ObjWorkSheet.Cells[68, 3].Value2 = "";

                //4
                ObjWorkSheet.Cells[69, 3].Value2 = "";
                ObjWorkSheet.Cells[70, 3].Value2 = "";
                ObjWorkSheet.Cells[71, 3].Value2 = "";
                ObjWorkSheet.Cells[72, 3].Value2 = "";

                //5
                ObjWorkSheet.Cells[73, 3].Value2 = "";
                ObjWorkSheet.Cells[74, 3].Value2 = "";
                ObjWorkSheet.Cells[75, 3].Value2 = "";
                ObjWorkSheet.Cells[76, 3].Value2 = "";
            }
            else if (SelectBanking.ZadanieNaOtcenku[5] == "1")
            {
                //1
                ObjWorkSheet.Cells[53, 3].Value2 = SelectBanking.Provoobledatel1[1] + " " + SelectBanking.Provoobledatel1[2] + " " + SelectBanking.Provoobledatel1[3];
                ObjWorkSheet.Cells[54, 3].Value2 = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]) + ", " + SelectBanking.Provoobledatel1[4];
                ObjWorkSheet.Cells[56, 3].Value2 = SelectBanking.Provoobledatel1[6];


                //2
                ObjWorkSheet.Cells[61, 3].Value2 = "";
                ObjWorkSheet.Cells[62, 3].Value2 = "";
                ObjWorkSheet.Cells[63, 3].Value2 = "";
                ObjWorkSheet.Cells[64, 3].Value2 = "";

                //3
                ObjWorkSheet.Cells[65, 3].Value2 = "";
                ObjWorkSheet.Cells[66, 3].Value2 = "";
                ObjWorkSheet.Cells[67, 3].Value2 = "";
                ObjWorkSheet.Cells[68, 3].Value2 = "";

                //4
                ObjWorkSheet.Cells[69, 3].Value2 = "";
                ObjWorkSheet.Cells[70, 3].Value2 = "";
                ObjWorkSheet.Cells[71, 3].Value2 = "";
                ObjWorkSheet.Cells[72, 3].Value2 = "";

                //5
                ObjWorkSheet.Cells[73, 3].Value2 = "";
                ObjWorkSheet.Cells[74, 3].Value2 = "";
                ObjWorkSheet.Cells[75, 3].Value2 = "";
                ObjWorkSheet.Cells[76, 3].Value2 = "";
            }

            //Физ лицо
            //excelcells = ObjWorkSheet.get_Range("С77", "С77");
            //excelcells.Value2 = SelectBanking.PhysZakaz[1] + " " + SelectBanking.PhysZakaz[2] + " " + SelectBanking.PhysZakaz[3];
            //excelcells = ObjWorkSheet.get_Range("С78", "С78");
            //excelcells.Value2 = "Паспорт: " + SelectBanking.PhysZakaz[4] + " " + SelectBanking.PhysZakaz[7] + ", " + SelectBanking.PhysZakaz[5];
            //excelcells = ObjWorkSheet.get_Range("С79", "С79");
            //excelcells.Value2 = SelectBanking.PhysZakaz[6];
            //excelcells = ObjWorkSheet.get_Range("С80", "С80");
            //excelcells.Value2 = "";
            ObjWorkSheet.Cells[77, 3].Value2 = SelectBanking.PhysZakaz[1] + " " + SelectBanking.PhysZakaz[2] + " " + SelectBanking.PhysZakaz[3];
            ObjWorkSheet.Cells[78, 3].Value2 = "Паспорт: " + Eramake.eCryptography.Decrypt(SelectBanking.PhysZakaz[4]) + " " + Eramake.eCryptography.Decrypt(SelectBanking.PhysZakaz[7]) + ", " + SelectBanking.PhysZakaz[5];
            ObjWorkSheet.Cells[79, 3].Value2 = SelectBanking.PhysZakaz[6];
            ObjWorkSheet.Cells[80, 3].Value2 = "";
            //Юр лицо
            //excelcells = ObjWorkSheet.get_Range("С81", "С81");
            //excelcells.Value2 = SelectBanking.UrZakaz[1];
            //excelcells = ObjWorkSheet.get_Range("С82", "С82");
            //excelcells.Value2 = SelectBanking.UrZakaz[2];
            //excelcells = ObjWorkSheet.get_Range("С83", "С83");
            //excelcells.Value2 = SelectBanking.UrZakaz[3];
            //excelcells = ObjWorkSheet.get_Range("С84", "С84");
            //excelcells.Value2 = SelectBanking.UrZakaz[4];
            ObjWorkSheet.Cells[81, 3].Value2 = SelectBanking.UrZakaz[1];
            ObjWorkSheet.Cells[82, 3].Value2 = SelectBanking.UrZakaz[2];
            ObjWorkSheet.Cells[83, 3].Value2 = SelectBanking.UrZakaz[3];
            ObjWorkSheet.Cells[84, 3].Value2 = SelectBanking.UrZakaz[4];
            //excelcells = ObjWorkSheet.get_Range("С1", "С1");
            //excelcells.Value2 = SelectBanking.nameDogovor;
            //excelcells = ObjWorkSheet.get_Range("С2", "С2");
            //excelcells.Value2 = SelectBanking.dateDogovor;
            ObjWorkSheet.Cells[1, 3].Value2 = SelectBanking.nameDogovor;
            ObjWorkSheet.Cells[2, 3].Value2 = SelectBanking.dateDogovor;
            //excelcells = ObjWorkSheet.get_Range("С87", "С87");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[9];
            //excelcells = ObjWorkSheet.get_Range("С88", "С88");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[10];
            //excelcells = ObjWorkSheet.get_Range("С89", "С89");
            //excelcells.Value2 = SelectBanking.VidStoimosti[1];
            ObjWorkSheet.Cells[87, 3].Value2 = SelectBanking.ZadanieNaOtcenku[9];
            ObjWorkSheet.Cells[88, 3].Value2 = SelectBanking.ZadanieNaOtcenku[10];
            ObjWorkSheet.Cells[89, 3].Value2 = SelectBanking.VidStoimosti[1];
            //excelcells = ObjWorkSheet.get_Range("С90", "С90");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[11];
            //excelcells = ObjWorkSheet.get_Range("С91", "С91");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[12];
            //excelcells = ObjWorkSheet.get_Range("С93", "С93");
            //excelcells.Value2 = SelectBanking.ZadanieNaOtcenku[13];
            ObjWorkSheet.Cells[90, 3].Value2 = SelectBanking.ZadanieNaOtcenku[11];
            ObjWorkSheet.Cells[91, 3].Value2 = SelectBanking.ZadanieNaOtcenku[12];
            ObjWorkSheet.Cells[93, 3].Value2 = SelectBanking.ZadanieNaOtcenku[13];

            //СРАВНИТЕЛЬНЫЙ
            ObjWorkSheet = (Worksheet)excelapp.Worksheets[5];
            ObjWorkSheet.Select();

            //СРАВНИТЕЛЬНЫЙ ОБЪЕКТ
            ObjWorkSheet.Cells[7, 2].Value2 = SelectBanking.SravnObject[1];
            ObjWorkSheet.Cells[8, 2].Value2 = SelectBanking.SravnObject[2];
            ObjWorkSheet.Cells[10, 2].Value2 = SelectBanking.SPP[1];
            ObjWorkSheet.Cells[13, 2].Value2 = SelectBanking.USLFIN[1];
            ObjWorkSheet.Cells[15, 2].Value2 = SelectBanking.Prava[1];
            if (SelectBanking.SravnObject[7] == "1")
            {ObjWorkSheet.Cells[16, 2].Value2 = "да"; }
            else { ObjWorkSheet.Cells[16, 2].Value2 = "нет"; }
            if (SelectBanking.SravnObject[8] == "1")
            { ObjWorkSheet.Cells[27, 2].Value2 = "С учетом мебели и техники"; }
            else { ObjWorkSheet.Cells[27, 2].Value2 = "Без учета мебели и техники"; }

            //Analog1
            ObjWorkSheet.Cells[3, 3].Value2 = SelectBanking.Analog1[1];
            ObjWorkSheet.Cells[4, 3].Value2 = SelectBanking.Analog1[2];
            ObjWorkSheet.Cells[5, 3].Value2 = SelectBanking.Analog1[3];
            ObjWorkSheet.Cells[6, 3].Value2 = SelectBanking.Analog1[4];
            ObjWorkSheet.Cells[7, 3].Value2 = SelectBanking.Analog1[5];
            ObjWorkSheet.Cells[8, 3].Value2 = SelectBanking.Analog1[6];
            ObjWorkSheet.Cells[9, 3].Value2 = SelectBanking.Analog1[7];
            ObjWorkSheet.Cells[10, 3].Value2 = SelectBanking.SPP1[1];
            ObjWorkSheet.Cells[11, 3].Value2 = SelectBanking.Analog1[9];
            ObjWorkSheet.Cells[13, 3].Value2 = SelectBanking.USLFIN1[1];
            ObjWorkSheet.Cells[15, 3].Value2 = SelectBanking.Prava1[1];
            if (SelectBanking.Analog1[12] == "1")
            { ObjWorkSheet.Cells[16, 3].Value2 = "да"; }
            else { ObjWorkSheet.Cells[16, 3].Value2 = "нет"; }
            ObjWorkSheet.Cells[18, 3].Value2 = SelectBanking.Analog1[1];
            ObjWorkSheet.Cells[19, 3].Value2 = SelectBanking.TDMS1[1];
            ObjWorkSheet.Cells[20, 3].Value2 = SelectBanking.SD1[1];
            ObjWorkSheet.Cells[21, 3].Value2 = SelectBanking.Analog1[1];
            ObjWorkSheet.Cells[22, 3].Value2 = SelectBanking.VIO1[1];
            ObjWorkSheet.Cells[23, 3].Value2 = SelectBanking.NBL1[1];
            ObjWorkSheet.Cells[24, 3].Value2 = SelectBanking.TS1[1];
            ObjWorkSheet.Cells[26, 3].Value2 = SelectBanking.SOTR1[1];
            if (SelectBanking.Analog1[20] == "1")
            { ObjWorkSheet.Cells[27, 3].Value2 = "С учетом мебели и техники"; }
            else { ObjWorkSheet.Cells[27, 3].Value2 = "Без учета мебели и техники"; }


            //Analog2
            ObjWorkSheet.Cells[3, 4].Value2 = SelectBanking.Analog2[1];
            ObjWorkSheet.Cells[4, 4].Value2 = SelectBanking.Analog2[2];
            ObjWorkSheet.Cells[5, 4].Value2 = SelectBanking.Analog2[3];
            ObjWorkSheet.Cells[6, 4].Value2 = SelectBanking.Analog2[4];
            ObjWorkSheet.Cells[7, 4].Value2 = SelectBanking.Analog2[5];
            ObjWorkSheet.Cells[8, 4].Value2 = SelectBanking.Analog2[6];
            ObjWorkSheet.Cells[9, 4].Value2 = SelectBanking.Analog2[7];
            ObjWorkSheet.Cells[10, 4].Value2 = SelectBanking.SPP2[1];
            ObjWorkSheet.Cells[11, 4].Value2 = SelectBanking.Analog2[9];
            ObjWorkSheet.Cells[13, 4].Value2 = SelectBanking.USLFIN2[1];
            ObjWorkSheet.Cells[15, 4].Value2 = SelectBanking.Prava2[1];
            if (SelectBanking.Analog2[12] == "1")
            { ObjWorkSheet.Cells[16, 4].Value2 = "да"; }
            else { ObjWorkSheet.Cells[16, 4].Value2 = "нет"; }
            ObjWorkSheet.Cells[18, 4].Value2 = SelectBanking.Analog2[1];
            ObjWorkSheet.Cells[19, 4].Value2 = SelectBanking.TDMS2[1];
            ObjWorkSheet.Cells[20, 4].Value2 = SelectBanking.SD2[1];
            ObjWorkSheet.Cells[21, 4].Value2 = SelectBanking.Analog2[1];
            ObjWorkSheet.Cells[22, 4].Value2 = SelectBanking.VIO2[1];
            ObjWorkSheet.Cells[23, 4].Value2 = SelectBanking.NBL2[1];
            ObjWorkSheet.Cells[24, 4].Value2 = SelectBanking.TS2[1];
            ObjWorkSheet.Cells[26, 4].Value2 = SelectBanking.SOTR2[1];
            if (SelectBanking.Analog2[20] == "1")
            { ObjWorkSheet.Cells[27, 4].Value2 = "С учетом мебели и техники"; }
            else { ObjWorkSheet.Cells[27, 4].Value2 = "Без учета мебели и техники"; }


            //Analog3
            ObjWorkSheet.Cells[3, 5].Value2 = SelectBanking.Analog3[1];
            ObjWorkSheet.Cells[4, 5].Value2 = SelectBanking.Analog3[2];
            ObjWorkSheet.Cells[5, 5].Value2 = SelectBanking.Analog3[3];
            ObjWorkSheet.Cells[6, 5].Value2 = SelectBanking.Analog3[4];
            ObjWorkSheet.Cells[7, 5].Value2 = SelectBanking.Analog3[5];
            ObjWorkSheet.Cells[8, 5].Value2 = SelectBanking.Analog3[6];
            ObjWorkSheet.Cells[9, 5].Value2 = SelectBanking.Analog3[7];
            ObjWorkSheet.Cells[10, 5].Value2 = SelectBanking.SPP3[1];
            ObjWorkSheet.Cells[11, 5].Value2 = SelectBanking.Analog3[9];
            ObjWorkSheet.Cells[13, 5].Value2 = SelectBanking.USLFIN3[1];
            ObjWorkSheet.Cells[15, 5].Value2 = SelectBanking.Prava3[1];
            if (SelectBanking.Analog3[12] == "1")
            { ObjWorkSheet.Cells[16, 5].Value2 = "да"; }
            else { ObjWorkSheet.Cells[16, 5].Value2 = "нет"; }
            ObjWorkSheet.Cells[18, 5].Value2 = SelectBanking.Analog3[1];
            ObjWorkSheet.Cells[19, 5].Value2 = SelectBanking.TDMS3[1];
            ObjWorkSheet.Cells[20, 5].Value2 = SelectBanking.SD3[1];
            ObjWorkSheet.Cells[21, 5].Value2 = SelectBanking.Analog3[1];
            ObjWorkSheet.Cells[22, 5].Value2 = SelectBanking.VIO3[1];
            ObjWorkSheet.Cells[23, 5].Value2 = SelectBanking.NBL3[1];
            ObjWorkSheet.Cells[24, 5].Value2 = SelectBanking.TS3[1];
            ObjWorkSheet.Cells[26, 5].Value2 = SelectBanking.SOTR3[1];
            if (SelectBanking.Analog3[20] == "1")
            { ObjWorkSheet.Cells[27, 5].Value2 = "С учетом мебели и техники"; }
            else { ObjWorkSheet.Cells[27, 5].Value2 = "Без учета мебели и техники"; }


            //Analog4
            ObjWorkSheet.Cells[3, 6].Value2 = SelectBanking.Analog4[1];
            ObjWorkSheet.Cells[4, 6].Value2 = SelectBanking.Analog4[2];
            ObjWorkSheet.Cells[5, 6].Value2 = SelectBanking.Analog4[3];
            ObjWorkSheet.Cells[6, 6].Value2 = SelectBanking.Analog4[4];
            ObjWorkSheet.Cells[7, 6].Value2 = SelectBanking.Analog4[5];
            ObjWorkSheet.Cells[8, 6].Value2 = SelectBanking.Analog4[6];
            ObjWorkSheet.Cells[9, 6].Value2 = SelectBanking.Analog4[7];
            ObjWorkSheet.Cells[10, 6].Value2 = SelectBanking.SPP4[1];
            ObjWorkSheet.Cells[11, 6].Value2 = SelectBanking.Analog4[9];
            ObjWorkSheet.Cells[13, 6].Value2 = SelectBanking.USLFIN4[1];
            ObjWorkSheet.Cells[15, 6].Value2 = SelectBanking.Prava4[1];
            if (SelectBanking.Analog4[12] == "1")
            { ObjWorkSheet.Cells[16, 6].Value2 = "да"; }
            else { ObjWorkSheet.Cells[16, 6].Value2 = "нет"; }
            ObjWorkSheet.Cells[18, 6].Value2 = SelectBanking.Analog4[1];
            ObjWorkSheet.Cells[19, 6].Value2 = SelectBanking.TDMS4[1];
            ObjWorkSheet.Cells[20, 6].Value2 = SelectBanking.SD4[1];
            ObjWorkSheet.Cells[21, 6].Value2 = SelectBanking.Analog4[1];
            ObjWorkSheet.Cells[22, 6].Value2 = SelectBanking.VIO4[1];
            ObjWorkSheet.Cells[23, 6].Value2 = SelectBanking.NBL4[1];
            ObjWorkSheet.Cells[24, 6].Value2 = SelectBanking.TS4[1];
            ObjWorkSheet.Cells[26, 6].Value2 = SelectBanking.SOTR4[1];
            if (SelectBanking.Analog4[20] == "1")
            { ObjWorkSheet.Cells[27, 6].Value2 = "С учетом мебели и техники"; }
            else { ObjWorkSheet.Cells[27, 6].Value2 = "Без учета мебели и техники"; }

        }

        private void ExportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
