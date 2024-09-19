namespace translatorNr
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void onCall(object sender, EventArgs e)
        {
            if(await this.DisplayAlert("CALL","Czy napewno chcesz zadzwonić pod podany numer?", "TAK", "NIE"))
            {
                try
                {
                    if (PhoneDialer.Default.IsSupported)
                        PhoneDialer.Default.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Unable to dial","Phone number was not valid.","OK");
                }
                catch (Exception)
                {
                    await DisplayAlert("Unable to dial", "Phone dialing failed", "OK");
                }
            }

            

            
            

            
        }

        private void onTranslate(object sender, EventArgs e)
        {
            string enteredNumber = entPhoneWord.Text;
            translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                btnCall.IsEnabled = true;
                btnCall.Text = "Call " + translatedNumber;
            }
            else
            {
                btnCall.IsEnabled = false;
                btnCall.Text = "Call";
            }
        }
    }

}
