namespace Ejercicio5;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(numer1.Text))
		{
			var numero = Convert.ToInt32(numer1.Text);
			var nur1 = Math.Pow(numero, 3);
			var nur2 = Math.Pow(numero, 2);
			cubo.Text = Convert.ToString(nur1);
			cuadrado.Text = Convert.ToString(nur2);
		}
		else
		{
			DisplayAlert("Eror", "Escribe tu numero primero ciego","Adoptado");
		}
    }
}

