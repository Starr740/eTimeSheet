using System;

namespace AspNetCore
{
  public class ProjectTeam
  {
  public int Id { get; set; } 
  public string? Project { get; set; }
  public string? Member { get; set; }
  public DateTime Start { get; set; }
  public DateTime End { get; set; }
  
  }
}