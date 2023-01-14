namespace LowLevelDesign.PrototypeAndRegistry
{
    internal interface Prototype<T>
    {
        T clone();
    }
}
