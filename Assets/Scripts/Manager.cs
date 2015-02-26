public class Manager : Singleton<Manager>
{
    protected Manager() { } // guarantee this will be always a singleton only - can't use the constructor!

    public int score = 0; //FIXME Herp derp no idea what I am doing
}