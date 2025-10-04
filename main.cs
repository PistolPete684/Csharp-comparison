using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    // Declare variables
    int availableSpace = cap - on;

    // Ternary operator based on boolean statement 
    return wait <= availableSpace ? 0 : wait - availableSpace;
    
//     if ((cap - on) > wait) {
//       return "0 # He can fit all 5 passengers";
//     } else {
//       return wait - (cap - on) + "# He can't fit 10 of the 50 waiting"
//     }
  }
}