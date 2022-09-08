using System;

public interface IRegistration
{
    Tuple<PairLetter, TripletNumber, PairLetter> Current { get; set; }
    Registration next();
    bool hasNext();
    void reset();
    string ToString();
}