using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;
using yt_DesignUI;
using System.Data.SqlClient;


namespace graduatework.Forms
{
    public partial class Treaty : Form
    {

        string connectionString = "Server=localhost;Database=graduatedb; Integrated Security=True;";
        public Treaty()
        {
            InitializeComponent();

        }

        private void Treaty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПДоговор". При необходимости она может быть перемещена или удалена.
            this.пДоговорTableAdapter1.Fill(this.graduatedbDataSet.ПДоговор);
            //Century Gothic; 18pt; style = Underline
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 18f, FontStyle.Underline); //жирный курсив размера 16
        }

        private async void ADD_Click(object sender, EventArgs e)
        {
            editTreaty eT = new editTreaty();
            eT.ShowDialog();
            if (eT.Rc)
            {
                if (eT.NT != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Добавить договор?",
                        "Сообщение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            sqlConnection.Open();
                            ////ДОБАВЛЯЕМ "ДОГОВОР"
                            string sqlTextDogovorADD = "dbo.Договор_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextDogovorADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter NT = new SqlParameter
                                {
                                    ParameterName = "@РНомер",
                                    Value = eT.NT,
                                    Direction = ParameterDirection.Input
                                };
                                SqlParameter DT = new SqlParameter
                                {
                                    ParameterName = "@РДатаЗаключения",
                                    Value = eT.DT,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(NT);
                                sqlCommand.Parameters.Add(DT);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idDogovor = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВЛЯЕМ ПЕРЕЧНИ ДОКУМЕНТОВ
                            string sqlTextPasportADD = "dbo.УдостоверениеЛичности_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPasportADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Nalichie = new SqlParameter
                                {
                                    ParameterName = "@РНаличие",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Nalichie);

                                SqlParameter Name = new SqlParameter
                                {
                                    ParameterName = "@РНазвание",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Name);

                                SqlParameter Put = new SqlParameter
                                {
                                    ParameterName = "@РПуть",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Put);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idPasport = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextTehPasportADD = "dbo.ТехПаспорт_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextTehPasportADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Nalichie = new SqlParameter
                                {
                                    ParameterName = "@РНаличие",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Nalichie);

                                SqlParameter Name = new SqlParameter
                                {
                                    ParameterName = "@РНазвание",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Name);

                                SqlParameter Put = new SqlParameter
                                {
                                    ParameterName = "@РПуть",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Put);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idTehPasport = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextEGRNADD = "dbo.ВыпискаЕГРН_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextEGRNADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Nalichie = new SqlParameter
                                {
                                    ParameterName = "@РНаличие",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Nalichie);

                                SqlParameter Name = new SqlParameter
                                {
                                    ParameterName = "@РНазвание",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Name);

                                SqlParameter Put = new SqlParameter
                                {
                                    ParameterName = "@РПуть",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Put);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idEGRN = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextDocumentsADD = "dbo.ПереченьДокументов_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextDocumentsADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter EGRN = new SqlParameter
                                {
                                    ParameterName = "@РЕГРН",
                                    Value = AddBanking.idEGRN,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(EGRN);

                                SqlParameter TehPasport = new SqlParameter
                                {
                                    ParameterName = "@РТехПаспорт",
                                    Value = AddBanking.idTehPasport,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TehPasport);

                                SqlParameter Pasport = new SqlParameter
                                {
                                    ParameterName = "@РУдостоверениеЛичности",
                                    Value = AddBanking.idPasport,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pasport);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idDocuments = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВЛЯЕМ "ОБЪЕКТ ОЦЕНКИ"
                            string sqlTextObjectOtsenkaADD = "dbo.ОбъектОценки_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextObjectOtsenkaADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter SubRF = new SqlParameter
                                {
                                    ParameterName = "@РСубъектРФ",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SubRF);

                                SqlParameter NaselPunkt = new SqlParameter
                                {
                                    ParameterName = "@РНаселенныйПункт",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(NaselPunkt);

                                SqlParameter AdmRaion = new SqlParameter
                                {
                                    ParameterName = "@РАдминистративныйРайон",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AdmRaion);

                                SqlParameter Ulitsa = new SqlParameter
                                {
                                    ParameterName = "@РУлица",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Ulitsa);

                                SqlParameter TipPomesh = new SqlParameter
                                {
                                    ParameterName = "@РТипПомещения",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipPomesh);

                                SqlParameter KolvoKomnat = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоЖилыхКомнат",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoKomnat);

                                SqlParameter ObshPloshad = new SqlParameter
                                {
                                    ParameterName = "@РОбщаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(ObshPloshad);

                                SqlParameter OtsenkePodlezgit = new SqlParameter
                                {
                                    ParameterName = "@РОценкеПодлежит",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(OtsenkePodlezgit);

                                SqlParameter Kadastr = new SqlParameter
                                {
                                    ParameterName = "@РКадастровыйУсловныйНомер",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Kadastr);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idObjectOtsenki = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВЛЯЕМ "СРАВНИТЕЛЬНЫЙ НАЛОГ"
                            string sqlTextAnalog1ADD = "dbo.СравнительныйАналог1_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextAnalog1ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter AddressGorod = new SqlParameter
                                {
                                    ParameterName = "@РАдресГород",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressGorod);
                                SqlParameter AddressUlitsa = new SqlParameter
                                {
                                    ParameterName = "@РАдресУлица",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressUlitsa);
                                SqlParameter Istochnik = new SqlParameter
                                {
                                    ParameterName = "@РИсточникИнформации",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Istochnik);
                                SqlParameter PeredPrava = new SqlParameter
                                {
                                    ParameterName = "@РПередаваемыеПрава",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PeredPrava);
                                SqlParameter Torg = new SqlParameter
                                {
                                    ParameterName = "@РВозможностьТорга",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Torg);
                                SqlParameter SostoyanieDoma = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеДома",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SostoyanieDoma);
                                SqlParameter EtajAndVsego = new SqlParameter
                                {
                                    ParameterName = "@РЭтажВсегоЭтажей",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(EtajAndVsego);
                                SqlParameter VidIzOkna = new SqlParameter
                                {
                                    ParameterName = "@РВидИзОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VidIzOkna);
                                SqlParameter Balkon = new SqlParameter
                                {
                                    ParameterName = "@РБалконЛоджия",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Balkon);
                                SqlParameter TipRemonta = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеОтделкиТипРемонта",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipRemonta);
                                SqlParameter Mebel = new SqlParameter
                                {
                                    ParameterName = "@РНаличиеМебелиТехники",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Mebel);
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                SqlParameter UdelTsena = new SqlParameter
                                {
                                    ParameterName = "@РУдельнаяЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UdelTsena);
                                SqlParameter KolvoKomnat = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоКомнат",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoKomnat);
                                SqlParameter GodPostr = new SqlParameter
                                {
                                    ParameterName = "@РГодПостройки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodPostr);
                                SqlParameter TsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TsenaPredl);
                                SqlParameter PloshadZayavl = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьЗаявленная",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshadZayavl);
                                SqlParameter idSposobPodshPloshadi = new SqlParameter
                                {
                                    ParameterName = "@РКодСпособПодсчетаПлощади",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSposobPodshPloshadi);
                                SqlParameter FactPlosh = new SqlParameter
                                {
                                    ParameterName = "@РФактическаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(FactPlosh);
                                SqlParameter idUslFinance = new SqlParameter
                                {
                                    ParameterName = "@РКодУсловиеФинансирования",
                                    Value = Convert.ToInt32("1"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idUslFinance);
                                SqlParameter TipDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодТипДомаМатериалСтен",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipDoma);
                                SqlParameter TipSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РТипСанузла",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipSanuzlov);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idAnalog1 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextAnalog2ADD = "dbo.СравнительныйАналог2_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextAnalog2ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter AddressGorod = new SqlParameter
                                {
                                    ParameterName = "@РАдресГород",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressGorod);
                                SqlParameter AddressUlitsa = new SqlParameter
                                {
                                    ParameterName = "@РАдресУлица",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressUlitsa);
                                SqlParameter Istochnik = new SqlParameter
                                {
                                    ParameterName = "@РИсточникИнформации",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Istochnik);
                                SqlParameter PeredPrava = new SqlParameter
                                {
                                    ParameterName = "@РПередаваемыеПрава",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PeredPrava);
                                SqlParameter Torg = new SqlParameter
                                {
                                    ParameterName = "@РВозможностьТорга",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Torg);
                                SqlParameter SostoyanieDoma = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеДома",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SostoyanieDoma);
                                SqlParameter EtajAndVsego = new SqlParameter
                                {
                                    ParameterName = "@РЭтажВсегоЭтажей",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(EtajAndVsego);
                                SqlParameter VidIzOkna = new SqlParameter
                                {
                                    ParameterName = "@РВидИзОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VidIzOkna);
                                SqlParameter Balkon = new SqlParameter
                                {
                                    ParameterName = "@РБалконЛоджия",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Balkon);
                                SqlParameter TipRemonta = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеОтделкиТипРемонта",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipRemonta);
                                SqlParameter Mebel = new SqlParameter
                                {
                                    ParameterName = "@РНаличиеМебелиТехники",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Mebel);
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                SqlParameter UdelTsena = new SqlParameter
                                {
                                    ParameterName = "@РУдельнаяЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UdelTsena);
                                SqlParameter KolvoKomnat = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоКомнат",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoKomnat);
                                SqlParameter GodPostr = new SqlParameter
                                {
                                    ParameterName = "@РГодПостройки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodPostr);
                                SqlParameter TsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TsenaPredl);
                                SqlParameter PloshadZayavl = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьЗаявленная",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshadZayavl);
                                SqlParameter idSposobPodshPloshadi = new SqlParameter
                                {
                                    ParameterName = "@РКодСпособПодсчетаПлощади",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSposobPodshPloshadi);
                                SqlParameter FactPlosh = new SqlParameter
                                {
                                    ParameterName = "@РФактическаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(FactPlosh);
                                SqlParameter idUslFinance = new SqlParameter
                                {
                                    ParameterName = "@РКодУсловиеФинансирования",
                                    Value = Convert.ToInt32("1"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idUslFinance);
                                SqlParameter TipDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодТипДомаМатериалСтен",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipDoma);
                                SqlParameter TipSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РТипСанузла",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipSanuzlov);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idAnalog2 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextAnalog3ADD = "dbo.СравнительныйАналог3_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextAnalog3ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter AddressGorod = new SqlParameter
                                {
                                    ParameterName = "@РАдресГород",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressGorod);
                                SqlParameter AddressUlitsa = new SqlParameter
                                {
                                    ParameterName = "@РАдресУлица",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressUlitsa);
                                SqlParameter Istochnik = new SqlParameter
                                {
                                    ParameterName = "@РИсточникИнформации",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Istochnik);
                                SqlParameter PeredPrava = new SqlParameter
                                {
                                    ParameterName = "@РПередаваемыеПрава",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PeredPrava);
                                SqlParameter Torg = new SqlParameter
                                {
                                    ParameterName = "@РВозможностьТорга",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Torg);
                                SqlParameter SostoyanieDoma = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеДома",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SostoyanieDoma);
                                SqlParameter EtajAndVsego = new SqlParameter
                                {
                                    ParameterName = "@РЭтажВсегоЭтажей",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(EtajAndVsego);
                                SqlParameter VidIzOkna = new SqlParameter
                                {
                                    ParameterName = "@РВидИзОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VidIzOkna);
                                SqlParameter Balkon = new SqlParameter
                                {
                                    ParameterName = "@РБалконЛоджия",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Balkon);
                                SqlParameter TipRemonta = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеОтделкиТипРемонта",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipRemonta);
                                SqlParameter Mebel = new SqlParameter
                                {
                                    ParameterName = "@РНаличиеМебелиТехники",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Mebel);
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                SqlParameter UdelTsena = new SqlParameter
                                {
                                    ParameterName = "@РУдельнаяЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UdelTsena);
                                SqlParameter KolvoKomnat = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоКомнат",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoKomnat);
                                SqlParameter GodPostr = new SqlParameter
                                {
                                    ParameterName = "@РГодПостройки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodPostr);
                                SqlParameter TsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TsenaPredl);
                                SqlParameter PloshadZayavl = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьЗаявленная",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshadZayavl);
                                SqlParameter idSposobPodshPloshadi = new SqlParameter
                                {
                                    ParameterName = "@РКодСпособПодсчетаПлощади",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSposobPodshPloshadi);
                                SqlParameter FactPlosh = new SqlParameter
                                {
                                    ParameterName = "@РФактическаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(FactPlosh);
                                SqlParameter idUslFinance = new SqlParameter
                                {
                                    ParameterName = "@РКодУсловиеФинансирования",
                                    Value = Convert.ToInt32("1"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idUslFinance);
                                SqlParameter TipDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодТипДомаМатериалСтен",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipDoma);
                                SqlParameter TipSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РТипСанузла",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipSanuzlov);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idAnalog3 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextAnalog4ADD = "dbo.СравнительныйАналог4_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextAnalog4ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter AddressGorod = new SqlParameter
                                {
                                    ParameterName = "@РАдресГород",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressGorod);
                                SqlParameter AddressUlitsa = new SqlParameter
                                {
                                    ParameterName = "@РАдресУлица",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(AddressUlitsa);
                                SqlParameter Istochnik = new SqlParameter
                                {
                                    ParameterName = "@РИсточникИнформации",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Istochnik);
                                SqlParameter PeredPrava = new SqlParameter
                                {
                                    ParameterName = "@РПередаваемыеПрава",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PeredPrava);
                                SqlParameter Torg = new SqlParameter
                                {
                                    ParameterName = "@РВозможностьТорга",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Torg);
                                SqlParameter SostoyanieDoma = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеДома",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SostoyanieDoma);
                                SqlParameter EtajAndVsego = new SqlParameter
                                {
                                    ParameterName = "@РЭтажВсегоЭтажей",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(EtajAndVsego);
                                SqlParameter VidIzOkna = new SqlParameter
                                {
                                    ParameterName = "@РВидИзОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VidIzOkna);
                                SqlParameter Balkon = new SqlParameter
                                {
                                    ParameterName = "@РБалконЛоджия",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Balkon);
                                SqlParameter TipRemonta = new SqlParameter
                                {
                                    ParameterName = "@РСостояниеОтделкиТипРемонта",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipRemonta);
                                SqlParameter Mebel = new SqlParameter
                                {
                                    ParameterName = "@РНаличиеМебелиТехники",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Mebel);
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                SqlParameter UdelTsena = new SqlParameter
                                {
                                    ParameterName = "@РУдельнаяЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UdelTsena);
                                SqlParameter KolvoKomnat = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоКомнат",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoKomnat);
                                SqlParameter GodPostr = new SqlParameter
                                {
                                    ParameterName = "@РГодПостройки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodPostr);
                                SqlParameter TsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TsenaPredl);
                                SqlParameter PloshadZayavl = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьЗаявленная",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshadZayavl);
                                SqlParameter idSposobPodshPloshadi = new SqlParameter
                                {
                                    ParameterName = "@РКодСпособПодсчетаПлощади",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSposobPodshPloshadi);
                                SqlParameter FactPlosh = new SqlParameter
                                {
                                    ParameterName = "@РФактическаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(FactPlosh);
                                SqlParameter idUslFinance = new SqlParameter
                                {
                                    ParameterName = "@РКодУсловиеФинансирования",
                                    Value = Convert.ToInt32("1"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idUslFinance);
                                SqlParameter TipDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодТипДомаМатериалСтен",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipDoma);
                                SqlParameter TipSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РТипСанузла",
                                    Value = Convert.ToInt32("2"),
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TipSanuzlov);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idAnalog4 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВЛЯЕМ ПРАВООБЛАДАТЕЛЕЙ
                            string sqlTextPravoobladatel1ADD = "dbo.Правообладатель_ДОБАВИТЬ";
                            string sqlTextPravoobladatel2ADD = "dbo.Правообладатель2_ДОБАВИТЬ";
                            string sqlTextPravoobladatel3ADD = "dbo.Правообладатель3_ДОБАВИТЬ";
                            string sqlTextPravoobladatel4ADD = "dbo.Правообладатель4_ДОБАВИТЬ";
                            string sqlTextPravoobladatel5ADD = "dbo.Правообладатель5_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPravoobladatel1ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter Rojd = new SqlParameter
                                {
                                    ParameterName = "@РСвидетельствоОРождении",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Rojd);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Dolya = new SqlParameter
                                {
                                    ParameterName = "@РДоляВПраве",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Dolya);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idProvoobledatel1 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPravoobladatel2ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter Rojd = new SqlParameter
                                {
                                    ParameterName = "@РСвидетельствоОРождении",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Rojd);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Dolya = new SqlParameter
                                {
                                    ParameterName = "@РДоляВПраве",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Dolya);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idProvoobledatel2 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPravoobladatel3ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter Rojd = new SqlParameter
                                {
                                    ParameterName = "@РСвидетельствоОРождении",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Rojd);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Dolya = new SqlParameter
                                {
                                    ParameterName = "@РДоляВПраве",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Dolya);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idProvoobledatel3 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPravoobladatel4ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter Rojd = new SqlParameter
                                {
                                    ParameterName = "@РСвидетельствоОРождении",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Rojd);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Dolya = new SqlParameter
                                {
                                    ParameterName = "@РДоляВПраве",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Dolya);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idProvoobledatel4 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPravoobladatel5ADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter Rojd = new SqlParameter
                                {
                                    ParameterName = "@РСвидетельствоОРождении",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Rojd);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Dolya = new SqlParameter
                                {
                                    ParameterName = "@РДоляВПраве",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Dolya);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idProvoobledatel5 = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ ЗАКАЗЧИКОВ
                            string sqlTextUrZakazADD = "dbo.ЗаказчикЮридический_ДОБАВИТЬ";
                            string sqlTextPhysZakazADD = "dbo.Заказчик_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPhysZakazADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Familia = new SqlParameter
                                {
                                    ParameterName = "@РФамилия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Familia);
                                SqlParameter Imya = new SqlParameter
                                {
                                    ParameterName = "@РИмя",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Imya);
                                SqlParameter Otchestvo = new SqlParameter
                                {
                                    ParameterName = "@РОтчество",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otchestvo);
                                SqlParameter PasportSeriya = new SqlParameter
                                {
                                    ParameterName = "@РПаспортСерия",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PasportSeriya);
                                SqlParameter PasportNomer = new SqlParameter
                                {
                                    ParameterName = "@РПаспортНомер",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PasportNomer);
                                SqlParameter Address = new SqlParameter
                                {
                                    ParameterName = "@РАдрес",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Address);
                                SqlParameter Contact = new SqlParameter
                                {
                                    ParameterName = "@РКонтактнаяИнформация",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Contact);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idPhysZakaz = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextUrZakazADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Nname = new SqlParameter
                                {
                                    ParameterName = "@РНаименование",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Nname);
                                SqlParameter OGRN = new SqlParameter
                                {
                                    ParameterName = "@РОГРН",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(OGRN);
                                SqlParameter Mesto = new SqlParameter
                                {
                                    ParameterName = "@РМестоНахождения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };

                                sqlCommand.Parameters.Add(Mesto);
                                SqlParameter DateP = new SqlParameter
                                {
                                    ParameterName = "@РДатаПрисвоения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DateP);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idUrZakaz = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ ЭЛЕМЕНТЫ ОТДЕЛКИ
                            string sqlTextKomnatiADD = "dbo.Комнаты_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextKomnatiADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Steni = new SqlParameter
                                {
                                    ParameterName = "@РСтены",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Steni);
                                SqlParameter Poli = new SqlParameter
                                {
                                    ParameterName = "@РПолы",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Poli);
                                SqlParameter Potolok = new SqlParameter
                                {
                                    ParameterName = "@РПотолок",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Potolok);
                                SqlParameter Okna = new SqlParameter
                                {
                                    ParameterName = "@РОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Okna);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idKomnati = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextKuhnyaADD = "dbo.Кухня_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextKuhnyaADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Steni = new SqlParameter
                                {
                                    ParameterName = "@РСтены",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Steni);
                                SqlParameter Poli = new SqlParameter
                                {
                                    ParameterName = "@РПолы",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Poli);
                                SqlParameter Potolok = new SqlParameter
                                {
                                    ParameterName = "@РПотолок",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Potolok);
                                SqlParameter Okna = new SqlParameter
                                {
                                    ParameterName = "@РОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Okna);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idKuhnya = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextSanuzliADD = "dbo.Санузлы_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextSanuzliADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Steni = new SqlParameter
                                {
                                    ParameterName = "@РСтены",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Steni);
                                SqlParameter Poli = new SqlParameter
                                {
                                    ParameterName = "@РПолы",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Poli);
                                SqlParameter Potolok = new SqlParameter
                                {
                                    ParameterName = "@РПотолок",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Potolok);
                                SqlParameter Okna = new SqlParameter
                                {
                                    ParameterName = "@РОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Okna);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idSanuzli = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextInieADD = "dbo.Иные_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextInieADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Steni = new SqlParameter
                                {
                                    ParameterName = "@РСтены",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Steni);
                                SqlParameter Poli = new SqlParameter
                                {
                                    ParameterName = "@РПолы",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Poli);
                                SqlParameter Potolok = new SqlParameter
                                {
                                    ParameterName = "@РПотолок",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Potolok);
                                SqlParameter Okna = new SqlParameter
                                {
                                    ParameterName = "@РОкна",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Okna);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idInie = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextOtdelkaADD = "dbo.Отделка_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextOtdelkaADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter DverVhod = new SqlParameter
                                {
                                    ParameterName = "@РВходнаяДверь",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DverVhod);
                                SqlParameter DverKomnati = new SqlParameter
                                {
                                    ParameterName = "@РМежкомнатныеДвери",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DverKomnati);
                                SqlParameter KomnatiKod = new SqlParameter
                                {
                                    ParameterName = "@РКодКомнаты",
                                    Value = AddBanking.idKomnati,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KomnatiKod);
                                SqlParameter KuhnyaKod = new SqlParameter
                                {
                                    ParameterName = "@РКодКухня",
                                    Value = AddBanking.idKuhnya,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KuhnyaKod);
                                SqlParameter SanuzliKod = new SqlParameter
                                {
                                    ParameterName = "@РКодСанузлы",
                                    Value = AddBanking.idSanuzli,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SanuzliKod);
                                SqlParameter InieKod = new SqlParameter
                                {
                                    ParameterName = "@РКодИные",
                                    Value = AddBanking.idInie,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(InieKod);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idOtdelka = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ ЗАДАНИЕ НА ОЦЕНКУ
                            string sqlTextZadanieNaOtsenkuADD = "dbo.ЗаданиеНаОценку_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextZadanieNaOtsenkuADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter KodObjectOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РКодОбъектОценки",
                                    Value = AddBanking.idObjectOtsenki,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodObjectOtsenki);

                                SqlParameter KodDocuments = new SqlParameter
                                {
                                    ParameterName = "@РКодПереченьДокументовДляОценки",
                                    Value = AddBanking.idDocuments,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodDocuments);

                                SqlParameter Obremeneniya = new SqlParameter
                                {
                                    ParameterName = "@РКодНаличиеОбременений",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Obremeneniya);

                                SqlParameter ChObremeneniya = new SqlParameter
                                {
                                    ParameterName = "@РКодХарактерОбременений",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(ChObremeneniya);

                                SqlParameter KolvoSobstv = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоСобственников",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoSobstv);

                                SqlParameter PhysUr = new SqlParameter
                                {
                                    ParameterName = "@РФизическоеЮридическоеЛицо",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PhysUr);

                                SqlParameter Pravoobl1 = new SqlParameter
                                {
                                    ParameterName = "@РКодПравообладателя1",
                                    Value = AddBanking.idProvoobledatel1,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pravoobl1);
                                SqlParameter Pravoobl2 = new SqlParameter
                                {
                                    ParameterName = "@РКодПравообладателя2",
                                    Value = AddBanking.idProvoobledatel2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pravoobl2);
                                SqlParameter Pravoobl3 = new SqlParameter
                                {
                                    ParameterName = "@РКодПравообладателя3",
                                    Value = AddBanking.idProvoobledatel3,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pravoobl3);
                                SqlParameter Pravoobl4 = new SqlParameter
                                {
                                    ParameterName = "@РКодПравообладателя4",
                                    Value = AddBanking.idProvoobledatel4,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pravoobl4);
                                SqlParameter Pravoobl5 = new SqlParameter
                                {
                                    ParameterName = "@РКодПравообладателя5",
                                    Value = AddBanking.idProvoobledatel5,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pravoobl5);

                                SqlParameter PhysLitso = new SqlParameter
                                {
                                    ParameterName = "@РКодЗаказчикаФизический",
                                    Value = AddBanking.idPhysZakaz,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PhysLitso);

                                SqlParameter UrLitso = new SqlParameter
                                {
                                    ParameterName = "@РКодЗаказчикаЮридический",
                                    Value = AddBanking.idUrZakaz,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UrLitso);

                                SqlParameter DogovorKod = new SqlParameter
                                {
                                    ParameterName = "@РНомерДоговораНаОценку",
                                    Value = AddBanking.idDogovor,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DogovorKod);

                                SqlParameter TIPNOO = new SqlParameter
                                {
                                    ParameterName = "@РКодТекущиеИмущественныеПраваНаОбъектОценки",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TIPNOO);

                                SqlParameter VidStoimosti = new SqlParameter
                                {
                                    ParameterName = "@РКодВидСтоимости",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VidStoimosti);

                                SqlParameter TselOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РЦельОценки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TselOtsenki);

                                SqlParameter IspRez = new SqlParameter
                                {
                                    ParameterName = "@РИспользованиеРезультатов",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(IspRez);
                                SqlParameter DOsm = new SqlParameter
                                {
                                    ParameterName = "@РДатаОсмотра",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DOsm);
                                SqlParameter DOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РДатаОценки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DOtsenki);
                                SqlParameter DSO = new SqlParameter
                                {
                                    ParameterName = "@РДатаСоставленияОтчета",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DSO);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idZadanieNaOtsenku = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ Идентификация и характеристика местоположения объекта оценки
                            string sqlTextIIXMOADD = "dbo.ИндентификацияИХаркаМестополженияОбъекта_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextIIXMOADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter KodObjectOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РКодОбъектаОценки",
                                    Value = AddBanking.idObjectOtsenki,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodObjectOtsenki);
                                SqlParameter KodLRM = new SqlParameter
                                {
                                    ParameterName = "@РКодЛокальноеРасположениеВнутриМикрорайона",
                                    Value = 1,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodLRM);
                                SqlParameter KodPreoblZastroyka = new SqlParameter
                                {
                                    ParameterName = "@РКодПреобладающаяЗастройка",
                                    Value = 1,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodPreoblZastroyka);
                                SqlParameter KodTransportDostup = new SqlParameter
                                {
                                    ParameterName = "@РКодТранспортнаяДоступность",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodTransportDostup);
                                SqlParameter KodOOT = new SqlParameter
                                {
                                    ParameterName = "@РКодОбеспеченнностьОбщТранспортом",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodOOT);
                                SqlParameter KodEOR = new SqlParameter
                                {
                                    ParameterName = "@РКодЭкологичестваяОбстановкаРайона",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodEOR);
                                SqlParameter KodOOSI = new SqlParameter
                                {
                                    ParameterName = "@РКодОбеспеченностьОбъектамиСоцИнфраструктуры",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodOOSI);
                                SqlParameter KodObjectSIPeshaya = new SqlParameter
                                {
                                    ParameterName = "@РОбъектыСоцИнфраструктурыПешая",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodObjectSIPeshaya);
                                SqlParameter KodObjectPromInf = new SqlParameter
                                {
                                    ParameterName = "@РОбъектыПромИнфраструктуры",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodObjectPromInf);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idIIXMO = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ Общая характеристика здания														
                            string sqlTextOXZADD = "dbo.ОбщаяХаркаЗдания_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextOXZADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter KodTipDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодТипДомаМатериалСтен",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodTipDoma);

                                SqlParameter Etajnost = new SqlParameter
                                {
                                    ParameterName = "@РЭтажность",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Etajnost);

                                SqlParameter KodMaterialPerek = new SqlParameter
                                {
                                    ParameterName = "@РКодМатериалПерекрытий",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodMaterialPerek);

                                SqlParameter GodPostr = new SqlParameter
                                {
                                    ParameterName = "@РГодПостройки",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodPostr);

                                SqlParameter GodKapRemonta = new SqlParameter
                                {
                                    ParameterName = "@РГодПоследнегоКапРемонта",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GodKapRemonta);

                                SqlParameter FactSrok = new SqlParameter
                                {
                                    ParameterName = "@РФактическийСрокСлужбы",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(FactSrok);

                                SqlParameter KodSostDoma = new SqlParameter
                                {
                                    ParameterName = "@РКодСостояниеДома",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodSostDoma);

                                SqlParameter KodSostVneshOtdelki = new SqlParameter
                                {
                                    ParameterName = "@РКодСостояниеВнешнейОтделки",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodSostVneshOtdelki);

                                SqlParameter KodDomofon = new SqlParameter
                                {
                                    ParameterName = "@РКодДомофон",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodDomofon);

                                SqlParameter KodParkovka = new SqlParameter
                                {
                                    ParameterName = "@РКодПарковка",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodParkovka);

                                SqlParameter KodNOPT = new SqlParameter
                                {
                                    ParameterName = "@РКодНаличиеОгражденнойПридомовойТерритории",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodNOPT);

                                SqlParameter KodNOP = new SqlParameter
                                {
                                    ParameterName = "@РКодНаличиеОбъектовПривлекательности",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodNOP);

                                SqlParameter KodSostPodjezd = new SqlParameter
                                {
                                    ParameterName = "@РКодСостояниеПодъезда",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodSostPodjezd);

                                SqlParameter KodDetPloshadka = new SqlParameter
                                {
                                    ParameterName = "@РКодДетскаяПлощадка",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodDetPloshadka);

                                SqlParameter KodGreenNasajd = new SqlParameter
                                {
                                    ParameterName = "@РКодЗеленыеНасаждения",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodGreenNasajd);

                                SqlParameter PhysIznos = new SqlParameter
                                {
                                    ParameterName = "@РОбщийФизическийИзнос",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PhysIznos);

                                SqlParameter DopInfa = new SqlParameter
                                {
                                    ParameterName = "@РДопИнформация",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(DopInfa);
                                SqlParameter MOPI = new SqlParameter
                                {
                                    ParameterName = "@РКодМетодОпределенияФизИзноса",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(MOPI);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idOXZ = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ Характеристика объекта оценки														
                            string sqlTextHarkaObjectaOtsenkiADD = "dbo.ХаркаОбъектаОценки_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextHarkaObjectaOtsenkiADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {

                                SqlParameter KodObjectOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РКодОбъектаОценки",
                                    Value = AddBanking.idObjectOtsenki,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodObjectOtsenki);

                                SqlParameter KodNaznachenye = new SqlParameter
                                {
                                    ParameterName = "@РКодНазначение",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodNaznachenye);

                                SqlParameter KodTekusheeIspolzovanie = new SqlParameter
                                {
                                    ParameterName = "@РКодТекущееИспользование",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodTekusheeIspolzovanie);

                                SqlParameter Etaj = new SqlParameter
                                {
                                    ParameterName = "@РЭтажРасположения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Etaj);

                                SqlParameter JilayaPloshad = new SqlParameter
                                {
                                    ParameterName = "@РЖилаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(JilayaPloshad);

                                SqlParameter PloshKomnata1 = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьКомнаты1",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshKomnata1);

                                SqlParameter PloshKomnata2 = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьКомнаты2",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshKomnata2);

                                SqlParameter PloshKomnata3 = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьКомнаты3",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshKomnata3);

                                SqlParameter PloshKomnata4 = new SqlParameter
                                {
                                    ParameterName = "@РПлощадьКомнаты4",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PloshKomnata4);

                                SqlParameter Kuhnya = new SqlParameter
                                {
                                    ParameterName = "@РКухня",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Kuhnya);

                                SqlParameter KolvoSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РКолвоСанузлов",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoSanuzlov);

                                SqlParameter KodTipSanuzlov = new SqlParameter
                                {
                                    ParameterName = "@РКодТипСанузлов",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodTipSanuzlov);

                                SqlParameter VisotaPotolkov = new SqlParameter
                                {
                                    ParameterName = "@РВысотаПотолкой",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(VisotaPotolkov);

                                SqlParameter BolkonLodjiya = new SqlParameter
                                {
                                    ParameterName = "@РБалконЛоджия",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(BolkonLodjiya);

                                SqlParameter HarkaBalkona = new SqlParameter
                                {
                                    ParameterName = "@РКодХарактеристикаБалконаЛоджии",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(HarkaBalkona);

                                SqlParameter KodVidIzOkon = new SqlParameter
                                {
                                    ParameterName = "@РКодВидИзОкон",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodVidIzOkon);

                                SqlParameter KodDannieOPereplanirovke = new SqlParameter
                                {
                                    ParameterName = "@РКодДанныеОПерепланировке",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodDannieOPereplanirovke);

                                SqlParameter KodTipOtdelki = new SqlParameter
                                {
                                    ParameterName = "@РКодТипОтделки",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodTipOtdelki);

                                SqlParameter KolvoBalkonov = new SqlParameter
                                {
                                    ParameterName = "@РКоличествоБалконовЛоджий",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KolvoBalkonov);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idHarkaObjectaOtsenki = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ Инженерное обеспечение			
                            string sqlTextInjenernoeObespADD = "dbo.ИнженерноеОбеспечение_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextInjenernoeObespADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {

                                SqlParameter HV = new SqlParameter
                                {
                                    ParameterName = "@РХолодноеВодоснабжение",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(HV);

                                SqlParameter GV = new SqlParameter
                                {
                                    ParameterName = "@РГорячееВодоснабжение",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GV);

                                SqlParameter GAS = new SqlParameter
                                {
                                    ParameterName = "@РГаз",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(GAS);

                                SqlParameter Electro = new SqlParameter
                                {
                                    ParameterName = "@РЭлектроснабжение",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Electro);

                                SqlParameter Otoplenie = new SqlParameter
                                {
                                    ParameterName = "@РОтопление",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Otoplenie);

                                SqlParameter Lift = new SqlParameter
                                {
                                    ParameterName = "@РЛифт",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Lift);

                                SqlParameter Musor = new SqlParameter
                                {
                                    ParameterName = "@РМусоропровод",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Musor);

                                SqlParameter Kanal = new SqlParameter
                                {
                                    ParameterName = "@РКанализация",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Kanal);

                                SqlParameter InternetPhone = new SqlParameter
                                {
                                    ParameterName = "@РИнтернетТелефон",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(InternetPhone);

                                SqlParameter Konsierj = new SqlParameter
                                {
                                    ParameterName = "@РКонсьерж",
                                    Value = "0",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Konsierj);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idInjenernoeObesp = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ Экспертная оценка технического состояния
                            string sqlTextEOTSADD = "dbo.ЭкспертнаяОценкаТехСостояния_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextEOTSADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {

                                SqlParameter Fund = new SqlParameter
                                {
                                    ParameterName = "@РФундаменты",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Fund);

                                SqlParameter Steni = new SqlParameter
                                {
                                    ParameterName = "@РСтены",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Steni);

                                SqlParameter Peregorodki = new SqlParameter
                                {
                                    ParameterName = "@РПерегородки",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Peregorodki);

                                SqlParameter Perekr = new SqlParameter
                                {
                                    ParameterName = "@РПерекрытия",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Perekr);

                                SqlParameter Krisha = new SqlParameter
                                {
                                    ParameterName = "@РКрыша",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Krisha);

                                SqlParameter Poli = new SqlParameter
                                {
                                    ParameterName = "@РПолы",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Poli);

                                SqlParameter Lestnitsa = new SqlParameter
                                {
                                    ParameterName = "@РЛестницы",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Lestnitsa);

                                SqlParameter OknaAndDveri = new SqlParameter
                                {
                                    ParameterName = "@РОкнаИДвери",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(OknaAndDveri);

                                SqlParameter OtdelkaVnut = new SqlParameter
                                {
                                    ParameterName = "@РОтделкаВнутренняя",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(OtdelkaVnut);

                                SqlParameter SanTehUstr = new SqlParameter
                                {
                                    ParameterName = "@РСанТехУстройства",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SanTehUstr);

                                SqlParameter CentrOtopl = new SqlParameter
                                {
                                    ParameterName = "@РЦентральноеОтопление",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(CentrOtopl);

                                SqlParameter Bodopr = new SqlParameter
                                {
                                    ParameterName = "@РВодопровод",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Bodopr);

                                SqlParameter HotWater = new SqlParameter
                                {
                                    ParameterName = "@РГорядееВодоснабжение",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(HotWater);

                                SqlParameter Kanal = new SqlParameter
                                {
                                    ParameterName = "@РКанализация",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Kanal);

                                SqlParameter Electro = new SqlParameter
                                {
                                    ParameterName = "@РЭлектроосвещение",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Electro);

                                SqlParameter Gas = new SqlParameter
                                {
                                    ParameterName = "@РГаз",
                                    Value = "1",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Gas);

                                SqlParameter Vivod = new SqlParameter
                                {
                                    ParameterName = "@РВывод",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Vivod);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idEOTS = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ ОПИСАНИЕ ФОРМУЛЯР
                            string sqlTextOpisanieFormulyarADD = "dbo.ОписаниеФормуляр_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextOpisanieFormulyarADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter idIIXMO = new SqlParameter
                                {
                                    ParameterName = "@РКодИдентификацияИХаркаМестоположенияОбъектаОЦенки",
                                    Value = AddBanking.idIIXMO,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idIIXMO);
                                SqlParameter idOXZ = new SqlParameter
                                {
                                    ParameterName = "@РКодОбщаяХаркаЗдания",
                                    Value = AddBanking.idOXZ,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idOXZ);
                                SqlParameter idHarkaObjectaOtsenki = new SqlParameter
                                {
                                    ParameterName = "@РКодХаркаОбъектаОценки",
                                    Value = AddBanking.idHarkaObjectaOtsenki,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idHarkaObjectaOtsenki);
                                SqlParameter idInjenernoeObesp = new SqlParameter
                                {
                                    ParameterName = "@РКодИнженерноеОбеспечение",
                                    Value = AddBanking.idInjenernoeObesp,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idInjenernoeObesp);
                                SqlParameter idOtdelka = new SqlParameter
                                {
                                    ParameterName = "@РКодОтделка",
                                    Value = AddBanking.idOtdelka,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idOtdelka);
                                SqlParameter idEOTS = new SqlParameter
                                {
                                    ParameterName = "@РКодЭкспертнаяОценкаТехСостояния",
                                    Value = AddBanking.idEOTS,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idEOTS);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idOpisanieFormulyar = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВЛЯЕМ РАСЧЕТЫ ИЗНОСОВ
                            string sqlTextPhysIznosADD = "dbo.РасчетФизИзноса_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextPhysIznosADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter NSSPDR = new SqlParameter
                                {
                                    ParameterName = "@РНормативныйСрокСлужбыПринятыйДляРасчетов",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(NSSPDR);
                                SqlParameter SOFSS = new SqlParameter
                                {
                                    ParameterName = "@РСпособОпределенияФактическогоСрокаСлужбы",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(SOFSS);
                                SqlParameter idOXZ = new SqlParameter
                                {
                                    ParameterName = "@РОбщаяХарактеристикаЗдания",
                                    Value = AddBanking.idOXZ,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idOXZ);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idPhysIznos = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextMethodADD = "dbo.МетодыРасчета_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextMethodADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter Phys = new SqlParameter
                                {
                                    ParameterName = "@РЗначениеФизическогоИзноса",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Phys);
                                SqlParameter Meth = new SqlParameter
                                {
                                    ParameterName = "@РПринятыйМетод",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Meth);
                                SqlParameter Pasport = new SqlParameter
                                {
                                    ParameterName = "@РФизИзносПаспорт",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Pasport);
                                SqlParameter PIzn = new SqlParameter
                                {
                                    ParameterName = "@РПринятыйИзнос",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PIzn);


                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idMethod = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextIznosADD = "dbo.РасчетИзноса_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextIznosADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter RFIZ = new SqlParameter
                                {
                                    ParameterName = "@РРасчетФизическогоИзносаЗдания",
                                    Value = AddBanking.idPhysIznos,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(RFIZ);
                                SqlParameter Metod = new SqlParameter
                                {
                                    ParameterName = "@РМетодРасчета",
                                    Value = AddBanking.idMethod,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Metod);

                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idIznos = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ СРАВНИТЕЛЬНЫЙ ОБЪЕКТ ОЦЕНКИ И "СРАВНИТЕЛЬНЫЙ"
                            string sqlTextSravnObjectADD = "dbo.СравнительныйОбъект_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextSravnObjectADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {

                                SqlParameter TsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(TsenaPredl);
                                SqlParameter KodSposobPodsPlosh = new SqlParameter
                                {
                                    ParameterName = "@РКодСпособПодсчетаПлощади",
                                    Value = 2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodSposobPodsPlosh);
                                SqlParameter KodFactPlosh = new SqlParameter
                                {
                                    ParameterName = "@РФактическаяПлощадь",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodFactPlosh);
                                SqlParameter KodUslFinance = new SqlParameter
                                {
                                    ParameterName = "@РКодУсловиеФинансирования",
                                    Value = 1,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(KodUslFinance);
                                SqlParameter idZadanieNaOtsenku = new SqlParameter
                                {
                                    ParameterName = "@РКодЗаданияНаОценку",
                                    Value = AddBanking.idZadanieNaOtsenku,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idZadanieNaOtsenku);

                                SqlParameter Istochnik = new SqlParameter
                                {
                                    ParameterName = "@РИсточникИнформации",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Istochnik);
                                SqlParameter PeredPrava = new SqlParameter
                                {
                                    ParameterName = "@РПередаваемыеПрава",
                                    Value = "2",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(PeredPrava);
                                SqlParameter Torg = new SqlParameter
                                {
                                    ParameterName = "@РВозможностьТорга",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Torg);
                                SqlParameter Mebel = new SqlParameter
                                {
                                    ParameterName = "@РНаличиеМебелиТехники",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(Mebel);
                                SqlParameter UdelTsenaPredl = new SqlParameter
                                {
                                    ParameterName = "@РУдельнаяЦенаПредложения",
                                    Value = "",
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(UdelTsenaPredl);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idSravnObject = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }
                            string sqlTextSravnADD = "dbo.Сравнительный_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextSravnADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter idSravnObject = new SqlParameter
                                {
                                    ParameterName = "@РКодОбъекта",
                                    Value = AddBanking.idSravnObject,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSravnObject);
                                SqlParameter idAnalog1 = new SqlParameter
                                {
                                    ParameterName = "@РКодАналога1",
                                    Value = AddBanking.idAnalog1,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idAnalog1);
                                SqlParameter idAnalog2 = new SqlParameter
                                {
                                    ParameterName = "@РКодАналога2",
                                    Value = AddBanking.idAnalog2,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idAnalog2);
                                SqlParameter idAnalog3 = new SqlParameter
                                {
                                    ParameterName = "@РКодАналога3",
                                    Value = AddBanking.idAnalog3,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idAnalog3);
                                SqlParameter idAnalog4 = new SqlParameter
                                {
                                    ParameterName = "@РКодАналога4",
                                    Value = AddBanking.idAnalog4,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idAnalog4);
                                SqlParameter OUTID = new SqlParameter
                                {
                                    ParameterName = "@OUTID",
                                    SqlDbType = SqlDbType.Int,
                                    Direction = ParameterDirection.Output
                                };
                                sqlCommand.Parameters.Add(OUTID);
                                await sqlCommand.ExecuteNonQueryAsync();
                                AddBanking.idSravn = Convert.ToInt32(sqlCommand.Parameters["@OUTID"].Value);
                            }

                            ////ДОБАВИТЬ ОТЧЕТ
                            string sqlTextOtchetADD = "dbo.Отчет_ДОБАВИТЬ";
                            using (SqlCommand sqlCommand = new SqlCommand(sqlTextOtchetADD, sqlConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                SqlParameter idOpisanieFormulyar = new SqlParameter
                                {
                                    ParameterName = "@РКодОписаниеФормуляр",
                                    Value = AddBanking.idOpisanieFormulyar,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idOpisanieFormulyar);
                                SqlParameter idZadanieNaOtsenku = new SqlParameter
                                {
                                    ParameterName = "@РКодЗаданиеНаОценку",
                                    Value = AddBanking.idZadanieNaOtsenku,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idZadanieNaOtsenku);
                                SqlParameter idSravn = new SqlParameter
                                {
                                    ParameterName = "@РКодСравнительный",
                                    Value = AddBanking.idSravn,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idSravn);
                                SqlParameter idIznos = new SqlParameter
                                {
                                    ParameterName = "@РКодРасчетИзноса",
                                    Value = AddBanking.idIznos,
                                    Direction = ParameterDirection.Input
                                };
                                sqlCommand.Parameters.Add(idIznos);


                                await sqlCommand.ExecuteNonQueryAsync();

                            }

                            //ОЧИСТИМ КЛАСС ОТ ДАННЫХ ДОБАВЛЕНИЯ ДЛЯ СЛЕДУЮЩИХ ДОБАВЛЕНИЙ
                            AddBanking.ClearAdd();
                        }
                        this.пДоговорTableAdapter1.Fill(this.graduatedbDataSet.ПДоговор);

                    }
                }
                else
                {
                    MessageBox.Show(
                        "Введите название договора",
                        "Сообщение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                }
            } // if
            
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataRowView rowt;
            //    rowt = (DataRowView)this.пДоговорBindingSource.Current;
            //    int Id = (int)rowt.Row.ItemArray[0];
            //    this.queriesTableAdapter1.Договор_УДАЛИТЬ(Id);

            //    this.пДоговорTableAdapter.Fill(this.graduatedbDataSet.ПДоговор);
            //}
            //catch { }

            DeleteBanking.idDogovor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show(
    "Удалить договор?",
    "Сообщение",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    //ПОЛУЧИТЬ ЗАДАНИЕ НА ОЦЕНКУ
                    string zaprosZNO = "SELECT * FROM ЗаданиеНаОценку WHERE НомерДоговораНаОценку = @РНомерДоговораНаОценку";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosZNO, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РНомерДоговораНаОценку",
                            Value = DeleteBanking.idDogovor,
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.ZadanieNaOtcenku = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.ZadanieNaOtcenku[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosObjectOtcenki = "SELECT * FROM ОбъектОценки WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosObjectOtcenki, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.ObjectOtsenki = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.ObjectOtsenki[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ОТЧЕТ
                    string zaprosOtchet = "SELECT * FROM Отчет WHERE КодЗаданиеНаОценку = @КодЗаданиеНаОценку";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosOtchet, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@КодЗаданиеНаОценку",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[0]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Otchet = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Otchet[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ПЕРЕЧНИ ДОКУМЕНТОВ
                    string zaprosDocuments = "SELECT * FROM ПереченьДокументов WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosDocuments, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[2]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Documents = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Documents[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosEGRN = "SELECT * FROM ВыпискаЕГРН WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosEGRN, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Documents[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.EGRN = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.EGRN[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosTehPasport = "SELECT * FROM ТехническийПаспорт WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosTehPasport, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Documents[2]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.TehPasport = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.TehPasport[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosPasport = "SELECT * FROM УдостоверениеЛичности WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPasport, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Documents[3]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Pasport = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Pasport[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ПРАВООБЛАДАТЕЛЕЙ
                    string zaprosPravoobl1 = "SELECT * FROM Правообладатель1 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl1, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[7]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Provoobledatel1 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Provoobledatel1[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosPravoobl2 = "SELECT * FROM Правообладатель2 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl2, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[16]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Provoobledatel2 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Provoobledatel2[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosPravoobl3 = "SELECT * FROM Правообладатель3 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl3, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[17]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Provoobledatel3 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Provoobledatel3[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosPravoobl4 = "SELECT * FROM Правообладатель4 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl4, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[18]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Provoobledatel4 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Provoobledatel4[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosPravoobl5 = "SELECT * FROM Правообладатель5 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl5, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[19]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Provoobledatel5 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Provoobledatel5[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ЗАКАЗЧИКОВ
                    string zaprosPhysZakaz = "SELECT * FROM Заказчик WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosPhysZakaz, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[8]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.PhysZakaz = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.PhysZakaz[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosUrZakaz = "SELECT * FROM ЗаказчикЮридический WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosUrZakaz, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[20]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.UrZakaz = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.UrZakaz[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ СРАВНИТЕЛЬНЫЙ
                    string zaprosSravn = "SELECT * FROM Сравнительный WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravn, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otchet[3]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Sravn = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Sravn[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSravnObject = "SELECT * FROM СравнительныйОбъект WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravnObject, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Sravn[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.SravnObject = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.SravnObject[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSravnAnalog1 = "SELECT * FROM СравнительныйАналог1 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog1, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Sravn[2]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Analog1 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Analog1[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSravnAnalog2 = "SELECT * FROM СравнительныйАналог2 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog2, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Sravn[3]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Analog2 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Analog2[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSravnAnalog3 = "SELECT * FROM СравнительныйАналог3 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog3, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Sravn[4]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Analog3 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Analog3[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSravnAnalog4 = "SELECT * FROM СравнительныйАналог4 WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog4, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Sravn[5]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Analog4 = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Analog4[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ РАСЧЕТ ИЗНОСА
                    string zaprosRaschetIznosa = "SELECT * FROM РасчетИзноса WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosRaschetIznosa, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otchet[4]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Iznos = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Iznos[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosRaschetPhysIznosa = "SELECT * FROM РасчетФизическогоИзносаЗдания WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosRaschetPhysIznosa, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Iznos[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.PhysIznos = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.PhysIznos[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosMethodRascheta = "SELECT * FROM МетодыРасчета WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosMethodRascheta, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Iznos[2]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Method = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Method[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ОПИСАНИЕ ФОРМУЛЯР
                    string zaprosFormulyar = "SELECT * FROM ОписаниеФормуляр WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosFormulyar, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otchet[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.OpisanieFormulyar = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.OpisanieFormulyar[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosIIXMOO = "SELECT * FROM ИдентификацияИХаркаМестоположенияОбъектаОценки WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosIIXMOO, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[1]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.IIXMO = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.IIXMO[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosOXZ = "SELECT * FROM ОбщаяХаркаЗдания WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosOXZ, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[2]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.OXZ = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.OXZ[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosXOO = "SELECT * FROM ХаркаОбъектаОценки WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosXOO, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[3]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.HarkaObjectaOtsenki = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.HarkaObjectaOtsenki[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosInjener = "SELECT * FROM ИнженерноеОбеспечение WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosInjener, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[4]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.InjenernoeObesp = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.InjenernoeObesp[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosOtdelka = "SELECT * FROM Отделка WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosOtdelka, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[5]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Otdelka = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Otdelka[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosEOTS = "SELECT * FROM ЭкспертнаяОценкаТехСостояния WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosEOTS, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.OpisanieFormulyar[6]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.EOTS = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.EOTS[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    //ПОЛУЧИТЬ ЭЛЕМЕНТЫ ОТДЕЛКИ
                    string zaprosKomnati = "SELECT * FROM Комнаты WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosKomnati, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otdelka[3]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Komnati = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Komnati[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosKuhnya = "SELECT * FROM Кухня WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosKuhnya, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otdelka[4]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Kuhnya = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Kuhnya[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosSanuzli = "SELECT * FROM Санузлы WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosSanuzli, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otdelka[5]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Sanuzli = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Sanuzli[i] = dt.Rows[0][i].ToString();
                        }
                    }
                    string zaprosInie = "SELECT * FROM Иные WHERE Код = @РКод";
                    using (SqlCommand sqlCom = new SqlCommand(zaprosInie, sqlConn))
                    {
                        SqlParameter Kode = new SqlParameter
                        {
                            ParameterName = "@РКод",
                            Value = Convert.ToInt32(DeleteBanking.Otdelka[6]),
                            Direction = ParameterDirection.Input
                        };
                        sqlCom.Parameters.Add(Kode);
                        SqlDataReader dr = sqlCom.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        DeleteBanking.Inie = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DeleteBanking.Inie[i] = dt.Rows[0][i].ToString();
                        }
                    }
                }
                //УДАЛЯЕМ ОТЧЕТ ПОЛНОСТЬЮ
                this.queriesTableAdapter1.Отчет_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Otchet[0]));
                this.queriesTableAdapter1.ОписаниеФормуляр_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.OpisanieFormulyar[0]));
                this.queriesTableAdapter1.РасчетИзноса_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Iznos[0]));

                this.queriesTableAdapter1.Сравнительный_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Sravn[0]));
                //УДАЛЯЕМ ЭЛЕМЕНТЫ "РАСЧЕТ ИЗНОСА"
                this.queriesTableAdapter1.РасчетФизИзноса_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.PhysIznos[0]));
                this.queriesTableAdapter1.МетодыРасчета_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Method[0]));
                //УДАЛЯЕМ ЭЛЕМЕНТЫ "ОПИСАНИЕ ФОРМУЛЯР"
                this.queriesTableAdapter1.ИндентификацияИХаркаМестополженияОбъекта_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.IIXMO[0]));
                this.queriesTableAdapter1.ОбщаяХаркаЗдания_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.OXZ[0]));
                this.queriesTableAdapter1.ХаркаОбъектаОценки_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.HarkaObjectaOtsenki[0]));
                this.queriesTableAdapter1.ИнженерноеОбеспечение_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.InjenernoeObesp[0]));
                this.queriesTableAdapter1.Отделка_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Otdelka[0]));
                this.queriesTableAdapter1.ЭкспертнаяОценкаТехСостояния_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.EOTS[0]));
                this.queriesTableAdapter1.Комнаты_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Komnati[0]));
                this.queriesTableAdapter1.Кухня_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Kuhnya[0]));
                this.queriesTableAdapter1.Санузлы_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Sanuzli[0]));
                this.queriesTableAdapter1.Иные_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Inie[0]));
                //УДАЛЯЕМ ЭЛЕМЕНТЫ "СРАВНИТЕЛЬНЫЙ"
                this.queriesTableAdapter1.СравнительныйАналог1_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Analog1[0]));
                this.queriesTableAdapter1.СравнительныйАналог2_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Analog2[0]));
                this.queriesTableAdapter1.СравнительныйАналог3_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Analog3[0]));
                this.queriesTableAdapter1.СравнительныйАналог4_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Analog4[0]));
                this.queriesTableAdapter1.СравнительныйОбъект_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.SravnObject[0]));
                //УДАЛЯЕМ ЭЛЕМЕНТЫ "ЗАДАНИЕ НА ОЦЕНКУ"
                this.queriesTableAdapter1.ЗаданиеНаОценку_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.ZadanieNaOtcenku[0]));
                this.queriesTableAdapter1.Правообладатель_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Provoobledatel1[0]));
                this.queriesTableAdapter1.Правообладатель2_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Provoobledatel2[0]));
                this.queriesTableAdapter1.Правообладатель3_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Provoobledatel3[0]));
                this.queriesTableAdapter1.Правообладатель4_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Provoobledatel4[0]));
                this.queriesTableAdapter1.Правообладатель5_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Provoobledatel5[0]));
                this.queriesTableAdapter1.Заказчик_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.PhysZakaz[0]));
                this.queriesTableAdapter1.ЗаказчикЮридический_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.UrZakaz[0]));
                this.queriesTableAdapter1.ОбъектОценки_Удалить(Convert.ToInt32(DeleteBanking.ObjectOtsenki[0]));
                this.queriesTableAdapter1.ПереченьДокументов_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Documents[0]));
                //УДАЛЯЕМ ПЕРЕЧНИ ДОКУМЕНТОВ
                this.queriesTableAdapter1.ВыпискаЕГРН_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.EGRN[0]));
                this.queriesTableAdapter1.ТехПаспорт_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.TehPasport[0]));
                this.queriesTableAdapter1.УдостоверениеЛичности_УДАЛИТЬ(Convert.ToInt32(DeleteBanking.Pasport[0]));
                //УДАЛЯЕМ ДОГОВОР
                this.queriesTableAdapter1.Договор_УДАЛИТЬ(DeleteBanking.idDogovor);
                this.пДоговорTableAdapter1.Fill(this.graduatedbDataSet.ПДоговор);

            }
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string NameTreaty = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DateTime DateTreaty = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                editTreaty eT = new editTreaty();
                eT.NT = NameTreaty;
                eT.DT = DateTreaty;
                eT.ShowDialog();
                if (eT.Rc)
                {
                    DialogResult result = MessageBox.Show(
    "Изменить договор?",
    "Сообщение",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.Yes)
                    {
                        queriesTableAdapter1.Договор_ИЗМЕНИТЬ(eT.NT, eT.DT, id);
                        this.пДоговорTableAdapter1.Fill(this.graduatedbDataSet.ПДоговор);

                    }
                } // if
            }
            catch { }
        }

        private void NTFilter__TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                пДоговорBindingSource.Filter = String.Format("{0} like '{1}*'", "Номер", textBox1.Text);
            }
            else
            {
                пДоговорBindingSource.Filter = "";
            }
        }

        private void DTFilter_ValueChanged(object sender, EventArgs e)
        {
            пДоговорBindingSource.Filter = String.Format("{0} = '{1}*'", "ДатаЗаключения", Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
        }

        private void NoFilter_Click(object sender, EventArgs e)
        {
            пДоговорBindingSource.Filter = "";
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void RjButton5_Click(object sender, EventArgs e)
        {
            SelectBanking.idDogovor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string NameTreaty = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DateTime DateTreaty = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            SelectBanking.nameDogovor = NameTreaty;
            SelectBanking.dateDogovor = DateTreaty.ToString();


            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                //ПОЛУЧИТЬ ЗАДАНИЕ НА ОЦЕНКУ
                string zaprosZNO = "SELECT * FROM ЗаданиеНаОценку WHERE НомерДоговораНаОценку = @РНомерДоговораНаОценку";
                using (SqlCommand sqlCom = new SqlCommand(zaprosZNO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РНомерДоговораНаОценку",
                        Value = SelectBanking.idDogovor,
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ZadanieNaOtcenku = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ZadanieNaOtcenku[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosObjectOtcenki = "SELECT * FROM ОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosObjectOtcenki, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ObjectOtsenki = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ObjectOtsenki[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ОТЧЕТ
                string zaprosOtchet = "SELECT * FROM Отчет WHERE КодЗаданиеНаОценку = @КодЗаданиеНаОценку";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOtchet, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@КодЗаданиеНаОценку",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[0]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Otchet = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Otchet[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ПЕРЕЧНИ ДОКУМЕНТОВ
                string zaprosDocuments = "SELECT * FROM ПереченьДокументов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosDocuments, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Documents = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Documents[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosEGRN = "SELECT * FROM ВыпискаЕГРН WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosEGRN, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Documents[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.EGRN = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.EGRN[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTehPasport = "SELECT * FROM ТехническийПаспорт WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTehPasport, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Documents[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TehPasport = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TehPasport[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPasport = "SELECT * FROM УдостоверениеЛичности WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPasport, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Documents[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Pasport = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Pasport[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ПРАВООБЛАДАТЕЛЕЙ
                string zaprosPravoobl1 = "SELECT * FROM Правообладатель1 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[7]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Provoobledatel1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Provoobledatel1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPravoobl2 = "SELECT * FROM Правообладатель2 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Provoobledatel2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Provoobledatel2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPravoobl3 = "SELECT * FROM Правообладатель3 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Provoobledatel3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Provoobledatel3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPravoobl4 = "SELECT * FROM Правообладатель4 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Provoobledatel4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Provoobledatel4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPravoobl5 = "SELECT * FROM Правообладатель5 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPravoobl5, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[19]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Provoobledatel5 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Provoobledatel5[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ЗАКАЗЧИКОВ
                string zaprosPhysZakaz = "SELECT * FROM Заказчик WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPhysZakaz, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.PhysZakaz = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.PhysZakaz[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUrZakaz = "SELECT * FROM ЗаказчикЮридический WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUrZakaz, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[20]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.UrZakaz = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.UrZakaz[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ СРАВНИТЕЛЬНЫЙ
                string zaprosSravn = "SELECT * FROM Сравнительный WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravn, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otchet[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Sravn = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Sravn[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSravnObject = "SELECT * FROM СравнительныйОбъект WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravnObject, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sravn[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SravnObject = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SravnObject[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSravnAnalog1 = "SELECT * FROM СравнительныйАналог1 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sravn[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Analog1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Analog1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSravnAnalog2 = "SELECT * FROM СравнительныйАналог2 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sravn[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Analog2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Analog2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSravnAnalog3 = "SELECT * FROM СравнительныйАналог3 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sravn[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Analog3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Analog3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSravnAnalog4 = "SELECT * FROM СравнительныйАналог4 WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSravnAnalog4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sravn[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Analog4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Analog4[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ РАСЧЕТ ИЗНОСА
                string zaprosRaschetIznosa = "SELECT * FROM РасчетИзноса WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosRaschetIznosa, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otchet[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Iznos = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Iznos[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosRaschetPhysIznosa = "SELECT * FROM РасчетФизическогоИзносаЗдания WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosRaschetPhysIznosa, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Iznos[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.PhysIznos = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.PhysIznos[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosMethodRascheta = "SELECT * FROM МетодыРасчета WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosMethodRascheta, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Iznos[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Method = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Method[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ОПИСАНИЕ ФОРМУЛЯР
                string zaprosFormulyar = "SELECT * FROM ОписаниеФормуляр WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosFormulyar, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otchet[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.OpisanieFormulyar = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.OpisanieFormulyar[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosIIXMOO = "SELECT * FROM ИдентификацияИХаркаМестоположенияОбъектаОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosIIXMOO  , sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.IIXMO = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.IIXMO[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOXZ = "SELECT * FROM ОбщаяХаркаЗдания WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOXZ, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.OXZ = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.OXZ[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosXOO = "SELECT * FROM ХаркаОбъектаОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosXOO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.HarkaObjectaOtsenki = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.HarkaObjectaOtsenki[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosInjener = "SELECT * FROM ИнженерноеОбеспечение WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosInjener, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.InjenernoeObesp = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.InjenernoeObesp[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOtdelka = "SELECT * FROM Отделка WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOtdelka, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Otdelka = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Otdelka[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosEOTS = "SELECT * FROM ЭкспертнаяОценкаТехСостояния WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosEOTS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OpisanieFormulyar[6]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.EOTS = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.EOTS[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧИТЬ ЭЛЕМЕНТЫ ОТДЕЛКИ
                string zaprosKomnati = "SELECT * FROM Комнаты WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosKomnati, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Komnati = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Komnati[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosKuhnya = "SELECT * FROM Кухня WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosKuhnya, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Kuhnya = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Kuhnya[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSanuzli = "SELECT * FROM Санузлы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSanuzli, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Sanuzli = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Sanuzli[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosInie = "SELECT * FROM Иные WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosInie, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[6]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Inie = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Inie[i] = dt.Rows[0][i].ToString();
                    }
                }

                //Получаем значения комбобоксов для отчета IIXMO
                string zaprosLokalRasp = "SELECT * FROM ЛокальноеРасположениеВнутриМикрорайона WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosLokalRasp, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.LokalRasp = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.LokalRasp[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPZ = "SELECT * FROM ПреобладающаяЗастройка WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPZ, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.PreoblZastr = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.PreoblZastr[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTD = "SELECT * FROM ТранспортнаяДоступность WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTD, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TranspDostup = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TranspDostup[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOOT = "SELECT * FROM ОбеспеченностьОбщТранспортом WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOOT, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ObespObshTrans = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ObespObshTrans[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosEOR = "SELECT * FROM ОбеспеченностьОбъектамиСоциальнойИнфраструктуры WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosEOR, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[7]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.EcoObstRaionl = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.EcoObstRaionl[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOOS = "SELECT * FROM ЭкологическаяОбстановкаРайона WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOOS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.IIXMO[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ObespObjSocInf = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ObespObjSocInf[i] = dt.Rows[0][i].ToString();
                    }
                }
                //ПОЛУЧАЕМ КОМБОБОКСЫ ОБЪЕКТА ОЦЕНКИ
                string zaprosTP = "SELECT * FROM ТипПомещения WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ObjectOtsenki[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TipPomesh = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TipPomesh[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOP = "SELECT * FROM ОценкеПодлежит WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ObjectOtsenki[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.OtsenkePold = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.OtsenkePold[i] = dt.Rows[0][i].ToString();
                    }
                }

                //ПОЛУЧАЕМ КОМБОБОКСЫ Общая характеристика здания
                string zaprosTDMS = "SELECT * FROM ТипДомаМатериалСтен WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTDMS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TipDomaMatSten = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TipDomaMatSten[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosMP = "SELECT * FROM [Материал перекрытий] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosMP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.MaterialPerekr = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.MaterialPerekr[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSD = "SELECT * FROM СостояниеДома WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSD, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[7]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SostDoma = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SostDoma[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSVO = "SELECT * FROM СостояниеВнешнейОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSVO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SostVneshOtd = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SostVneshOtd[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosDomofon = "SELECT * FROM Домофон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosDomofon, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Domofon = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Domofon[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosParkovka = "SELECT * FROM Парковка WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosParkovka, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[12]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Parkovka = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Parkovka[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNOPT = "SELECT * FROM НаличиеОгороженнойПридомовойТерритории WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNOPT, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.OgorojdTerr = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.OgorojdTerr[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNROPPD = "SELECT * FROM НаличиеОбъектовПривлекательности WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNROPPD, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Privlekatelnost = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Privlekatelnost[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSP = "SELECT * FROM СостояниеПодъезда WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[15]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SostPodjezd = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SostPodjezd[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosDeti = "SELECT * FROM ДетскаяПлощадка WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosDeti, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.DetPlosh = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.DetPlosh[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosZN = "SELECT * FROM ЗеленыеНасаждения WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosZN, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.OXZ[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ZelNasajd = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ZelNasajd[i] = dt.Rows[0][i].ToString();
                    }
                }

                //ПОЛУЧАЕМ КОМБОБОКСЫ Характеристика объекта оценки
                string zaprosNAZNACH = "SELECT * FROM Назначение WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNAZNACH, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Naznachenie = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Naznachenie[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTI = "SELECT * FROM ТекущееИспользование WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTI, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TekushIsp = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TekushIsp[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTS = "SELECT * FROM ТипСанузлов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[12]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TipSanuzlov = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TipSanuzlov[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosBL = "SELECT * FROM [Балкон/Лоджия] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosBL, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.HarkaBalkon = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.HarkaBalkon[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSteklo = "SELECT * FROM [Застеклен/Незастеклен] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSteklo, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[15]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Steklo = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Steklo[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVIO = "SELECT * FROM ВидИзОкон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVIO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VidIzOkon = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VidIzOkon[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosDOP = "SELECT * FROM ДанныеОПерепланировке WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosDOP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.DannieOPereplan = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.DannieOPereplan[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTO = "SELECT * FROM ТипОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TipOtdelki = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TipOtdelki[i] = dt.Rows[0][i].ToString();
                    }
                }

                //ПОЛУЧИТЬ КОМБОБОКСЫ ОТДЕЛКИ
                string zaprosVD = "SELECT * FROM ВходнаяДверь WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVD, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VhodDver = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VhodDver[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosMD = "SELECT * FROM МежкомнатныеДвери WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosMD, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Otdelka[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.MejkomnataDver = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.MejkomnataDver[i] = dt.Rows[0][i].ToString();
                    }
                }

                string zaprosSteniKomnati = "SELECT * FROM Стены WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSteniKomnati, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Komnati[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KomnatiSteni = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KomnatiSteni[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPoliKomnati = "SELECT * FROM Полы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPoliKomnati, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Komnati[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KomnatiPoli = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KomnatiPoli[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPotolokKomnati = "SELECT * FROM Потолок WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPotolokKomnati, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Komnati[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KomnatiPotolok = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KomnatiPotolok[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOknaKomnati = "SELECT * FROM Окна WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOknaKomnati, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Komnati[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KomnatiOkna = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KomnatiOkna[i] = dt.Rows[0][i].ToString();
                    }
                }

                string zaprosSteniKuhnya = "SELECT * FROM Стены WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSteniKuhnya, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Kuhnya[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KuhnyaSteni = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KuhnyaSteni[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPoliKuhnya = "SELECT * FROM Полы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPoliKuhnya, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Kuhnya[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KuhnyaPoli = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KuhnyaPoli[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPotolokKuhnya = "SELECT * FROM Потолок WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPotolokKuhnya, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Kuhnya[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KuhnyaPotolok = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KuhnyaPotolok[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOknaKuhnya = "SELECT * FROM Окна WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOknaKuhnya, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Kuhnya[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.KuhnyaOkna = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.KuhnyaOkna[i] = dt.Rows[0][i].ToString();
                    }
                }

                string zaprosSteniSanuzli = "SELECT * FROM Стены WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSteniSanuzli, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sanuzli[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SanuzliSteni = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SanuzliSteni[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPoliSanuzli = "SELECT * FROM Полы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPoliSanuzli, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sanuzli[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SanuzliPoli = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SanuzliPoli[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPotolokSanuzli = "SELECT * FROM Потолок WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPotolokSanuzli, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sanuzli[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SanuzliPotolok = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SanuzliPotolok[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOknaSanuzli = "SELECT * FROM Окна WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOknaSanuzli, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Sanuzli[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SanuzliOkna = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SanuzliOkna[i] = dt.Rows[0][i].ToString();
                    }
                }

                string zaprosSteniInie = "SELECT * FROM Стены WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSteniInie, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Inie[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.InieSteni = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.InieSteni[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPoliInie = "SELECT * FROM Полы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPoliInie, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Inie[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.IniePoli = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.IniePoli[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPotolokInie = "SELECT * FROM Потолок WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPotolokInie, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Inie[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.IniePotolok = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.IniePotolok[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosOknaInie = "SELECT * FROM Окна WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosOknaInie, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Inie[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.InieOkna = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.InieOkna[i] = dt.Rows[0][i].ToString();
                    }
                }

                //ПОЛУЧАЕМ КОМБОБОКСЫ Общая характеристика здания
                string zaprosNSSPDR = "SELECT * FROM НормативныеСрокиЖизниЖилыхЗданий WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNSSPDR, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.PhysIznos[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NSSPDR = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NSSPDR[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSOFSS = "SELECT * FROM СпособОпределенияФактическогоСрокаСлужбы WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSOFSS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.PhysIznos[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SOFSS = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SOFSS[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPrMethod = "SELECT * FROM МетодОпределенияФизИзноса WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPrMethod, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Method[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.PrinMethod = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.PrinMethod[i] = dt.Rows[0][i].ToString();
                    }
                }

                //ПОЛУЧАЕМ КОМБОБОКСЫ Задание на оценку
                string zaprosTIPNOO = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTIPNOO, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TIPNOO = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TIPNOO[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNalichObr = "SELECT * FROM НаличиеОбременений WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNalichObr, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NalichObr = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NalichObr[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosHarkaObr = "SELECT * FROM ХарактерОбременений WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosHarkaObr, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.HarkaObr = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.HarkaObr[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPhysUrLitso = "SELECT * FROM ФизЮрЛицо WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPhysUrLitso, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[6]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.PhysUrLitso = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.PhysUrLitso[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVS = "SELECT * FROM ВидСтоимости WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVS, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[15]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VidStoimosti = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VidStoimosti[i] = dt.Rows[0][i].ToString();
                    }
                }

                //КОМБОБОКС СРАВНИТЕЛЬНЫЙ ОБЪЕКТ
                string zaprosSPP = "SELECT * FROM СпособПодсчетаПлощади WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSPP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.SravnObject[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SPP = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SPP[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUF = "SELECT * FROM УсловияФинансирования WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUF, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.SravnObject[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.USLFIN = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.USLFIN[i] = dt.Rows[0][i].ToString();
                    }
                }

                //analog2
                string zaprosSPP2 = "SELECT * FROM СпособПодсчетаПлощади WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSPP2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SPP2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SPP2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUF2 = "SELECT * FROM УсловияФинансирования WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUF2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.USLFIN2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.USLFIN2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPP2 = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPP2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Prava2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Prava2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTDMS2 = "SELECT * FROM ТипДомаМатериалСтен WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTDMS2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TDMS2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TDMS2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSD2 = "SELECT * FROM СостояниеДома WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSD2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SD2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SD2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVIO2 = "SELECT * FROM ВидИзОкон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVIO2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VIO2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VIO2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNBL2 = "SELECT * FROM [Балкон/Лоджия] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNBL2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NBL2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NBL2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTS2 = "SELECT * FROM ТипСанузлов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTS2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TS2  = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TS2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSOTR2 = "SELECT * FROM ТипОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSOTR2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog2[19]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SOTR2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SOTR2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPP = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPP, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.SravnObject[6]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Prava = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Prava[i] = dt.Rows[0][i].ToString();
                    }
                }
                //analog1
                string zaprosSPP1 = "SELECT * FROM СпособПодсчетаПлощади WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSPP1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SPP1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SPP1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUF1 = "SELECT * FROM УсловияФинансирования WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUF1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.USLFIN1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.USLFIN1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPP1 = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPP1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Prava1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Prava1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTDMS1 = "SELECT * FROM ТипДомаМатериалСтен WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTDMS1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TDMS1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TDMS1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSD1 = "SELECT * FROM СостояниеДома WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSD1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SD1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SD1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVIO1 = "SELECT * FROM ВидИзОкон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVIO1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VIO1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VIO1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNBL1 = "SELECT * FROM [Балкон/Лоджия] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNBL1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NBL1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NBL1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTS1 = "SELECT * FROM ТипСанузлов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTS1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TS1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TS1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSOTR1 = "SELECT * FROM ТипОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSOTR1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog1[19]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SOTR1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SOTR1[i] = dt.Rows[0][i].ToString();
                    }
                }

                //Analog3
                string zaprosSPP3 = "SELECT * FROM СпособПодсчетаПлощади WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSPP3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SPP3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SPP3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUF3 = "SELECT * FROM УсловияФинансирования WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUF3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.USLFIN3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.USLFIN3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPP3 = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPP3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Prava3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Prava3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTDMS3 = "SELECT * FROM ТипДомаМатериалСтен WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTDMS3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TDMS3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TDMS3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSD3 = "SELECT * FROM СостояниеДома WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSD3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SD3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SD3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVIO3 = "SELECT * FROM ВидИзОкон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVIO3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VIO3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VIO3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNBL3 = "SELECT * FROM [Балкон/Лоджия] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNBL3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NBL3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NBL3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTS3 = "SELECT * FROM ТипСанузлов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTS3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TS3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TS3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSOTR3 = "SELECT * FROM ТипОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSOTR3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog3[19]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SOTR3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SOTR3[i] = dt.Rows[0][i].ToString();
                    }
                }
                //Analog4
                string zaprosSPP4 = "SELECT * FROM СпособПодсчетаПлощади WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSPP4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SPP4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SPP4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosUF4 = "SELECT * FROM УсловияФинансирования WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosUF4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.USLFIN4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.USLFIN4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosPP4 = "SELECT * FROM ТекущиеИмущественныеПраваНаОбъектОценки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosPP4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.Prava4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.Prava4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTDMS4 = "SELECT * FROM ТипДомаМатериалСтен WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTDMS4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TDMS4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TDMS4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSD4 = "SELECT * FROM СостояниеДома WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSD4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SD4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SD4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosVIO4 = "SELECT * FROM ВидИзОкон WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosVIO4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.VIO4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.VIO4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosNBL4 = "SELECT * FROM [Балкон/Лоджия] WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosNBL4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[17]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.NBL4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.NBL4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosTS4 = "SELECT * FROM ТипСанузлов WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosTS4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[18]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.TS4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.TS4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosSOTR4 = "SELECT * FROM ТипОтделки WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosSOTR4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.Analog4[19]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.SOTR4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.SOTR4[i] = dt.Rows[0][i].ToString();
                    }
                }

                string zaprosES1 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES1, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[1]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES1 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES1[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES2 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES2, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[2]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES2 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES2[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES3 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES3, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[3]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES3 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES3[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES4 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES4, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[4]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES4 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES4[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES5 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES5, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[5]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES5 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES5[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES6 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES6, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[6]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES6 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES6[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES7 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES7, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[7]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES7 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES7[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES8 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES8, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[8]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES8 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES8[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES9 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES9, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[9]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES9 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES9[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES10 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES10, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[10]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES10 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES10[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES11 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES11, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[11]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES11 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES11[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES12 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES12, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[12]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES12 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES12[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES13 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES13, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[13]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES13 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES13[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES14 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES14, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[14]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES14 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES14[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES15 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES15, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[15]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES15 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES15[i] = dt.Rows[0][i].ToString();
                    }
                }
                string zaprosES16 = "SELECT * FROM ЭкспертноеСостояние WHERE Код = @РКод";
                using (SqlCommand sqlCom = new SqlCommand(zaprosES16, sqlConn))
                {
                    SqlParameter Kode = new SqlParameter
                    {
                        ParameterName = "@РКод",
                        Value = Convert.ToInt32(SelectBanking.EOTS[16]),
                        Direction = ParameterDirection.Input
                    };
                    sqlCom.Parameters.Add(Kode);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    SelectBanking.ES16 = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        SelectBanking.ES16[i] = dt.Rows[0][i].ToString();
                    }
                }
            }

            //MainForm.btnVisible(object sender, EventArgs e);
        }
    }
    }


