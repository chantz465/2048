namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the game
            InitializeGame();
        }

        private TableLayoutPanel tableLayoutPanel1;

        // Other methods and event handlers for the form
    }

    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Value { get; set; }
    }

    public class GameBoard
    {
        public const int BoardSize = 4;
        public Tile[,] Tiles { get; set; }

        public GameBoard()
        {
            Tiles = new Tile[BoardSize, BoardSize];
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Tiles[i, j] = new Tile { X = i, Y = j, Value = 0 };
                }
            }
        }

        private void AddInitialTiles()
        {
            Random random = new Random();
            int x1 = random.Next(0, GameBoard.BoardSize);
            int y1 = random.Next(0, GameBoard.BoardSize);
            int x2 = random.Next(0, GameBoard.BoardSize);
            int y2 = random.Next(0, GameBoard.BoardSize);

            while (x2 == x1 && y2 == y1)
            {
                x2 = random.Next(0, GameBoard.BoardSize);
                y2 = random.Next(0, GameBoard.BoardSize);
            }

            Tiles[x1, y1].Value = random.Next(1, 3) * 2;
            Tiles[x2, y2].Value = random.Next(1, 3) * 2;
        }

    }



}



