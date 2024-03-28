﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Car : ICar
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int ColorId { get; set; }
    public DateTime ModelYear { get; set; }
    public int DailyPrice { get; set; }
    public string Description { get; set; }

}
