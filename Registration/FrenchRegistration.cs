
class FrenchRegistration : RegistrationDecorator
{
    public FrenchRegistration(IRegistration registration) : base(registration)
    {
    }

    public override string ToString()
    {
        return "Votre plaque d'immatriculation est : " + base.ToString();
    }
}