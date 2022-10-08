class contaEspecial : Conta
{

    public decimal limite;

    public contaEspecial(string num, string tit, decimal sal, decimal lim) : base(num, tit, sal)
    {
        this.limite = lim;

    }

    public override void retirar(decimal val, DateTime dat, string mot)
    {
        if(this.saldo + this.limite > val){
            Transacao saque = new Transacao(-val, dat, mot);
                this.movimentacao.Add(saque);
        }
    }

}