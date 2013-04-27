using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CareerReport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += delegate { this.DragMove(); };
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Clearfield()
        {
            presentdateDP.SelectedDate = DateTime.Now.Date;
            nameTB.Text = addressTB.Text = adressContTB.Text = cityTB.Text = stateTB.Text = zipTB.Text =
            phoneTB.Text = faxTB.Text = websiteTB.Text = emailConventionTB.Text = dataSourceTB.Text =
            statusTB.Text = facilityTB.Text = uniqueCntctIdTB.Text = firstNameTB.Text = lastNameTB.Text = positionTB.Text = "";
        }

        private void resetFieldsBtn_Click(object sender, RoutedEventArgs e)
        {
            Clearfield();
        }

        private void submitInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            CareerReportData.DetailsInfo newDetails = new CareerReportData.DetailsInfo();

            newDetails.id = GenerateId();

            newDetails.presentdate = presentdateDP.SelectedDate.Value;
            newDetails.name = nameTB.Text;
            newDetails.address = addressTB.Text;
            newDetails.adresscont = adressContTB.Text;
            newDetails.city = cityTB.Text;
            newDetails.state = stateTB.Text;
            newDetails.zip = zipTB.Text;
            newDetails.phone = phoneTB.Text;
            newDetails.fax = faxTB.Text;
            newDetails.website = websiteTB.Text;
            newDetails.emailconvention = emailConventionTB.Text;
            newDetails.datasource = dataSourceTB.Text;
            newDetails.status = statusTB.Text;
            newDetails.facility = facilityTB.Text;
            newDetails.uniquecntctid = uniqueCntctIdTB.Text;
            newDetails.firstmame = firstNameTB.Text;
            newDetails.lastname = lastNameTB.Text;
            newDetails.position = positionTB.Text;

            CareerReportDb.DbInteraction.EnterNewDetails(newDetails);
            Clearfield();
        }

        private string GenerateId()
        {
            return DateTime.Now.ToOADate().ToString();
        }

    }
}
