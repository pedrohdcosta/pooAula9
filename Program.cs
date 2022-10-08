Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);
List<string> menu = new List<string>();
string opcao;

menu.Add("1 - Contas      ");
menu.Add("2 - Movimentacao");
menu.Add("3 - Extratos    ");
menu.Add("0 - sair        ");

while (true)
{
    tela.montarTelaGeral();
    tela.montarLinhaHor(2, 0, 79);
    tela.centralizar(1, 0, 79, "Manseria Bank");
    opcao = tela.mostrarMenu(2, 3, menu);

    if (opcao == "0") break;

    if (opcao == "1")
    {

    }
}

Console.Clear();