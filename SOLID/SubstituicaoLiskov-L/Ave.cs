namespace SubstituicaoLiskov_L
{
    public abstract class Ave
    {
        public abstract void Mover();

        public virtual void Dormir() => Console.WriteLine("Dormindo...");
    }
}