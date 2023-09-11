namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public void OnClicked(object sender, EventArgs e)
	{
        //int min = 1;
        //var numLista = SeletorDeLadosDoDado.SelectedItem;

        //int max = int.Parse(numLista.ToString());

        //Random rnd= new Random();

        //int numeroGerado = rnd.Next(min, max);
        //numeroSorteado.Text = numeroGerado.ToString();

        var maxValue = SeletorDeLadosDoDado.SelectedItem;
        var numeroSorteado = new Random().Next(1, (int)maxValue);

        NumeroSorteado.Text = numeroSorteado.ToString();

    }
}

