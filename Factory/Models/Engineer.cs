using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string EngineerDescription { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }
  }
}