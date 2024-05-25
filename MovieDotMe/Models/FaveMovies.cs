using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDotMe.Models;

public class FaveMovies
{
    public string Username { get; set; }
    public List<string> Titles { get; set; }
}
