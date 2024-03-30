﻿using System;
using System.Collections.Generic;

namespace Domain.Model;

public partial class EstadoHabitacion
{
    public int IdEstadoHabitacion { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
