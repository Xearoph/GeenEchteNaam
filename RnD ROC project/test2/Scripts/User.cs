using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// init class for User (that is shown on the cube)
public class User
{
   public string Name { get; set; }
   public string About { get; set; }
   public List<Skill> Skills { get; set; }

   public User(string Name, string About, List<Skill> Skills)
   {
      this.Name = Name;
      this.About = About;
      this.Skills = Skills;
   }

   public override string ToString()
   {
      return "Person: " + this.Name + " About me: " + this.About;
   }
}

