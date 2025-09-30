using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConcretePrototype2 : Prototype
{
    // Constructor

    public ConcretePrototype2(string id)
        : base(id)
    {
    }

    // Trả về bản sao

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
