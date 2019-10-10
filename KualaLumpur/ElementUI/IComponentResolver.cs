namespace KualaLumpur.ElementUI
{
    public interface IComponentResolver
    {
        T Create<T>(string selecteur);
    }
}
