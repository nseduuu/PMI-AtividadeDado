namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public class Dice // Classe do dado
    {
        private int NumSides { get; set; }

        public Dice() { } // Construtor vazio 'Padrao'
        public Dice(int numSides) // Construtor com argumentos 
        {
            NumSides = numSides; // Numero de lados recebe o parametro do argumento
        }

        public int RollDice() // metodo que gera um numero aleatorio 
        {
            int random = new Random().Next(1, NumSides + 1);
            return random;
        }
    }

    public void OnClicked(object sender, EventArgs e)
	{
        int numSides = (int)SeletorDeLadosDoDado.SelectedItem;

        Dice dice = new Dice(numSides);

        NumeroSorteado.Text = dice.RollDice().ToString();

        diceImage.Source = ImageSource.FromFile($"dice_d{numSides}.png");


    }
}

