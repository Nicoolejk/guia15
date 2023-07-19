namespace Navegacion;

public partial class Gas : ContentPage
{
	public Gas()
	{
		InitializeComponent();
	}
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        double cantidadGalones, precioLitro;

        if (!double.TryParse(txtCantidadGalones.Text, out cantidadGalones) ||
            !double.TryParse(txtPrecioLitro.Text, out precioLitro))
        {
            lblResultado.Text = "Valores inválidos";
            return;
        }

        // Convertir galones a litros (1 galón = 3.78541 litros)
        double cantidadLitros = cantidadGalones * 3.78541;

        // Calcular el monto a cobrar
        double montoCobrar = cantidadLitros * precioLitro;

        lblResultado.Text = $"Cantidad a cobrar: {montoCobrar:C}";
    }

}