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

        //Dice dado = new Dice((int)SeletorDeLadosDoDado.SelectedItem); // aqui o valor de lados do dado vai ser definido pelo picker

        //var numeroSorteado = dado.RollDice(); // aqui o numero sorteado vai receber o metodo random 

        //NumeroSorteado.Text = numeroSorteado.ToString(); // aqui o valor do NumeroSorteado recebe o numeroSorteado pelo metodo random



        //int min = 1;
        //var numLista = SeletorDeLadosDoDado.SelectedItem;

        //int max = int.Parse(numLista.ToString());

        //Random rnd= new Random();

        //int numeroGerado = rnd.Next(min, max);
        //numeroSorteado.Text = numeroGerado.ToString();


        //Correção
        //var maxValue = SeletorDeLadosDoDado.SelectedItem;
        //var numeroSorteado = new Random().Next(1, (int)maxValue + 1);

        //NumeroSorteado.Text = numeroSorteado.ToString();

    }
}

