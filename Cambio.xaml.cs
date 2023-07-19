namespace Navegacion;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}
    private void Restar_Clicked(object sender, EventArgs e)
    {
        decimal cantidad1, cantidad2;

        if (!decimal.TryParse(txtCantidad1.Text, out cantidad1) ||
            !decimal.TryParse(txtCantidad2.Text, out cantidad2))
        {
            lblResultado.Text = "Cantidad inválida";
            return;
        }

        decimal resultado = cantidad1 - cantidad2;

        lblResultado.Text = $"El resultado del cambio es: {resultado:C}";
    }




}