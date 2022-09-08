class EnglishRegistration : RegistrationDecorator
{
    public EnglishRegistration(IRegistration registration) : base(registration)
    {
    }

    public override string ToString()
    {
        return"Your license plate is : " + base.ToString();
    }
}