﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.DataAccess;

public partial class zona
{
    public int id_zona { get; set; }

    public string nombre { get; set; }

    public string descripcion { get; set; }

    public virtual ICollection<cliente> cliente { get; set; } = new List<cliente>();

    public virtual ICollection<punto_venta> punto_venta { get; set; } = new List<punto_venta>();

    public virtual ICollection<reparto> reparto { get; set; } = new List<reparto>();
}