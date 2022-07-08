using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduatework
{
   class DeleteBanking
    {
        public static int idDogovor;
        public static string[] ZadanieNaOtcenku;
        public static string[] ObjectOtsenki;
        public static string[] Pasport;
        public static string[] TehPasport;
        public static string[] EGRN;
        public static string[] Documents;
        public static string[] Analog1;
        public static string[] Analog2;
        public static string[] Analog3;
        public static string[] Analog4;
        public static string[] Provoobledatel1;
        public static string[] Provoobledatel2;
        public static string[] Provoobledatel3;
        public static string[] Provoobledatel4;
        public static string[] Provoobledatel5;
        public static string[] UrZakaz;
        public static string[] PhysZakaz;
        public static string[] Komnati;
        public static string[] Kuhnya;
        public static string[] Sanuzli;
        public static string[] Inie;
        public static string[] Otdelka;
        public static string[] IIXMO;
        public static string[] OXZ;
        public static string[] HarkaObjectaOtsenki;
        public static string[] InjenernoeObesp;
        public static string[] EOTS;
        public static string[] OpisanieFormulyar;
        public static string[] PhysIznos;
        public static string[] Iznos;
        public static string[] SravnObject;
        public static string[] Sravn;
        public static string[] Method;
        public static string[] Otchet;
    }

    class SelectBanking
    {   
        public static int idDogovor;
        public static string nameDogovor;
        public static string dateDogovor;

        public static string[] ZadanieNaOtcenku;
        public static string[] ObjectOtsenki;
        public static string[] Pasport;
        public static string[] TehPasport;
        public static string[] EGRN;
        public static string[] Documents;
        public static string[] Analog1;
        public static string[] Analog2;
        public static string[] Analog3;
        public static string[] Analog4;
        public static string[] Provoobledatel1;
        public static string[] Provoobledatel2;
        public static string[] Provoobledatel3;
        public static string[] Provoobledatel4;
        public static string[] Provoobledatel5;
        public static string[] UrZakaz;
        public static string[] PhysZakaz;
        public static string[] Komnati;
        public static string[] Kuhnya;
        public static string[] Sanuzli;
        public static string[] Inie;
        public static string[] Otdelka;
        public static string[] IIXMO;
        public static string[] OXZ;
        public static string[] HarkaObjectaOtsenki;
        public static string[] InjenernoeObesp;
        public static string[] EOTS;
        public static string[] OpisanieFormulyar;
        public static string[] PhysIznos;
        public static string[] Iznos;
        public static string[] SravnObject;
        public static string[] Sravn;
        public static string[] Method;
        public static string[] Otchet;


        //Идентификация и характеристика местоположения объекта оценки
        public static string[] LokalRasp;//+
        public static string[] PreoblZastr;//+
        public static string[] TranspDostup;//+
        public static string[] ObespObshTrans;//+
        public static string[] ObespObjSocInf;
        public static string[] EcoObstRaionl;

        //Объект оценки
        public static string[] TipPomesh;//+
        public static string[] OtsenkePold;//+

        //ОбщаяХаркаЗдания
        public static string[] TipDomaMatSten;
        public static string[] MaterialPerekr;
        public static string[] SostDoma;
        public static string[] SostVneshOtd;
        public static string[] Domofon;
        public static string[] Parkovka;
        public static string[] OgorojdTerr;
        public static string[] Privlekatelnost;
        public static string[] SostPodjezd;
        public static string[] DetPlosh;
        public static string[] ZelNasajd;

        //Характеристика объекта оценки
        public static string[] Naznachenie;
        public static string[] TekushIsp;
        public static string[] TipSanuzlov;
        public static string[] HarkaBalkon;
        public static string[] Steklo;
        public static string[] VidIzOkon;
        public static string[] DannieOPereplan;
        public static string[] TipOtdelki;

        //Отделка
        public static string[] VhodDver;
        public static string[] MejkomnataDver;
        public static string[] KomnatiSteni;
        public static string[] KomnatiPoli;
        public static string[] KomnatiPotolok;
        public static string[] KomnatiOkna;
        public static string[] KuhnyaSteni;
        public static string[] KuhnyaPoli;
        public static string[] KuhnyaPotolok;
        public static string[] KuhnyaOkna;        
        public static string[] SanuzliSteni;
        public static string[] SanuzliPoli;
        public static string[] SanuzliPotolok;
        public static string[] SanuzliOkna;
        public static string[] InieSteni;
        public static string[] IniePoli;
        public static string[] IniePotolok;
        public static string[] InieOkna;

        //Расчет
        public static string[] NSSPDR;
        public static string[] SOFSS;
        public static string[] PrinMethod;

        //Задание на оценку
        public static string[] TIPNOO;
        public static string[] NalichObr;
        public static string[] HarkaObr;
        public static string[] PhysUrLitso;
        public static string[] VidStoimosti;

        //СРАВНИТЕЛЬНЫЙ ОБЪЕКТ
        public static string[] SPP;
        public static string[] USLFIN;
        public static string[] Prava;

        //Analog1
        public static string[] SPP1;
        public static string[] USLFIN1;
        public static string[] Prava1;
        public static string[] TDMS1;
        public static string[] SD1;
        public static string[] VIO1;
        public static string[] NBL1;
        public static string[] TS1;
        public static string[] SOTR1;

        //Analog2
        public static string[] SPP2;
        public static string[] USLFIN2;
        public static string[] Prava2;
        public static string[] TDMS2;
        public static string[] SD2;
        public static string[] VIO2;
        public static string[] NBL2;
        public static string[] TS2;
        public static string[] SOTR2;

        //Analog3
        public static string[] SPP3;
        public static string[] USLFIN3;
        public static string[] Prava3;
        public static string[] TDMS3;
        public static string[] SD3;
        public static string[] VIO3;
        public static string[] NBL3;
        public static string[] TS3;
        public static string[] SOTR3;

        //Analog4
        public static string[] SPP4;
        public static string[] USLFIN4;
        public static string[] Prava4;
        public static string[] TDMS4;
        public static string[] SD4;
        public static string[] VIO4;
        public static string[] NBL4;
        public static string[] TS4;
        public static string[] SOTR4;

        //econom ots
        public static string[] ES1;
        public static string[] ES2;
        public static string[] ES3;
        public static string[] ES4;
        public static string[] ES5;
        public static string[] ES6;
        public static string[] ES7;
        public static string[] ES8;
        public static string[] ES9;
        public static string[] ES10;
        public static string[] ES11;
        public static string[] ES12;
        public static string[] ES13;
        public static string[] ES14;
        public static string[] ES15;
        public static string[] ES16;
    }
    class AddBanking
    {
        public static int idDogovor;
        public static int idObjectOtsenki;
        public static int idPasport;
        public static int idTehPasport;
        public static int idEGRN;
        public static int idDocuments;
        public static int idAnalog1;
        public static int idAnalog2;
        public static int idAnalog3;
        public static int idAnalog4;
        public static int idProvoobledatel1;
        public static int idProvoobledatel2;
        public static int idProvoobledatel3;
        public static int idProvoobledatel4;
        public static int idProvoobledatel5;
        public static int idUrZakaz;
        public static int idPhysZakaz;
        public static int idKomnati;
        public static int idKuhnya;
        public static int idSanuzli;
        public static int idInie;
        public static int idOtdelka;
        public static int idZadanieNaOtsenku;
        public static int idIIXMO;
        public static int idOXZ;
        public static int idHarkaObjectaOtsenki;
        public static int idInjenernoeObesp;
        public static int idEOTS;
        public static int idOpisanieFormulyar;
        public static int idPhysIznos;
        public static int idIznos;
        public static int idSravnObject;
        public static int idSravn;
        public static int idMethod;

        public static void ClearAdd()
        {
            //idDogovor = Convert.ToInt32("");
            //idObjectOtsenki = Convert.ToInt32("");
            //idPasport = Convert.ToInt32("");
            //idTehPasport = Convert.ToInt32("");
            //idEGRN = Convert.ToInt32("");
            //idDocuments = Convert.ToInt32("");
            //idAnalog1 = Convert.ToInt32("");
            //idAnalog2 = Convert.ToInt32("");
            //idAnalog3 = Convert.ToInt32("");
            //idAnalog4 = Convert.ToInt32("");
            //idProvoobledatel1 = Convert.ToInt32("");
            //idProvoobledatel2 = Convert.ToInt32("");
            //idProvoobledatel3 = Convert.ToInt32("");
            //idProvoobledatel4 = Convert.ToInt32("");
            //idProvoobledatel5 = Convert.ToInt32("");
            //idUrZakaz = Convert.ToInt32("");
            //idPhysZakaz = Convert.ToInt32("");
            //idKomnati = Convert.ToInt32("");
            //idKuhnya = Convert.ToInt32("");
            //idSanuzli = Convert.ToInt32("");
            //idInie = Convert.ToInt32("");
            //idOtdelka = Convert.ToInt32("");
            //idZadanieNaOtsenku = Convert.ToInt32("");
            //idIIXMO = Convert.ToInt32("");
            //idOXZ = Convert.ToInt32("");
            //idHarkaObjectaOtsenki = Convert.ToInt32("");
            //idInjenernoeObesp = Convert.ToInt32("");
            //idEOTS = Convert.ToInt32("");
            //idOpisanieFormulyar = Convert.ToInt32("");
            //idPhysIznos = Convert.ToInt32("");
            //idIznos = Convert.ToInt32("");
            //idSravnObject = Convert.ToInt32("");
            //idSravn = Convert.ToInt32("");
            //idMethod = Convert.ToInt32("");
        }
    }


    class GKHParse
    {
        //MINGKH PARSE
        //Main
        //public static string GKHURL;
        public static string GKHAddress;
        public static string GKHGodPostroiki;
        public static string GKHKolVoEtajey;
        public static string GKHTipDoma;
        public static string GHJiliePomesheniya;
        public static string GKHSeriaTipZdaniya;
        public static string GKHTipPerekritiy;
        public static string GKHMaterialNesushSten;
        public static string GKHTipMusora;
        public static string GKHAvariya;

        public static string GKHDetskayaPloshadka;
        public static string GKHSportPloshadka;
        public static string GKHKadastr;
        public static string GKHUprKompaniya;
        //Основные сведения
        public static string GKHGodVvoda;
        public static string GKHDopInfa;
        public static string GKHEnergoEff;
        public static string GKHPodezdi;
        public static string GKHEtajiMax;
        public static string GKHEtajiMin;
        public static string GKHJilayaPloshad;
        public static string GKHNeJilayaPloshad;
        public static string GKHPloshadPomesh;
        public static string GKHZemlyaPloshad;
        public static string GKHParkovkaPloshad;
        public static string GKHFondKapRemonta;

        //Инженерные системы
        //public static string GKHKolVoVvodovVDom;
        //public static string GKHObiemVigrebYam;
        //public static string GKHVentilyatsiya;
        //public static string GKHVootvod;
        //public static string GKHSistemaVodostokov;
        //public static string GKHGazosnabjenie;
        //public static string GKHGoryachayaVoda;
        //public static string GKHSistemaPojara;
        //public static string GKHTeplosnabjenie;
        //public static string GKHHolodnayaVoda;
        //public static string GKHElectro;

        ////Конструктивные элементы
        //public static string GKHPloshadPodvala;
        //public static string GKHKrisha;
        //public static string GKHFasad;
        //public static string GKHFundament;
    }

    class AvitoParseAnalog1
    {
        //AVITO PARSE
        //Информация о продавце
        public static string AvitoTown;
        public static string AvitoURL;
        public static string AvitoItemID; //+
        public static string AvitoName;
        public static string AvitoPriceMain; //"5 805 640" +
        public static string AvitoSubPriceMain; //"75 990 ₽ за м²" +
        public static string AvitoSrokSdachiMain;

        //О квартире
        public static string AvitoTipJiliyaMain; //Тип жилья
        public static string AvitoEtajMain; //"Этаж: 14 из 17"
        public static string AvitoKomnatiMain; //"Количество комнат: 3" + 
        public static string AvitoPloshadMain; //"Общая площадь: 76.4 м²" +
        public static string AvitoPloshadKuhniMain; // +
        public static string AvitoPloshadJilayaMain; // +
        public static string AvitoVisotaPotolkovMain; // +
        public static string AvitoSanuzelMain;
        public static string AvitoOknaMain;
        public static string AvitoOtdelkaMain;
        public static string AvitoTipKomnatMain;//"Тип комнат: изолированные"
        public static string AvitoRemontMain;
        public static string AvitoSposobProdajiMain;

        //О доме 1
        public static string AvitoTipDomaMain; //"Тип дома: панельный"
        public static string AvitoGodPostroykiMain;
        public static string AvitoEtajiAllMain; //"Этажей в доме: 17"
        public static string AvitoLiftPMain;
        public static string AvitoLiftGMain;
        public static string AvitoDvorMain;
        public static string AvitoParkovkaMain;

        //Адрес
        public static string AvitoAddressUlitsaDomMain; //"ул. Труда, д. 13"
        public static string AvitoAddressRaionMain; //"р-н Центральный"



        //О доме

        public static string AvitoBalkonMain;
    }
    class AvitoParseAnalog2
    {
        //AVITO PARSE
        //Информация о продавце
        public static string AvitoTown;
        public static string AvitoURL;
        public static string AvitoItemID; //+
        public static string AvitoName;
        public static string AvitoPriceMain; //"5 805 640" +
        public static string AvitoSubPriceMain; //"75 990 ₽ за м²" +
        public static string AvitoSrokSdachiMain;

        //О квартире
        public static string AvitoTipJiliyaMain; //Тип жилья
        public static string AvitoEtajMain; //"Этаж: 14 из 17"
        public static string AvitoKomnatiMain; //"Количество комнат: 3" + 
        public static string AvitoPloshadMain; //"Общая площадь: 76.4 м²" +
        public static string AvitoPloshadKuhniMain; // +
        public static string AvitoPloshadJilayaMain; // +
        public static string AvitoVisotaPotolkovMain; // +
        public static string AvitoSanuzelMain;
        public static string AvitoOknaMain;
        public static string AvitoOtdelkaMain;
        public static string AvitoTipKomnatMain;//"Тип комнат: изолированные"
        public static string AvitoRemontMain;
        public static string AvitoSposobProdajiMain;

        //О доме 1
        public static string AvitoTipDomaMain; //"Тип дома: панельный"
        public static string AvitoGodPostroykiMain;
        public static string AvitoEtajiAllMain; //"Этажей в доме: 17"
        public static string AvitoLiftPMain;
        public static string AvitoLiftGMain;
        public static string AvitoDvorMain;
        public static string AvitoParkovkaMain;

        //Адрес
        public static string AvitoAddressUlitsaDomMain; //"ул. Труда, д. 13"
        public static string AvitoAddressRaionMain; //"р-н Центральный"



        //О доме

        public static string AvitoBalkonMain;
    }
    class AvitoParseAnalog3
    {
        //AVITO PARSE
        //Информация о продавце
        public static string AvitoTown;
        public static string AvitoURL;
        public static string AvitoItemID; //+
        public static string AvitoName;
        public static string AvitoPriceMain; //"5 805 640" +
        public static string AvitoSubPriceMain; //"75 990 ₽ за м²" +
        public static string AvitoSrokSdachiMain;

        //О квартире
        public static string AvitoTipJiliyaMain; //Тип жилья
        public static string AvitoEtajMain; //"Этаж: 14 из 17"
        public static string AvitoKomnatiMain; //"Количество комнат: 3" + 
        public static string AvitoPloshadMain; //"Общая площадь: 76.4 м²" +
        public static string AvitoPloshadKuhniMain; // +
        public static string AvitoPloshadJilayaMain; // +
        public static string AvitoVisotaPotolkovMain; // +
        public static string AvitoSanuzelMain;
        public static string AvitoOknaMain;
        public static string AvitoOtdelkaMain;
        public static string AvitoTipKomnatMain;//"Тип комнат: изолированные"
        public static string AvitoRemontMain;
        public static string AvitoSposobProdajiMain;

        //О доме 1
        public static string AvitoTipDomaMain; //"Тип дома: панельный"
        public static string AvitoGodPostroykiMain;
        public static string AvitoEtajiAllMain; //"Этажей в доме: 17"
        public static string AvitoLiftPMain;
        public static string AvitoLiftGMain;
        public static string AvitoDvorMain;
        public static string AvitoParkovkaMain;

        //Адрес
        public static string AvitoAddressUlitsaDomMain; //"ул. Труда, д. 13"
        public static string AvitoAddressRaionMain; //"р-н Центральный"



        //О доме

        public static string AvitoBalkonMain;
    }
    class AvitoParseAnalog4
    {
        //AVITO PARSE
        //Информация о продавце
        public static string AvitoTown;
        public static string AvitoURL;
        public static string AvitoItemID; //+
        public static string AvitoName;
        public static string AvitoPriceMain; //"5 805 640" +
        public static string AvitoSubPriceMain; //"75 990 ₽ за м²" +
        public static string AvitoSrokSdachiMain;

        //О квартире
        public static string AvitoTipJiliyaMain; //Тип жилья
        public static string AvitoEtajMain; //"Этаж: 14 из 17"
        public static string AvitoKomnatiMain; //"Количество комнат: 3" + 
        public static string AvitoPloshadMain; //"Общая площадь: 76.4 м²" +
        public static string AvitoPloshadKuhniMain; // +
        public static string AvitoPloshadJilayaMain; // +
        public static string AvitoVisotaPotolkovMain; // +
        public static string AvitoSanuzelMain;
        public static string AvitoOknaMain;
        public static string AvitoOtdelkaMain;
        public static string AvitoTipKomnatMain;//"Тип комнат: изолированные"
        public static string AvitoRemontMain;
        public static string AvitoSposobProdajiMain;

        //О доме 1
        public static string AvitoTipDomaMain; //"Тип дома: панельный"
        public static string AvitoGodPostroykiMain;
        public static string AvitoEtajiAllMain; //"Этажей в доме: 17"
        public static string AvitoLiftPMain;
        public static string AvitoLiftGMain;
        public static string AvitoDvorMain;
        public static string AvitoParkovkaMain;

        //Адрес
        public static string AvitoAddressUlitsaDomMain; //"ул. Труда, д. 13"
        public static string AvitoAddressRaionMain; //"р-н Центральный"



        //О доме

        public static string AvitoBalkonMain;
    }
}
