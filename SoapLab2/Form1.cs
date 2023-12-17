using SoapLab2.CountryInfoSvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                CountryInfoService countryInfoService = new CountryInfoService();
                var tCountryInfos = countryInfoService.FullCountryInfoAllCountries();

                Random random = new Random();

                if (tCountryInfos.Length > 0)
                {
                    int randomIndex = random.Next(tCountryInfos.Length);

                    CmbCountryCapital.Text = tCountryInfos[randomIndex].sCapitalCity;
                    CmbPhoneCode.Text = tCountryInfos[randomIndex].sPhoneCode;
                    CmbCountryName.Text = tCountryInfos[randomIndex].sName;
                    CmbCountryContinent.Text = tCountryInfos[randomIndex].sContinentCode;
                    CmbCurrencyIso.Text = tCountryInfos[randomIndex].sCurrencyISOCode;

                    CmbCountryCapital.Items.Clear();
                    CmbPhoneCode.Items.Clear();
                    CmbCountryName.Items.Clear();
                    CmbCountryContinent.Items.Clear();
                    CmbCurrencyIso.Items.Clear();

                    CmbCountryCapital.Items.Add(tCountryInfos[randomIndex].sCapitalCity);
                    CmbPhoneCode.Items.Add(tCountryInfos[randomIndex].sPhoneCode);
                    CmbCountryName.Items.Add(tCountryInfos[randomIndex].sName);
                    CmbCountryContinent.Items.Add(tCountryInfos[randomIndex].sContinentCode);
                    CmbCurrencyIso.Items.Add(tCountryInfos[randomIndex].sCurrencyISOCode);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(text: @"Error in GetCountryNameByName. " + exc.Message);
            }
        }
    }
}
