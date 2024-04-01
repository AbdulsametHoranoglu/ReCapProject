using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Color : ICar
{
    public int ColorId { get; set; }
    public string ColorName { get; set; }
}
