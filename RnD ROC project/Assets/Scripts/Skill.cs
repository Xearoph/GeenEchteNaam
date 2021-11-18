using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// init class for skill to create an array list of skills for a user
public class Skill
{
   public string Name { get; set; }
   public Skill(string Name)
   {
      this.Name = Name;
   }
}
