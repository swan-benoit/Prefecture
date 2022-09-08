using System;

public class RegistrationDecorator : IRegistration
{
    public Tuple<PairLetter, TripletNumber, PairLetter> Current { get; set; }
    private IRegistration Wrappee { get; }

    public RegistrationDecorator(IRegistration registration)
    {
        Wrappee = registration;
    }

    public Registration next()
    {
        return Wrappee.next();
    }

    public bool hasNext()
    {
        return Wrappee.hasNext();
    }

    public void reset()
    {
        Wrappee.reset();
    }

    public override string ToString()
    {
        return Wrappee.ToString();
    }
}