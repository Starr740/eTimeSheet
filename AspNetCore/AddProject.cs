using System;
using System.Text.Json;

namespace AspNetCore
{
  public class AddProject
  {
  public int Id { get; set; } 
  public string? Project { get; set; }
  public string? Coordinator { get; set; }
  public DateTime Start { get; set; }
  public DateTime End { get; set; }
  
  }
}