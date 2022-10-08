class Tela
{
    ConsoleColor corfundo, cortexto;

    public Tela(ConsoleColor cf, ConsoleColor ct)
    {
        this.corfundo = cf;
        this.cortexto = ct;

        this.configurarTela();
    }

    public void configurarTela()
    {

        Console.BackgroundColor = this.corfundo;
        Console.ForegroundColor = this.cortexto;
        Console.Clear();
    }

    public void montarTelaGeral()
    {
        this.montarMoldura(0, 0, 79, 24);
        this.montarLinhaHor(2, 0, 79);
        this.centralizar(1, 0, 79, "Manseira Bank");
    }

    public void montarMoldura(int ci, int li, int cf, int lf)
    {

        int col, lin;
        this.limparArea(ci, li, cf, lf);
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("-");

            Console.SetCursorPosition(col, lf);
            Console.Write("-");
        }
        
        for (lin = li; lin <= lf; lin++)
        {

            Console.SetCursorPosition(ci, lin);
            Console.Write("|");

            Console.SetCursorPosition(cf, lin);
            Console.Write("|");
        }


        Console.SetCursorPosition(ci, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
        Console.SetCursorPosition(cf, li); Console.Write("+");
        Console.SetCursorPosition(cf, lf); Console.Write("+");
    }

    public void limparArea(int ci, int li, int cf, int lf)
    {
        int col, lin;
        for (col = ci; col < +cf; col++)
        {
            for (lin = li; lin <= lf; lin++)
            {
                Console.SetCursorPosition(col, lin);
                Console.Write(" ");
            }
        }
    }

    public void montarLinhaHor(int lin, int ci, int cf)
    {
        int col;
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("-");
        }
        Console.SetCursorPosition(ci, lin); Console.Write("+");
        Console.SetCursorPosition(cf, lin); Console.Write("+");
    }

    public void centralizar(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci + (cf - ci - msg.Length) / 2;
        Console.SetCursorPosition(col, lin);
        Console.Write(msg);
    }

    public string mostrarMenu(int ci, int li, List<string> opcoes){

        string op;
        int col, lin, cf, lf;

        lf = li + opcoes.Count + 2;
        cf = ci + opcoes[0].Length + 1;
        this.montarMoldura(ci,li,cf,lf);

        col = ci + 1;
        lin = li + 1;
        foreach(string item in opcoes){

            Console.SetCursorPosition(col, lin);
            Console.Write(item);
            lin++;
        }
        Console.SetCursorPosition(col,lin);
        Console.Write("Opcao : ");
        op = Console.ReadLine();


        return op;
    }
}