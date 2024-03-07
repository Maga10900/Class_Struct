namespace Class_And_Struct_Task;

class Fractions
{
    private int _suret;
    private int _mexrec;
    public int suret { get { return _suret; } set { _suret = value; } }
    public int mexrec { get { return _mexrec; } set { if (value == 0) throw new Exception("Mexrec 0 ola bilmez"); _mexrec = value; } }

    public Fractions()
    {
        _suret = 1;
        _mexrec = 1;
    }
    public Fractions(int a, int b)
    {
        this.suret = a;
        this.mexrec = b;
    }

    public Fractions Multiply(Fractions other)
    {
        int NewSuret = this._suret * other._suret;
        int NewMexrec = this.mexrec * other._mexrec;
        return new Fractions(NewSuret, NewMexrec);
    }
    public Fractions Divide(Fractions other)
    {
        int NewSuret = this._suret * other._mexrec;
        int NewMexrec = this.mexrec * other._suret;
        return new Fractions(NewSuret, NewMexrec);
    }
    public Fractions Add(Fractions other)
    {
        int num = (other._suret * this._mexrec + this._suret * other._mexrec);
        int denom = this._suret * other._suret;
        Fractions f = new(num, denom);
        return f;
    }
    public Fractions Minus(Fractions other)
    {
        int count = 1;
        while (true)
        {
            if (count % other._suret == 0 && count % _suret == 0)
                break;

            count++;
        }
        int NewDenominator = count;
        int NewNumerator = other._mexrec * _suret - _mexrec * other._suret;
        if (NewNumerator < 0) NewNumerator *= -1;
        return new Fractions(NewNumerator, NewDenominator);
    }
    public void Simplify()
    {
        int count = 2;
        int min = 0;
        if (_mexrec < _suret)
            min = _mexrec;
        else if (_mexrec > _suret)
            min = _suret;
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(1);
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        while (true)
        {

            if (_mexrec % count == 0 && _suret % count == 0)
            {
                _mexrec /= count;
                _suret /= count;
            }
            if (count == min)
            {
                if (_suret == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(_mexrec);
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                Print();
                return;
            }

            count++;
        }
    }
    public void Print()
    {
        Console.WriteLine($"{_suret} / {_mexrec}");
    }
}