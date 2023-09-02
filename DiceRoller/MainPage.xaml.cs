namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public void OnClicked(object sender, EventArgs e)
	{
        int min = 1;
        var numLista = picker.SelectedItem;

        int max = int.Parse(numLista.ToString());

        Random rnd= new Random();

        int numeroGerado = rnd.Next(min, max);
        numeroTela.Text = numeroGerado.ToString();
        
    }
}

