
using tabuleiro;
using xadrez_console.xadrez;
using xadrez_console;
try
{
    Tabuleiro tab = new Tabuleiro(8, 8);
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
