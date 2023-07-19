namespace Navegacion;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        double baseTriangulo, alturaTriangulo;

        if (!double.TryParse(txtBase.Text, out baseTriangulo) ||
            !double.TryParse(txtAltura.Text, out alturaTriangulo))
        {
            lblResultado.Text = "Valores inválidos";
            return;
        }

        double superficie = 0.5 * baseTriangulo * alturaTriangulo;

        lblResultado.Text = $"La superficie del triángulo es: {superficie}";
    }

}