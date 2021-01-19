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
  }
}