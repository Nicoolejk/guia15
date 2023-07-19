namespace Navegacion;

public partial class Dino : ContentPage
{
	public Dino()
	{
		InitializeComponent();
	}
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        double pesoKg, alturaM;

        if (!double.TryParse(txtPeso.Text, out pesoKg) ||
            !double.TryParse(txtAltura.Text, out alturaM))
        {
            lblResultado.Text = "Valores inválidos";
            return;
        }

        // Convertir peso de kg a libras (1 kg = 2.20462 libras)
        double pesoLb = pesoKg * 2.20462;

        // Convertir altura de metros a centímetros (1 metro = 100 centímetros)
        double alturaCm = alturaM * 100;

        lblResultado.Text = $"Dinosaurio: {nombre}\n\n" +
                            $"Peso: {pesoLb} libras\n" +
                            $"Altura: {alturaCm} centímetros";
    }

}