using System;
using System.Collections.Generic;

namespace MovieManagementSystemCoreApp.Models;

public partial class Movie
{
    public int Movieid { get; set; }

    public string Moviename { get; set; } = null!;

    public string DirectorName { get; set; } = null!;

    public string ProducerName { get; set; } = null!;

    public string ActorName { get; set; } = null!;

    public string ActressName { get; set; } = null!;

    public string MovieVerdict { get; set; } = null!;

    public string MovieBudget { get; set; } = null!;

    public string MovieRating { get; set; } = null!;

    public string MovieReleaseYear { get; set; } = null!;
}
