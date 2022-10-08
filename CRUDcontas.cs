class CRUDcontas
{

    List<Conta> BDcontas = new List<Conta>();
    Tela tela;

    public CRUDcontas(Tela t)
    {

        this.tela = t;

    }

    public void montarTela(int ci, int li, int cf, int lf)
    {

        this.tela.montarMoldura(ci, li, cf, lf);
        this.tela.montarLinhaHor(li + 2, ci, cf);
        this.tela.centralizar(li + 1, ci, cf, "Cadastro de Contas");
        
    }
}