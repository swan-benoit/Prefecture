class SpanishRegistration : RegistrationDecorator
{
    public SpanishRegistration(IRegistration registration) : base(registration)
    {
    }

    public override string ToString()
    {
        return "El coche está : " + base.ToString();
    }
    
}