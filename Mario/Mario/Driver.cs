using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Driver
{
    private double _skill;

    public string Name { get; private set; }
    public double DriverSkill
    {
        get { return _skill; }
        protected set { _skill = value; }
    }

    protected Driver(string  name, double skill)
    {
        Name = name;
        DriverSkill = skill;
    }
}
