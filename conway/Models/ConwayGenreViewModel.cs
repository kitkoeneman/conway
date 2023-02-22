using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace conway.Models;

public class ConwayGenreViewModel
{
    public List<Conway>? Conways { get; set; }
    public SelectList? Genres { get; set; }
    public string? ConwayGenre { get; set; }
    public string? SearchString { get; set; }
}