using System;
namespace PatronFacade_fachada
{
    class Program
    {
        public static void Main(String[] args)
        {
        IAcelerador acelerador = new Acelerador();
        IEmbrague embrague = new Embrague();
        IPalancaCambios palancaCambios = new PalancaCambios();

        Centralita centralita = new Centralita(embrague, acelerador, palancaCambios);
        centralita.AumentarMarcha();
        }
     }
}
