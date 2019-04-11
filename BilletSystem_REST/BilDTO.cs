using BilletLibrary;

namespace BilletSystem_REST
{
    public class BilDTO : BilletLibrary.Bil
    {
        public new int pris => Pris();
        public new string type => KøreTøjType();

    }
}