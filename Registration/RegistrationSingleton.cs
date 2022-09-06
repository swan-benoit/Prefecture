
public class RegistrationSingleton
{
    private static Registration _instance;

    public static Registration GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Registration();
        }

        return _instance;
    }

}