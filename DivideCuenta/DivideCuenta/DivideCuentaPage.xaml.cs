namespace DivideCuenta
{
    public partial class DivideCuentaPage : ContentPage
    {
        public DivideCuentaPage()
        {
            InitializeComponent();
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            var monto = sldMonto.Value;
            var personas = stpPersonas.Value;
            var propina = sldPropina.Value / 100;

            var montoPropina = monto * propina;
            var total = monto + montoPropina;
            var porPersona = personas > 0 ? total / personas : 0;

            lblMonto.Text = $"Monto: ₡{monto:N0}";
            lblPersonas.Text = $"Personas: {(int)personas}";
            lblPropina.Text = $"Propina: {sldPropina.Value:N0}%";

            lblSubtotal.Text = $"Subtotal: ₡{monto:N0}";
            lblMontoPropina.Text = $"Propina: ₡{montoPropina:N0}";
            lblTotal.Text = $"Total: ₡{total:N0}";
            lblPorPersona.Text = $"Por persona: ₡{porPersona:N0}";
        }

        private void btnSorpresa_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            sldPropina.Value = random.Next(0, 31);
            Calcular();
        }
    }
}