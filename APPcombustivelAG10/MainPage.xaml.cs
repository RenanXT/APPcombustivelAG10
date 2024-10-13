using System.Xml.Linq;

namespace APPcombustivelAG10
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = txt_Marca.Text;
                string modelo = txt_modelo.Text;

                string msg = "";
                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando mais para o seu modelo " +marca + modelo +".";
                }
                else
                {
                    msg = "O etanol está compensando mais para o seu modelo " + marca + modelo + ".";
                }
                DisplayAlert("Calculado", msg, "OK");
                 }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
