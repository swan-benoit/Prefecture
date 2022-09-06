using System;

public interface ICounter<T, out U>
{
    T Current { get; set; }

    U next();

    Boolean hasNext();

    void reset();

}