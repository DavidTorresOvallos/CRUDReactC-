using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Contact
{
    public int IdContact { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }
}
