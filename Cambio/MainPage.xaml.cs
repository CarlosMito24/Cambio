namespace Cambio;

///<Summary>
///<Createddate> 2022/06/29 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/29 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Costo.Text) && !string.IsNullOrEmpty(Cantidad.Text))
        {
            double articulo, dinero, vuelto;
            articulo = Convert.ToDouble(Costo.Text);
            dinero = Convert.ToDouble(Cantidad.Text);
            vuelto = dinero - articulo;
            Cambio.Text = Convert.ToString(vuelto);
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos solicitados", "Ok");
            Cambio.Text = "";
        }
    }
}