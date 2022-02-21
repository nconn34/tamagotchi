using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Mood { get; set; }
    public int Sleep { get; set; }

    public Tamagotchi (int food, int mood, int sleep)
    {
      Food = food;
      Mood = mood;
      Sleep = sleep;
    }
    public void CreateTama(string inputtedName) 
    {
      this.Name = inputtedName;
      this.Food = 10;
      this.Mood = 10;
      this.Sleep = 10;

    public bool accelerate = false;
    public Button throttle;
          
    void Start ()
    {
          throttle.onClick.AddListener(throttleTrue);
    }
          
    public void Update()
      { 
    >> IF (throttleTrue) <<
    accelerate = true;
    { Do stuff.. }
    accelerate = false;
    } 
  }       
}